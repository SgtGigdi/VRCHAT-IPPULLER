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

        private async void button1_Click(object sender, EventArgs e)
        {
            string userId = userid.Text;
            string youtubeUrl = method.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(youtubeUrl))
            {
                MessageBox.Show("Please provide both User ID and YouTube URL.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string apiUrl = $"https://vrchatapi.onrender.com/vrchat/api/v1/create-endpoint?userId={userId}&youtubeUrl={Uri.EscapeDataString(youtubeUrl)}";
                var handler = new HttpClientHandler();
                handler.CookieContainer = CookieHelper.CookieContainer;

                using (HttpClient client = new HttpClient(handler))
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        dynamic errorResult = JsonConvert.DeserializeObject(errorContent);

                        if (response.StatusCode == HttpStatusCode.Forbidden)
                        {
                            MessageBox.Show($"Error: {errorResult.error}", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Activate a 12-hour key on our website for free, by logging in on the website and click VRChat puller and completing the steps.");
                            Process.Start("https://vrchatapi.onrender.com");
                        }
                        else
                        {
                            MessageBox.Show("The API appears to be offline or the information inputted for generation is incorrect.  Please try again later.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }

                    string responseContent = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(responseContent);

                    string grabUrl = result.grabUrl;
                    string trackUrl = result.trackUrl;
                    string endpointId = result.endpointId;

                    instanceid.Text = endpointId;
                    label8.Text = "Youtube URL: " + youtubeUrl;
                    pullurl.Text = grabUrl;

                    MessageBox.Show("Endpoint created successfully!\nGrab URL: " + grabUrl + "\nTrack URL: " + trackUrl, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Error connecting to the API. The information inputted for generation is either incorrect or the server is down. Please try again later.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pullurl.Text);
            MessageBox.Show("Successfully Copied To Clipboard!");
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
            MessageBox.Show("To start. Simply Create A New Instance using the menu here. Then join a world with a working video player and then invite the person you are pulling to the world. Once they join copy the pull url and paste it into the url box on the map. once finished come back here and enter your instance ID to the pulling menu and there is the information.");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("coming soon.");
        }
    }
}