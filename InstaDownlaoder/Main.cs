using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using InstaDownlaoder.Properties;

namespace InstaDownlaoder
{
    public partial class Main : Form
    {
        public bool light, dark;
        public string argument, appPath;
        public string localAppPath = "instaDownloader_console.exe";

        insta appSettings = new insta();

        private void checkApp() // 1
        {
            try
            {
                if (appSettings.AppPath.Equals(localAppPath))
                {
                    appPath = localAppPath;
                    appSettings.AppPath = localAppPath;
                    appSettings.Save();
                }
                else if (!appSettings.AppPath.Equals(localAppPath))
                {
                    if (File.Exists(appSettings.AppPath))
                    {
                        appPath = appSettings.AppPath;
                        appSettings.Save();
                    }
                    else
                    {
                        MessageBox.Show("Looks like my apps are not in the same directory, that is ok, just tell me where it is!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        OpenFileDialog findApp = new OpenFileDialog();
                        if (DialogResult.OK == findApp.ShowDialog())
                        {
                            appPath = Path.GetFullPath(findApp.FileName);
                            appSettings.AppPath = appPath;
                            appSettings.Save();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void writeDefault()
        {
            try
            {
                appSettings.Theme = "Dark";
                rdnBtnDark.Checked = true;
                dark = true;
                EnableDarkTheme();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void writeSave()
        {
            try
            {
                if (dark)
                {
                    appSettings.Theme = "Dark";
                    appSettings.Save();
                }
                else if (light)
                {
                    appSettings.Theme = "Light";
                    appSettings.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("writeSave();" + ex.Message);
            }
        }

        private void loadUI() // 2
        {
            try
            {
                if (appSettings.Theme.Equals("Dark"))
                {
                    rdnBtnDark.Checked = true;
                    rdnBtnLight.Checked = false;
                    EnableDarkTheme();
                }
                else if (appSettings.Theme.Equals("Light"))
                {
                    rdnBtnLight.Checked = true;
                    rdnBtnDark.Checked = false;
                    EnableLightTheme();
                }
                else if (!appSettings.Theme.Equals("Dark") || !appSettings.Theme.Equals("Light"))
                {
                    writeDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loadUI();" + ex.Message);
            }
        }

        public Main()
        {
            InitializeComponent();  // DEFAULT

            checkApp();
            loadUI();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            try
            {
                panelSettings.Visible = false;
                mainPanel.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                panelSettings.Visible = true;
                mainPanel.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void EnableDarkTheme()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            btnHome.BackColor = Color.FromArgb(45, 45, 48);
            btnSettings.BackColor = Color.FromArgb(45, 45, 48);
            btnGitHub.BackColor = Color.FromArgb(45, 45, 48);
            btnGitHub.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);

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

            GC.Collect();
            writeSave();
        }

        private void EnableLightTheme()
        {
            this.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnSettings.BackColor = Color.White;
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

            GC.Collect();
            writeSave();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            panelSettings.Visible = false;
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
                    dark = true;
                    light = false;
                    EnableDarkTheme();
                }
                else if (rdnBtnLight.Checked)
                {
                    light = true;
                    dark = false;
                    EnableLightTheme();
                }
            }
            catch (Exception)
            {
                throw;
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

        private static string grabClipboard()
        {
            try
            {
                return Clipboard.GetText().ToString();
            }
            catch (Exception)
            {
                throw;
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
                else if (txtUrl.Text.Equals("") || txtUrl.Text.Equals(" "))
                {
                    if (checkBoxQuit.Checked)
                    {
                        if (txtName.Text.Equals("") || txtName.Text.Equals(" "))
                        {
                            argument = "-u \"" + grabClipboard() + "\" " + " -q";
                            Process.Start(appPath, argument);
                        }
                        else
                        {
                            argument = "-u \"" + grabClipboard() + "\" -n \"" + txtName.Text + "\" -q";
                            Process.Start(appPath, argument);
                        }
                    }
                    else if (checkBoxVerbose.Checked)
                    {
                        if (txtName.Text.Equals("") || txtName.Text.Equals(" "))
                        {
                            argument = "-u \"" + grabClipboard() + "\" " + " -v";
                            Process.Start(appPath, argument);
                        }
                        else
                        {
                            argument = "-u \"" + grabClipboard() + "\" -n \"" + txtName.Text + "\" -v";
                            Process.Start(appPath, argument);
                        }
                    }
                    else if (!checkBoxQuit.Checked && !checkBoxVerbose.Checked)
                    {
                        if (txtName.Text.Equals("") || txtName.Text.Equals(" "))
                        {
                            argument = "-u \"" + grabClipboard() + "\"";
                            Process.Start(appPath, argument);
                        }
                        else
                        {
                            argument = "-u \"" + grabClipboard() + "\" -n \"" + txtName.Text + "\"";
                            Process.Start(appPath, argument);
                        }
                    }
                }
                else if (checkBoxQuit.Checked)
                {
                    if (txtName.Text.Equals("") || txtName.Text.Equals(" "))
                    {
                        argument = "-u \"" + txtUrl.Text + "\" " + " -q";
                        Process.Start(appPath, argument);
                    }
                    else
                    {
                        argument = "-u \"" + txtUrl.Text + "\" -n \"" + txtName.Text + "\" -q";
                        Process.Start(appPath, argument);
                    }
                }
                else if (checkBoxVerbose.Checked)
                {
                    if (txtName.Text.Equals("") || txtName.Text.Equals(" "))
                    {
                        argument = "-u \"" + txtUrl.Text + "\" " + " -v";
                        Process.Start(appPath, argument);
                    }
                    else
                    {
                        argument = "-u \"" + txtUrl.Text + "\" -n \"" + txtName.Text + "\" -v";
                        Process.Start(appPath, argument);
                    }
                }
                else if (!checkBoxQuit.Checked && !checkBoxVerbose.Checked)
                {
                    if (txtName.Text.Equals("") || txtName.Text.Equals(" "))
                    {
                        argument = "-u \"" + txtUrl.Text + "\"";
                        Process.Start(appPath, argument);
                    }
                    else
                    {
                        argument = "-u \"" + txtUrl.Text + "\" -n \"" + txtName.Text + "\"";
                        Process.Start(appPath, argument);
                    }
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

        private void RdnBtnDark_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdnBtnDark.Checked)
                {
                    dark = true;
                    light = false;
                    EnableDarkTheme();
                }
                else if (rdnBtnLight.Checked)
                {
                    light = true;
                    dark = false;
                    EnableLightTheme();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
