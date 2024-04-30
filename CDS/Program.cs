using CDS.Forms;
using System;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace CDS
{
        internal static class Program
        {
                private static NotifyIcon trayIcon;

                /// <summary>
                ///  The main entry point for the application.
                /// </summary>
                [STAThread]
                static void Main()
                {
                        ApplicationConfiguration.Initialize();

                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);

                        Icon formIcon = Properties.Resources.logo;


                        trayIcon = new NotifyIcon
                        {
                                Icon = formIcon,
                                Text = "CDS Application",
                                Visible = true
                        };

                        trayIcon.ContextMenuStrip = new ContextMenuStrip();
                        trayIcon.ContextMenuStrip.Items.Add("Open", null, (sender, e) => ShowMainForm());
                        trayIcon.ContextMenuStrip.Items.Add("Hide", null, (sender, e) => HideApplication());
                        trayIcon.ContextMenuStrip.Items.Add("Exit", null, (sender, e) => ExitApplication());

                        trayIcon.DoubleClick += (sender, e) => ShowMainForm();

                        Application.Run(new Forms.CDS());
                }

                private static void ShowMainForm()
                {
                        if (Application.OpenForms.Count == 0)
                        {
                                Application.Run(new Forms.CDS());
                        }
                        else
                        {
                                Application.OpenForms[0].Show();
                        }
                }

                private static void ExitApplication()
                {
                        Application.Exit();
                }

                private static void HideApplication()
                {
                        Application.OpenForms[0].Hide();
                }
        }
}
