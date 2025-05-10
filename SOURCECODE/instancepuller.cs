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
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string instanceid = instance.Text;

            if (string.IsNullOrEmpty(instanceid))
            {
                MessageBox.Show("Please enter an instance ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (HttpClientHandler handler = new HttpClientHandler { CookieContainer = CookieHelper.CookieContainer })
            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    string url = $"https://vrchatapi.onrender.com/vrchat/api/v1/track/{instanceid}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        dynamic errorResult = JsonConvert.DeserializeObject(errorContent);

                        if (response.StatusCode == HttpStatusCode.Forbidden && errorResult?.error != null)
                        {
                            MessageBox.Show($"Error: {errorResult.error}", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Activate a 12-hour key on our website for free, by logging in on the website and click VRChat puller and completing the steps.");
                            Process.Start("https://vrchatapi.onrender.com");
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound && errorResult?.error == "Temporary endpoint not found.")
                        {
                            MessageBox.Show("The temporary endpoint was not found. Please verify the instance ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("The specified instance ID was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("The API is currently unreachable. Please try again later.", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        return;
                    }

                    string result = await response.Content.ReadAsStringAsync();
                    dynamic results = JsonConvert.DeserializeObject(result);

                    if (results.pulled != null && results.pulled.Count > 0)
                    {
                        var pulledData = results.pulled[0];
                        user2ID.Text = pulledData.userId;
                        user2ip.Text = pulledData.ip;
                        InstanceID.Text = pulledData.endpointId;
                        user2timestamp.Text = pulledData.timestamp;
                    }
                    else
                    {
                        MessageBox.Show("No data found for this instance. Try pulling again", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Connection error. Please check your internet and try again.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ScriptHub_Load(object sender, EventArgs e)
        {
            // Any initialization logic for ScriptHub
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your listbox logic if any
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Panel paint logic if any
        }

        private void ScriptBox_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("discord.gg/7cyrKZcj8W"); // Open the Discord link
        }

        private void method_TextChanged(object sender, EventArgs e)
        {
            // Logic for method text changes if any
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(user2ip.Text);  // Copy IP to clipboard
            MessageBox.Show("Successfully Copied To Clipboard!");
        }
    }
}
