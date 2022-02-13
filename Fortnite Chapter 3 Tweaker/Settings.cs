using System;
using System.Collections.Generic;
using System.ComponentModel;
using Squirrel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO.Compression;

namespace Fortnite_Chapter_3_Tweaker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            
  
            






        }


        
        
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Assembly assembly = Assembly.GetExecutingAssembly();

            versionTextBox.Text = assembly.GetName().Version.ToString(3);






        }












        private void guna2GradientButton1_Click(object sender, EventArgs e)
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
            {
                RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel");
                smb.SetValue("DistributeTimers", 0x0000002, RegistryValueKind.DWord);
            }
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
            {
                RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\MapsBroker");
                smb.SetValue("Start", 0x0000002, RegistryValueKind.DWord);
            }
            {
                RegistryKey smb = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize");
                smb.SetValue("EnableTransparency", 0x0000001, RegistryValueKind.DWord);
            }
            {

                RegistryKey smb = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GpuEnergyDrv");
                smb.SetValue("Start", 0x0000003, RegistryValueKind.DWord);

            }
            {

                RegistryKey smb = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications");
                smb.SetValue("GlobalUserDisabled", 0x0000001, RegistryValueKind.DWord);

            }
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

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            new Additional_Apps().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
