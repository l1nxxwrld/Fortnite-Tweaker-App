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

namespace Fortnite_Chapter_3_Tweaker
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Happy Tweaking ;) ", "HAPYY TWEAKING ;)", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.Yes);
            }
            new Tweaker().Show();
            new Info().Show();
            this.Hide();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Rules().Show();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            new Settings().Show();
        }
    }
}
