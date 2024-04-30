using DiscordRPC;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Discord_Custom_Status
{
    public partial class DiscordCustomStatusForm : Form
    {
        private DiscordRpcClient discordRpcClient;
        private NotifyIcon trayIcon;
        public int secondss;
        public string customClientID, customLargeImgKey, customSmallImgKey, customLargeImgText, customSmallImgText, customDetails, customState;

        public DiscordCustomStatusForm()
        {
            InitializeComponent();
            LoadSettings(); // Load saved settings on form initialization
            InitializeDiscordRpc();
            AddToStartup();
            InitializeTrayIcon();
        }
        private void InitializeTrayIcon()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordCustomStatusForm));
            trayIcon = new NotifyIcon();
            trayIcon.Text = "DCS v6";
            trayIcon.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon"); ; // Путь к иконке вашего приложения
            trayIcon.Visible = true;

            // Добавление обработчика щелчка на иконке в лотке
            trayIcon.MouseClick += TrayIcon_MouseClick;
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // Показать/скрыть форму приложения по щелчку на иконке
            if (e.Button == MouseButtons.Left)
            {
                // Пример:
                Visible = !Visible;
            }
        }
        private void AddToStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                // Specify the name you want to give to your program in the registry
                string appName = "Discord Custom Status";

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
        private void SaveSettings(object l, EventArgs e)
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
            Properties.Settings.Default.Timer = checkBox1.Checked;
            Properties.Settings.Default.Party = checkBox2.Checked;

            Properties.Settings.Default.CustomClientID = customClientID;
            Properties.Settings.Default.CustomLargeImgKey = customLargeImgKey;
            Properties.Settings.Default.CustomLargeImgText = customLargeImgText;
            Properties.Settings.Default.CustomSmallImgText = customSmallImgKey;
            Properties.Settings.Default.CustomSmallImgText = customSmallImgText;
            Properties.Settings.Default.CustomDetails = customDetails;
            Properties.Settings.Default.CustomState = customState;
            Properties.Settings.Default.Button1Label = textBox4.Text;
            Properties.Settings.Default.Button1Url = textBox5.Text;
            Properties.Settings.Default.Button2Url = textBox6.Text;
            Properties.Settings.Default.Button2Label = textBox7.Text;
            MessageBox.Show("Setting saved to next start!");
            Properties.Settings.Default.Save();

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
            customState = Properties.Settings.Default.CustomState;
        }

        private void InitializeDiscordRpc()
        {
            discordRpcClient ??= new DiscordRpcClient(ClientIDFild.Text);

            discordRpcClient.OnReady += (sender, e) =>
            {
                Console.WriteLine("Discord RPC is ready!");
            };

            discordRpcClient.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine($"Presence updated: {e.Presence}");
            };

            if (!discordRpcClient.IsInitialized)
                discordRpcClient.Initialize();

            // Set initial presence
            UpdatePresence();
        }

        private void UpdatePresence()
        {
            DateTime startTime = DateTime.UtcNow;

            var buttons = new List<DiscordRPC.Button>();
            if (checkBox3.Checked)
                buttons.Add(new()
                {
                    Label = textBox7.Text ?? "rafaelchasman.ru",
                    Url = textBox6.Text ?? "https://rafaelchasman.ru"
                });
            if (isAddButtonsChecked.Checked)
                buttons.Add(new()
                {
                    Label = textBox4.Text ?? "yawaflua.ru",
                    Url = textBox5.Text ?? "https://yawaflua.ru"
                });
            if (!discordRpcClient.IsInitialized)
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
                    Buttons = buttons.ToArray(),
                    Party = checkBox2.Checked ? null : new Party
                    {
                        ID = new Random().Next(9999).ToString(),
                        Size = int.Parse(textBox1.Text),
                        Max = int.Parse(textBox2.Text)
                    },
                    Timestamps = checkBox1.Checked ? null : new Timestamps { Start = DateTime.Now.AddHours(-(int.Parse(textBox3.Text) + 2)) }
                });
            else
            {
                discordRpcClient.UpdateButtons(buttons.ToArray());
                discordRpcClient.UpdateDetails(detailsFild.Text);
                discordRpcClient.UpdateState(stateTextFild.Text);
                discordRpcClient.UpdateLargeAsset(largeImgKeyFild.Text, largeImgTextFild.Text);
                discordRpcClient.UpdateSmallAsset(smallImgKeyFild.Text, smallImgTextFild.Text);
                discordRpcClient.UpdateParty(checkBox2.Checked ? null : new Party
                {
                    ID = new Random().Next(9999).ToString(),
                    Size = int.Parse(textBox1.Text),
                    Max = int.Parse(textBox2.Text)
                });
                if (checkBox1.Checked)
                    discordRpcClient.UpdateStartTime(DateTime.Now.AddHours(-(int.Parse(textBox3.Text) + 2)));
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Dispose of the existing DiscordRpcClient


            // Create a new DiscordRpcClient with the updated client ID
            discordRpcClient ??= new DiscordRpcClient(ClientIDFild.Text);

            // Initialize the new client
            InitializeDiscordRpc();

            if (checkBox1.Checked)
            {
                timer.Enabled = false;
                secondss = int.Parse(textBox3.Text) * 3600;
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
            label16.Enabled = !checkBox1.Checked;
            textBox3.Enabled = !checkBox1.Checked;
            label15.Enabled = !checkBox1.Checked;
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
            label11.Text = stateTextFild.Text + " (" + textBox1.Text + " of " + textBox2.Text + ")";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                textBox1.Text = "1";
                textBox2.Text = "2";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label11.Text = stateTextFild.Text + " (" + textBox1.Text + " of " + textBox2.Text + ")";
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                textBox1.Text = "1";
                textBox2.Text = "2";
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
                label14.Enabled = false;
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

            if (secondss > 3600)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = checkBox3.Checked;
            textBox6.Enabled = checkBox3.Checked;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = isAddButtonsChecked.Checked;
            textBox5.Enabled = isAddButtonsChecked.Checked;
        }


    }
}