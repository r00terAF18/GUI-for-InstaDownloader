namespace InstaDownlaoder
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSettings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.rdnBtnLight = new System.Windows.Forms.RadioButton();
            this.rdnBtnDark = new System.Windows.Forms.RadioButton();
            this.Theme = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.checkBoxVerbose = new System.Windows.Forms.CheckBox();
            this.checkBoxQuit = new System.Windows.Forms.CheckBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.btnTwitter);
            this.panelSettings.Controls.Add(this.btnInstagram);
            this.panelSettings.Controls.Add(this.btnGitHub);
            this.panelSettings.Controls.Add(this.rdnBtnLight);
            this.panelSettings.Controls.Add(this.rdnBtnDark);
            this.panelSettings.Controls.Add(this.Theme);
            this.panelSettings.ForeColor = System.Drawing.Color.Magenta;
            this.panelSettings.Location = new System.Drawing.Point(145, 12);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(512, 205);
            this.panelSettings.TabIndex = 3;
            this.panelSettings.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Orchid;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "My social media";
            // 
            // btnTwitter
            // 
            this.btnTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTwitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwitter.Image = global::InstaDownlaoder.Properties.Resources.twitter;
            this.btnTwitter.Location = new System.Drawing.Point(301, 81);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(45, 42);
            this.btnTwitter.TabIndex = 6;
            this.btnTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTwitter.UseVisualStyleBackColor = false;
            this.btnTwitter.Click += new System.EventHandler(this.BtnTwitter_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInstagram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInstagram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagram.Image = global::InstaDownlaoder.Properties.Resources.instagram;
            this.btnInstagram.Location = new System.Drawing.Point(246, 81);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(45, 42);
            this.btnInstagram.TabIndex = 5;
            this.btnInstagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInstagram.UseVisualStyleBackColor = false;
            this.btnInstagram.Click += new System.EventHandler(this.BtnInstagram_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Image = global::InstaDownlaoder.Properties.Resources.Github;
            this.btnGitHub.Location = new System.Drawing.Point(195, 81);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(45, 42);
            this.btnGitHub.TabIndex = 4;
            this.btnGitHub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.BtnGitHub_Click);
            // 
            // rdnBtnLight
            // 
            this.rdnBtnLight.AutoSize = true;
            this.rdnBtnLight.ForeColor = System.Drawing.Color.Orchid;
            this.rdnBtnLight.Location = new System.Drawing.Point(281, 13);
            this.rdnBtnLight.Name = "rdnBtnLight";
            this.rdnBtnLight.Size = new System.Drawing.Size(66, 25);
            this.rdnBtnLight.TabIndex = 2;
            this.rdnBtnLight.Text = "Light";
            this.rdnBtnLight.UseVisualStyleBackColor = true;
            this.rdnBtnLight.CheckedChanged += new System.EventHandler(this.RdnBtnLight_CheckedChanged);
            // 
            // rdnBtnDark
            // 
            this.rdnBtnDark.AutoSize = true;
            this.rdnBtnDark.ForeColor = System.Drawing.Color.Orchid;
            this.rdnBtnDark.Location = new System.Drawing.Point(195, 13);
            this.rdnBtnDark.Name = "rdnBtnDark";
            this.rdnBtnDark.Size = new System.Drawing.Size(64, 25);
            this.rdnBtnDark.TabIndex = 1;
            this.rdnBtnDark.Text = "Dark";
            this.rdnBtnDark.UseVisualStyleBackColor = true;
            this.rdnBtnDark.CheckedChanged += new System.EventHandler(this.RdnBtnDark_CheckedChanged);
            // 
            // Theme
            // 
            this.Theme.AutoSize = true;
            this.Theme.ForeColor = System.Drawing.Color.Orchid;
            this.Theme.Location = new System.Drawing.Point(19, 17);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(61, 21);
            this.Theme.TabIndex = 0;
            this.Theme.Text = "Theme";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 94);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(12, 123);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(127, 94);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.checkBoxVerbose);
            this.mainPanel.Controls.Add(this.checkBoxQuit);
            this.mainPanel.Controls.Add(this.btnDownload);
            this.mainPanel.Controls.Add(this.txtName);
            this.mainPanel.Controls.Add(this.txtUrl);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.ForeColor = System.Drawing.Color.Magenta;
            this.mainPanel.Location = new System.Drawing.Point(145, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(512, 205);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Visible = false;
            // 
            // checkBoxVerbose
            // 
            this.checkBoxVerbose.AutoSize = true;
            this.checkBoxVerbose.ForeColor = System.Drawing.Color.Orchid;
            this.checkBoxVerbose.Location = new System.Drawing.Point(106, 125);
            this.checkBoxVerbose.Name = "checkBoxVerbose";
            this.checkBoxVerbose.Size = new System.Drawing.Size(90, 25);
            this.checkBoxVerbose.TabIndex = 7;
            this.checkBoxVerbose.Text = "Verbose";
            this.checkBoxVerbose.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuit
            // 
            this.checkBoxQuit.AutoSize = true;
            this.checkBoxQuit.ForeColor = System.Drawing.Color.Orchid;
            this.checkBoxQuit.Location = new System.Drawing.Point(23, 125);
            this.checkBoxQuit.Name = "checkBoxQuit";
            this.checkBoxQuit.Size = new System.Drawing.Size(61, 25);
            this.checkBoxQuit.TabIndex = 6;
            this.checkBoxQuit.Text = "Quit";
            this.checkBoxQuit.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.Orchid;
            this.btnDownload.Location = new System.Drawing.Point(405, 159);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(99, 33);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(430, 29);
            this.txtName.TabIndex = 4;
            // 
            // txtUrl
            // 
            this.txtUrl.AllowDrop = true;
            this.txtUrl.Location = new System.Drawing.Point(72, 14);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(430, 29);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtUrl_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orchid;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orchid;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(659, 229);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSettings);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Downloader - @AmirRoohi2K";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label Theme;
        private System.Windows.Forms.RadioButton rdnBtnLight;
        private System.Windows.Forms.RadioButton rdnBtnDark;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnInstagram;
        private System.Windows.Forms.Button btnTwitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.CheckBox checkBoxQuit;
        private System.Windows.Forms.CheckBox checkBoxVerbose;
    }
}

