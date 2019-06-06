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
using System.Diagnostics;

namespace InstaDownlaoder
{
    public partial class Main : Form
    {

        bool settingsFile, light, dark;
        string settings = @"C:/Users/" + Environment.UserName + @"/AppData/Local/insta.config";

        private void checkForSettingsFile()
        {
            if (!File.Exists(settings))
            {
                settingsFile = false;
                File.Create(settings);
                settingsFile = true;
            }
            else
            {
                settingsFile = true;
            }
        }

        private void writeSave()
        {
            StreamWriter sw = new StreamWriter(settings);
            string stringToWrite = "";
            if (dark)
            {
                stringToWrite = "Theme = \"Dark\"";
            }
            else if (light)
            {
                stringToWrite = "Theme = \"Light\"";
            }
            sw.Write(stringToWrite);
            sw.Close();
        }

        private void readSave()
        {
            StreamReader sw = new StreamReader(settings);
            string check = sw.ReadLine();
            sw.Close();
            if (check.Equals("Theme = \"Dark\""))
            {
                EnableDarkTheme();
            }
            else if (check.Equals("Theme = \"Light\""))
            {
                EnableLightTheme();
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = true;
        }

        private void EnableDarkTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            btnHome.BackColor = Color.FromArgb(45, 45, 48);
            btnSettings.BackColor = Color.FromArgb(45, 45, 48);
            btnGitHub.BackColor = Color.FromArgb(45, 45, 48);
            btnInstagram.BackColor = Color.FromArgb(45, 45, 48);
            btnTwitter.BackColor = Color.FromArgb(45, 45, 48);
            rdnBtnDark.Checked = true;
            writeSave();
        }

        private void EnableLightTheme()
        {
            this.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnSettings.BackColor = Color.White;
            btnTwitter.BackColor = Color.White;
            btnInstagram.BackColor = Color.White;
            btnGitHub.BackColor = Color.White;
            rdnBtnLight.Checked = true;
            writeSave();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            checkForSettingsFile();
            readSave();
        }

        private void BtnTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/AmirRoohi2K");
        }

        private void BtnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/hello_worldfromcs/");
        }

        private void BtnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/AmirRoohi2000");
        }

        private void RdnBtnLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnDark.Checked)
            {
                EnableDarkTheme();
                dark = true;
                light = false;
            }
            else if (rdnBtnLight.Checked)
            {
                EnableLightTheme();
                light = true;
                dark = false;
            }
        }

        private void RdnBtnDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnDark.Checked)
            {
                EnableDarkTheme();
                dark = true;
                light = false;
            }
            else if (rdnBtnLight.Checked)
            {
                EnableLightTheme();
                light = true;
                dark = false;
            }
        }
    }
}
