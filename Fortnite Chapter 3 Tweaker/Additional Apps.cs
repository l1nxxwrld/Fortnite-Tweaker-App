using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
namespace Fortnite_Chapter_3_Tweaker
{
    public partial class Additional_Apps : Form
    {
        public Additional_Apps()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to download Msi AfterBurner?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)

                System.Diagnostics.Process.Start("https://download.msi.com/uti_exe/vga/MSIAfterburnerSetup.zip?__token__=exp=1644050236~acl=/*~hmac=818c33dd69ae2e956563b45e596a1ef7d0c198377287a7faf2d9381a64976e00");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to download DNS Jumper?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)

                System.Diagnostics.Process.Start("https://www.sordum.org/downloads/?dns-jumper");
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to download TCP Optimizer?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)

                System.Diagnostics.Process.Start("https://www.speedguide.net/files/TCPOptimizer.exe");
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
        if (MessageBox.Show("Do you want to download Filter Keys Setter?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)

                System.Diagnostics.Process.Start("https://geekhack.org/index.php?action=dlattach;topic=41881.0;attach=17473"); 
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to download MSI Mode Tool v2?", "Ask", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)

                System.Diagnostics.Process.Start("http://download2391.mediafire.com/7nrc9c8gx89g/2kkkvko7e75opce/MSI_util_v2.zip");
        }
    }
}
