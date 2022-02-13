using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Fortnite_Chapter_3_Tweaker
{
    public partial class Tweaker : Form
    {
        public Tweaker()
        {
            InitializeComponent();
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (checkbox10.Checked == false)
                {

                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\DiagTrack");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }

                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\dmwappushservice");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\diagsvc");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }


                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }

                }

                if (checkbox10.Checked == true)
                {
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\DiagTrack");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }

                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\dmwappushservice");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\diagsvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }

                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service");
                        smb.SetValue("Start", 0x0000001, RegistryValueKind.DWord);


                    }
                }
            }

            {
                if (checkbox6.Checked == false)
                {

                    RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications");
                    smb.SetValue("GlobalUserDisabled", 0x0000001, RegistryValueKind.DWord);

                }

                if (checkbox6.Checked == true)
                {

                    RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications");
                    smb.SetValue("GlobalUserDisabled", 0x0000001, RegistryValueKind.DWord);
                }
            }
            {
                if (checkbox2.Checked == false)
                {

                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GpuEnergyDrv");
                    smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);

                }

                if (checkbox2.Checked == true)
                {

                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GpuEnergyDrv");
                    smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling");
                    smb.SetValue("PowerThrottlingOff", 0x0000001, RegistryValueKind.DWord);
                }
            
            }
            {
                if (checkbox3.Checked == false)
                {
                    RegistryKey smb = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize");
                    smb.SetValue("EnableTransparency", 0x0000001, RegistryValueKind.DWord);
                }

                if (checkbox3.Checked == true)

                {
                    RegistryKey smb = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize");
                    smb.SetValue("EnableTransparency", 0x0000000, RegistryValueKind.DWord);
                }
            }
            {
                if (checkbox4.Checked == false)
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\MapsBroker");
                    smb.SetValue("Start", 0x0000002, RegistryValueKind.DWord);
                }
                if (checkbox4.Checked == true)
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\MapsBroker");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
            }
            {
                if (checkbox5.Checked == false)
                {
                    {
                        RegistryKey smb = Registry.CurrentUser.CreateSubKey("System\\GameConfigStore");
                        smb.SetValue("GameDVR_Enabled", 0x0000001, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_FSEBehaviorMode", 0x0000001, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_HonorUserFSEBehaviorMode", 0x0000001, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", 0x0000000, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_EFSEFeatureFlags", 0x0000000, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR");
                        smb.SetValue("value", 0x0000001, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR");
                        smb.SetValue("AllowGameDVR", 0x0000001, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR");
                        smb.SetValue("AppCaptureEnabled", 0x0000001, RegistryValueKind.DWord);
                    }

                }

                if (checkbox5.Checked == true)

                {
                    {
                        RegistryKey smb = Registry.CurrentUser.CreateSubKey("System\\GameConfigStore");
                        smb.SetValue("GameDVR_Enabled", 0x0000000, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_FSEBehaviorMode", 0x0000002, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_HonorUserFSEBehaviorMode", 0x0000000, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", 0x0000001, RegistryValueKind.DWord);
                        smb.SetValue("GameDVR_EFSEFeatureFlags", 0x0000000, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR");
                        smb.SetValue("value", 0x0000000, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR");
                        smb.SetValue("AllowGameDVR", 0x0000000, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR");
                        smb.SetValue("AppCaptureEnabled", 0x0000000, RegistryValueKind.DWord);

                    }

                }
            }

            {
                if (checkbox7.Checked == false)
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel");
                    smb.SetValue("DistributeTimers", 0x0000002, RegistryValueKind.DWord);
                }
                if  (checkbox7.Checked == true)
                    {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel");
                    smb.SetValue("DistributeTimers", 0x0000001, RegistryValueKind.DWord);
                }
            }

            {
                if (checkbox9.Checked == false)
                {
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR");
                        smb.SetValue("value", 0x0000001, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR");
                        smb.SetValue("AllowGameDVR", 0x0000001, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR");
                        smb.SetValue("AppCaptureEnabled", 0x0000001, RegistryValueKind.DWord);
                    }
                }
                if (checkbox9.Checked == true)
                {
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR");
                        smb.SetValue("value", 0x0000000, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR");
                        smb.SetValue("AllowGameDVR", 0x0000000, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR");
                        smb.SetValue("AppCaptureEnabled", 0x0000000, RegistryValueKind.DWord);

                    }
                }

                 if (checkbox1.Checked == false)
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WbioSrvc");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\FontCache");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\FontCache3.0.0.0");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GraphicsPerfSvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\stisvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\DiagTrack");
                        smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WerSvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\PcaSvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Wecsvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }

                {

                    if (checkbox1.Checked == true)
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WbioSrvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\FontCache");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\FontCache3.0.0.0");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GraphicsPerfSvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\stisvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\DiagTrack");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WerSvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\PcaSvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    {
                        RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Wecsvc");
                        smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                    }
                    if (MessageBox.Show("Do you want to reboot your PC to apply tweaks corectly?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    if (MessageBox.Show("Your PC will reboot in 30 seconds. If you are writing documents, its time to save them", "Ask", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes)
                        Process.Start("shutdown.exe", "-r -t 30");








                }
            }
        }


        private void Tweaker_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (checkbox1.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void guna2CustomCheckBox11_Click(object sender, EventArgs e)
        {
            if (checkboxall.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;

            }

            if (checkboxall.Checked == true)
            {
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WbioSrvc");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\FontCache");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\FontCache3.0.0.0");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GraphicsPerfSvc");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\stisvc");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\DiagTrack");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\WerSvc");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\PcaSvc");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\Wecsvc");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR");
                    smb.SetValue("value", 0x0000000, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR");
                    smb.SetValue("AllowGameDVR", 0x0000000, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR");
                    smb.SetValue("AppCaptureEnabled", 0x0000000, RegistryValueKind.DWord);

                }
                {
                    RegistryKey smb = Registry.CurrentUser.CreateSubKey("System\\GameConfigStore");
                    smb.SetValue("GameDVR_Enabled", 0x0000000, RegistryValueKind.DWord);
                    smb.SetValue("GameDVR_FSEBehaviorMode", 0x0000002, RegistryValueKind.DWord);
                    smb.SetValue("GameDVR_HonorUserFSEBehaviorMode", 0x0000000, RegistryValueKind.DWord);
                    smb.SetValue("GameDVR_DXGIHonorFSEWindowsCompatible", 0x0000001, RegistryValueKind.DWord);
                    smb.SetValue("GameDVR_EFSEFeatureFlags", 0x0000000, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR");
                    smb.SetValue("value", 0x0000000, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR");
                    smb.SetValue("AllowGameDVR", 0x0000000, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR");
                    smb.SetValue("AppCaptureEnabled", 0x0000000, RegistryValueKind.DWord);

                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\MapsBroker");
                    smb.SetValue("Start", 0x0000004, RegistryValueKind.DWord);
                }
                {

                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GpuEnergyDrv");
                    smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);
                }
                {
                    RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling");
                    smb.SetValue("PowerThrottlingOff", 0x0000001, RegistryValueKind.DWord);
                }
             }







        }
        


        private void checkbox2_Click(object sender, EventArgs e)
        {
            if (checkbox2.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox3_Click(object sender, EventArgs e)
        {
            
            
            if (checkbox3.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox4_Click(object sender, EventArgs e)
        {
            if (checkbox4.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox5_Click(object sender, EventArgs e)
        {
            if (checkbox5.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox6_Click(object sender, EventArgs e)
        {
            if (checkbox6.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox7_Click(object sender, EventArgs e)
        {
            if (checkbox7.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox8_Click(object sender, EventArgs e)
        {
            if (checkbox8.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox9_Click(object sender, EventArgs e)
        {
            if (checkbox9.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void checkbox10_Click(object sender, EventArgs e)
        {
            if (checkbox10.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            new Settings().Show();

        }
    }
    }

