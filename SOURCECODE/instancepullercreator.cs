using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GigdiPuller;
using System.Collections.Specialized;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GigdiPuller
{
    public partial class instancepullercreator : Form
    {


        public instancepullercreator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(instanceid.Text);
            MessageBox.Show("Successfully Copied To Clipboard!");
        }

        private void Scripts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ID = userid.Text;
            String Method = method.Text;
            if (Method == "invite")
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        string result = webClient.DownloadString("https://sgtgigdilauncher-purchaseapi.herokuapp.com/vrchat/api/v1/ippuller/inviterequest");
                        Process.Start("https://vrchat.com/home/user/usr_cebde138-461c-460e-bcd1-88d3a8680b9e");
                        MessageBox.Show("Please ensure you have friended SgtGigdiInviter as a friend on vrc");
                    }
                    catch (WebException)
                    {
                        MessageBox.Show("Invites are currently disabled or the server is offline. Check the discord for updates.", "GigdiPuller ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    Process.Start("https://vrchat.com/home/user/usr_cebde138-461c-460e-bcd1-88d3a8680b9e");
                    MessageBox.Show("Please ensure you have friended SgtGigdiInviter as a friend on vrc");
                    string result = webClient.DownloadString("https://sgtgigdilauncher-purchaseapi.herokuapp.com/vrchat/api/v1/ippuller/start?way=" + Method + "&user=" + ID);
                    dynamic results = JsonConvert.DeserializeObject(result);
                    instanceid.Text = results.instanceid;
                    worldurl.Text = results.worldurl;
                    pullurl.Text = results.pullurl;
                    ClickToJoinWorld.Visible = true;
                }
                catch (WebException)
                {
                    MessageBox.Show("Something went wrong. Please ensure you have your correct USER ID and a method in the boxes above or the server is offline. Check the discord for updates.", "GigdiPuller ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pullurl.Text);
            MessageBox.Show("Successfully Copied To Clipboard!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(worldurl.Text);
            MessageBox.Show("Successfully Copied To Clipboard!");
        }

        private void Stuff_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            instancepuller main = new instancepuller();
            main.Show();
        }

        private void Script_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To start. Simply Create A New Instance using the menu here. Then join the world either by clicking Click to join world. or joining the invite sent if you enabled that. then invite the person you are pulling to the world. Once they join copy the pull url and paste it into the url box on the map. once finished come back here and enter your instance ID to the pulling menu and there is the information.");
        }

        private void OpenYouTubeChannel_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("http://discord.gg/7cyrKZcj8W");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void key_Click(object sender, EventArgs e)
        {

        }

        private void level_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void OpenYouTubeChannel_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://discord.gg/7cyrKZcj8W");
        }

        private void News_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Process.Start(worldurl.Text);
        }

        private void worldurl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon.");
        }
    }
}