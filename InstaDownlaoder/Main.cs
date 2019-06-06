using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaDownlaoder
{
    public partial class Main : Form
    {
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
        }

        private void EnableLightTheme()
        {
            this.BackColor = Color.White;
            btnHome.BackColor = Color.White;
            btnSettings.BackColor = Color.White;
        }

        private void RdnBtnLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnDark.Checked)
            {
                EnableDarkTheme();
            }
            else if (rdnBtnLight.Checked)
            {
                EnableLightTheme();
            }
        }

        private void RdnBtnDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnBtnDark.Checked)
            {
                EnableDarkTheme();
            }
            else if (rdnBtnLight.Checked)
            {
                EnableLightTheme();
            }
        }
    }
}
