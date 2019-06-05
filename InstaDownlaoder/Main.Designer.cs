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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = global::InstaDownlaoder.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 94);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::InstaDownlaoder.Properties.Resources.tools_64;
            this.btnSettings.Location = new System.Drawing.Point(12, 123);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(127, 94);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Location = new System.Drawing.Point(145, 12);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(611, 295);
            this.panelSettings.TabIndex = 3;
            this.panelSettings.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(768, 319);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSettings);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Instagram Downloader - @AmirRoohi2K";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelSettings;
    }
}

