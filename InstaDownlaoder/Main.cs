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
    }
}
