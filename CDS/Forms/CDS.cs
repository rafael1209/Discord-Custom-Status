using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDS.Forms
{
        public partial class CDS : Form
        {
                private DiscordRpcClient discordRpcClient;

                public CDS()
                {
                        InitializeComponent();
                        InitializeDiscordRpc();
                }

                private void InitializeDiscordRpc()
                {
                        discordRpcClient ??= new DiscordRpcClient(textBox1.Text);

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

                        UpdatePresence();
                }

                private void UpdatePresence()
                {
                        var buttons = new List<DiscordRPC.Button>();

                        buttons.Add(new()
                        {
                                Label = textBox12.Text ?? "rafaelchasman.ru",
                                Url = textBox11.Text ?? "https://rafaelchasman.ru/"
                        });

                        Random random = new Random();
                        discordRpcClient.SetPresence(new RichPresence
                        {
                                Details = textBox2.Text,
                                State = textBox3.Text,
                                Assets = new Assets
                                {
                                        LargeImageKey = textBox4.Text,
                                        LargeImageText = textBox7.Text,
                                        SmallImageKey = textBox5.Text,
                                        SmallImageText = textBox6.Text
                                },
                                Buttons = buttons.ToArray(),
                                Party = checkBox2.Checked ? null : new Party
                                {
                                        ID = new Random().Next(9999).ToString(),
                                        Size = int.Parse(textBox1.Text),
                                        Max = int.Parse(textBox2.Text)
                                },
                                Timestamps = checkBox1.Checked ? null : new Timestamps
                                {
                                        Start = DateTime.Now.AddHours(-(int.Parse(textBox3.Text) + 2))
                                }
                        });
                }

                private void button1_Click(object sender, EventArgs e)
                {

                }
        }
}
