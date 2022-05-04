using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigdiPuller;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace GigdiPuller
{
    public partial class instancepuller : Form
    {
        public instancepuller()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String instanceid = instance.Text;
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string result = webClient.DownloadString("https://sgtgigdilauncher-purchaseapi.herokuapp.com/vrchat/api/v1/ippuller/grab?instance=" + instanceid);
                    dynamic results = JsonConvert.DeserializeObject(result);
                    user1displayname.Text = results.pulleduser1.displayname;
                    user1platform.Text = results.pulleduser1.platform;
                    user1ID.Text = results.pulleduser1.userID;
                    user2displayname.Text = results.pulleduser2.displayname;
                    user2platform.Text = results.pulleduser2.platform;
                    user2ID.Text = results.pulleduser2.userID;
                    user2ip.Text = results.pulleduser2.userIP;
                }
                catch (WebException)
                {
                    MessageBox.Show("Something went wrong for one of three reasons. That instance does not exist or you have been rate limited or the server is offline. Check the discord for updates.", "GigdiPuller ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ScriptHub_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScriptBox_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("discord.gg/7cyrKZcj8W");
        }

        private void method_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(user2ip.Text);
            MessageBox.Show("Successfully Copied To Clipboard!");
        }
    }
}