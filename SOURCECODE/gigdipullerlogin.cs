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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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

        private async void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string username = txtEmail.Text;
            string password = txtpassword.Text;

            // Perform the login request
            bool isLoggedIn = await TryLogin(username, password);

            if (isLoggedIn)
            {
                MessageBox.Show("Welcome to SgtGigdi Puller.");
                instancepullercreator main = new instancepullercreator();
                main.Show();
                this.Hide();
            }
            else
            {
                //incorrect information
                return;
            }
        }

        private async Task<bool> TryLogin(string username, string password)
        {
            using (HttpClientHandler handler = new HttpClientHandler())
            {
                // Create an instance of CookieContainer to store cookies
                handler.CookieContainer = CookieHelper.CookieContainer; // Use the shared CookieContainer

                using (HttpClient client = new HttpClient(handler))
                {
                    // Define the API URL (pointing to the new /loginuser endpoint)
                    string url = "https://vrchatapi.onrender.com/login/loginuser";

                    // Create a dictionary for the login credentials
                    var loginData = new Dictionary<string, string>
            {
                { "email", username },
                { "password", password }
            };

                    // Serialize the dictionary to JSON
                    string jsonContent = JsonConvert.SerializeObject(loginData);

                    // Create the HttpContent using JSON
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    try
                    {
                        // Send the POST request with the JSON content
                        HttpResponseMessage response = await client.PostAsync(url, content);

                        // Log the raw response content for debugging
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response Content: {responseContent}");  // For debugging

                        // If the response is successful (HTTP 200-299)
                        if (response.IsSuccessStatusCode)
                        {
                            var responseData = JsonConvert.DeserializeObject<dynamic>(responseContent);

                            // Check if login is successful based on the 'status' field
                            if (responseData.status == true)
                            {
                                // Login is successful, cookies are stored in the shared CookieContainer
                                MessageBox.Show(responseData.message.ToString(), "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else if (responseData.banStatus != null && responseData.banStatus.isBanned)
                            {
                                // User is banned
                                MessageBox.Show($"You are banned.\nReason: {responseData.banStatus.reason}\nDuration: {responseData.banStatus.duration} days", "Banned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            else
                            {
                                // Login error or other case
                                MessageBox.Show(responseData.message.ToString(), "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"The server returned an error possibly because it's offline. Check the discord server: {response.StatusCode}.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any other exceptions (e.g., network issues, server offline, etc.)
                        MessageBox.Show($"The server is currently offline or an error occurred: {ex.Message}. Please check the Discord server for updates.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
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

        private void siticoneRoundedButton2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://vrchatapi.onrender.com/register");
        }
    }
}
