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
            else
            {

            }
            sw.Write(stringToWrite);
            sw.Close();
        }

        private void readSave()
        {
            StreamReader sw = new StreamReader(settings);
            string check = "";
            while ((check = sw.ReadLine()) != null)
            {
                if (check.Equals("Theme = \"Dark\""))
                {
                    EnableDarkTheme();
                }
                else if (check.Equals("Theme = \"Light\""))
                {
                    EnableLightTheme();
                }
                else
                {

                }
            }
            sw.Close();
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
            rdnBtnDark.Checked = true;
        }

        private void EnableLightTheme()
        {
            this.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnSettings.BackColor = Color.White;
            rdnBtnLight.Checked = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            checkForSettingsFile();
            readSave();
        }

        private void RdnBtnLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnDark.Checked)
            {
                EnableDarkTheme();
                dark = true;
                light = false;
                writeSave();
            }
            else if (rdnBtnLight.Checked)
            {
                EnableLightTheme();
                light = true;
                dark = false;
                writeSave();
            }
        }

        private void RdnBtnDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnDark.Checked)
            {
                EnableDarkTheme();
                dark = true;
                light = false;
                writeSave();
            }
            else if (rdnBtnLight.Checked)
            {
                EnableLightTheme();
                light = true;
                dark = false;
                writeSave();
            }
        }
    }
}
