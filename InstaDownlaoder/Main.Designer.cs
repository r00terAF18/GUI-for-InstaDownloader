﻿namespace InstaDownlaoder
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.rdnBtnLight = new System.Windows.Forms.RadioButton();
            this.rdnBtnDark = new System.Windows.Forms.RadioButton();
            this.Theme = new System.Windows.Forms.Label();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
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
            // panelSettings
            // 
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
            // rdnBtnLight
            // 
            this.rdnBtnLight.AutoSize = true;
            this.rdnBtnLight.ForeColor = System.Drawing.Color.Orchid;
            this.rdnBtnLight.Location = new System.Drawing.Point(196, 17);
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
            this.rdnBtnDark.Location = new System.Drawing.Point(110, 17);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(659, 229);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSettings);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Instagram Downloader - @AmirRoohi2K";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label Theme;
        private System.Windows.Forms.RadioButton rdnBtnLight;
        private System.Windows.Forms.RadioButton rdnBtnDark;
    }
}

