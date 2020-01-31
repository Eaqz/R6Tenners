using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace R6Tenners
{
    public partial class ServerSwitchForm : MetroForm
    {
        // Get Directory for Profiles
        string ProfilesDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal‌​) + "\\My Games\\Rainbow Six - Siege";
        private void UpdateCurrentLabels()
        {
            // Search all files with ".ini" extension and store in array
            string[] filePaths = Directory.GetFiles(ProfilesDirectory, "*.ini", SearchOption.AllDirectories);

            if (filePaths.Count() > 1) // If we have multiple profiles
            {
                for (int i = 0; i < filePaths.Count() - 1; i++)
                {
                    INIFile ini1 = new INIFile(filePaths[i]);
                    INIFile ini2 = new INIFile(filePaths[i+1]);

                    if (ini1.IniReadValue("ONLINE", "DataCenterHint") != ini2.IniReadValue("ONLINE", "DataCenterHint"))
                    {
                        current_Lb.Text = "Current : Not all same server settings";
                        break;
                    }
                    else if (i == filePaths.Count() - 2)
                    {
                        current_Lb.Text = "Current : " + ini1.IniReadValue("ONLINE", "DataCenterHint");
                        server_Cb.Text = ini1.IniReadValue("ONLINE", "DataCenterHint");
                    }
                }
            }
            else
            {
                INIFile ini = new INIFile(filePaths[0]);
                current_Lb.Text = "Current : " + ini.IniReadValue("ONLINE", "DataCenterHint");
                server_Cb.Text = ini.IniReadValue("ONLINE", "DataCenterHint");
            }

            profiles_Lb.Text = "Detected Profiles : " + filePaths.Count().ToString();
        }

        private void SetTheme(MetroFramework.MetroColorStyle colorStyle)
        {
            this.Style = colorStyle;
            server_Cb.Style = colorStyle;

            this.Refresh();
        }
        public ServerSwitchForm(MetroFramework.MetroColorStyle colorStyle)
        {
            InitializeComponent();

            server_Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            SetTheme(colorStyle);
            UpdateCurrentLabels();
        }

        private void apply_BTN_Click(object sender, EventArgs e)
        {
            if (server_Cb.Text != "NULL")
            {
                string selected_server = server_Cb.Text;
                string[] filePaths = Directory.GetFiles(ProfilesDirectory, "*.ini", SearchOption.AllDirectories);

                for (int i = 0; i < filePaths.Count(); i++)
                {
                    INIFile ini = new INIFile(filePaths[i]);

                    // Set the new server region for all profiles
                    if (!selected_server.Contains("default"))
                    {
                        if (selected_server.Contains("scus")) ini.IniWriteValue("ONLINE", "DataCenterHint", "scus");
                        else if (selected_server.Contains("seas")) ini.IniWriteValue("ONLINE", "DataCenterHint", "seas");
                        else ini.IniWriteValue("ONLINE", "DataCenterHint", selected_server.Substring(0, 3));
                    }
                    else ini.IniWriteValue("ONLINE", "DataCenterHint", "default");
                }

                UpdateCurrentLabels();
            }
            else MessageBox.Show("Please choose a server from the list", "Yikes Boomer");
        }
    }
}
