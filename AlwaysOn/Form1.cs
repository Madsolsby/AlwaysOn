using Bunifu.UI.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlwaysOn
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }


        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static uint cFonts = 0;
        private static void AddFont(byte[] fontdata)
        {
            try
            {
                int fontLength; System.IntPtr dataPointer;

                //We are going to need a pointer to the font data, so we are generating it here
                dataPointer = Marshal.AllocCoTaskMem(fontdata.Length);


                //Copying the fontdata into the memory designated by the pointer
                Marshal.Copy(fontdata, 0, dataPointer, (int)fontdata.Length);

                // Register the font with the system.
                AddFontMemResourceEx(dataPointer, (uint)fontdata.Length, IntPtr.Zero, ref cFonts);

                //Keep track of how many fonts we've added.
                cFonts += 1;

                //Finally, we can actually add the font to our collection
                pfc.AddMemoryFont(dataPointer, (int)fontdata.Length);
            }
            catch { }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AddFont(Properties.Resources.Brandon_reg);
            AddFont(Properties.Resources.Brandon_med);
            AddFont(Properties.Resources.Brandon_blk);
            AddFont(Properties.Resources.Brandon_light);

            //0 = Bold
            //1 = light


            int fontsize = 14;
            int fontsizeSmall = 12;

            FontFamily ffb = pfc.Families[0];
            Font pacmanFontB = new Font(ffb, fontsize, FontStyle.Bold);

            FontFamily ffLT = pfc.Families[1];
            Font pacmanFontLT = new Font(ffLT, fontsize, FontStyle.Regular);

            FontFamily ffm = pfc.Families[1];
            Font pacmanFontL = new Font(ffm, fontsizeSmall, FontStyle.Regular);

            lTitle.Font = pacmanFontB;
            lFrequency.Font = pacmanFontLT;
            tbInterval.Font = pacmanFontLT;
            lLastRun.Font = pacmanFontL;
            lLastRunTitle.Font = pacmanFontL;
            linfo1.Font = pacmanFontL;
            lStartWithWindows.Font = pacmanFontLT;

            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) System.Diagnostics.Process.GetCurrentProcess().Kill();

            if (checkStartWithWindows() == true)
            {
                Properties.Settings.Default.StartUp = true;
                Properties.Settings.Default.Save();
                toggleStartup.Checked = true;
            } else
            {
                Properties.Settings.Default.StartUp = false;
                Properties.Settings.Default.Save();
                toggleStartup.Checked = false;
            }

            Bunifu.Framework.UI.BunifuElipse profileGifElipse = new Bunifu.Framework.UI.BunifuElipse();
            profileGifElipse.ElipseRadius = 10;
            profileGifElipse.TargetControl = this;


            try { SetRunAtStartupReg(); } catch
            {

            };

            starting = false;
        }

        public static bool checkStartWithWindows()
        {
            RegistryKey winLogonKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            return (winLogonKey.GetValueNames().Contains("AlwaysOn"));
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        private void functionOn()
        {
            PreventSleep();
            KeepSystemAwake();
            PreventMonitorPowerdown();
        }

        private void functionOff()
        {
            PreventSleepOff();
            AllowMonitorPowerdown();
        }

        void PreventSleep()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
        }
        void PreventSleepOff()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_CONTINUOUS);
        }

        void KeepSystemAwake()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED);
        }

        void PreventMonitorPowerdown()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS);
        }

        void AllowMonitorPowerdown()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
        }




        private void timerMain_Tick(object sender, EventArgs e)
        {
            lLastRun.Visible = true; lLastRunTitle.Visible = true;
            lLastRun.Text = DateTime.Now.ToString();
            functionOn();

        }

        private void toggle_CheckedChanged(object sender, EventArgs e)
        {

            if (toggle.Checked == true)
            {
                if (tbInterval.Text.Length < 1)
                {
                    tbInterval.Text = 60.ToString();
                }

                Properties.Settings.Default.boolActive = true;
                timerMain.Stop();
                timerMain.Interval = calculateInterval(Int32.Parse(tbInterval.Text));
                timerMain.Start();
            } else if (toggle.Checked == false)
            {
                Properties.Settings.Default.boolActive = false;
                timerMain.Stop();
                functionOff();
            }
        }

        private int calculateInterval(int input)
        {
            string change = input.ToString() + 0 + 0 + 0;
            int newval = Int32.Parse(change);
            return newval;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Save();
            this.Dispose();

            
        }

        bool starting = true;
        private void toggleStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (starting == true) { } else
            {
                if (toggleStartup.Checked == true)
                {
                    Properties.Settings.Default.StartUp = true;
                    Properties.Settings.Default.Save();
                    SetRunAtStartupReg();
                }
                else
                {
                    Properties.Settings.Default.StartUp = false;
                    Properties.Settings.Default.Save();
                    SetRunAtStartupReg();
                }
            }

        }

        public static void SetRunAtStartupReg()
        {
            //Set the application to run at startup

            if (Properties.Settings.Default.StartUp == true)
            {

                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("AlwaysOn", Application.ExecutablePath);
            }
            else
            {

                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("AlwaysOn", false);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;

            if (Properties.Settings.Default.boolActive == true)
            {
                toggle.Checked = true;
            } else
            {
                toggle.Checked = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;

                notifyIcon1.BalloonTipTitle = "Minimized";
                notifyIcon1.BalloonTipText = "AlwaysOn has been minimized";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {

            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (toggle.Checked == true)
                {
                    tsEnableOrDisable.Text = "Disable";
                } else
                {
                    tsEnableOrDisable.Text = "Enable";
                }
                cms.Show();
            }
        }

        private void tsEnableOrDisable_Click(object sender, EventArgs e)
        {
            if (tsEnableOrDisable.Text == "Disable")
            {
                toggle.Checked = false;
                Properties.Settings.Default.boolActive = false;
                timerMain.Stop();
                tsEnableOrDisable.Text = "Enable";
            } else if (tsEnableOrDisable.Text == "Enable")
            {
                tsEnableOrDisable.Text = "Disable";
                toggle.Checked = true;
                Properties.Settings.Default.boolActive = true;
                timerMain.Interval = calculateInterval(Int32.Parse(tbInterval.Text));
                timerMain.Start();
            }
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            pTop.Focus();
        }


        private void tbInterval_TextChanged(object sender, EventArgs e)
        {

            if (starting == false)
            {
                bLoader.Show();
            }

            timerTextChanged.Stop();
            timerTextChanged.Start();
            
        }

        private void timerTextChanged_Tick(object sender, EventArgs e)
        {
            if (tbInterval.Text.Length < 1)
            {
                toggle.Checked = false;
                timerTextChanged.Stop();

            }
            else
            {
                timerMain.Interval = calculateInterval(Int32.Parse(tbInterval.Text));
                timerTextChanged.Stop();
            }
            bLoader.Hide();
         
        }

        private void tbInterval_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void toggle_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            functionOff();
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {
            if (linfo1.Text.Contains("Version")) { linfo1.Text = "By Simplified Launch"; } else { linfo1.Text = "Version 1.0.1.4"; };
            
        }
    }
}
