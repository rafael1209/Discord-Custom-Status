using DiscordRPC;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Discord_Custom_Status
{
    public partial class Form1 : Form
    {
        private DiscordRpcClient discordRpcClient;
        public int secondss;
        public string customClientID, customLargeImgKey, customSmallImgKey, customLargeImgText, customSmallImgText, customDetails, customState;

        public Form1()
        {
            InitializeComponent();
            LoadSettings(); // Load saved settings on form initialization
            InitializeDiscordRpc();
            AddToStartup();
        }

        private void AddToStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                // Specify the name you want to give to your program in the registry
                string appName = "Discord_Custom_Status";

                // Specify the path to your executable
                string appPath = Application.ExecutablePath;

                // Add the program to auto-start
                registryKey.SetValue(appName, appPath);
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as insufficient permissions
                Console.WriteLine($"Error adding to startup: {ex.Message}");
            }
        }
        private void LoadSettings()
        {
            // Load saved settings
            ClientIDFild.Text = Properties.Settings.Default.ClientID;
            largeImgKeyFild.Text = Properties.Settings.Default.LargeImageKey;
            largeImgTextFild.Text = Properties.Settings.Default.LargeImageText;
            smallImgKeyFild.Text = Properties.Settings.Default.SmallImageKey;
            smallImgTextFild.Text = Properties.Settings.Default.SmallImageText;
            detailsFild.Text = Properties.Settings.Default.Details;
            stateTextFild.Text = Properties.Settings.Default.State;
            textBox1.Text = Properties.Settings.Default.PartyIn;
            textBox2.Text = Properties.Settings.Default.PartyMax;
            checkBox1.Checked = Properties.Settings.Default.Timer;
            checkBox2.Checked = Properties.Settings.Default.Party;

            customClientID = Properties.Settings.Default.CustomClientID;
            customLargeImgKey = Properties.Settings.Default.LargeImageKey;
            customLargeImgText = Properties.Settings.Default.LargeImageText;
            customSmallImgKey = Properties.Settings.Default.SmallImageKey;
            customSmallImgText = Properties.Settings.Default.SmallImageText;
            customDetails = Properties.Settings.Default.CustomDetails;
            customState= Properties.Settings.Default.CustomState;
        }

        private void SaveSettings()
        {
            // Save settings
            Properties.Settings.Default.ClientID = ClientIDFild.Text;
            Properties.Settings.Default.LargeImageKey = largeImgKeyFild.Text;
            Properties.Settings.Default.LargeImageText = largeImgTextFild.Text;
            Properties.Settings.Default.SmallImageKey = smallImgKeyFild.Text;
            Properties.Settings.Default.SmallImageText = smallImgTextFild.Text;
            Properties.Settings.Default.Details = detailsFild.Text;
            Properties.Settings.Default.State = stateTextFild.Text;
            Properties.Settings.Default.PartyIn = textBox1.Text;
            Properties.Settings.Default.PartyMax = textBox2.Text;
            Properties.Settings.Default.Timer= checkBox1.Checked;
            Properties.Settings.Default.Party = checkBox2.Checked;

            Properties.Settings.Default.CustomClientID = customClientID;
            Properties.Settings.Default.CustomLargeImgKey = customLargeImgKey;
            Properties.Settings.Default.CustomLargeImgText= customLargeImgText;
            Properties.Settings.Default.CustomSmallImgText = customSmallImgKey;
            Properties.Settings.Default.CustomSmallImgText= customSmallImgText;
            Properties.Settings.Default.CustomDetails = customDetails;
            Properties.Settings.Default.CustomState= customState;

            Properties.Settings.Default.Save();
        }

        private void InitializeDiscordRpc()
        {
            discordRpcClient = new DiscordRpcClient(ClientIDFild.Text);

            discordRpcClient.OnReady += (sender, e) =>
            {
                Console.WriteLine("Discord RPC is ready!");
            };

            discordRpcClient.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine($"Presence updated: {e.Presence}");
            };

            discordRpcClient.Initialize();

            // Set initial presence
            UpdatePresence();
        }

        private void UpdatePresence()
        {
            DateTime startTime = DateTime.UtcNow;

            discordRpcClient.SetPresence(new RichPresence
            {
                Details = detailsFild.Text,
                State = stateTextFild.Text,
                Assets = new Assets
                {
                    LargeImageKey = largeImgKeyFild.Text,
                    LargeImageText = largeImgTextFild.Text,
                    SmallImageKey = smallImgKeyFild.Text,
                    SmallImageText = smallImgTextFild.Text
                },
                Party = checkBox2.Checked ? null : new Party
                {
                    ID = "123",
                    Size = int.Parse(textBox1.Text),
                    Max = int.Parse(textBox2.Text)
                },
                Timestamps = checkBox1.Checked ? null : new Timestamps { Start = DateTime.Now.AddHours(-(int.Parse(textBox3.Text)+2)) }
            });
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Dispose of the existing DiscordRpcClient
            discordRpcClient.Dispose();

            // Create a new DiscordRpcClient with the updated client ID
            discordRpcClient = new DiscordRpcClient(ClientIDFild.Text);

            // Initialize the new client
            InitializeDiscordRpc();

            // Update the presence details
            UpdatePresence();

            // Save the settings after the update
            SaveSettings();

            if (checkBox1.Checked)
            {
                timer.Enabled = false;
                secondss = int.Parse(textBox3.Text)*3600;
                label12.Text = "Passed 00:00";
            }
            else
            {
                timer.Enabled = true;
                secondss = int.Parse(textBox3.Text) * 3600;
                label12.Text = "Passed 00:00";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = !checkBox1.Checked;
            label16.Enabled= !checkBox1.Checked;
            textBox3.Enabled = !checkBox1.Checked;
            label15.Enabled= !checkBox1.Checked;
        }

        private void detailsFild_TextChanged(object sender, EventArgs e)
        {
            label10.Text = detailsFild.Text;
        }

        private void stateTextFild_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                label11.Text = stateTextFild.Text + " (" + textBox1.Text + " of " + textBox2.Text + ")";
            }
            else
            {
                label11.Text = stateTextFild.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label11.Text = stateTextFild.Text+" ("+textBox1.Text+" of "+textBox2.Text+")";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                textBox1.Text = "1";
                textBox2.Text = "2";
            }
            else if (int.Parse(textBox1.Text)>int.Parse(textBox2.Text))
            {
                MessageBox.Show("The size of the group must be larger than the size of the participants!");
                textBox1.ForeColor = Color.Red;
                textBox1.Text = 0.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label11.Text = stateTextFild.Text + " (" + textBox1.Text + " of " + textBox2.Text + ")";
            if (textBox1.Text==""||textBox2.Text=="")
            {
                textBox1.Text = "1";
                textBox2.Text = "2";
            }
            else if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
                MessageBox.Show("The size of the group must be larger than the size of the participants!");
                textBox2.ForeColor = Color.Red;
                textBox2.Text = 9999.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                label11.Text = stateTextFild.Text + " (" + textBox1.Text + " of " + textBox2.Text + ")";
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                label14.Enabled = true;
            }
            else
            {
                label11.Text = stateTextFild.Text;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                label14.Enabled= false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            secondss++;
            int totalSeconds = secondss;

            int hours = totalSeconds / 3600;
            int remainingSeconds = totalSeconds % 3600;

            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;

            if (secondss>3600)
            {
                label12.Text = String.Format("Passed {0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
            }
            else
            {
                label12.Text = String.Format("Passed {0:D2}:{1:D2}", minutes, seconds);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.BackColor = Color.Red;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customClientID = ClientIDFild.Text;
            customLargeImgKey = largeImgKeyFild.Text;
            customLargeImgText = largeImgTextFild.Text;
            customSmallImgKey = smallImgKeyFild.Text;
            customSmallImgText = smallImgTextFild.Text;
            customDetails = detailsFild.Text;
            customState = stateTextFild.Text;
            SaveSettings();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex==0)
            {
                label4.Text = "Premium Plus";
                ClientIDFild.Text = "1166755301312180294";
                largeImgKeyFild.Text = "_premium_";
                largeImgTextFild.Text = "Premium Plus IL";
                smallImgKeyFild.Text = "verified";
                smallImgTextFild.Text = "Verified";
                detailsFild.Text = "Buy cheap premium services";
                stateTextFild.Text = "premiumplus-il.com";
                pictureBox1.Load("https://cdn.discordapp.com/app-assets/1166755301312180294/1166769710742917190.png");
                pictureBox2.Load("https://cdn.discordapp.com/app-assets/1166755301312180294/1166772103626895441.png");
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                label4.Text = "Lionel Messi";
                ClientIDFild.Text = "1168172477839589436";
                largeImgKeyFild.Text = "messi";
                largeImgTextFild.Text = "Lionel Messi";
                smallImgKeyFild.Text = "goldball";
                smallImgTextFild.Text = "Gold Ball";
                detailsFild.Text = "Messi🐐";
                stateTextFild.Text = "The best soccer player in the world!";
                pictureBox1.Load("https://cdn.discordapp.com/app-assets/1168172477839589436/1168322339348414604.png");
                pictureBox2.Load("https://cdn.discordapp.com/app-assets/1168172477839589436/1168173347436249178.png");
            }
            else if (comboBox2.SelectedIndex == 2)
            {   
                label4.Text = "Brawl Stars";
                ClientIDFild.Text = "1168312406804537414";
                largeImgKeyFild.Text = "brawlstars";
                largeImgTextFild.Text = "Brawl Stars";
                smallImgKeyFild.Text = "ball";
                smallImgTextFild.Text = "BrawlBall";
                detailsFild.Text = "In Lobby with Rafaello";
                stateTextFild.Text = "BrawlBall";
                pictureBox1.Load("https://cdn.discordapp.com/app-assets/1168312406804537414/1168312752851402852.png");
                pictureBox2.Load("https://cdn.discordapp.com/app-assets/1168312406804537414/1168332012755615824.png");
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                label4.Text = "Binance";
                ClientIDFild.Text = "1168313472384249986";
                largeImgKeyFild.Text = "binance";
                largeImgTextFild.Text = "Binance";
                smallImgKeyFild.Text = "bitcoin";
                smallImgTextFild.Text = "Bitcoin";
                detailsFild.Text = "Trading";
                stateTextFild.Text = "Bitcoin";
                pictureBox1.Load("https://cdn.discordapp.com/app-assets/1168313472384249986/1168313517422682144.png");
                pictureBox2.Load("https://cdn.discordapp.com/app-assets/1168313472384249986/1168324184213037136.png");
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                label4.Text = "Custom";
                ClientIDFild.Text = customClientID;
                largeImgKeyFild.Text = customLargeImgKey;
                largeImgTextFild.Text = customLargeImgText;
                smallImgKeyFild.Text = customSmallImgKey;
                smallImgTextFild.Text = customSmallImgText;
                detailsFild.Text = customDetails;
                stateTextFild.Text = customState;
                pictureBox1.Load("https://htmlcolorcodes.com/assets/images/colors/steel-gray-color-solid-background-1920x1080.png");
                pictureBox2.Load("https://images.unsplash.com/flagged/photo-1593005510329-8a4035a7238f?q=80&w=1000&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxleHBsb3JlLWZlZWR8NXx8fGVufDB8fHx8fA%3D%3D");
            }
        }
    }
}