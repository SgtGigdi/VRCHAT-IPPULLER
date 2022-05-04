using GigdiPuller;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigdiPuller
{
    public partial class gigdipullerlogin : Form
    {

        public gigdipullerlogin()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Welcome to SgtGigdi Puller.");
                instancepullercreator main = new instancepullercreator();
                main.Show();
                this.Hide();
                return;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/7cyrKZcj8W");
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            Process.Start("");
        }
    }
}