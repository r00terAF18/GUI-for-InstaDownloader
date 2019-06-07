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
using System.Text.RegularExpressions;

namespace InstaDownlaoder
{
    public partial class Main : Form
    {
        bool light, dark;
        public string argument;
        public string settings = @"C:/Users/" + Environment.UserName + @"/AppData/Local/insta.config";
        public string appPath;

        private void checkApp()
        {
            try
            {
                if (File.Exists(appPath))
                {

                }
                else
                {
                    MessageBox.Show("Looks like my apps are not in the same directory, that is ok, just tell me where it is!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OpenFileDialog findApp = new OpenFileDialog();
                    if (DialogResult.OK == findApp.ShowDialog())
                    {
                        appPath = Path.GetFullPath(findApp.FileName);
                        writeSave();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkForSettingsFile()
        {
            try
            {
                if (!File.Exists(settings))
                {
                    File.Create(settings);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeSave()
        {
            try
            {
                StreamWriter sw = new StreamWriter(settings);
                string stringToWrite = "";
                if (dark)
                {
                    stringToWrite = "Theme = \"Dark\"\nApp Path = \"" + appPath + "\"";
                }
                else if (light)
                {
                    stringToWrite = "Theme = \"Light\"\nApp Path = \"" + appPath + "\"";
                }
                sw.Write(stringToWrite);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void instaConsole()
        {
            try
            {
                StreamReader sw = new StreamReader(settings);
                string theme = sw.ReadLine();
                string app = sw.ReadLine();
                sw.Close();
                Regex regex = new Regex("\"[^\"]*\"");
                char[] toTrim = "\"".ToCharArray();
                appPath = regex.Match(app).ToString().Trim(toTrim);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readSave()
        {
            try
            {
                StreamReader sw = new StreamReader(settings);
                string theme = sw.ReadLine();
                string app = sw.ReadLine();
                sw.Close();
                if (theme.Equals("Theme = \"Dark\""))
                {
                    EnableDarkTheme();
                }
                else if (theme.Equals("Theme = \"Light\""))
                {
                    EnableLightTheme();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            try
            {
                panelSettings.Visible = false;
                mainPanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                panelSettings.Visible = true;
                mainPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EnableDarkTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            btnHome.BackColor = Color.FromArgb(45, 45, 48);
            btnSettings.BackColor = Color.FromArgb(45, 45, 48);
            btnGitHub.BackColor = Color.FromArgb(45, 45, 48);
            btnGitHub.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnInstagram.BackColor = Color.FromArgb(45, 45, 48);
            btnInstagram.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnTwitter.BackColor = Color.FromArgb(45, 45, 48);
            btnTwitter.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);

            btnDownload.BackColor = Color.FromArgb(45, 45, 48);
            btnDownload.ForeColor = Color.Orchid;
            btnDownload.FlatAppearance.BorderColor = Color.Orchid;

            txtUrl.BackColor = Color.FromArgb(45, 45, 48);
            txtName.BackColor = Color.FromArgb(45, 45, 48);

            txtUrl.ForeColor = Color.Orchid;
            txtName.ForeColor = Color.Orchid;

            label1.ForeColor = Color.Orchid;
            label2.ForeColor = Color.Orchid;
            label3.ForeColor = Color.Orchid;
            Theme.ForeColor = Color.Orchid;

            rdnBtnDark.ForeColor = Color.Orchid;
            rdnBtnLight.ForeColor = Color.Orchid;

            checkBoxQuit.ForeColor = Color.Orchid;
            checkBoxVerbose.ForeColor = Color.Orchid;

            rdnBtnDark.Checked = true;
            writeSave();
        }

        private void EnableLightTheme()
        {
            this.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnSettings.BackColor = Color.White;
            btnTwitter.BackColor = Color.White;
            btnTwitter.FlatAppearance.BorderColor = Color.White;
            btnInstagram.BackColor = Color.White;
            btnInstagram.FlatAppearance.BorderColor = Color.White;
            btnGitHub.BackColor = Color.White;
            btnGitHub.FlatAppearance.BorderColor = Color.White;

            btnDownload.BackColor = Color.White;
            btnDownload.ForeColor = Color.Black;
            btnDownload.FlatAppearance.BorderColor = Color.White;

            txtName.BackColor = Color.White;
            txtUrl.BackColor = Color.White;

            txtName.ForeColor = Color.Black;
            txtUrl.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            Theme.ForeColor = Color.Black;

            rdnBtnDark.ForeColor = Color.Black;
            rdnBtnLight.ForeColor = Color.Black;

            checkBoxQuit.ForeColor = Color.Black;
            checkBoxVerbose.ForeColor = Color.Black;

            rdnBtnLight.Checked = true;
            writeSave();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            checkForSettingsFile();
            instaConsole();
            readSave();
            checkApp();
            mainPanel.Visible = true;
        }

        private void BtnTwitter_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://twitter.com/AmirRoohi2K");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInstagram_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.instagram.com/hello_worldfromcs/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGitHub_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/AmirRoohi2000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdnBtnLight_CheckedChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUrl_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.All;
                txtUrl.Text = e.Data.GetData(DataFormats.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxQuit.Checked && checkBoxVerbose.Checked)
                {
                    MessageBox.Show("Either Quit or Verbose or none, but not both!", "Please note!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUrl.Text.Equals("") || txtName.Text.Equals(""))
                {
                    MessageBox.Show("The app needs a URL and a Name!", "Please note!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkBoxQuit.Checked)
                {
                    argument = "-u " + txtUrl.Text + " -n " + txtName.Text + " -q";
                }
                else if (checkBoxVerbose.Checked)
                {
                    argument = "-u " + txtUrl.Text + " -n " + txtName.Text + " -v";
                }
                else if (!checkBoxQuit.Checked && !checkBoxVerbose.Checked)
                {
                    argument = "-u " + txtUrl.Text + " -n " + txtName.Text;
                }
                else
                {

                }
                Process.Start(appPath, argument);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RdnBtnDark_CheckedChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}