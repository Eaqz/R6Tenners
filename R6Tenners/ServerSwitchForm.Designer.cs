namespace R6Tenners
{
    partial class ServerSwitchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSwitchForm));
            this.server_Cb = new MetroFramework.Controls.MetroComboBox();
            this.info_GB = new System.Windows.Forms.GroupBox();
            this.apply_BTN = new MetroFramework.Controls.MetroButton();
            this.profiles_Lb = new MetroFramework.Controls.MetroLabel();
            this.current_Lb = new MetroFramework.Controls.MetroLabel();
            this.info_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // server_Cb
            // 
            this.server_Cb.FormattingEnabled = true;
            this.server_Cb.ItemHeight = 23;
            this.server_Cb.Items.AddRange(new object[] {
            "default \'ping based\'",
            "eus     \'us east\'",
            "cus     \'us central\'",
            "scus    \'us south central\'",
            "wus     \'us west\'",
            "sbr      \'brazil south\'",
            "neu     \'europe north\'",
            "weu     \'europe west\'",
            "eas       \'asia east\'",
            "seas     \'asia south east\'",
            "eau      \'australia east\'",
            "wja      \'japan west\'"});
            this.server_Cb.Location = new System.Drawing.Point(23, 63);
            this.server_Cb.Name = "server_Cb";
            this.server_Cb.Size = new System.Drawing.Size(171, 29);
            this.server_Cb.Style = MetroFramework.MetroColorStyle.Red;
            this.server_Cb.TabIndex = 0;
            this.server_Cb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.server_Cb.UseSelectable = true;
            // 
            // info_GB
            // 
            this.info_GB.Controls.Add(this.current_Lb);
            this.info_GB.Controls.Add(this.profiles_Lb);
            this.info_GB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_GB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.info_GB.Location = new System.Drawing.Point(23, 100);
            this.info_GB.Name = "info_GB";
            this.info_GB.Size = new System.Drawing.Size(238, 81);
            this.info_GB.TabIndex = 1;
            this.info_GB.TabStop = false;
            this.info_GB.Text = "Info";
            // 
            // apply_BTN
            // 
            this.apply_BTN.Location = new System.Drawing.Point(200, 63);
            this.apply_BTN.Name = "apply_BTN";
            this.apply_BTN.Size = new System.Drawing.Size(61, 29);
            this.apply_BTN.Style = MetroFramework.MetroColorStyle.Red;
            this.apply_BTN.TabIndex = 2;
            this.apply_BTN.Text = "Apply";
            this.apply_BTN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apply_BTN.UseSelectable = true;
            this.apply_BTN.Click += new System.EventHandler(this.apply_BTN_Click);
            // 
            // profiles_Lb
            // 
            this.profiles_Lb.AutoSize = true;
            this.profiles_Lb.Location = new System.Drawing.Point(7, 27);
            this.profiles_Lb.Name = "profiles_Lb";
            this.profiles_Lb.Size = new System.Drawing.Size(119, 19);
            this.profiles_Lb.Style = MetroFramework.MetroColorStyle.Red;
            this.profiles_Lb.TabIndex = 0;
            this.profiles_Lb.Text = "Detected Profiles : ";
            this.profiles_Lb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // current_Lb
            // 
            this.current_Lb.AutoSize = true;
            this.current_Lb.Location = new System.Drawing.Point(20, 46);
            this.current_Lb.Name = "current_Lb";
            this.current_Lb.Size = new System.Drawing.Size(106, 19);
            this.current_Lb.Style = MetroFramework.MetroColorStyle.Red;
            this.current_Lb.TabIndex = 1;
            this.current_Lb.Text = "Current Server : ";
            this.current_Lb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ServerSwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.apply_BTN);
            this.Controls.Add(this.info_GB);
            this.Controls.Add(this.server_Cb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerSwitchForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Change Server Region";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.info_GB.ResumeLayout(false);
            this.info_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox server_Cb;
        private System.Windows.Forms.GroupBox info_GB;
        private MetroFramework.Controls.MetroLabel current_Lb;
        private MetroFramework.Controls.MetroLabel profiles_Lb;
        private MetroFramework.Controls.MetroButton apply_BTN;
    }
}