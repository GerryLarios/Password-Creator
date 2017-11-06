namespace PasswordCreator
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.cmbTheme = new MetroFramework.Controls.MetroComboBox();
            this.lblTheme = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblGmail = new MetroFramework.Controls.MetroLabel();
            this.lblSteam = new MetroFramework.Controls.MetroLabel();
            this.lblPaypal = new MetroFramework.Controls.MetroLabel();
            this.lblUnity = new MetroFramework.Controls.MetroLabel();
            this.lblFb = new MetroFramework.Controls.MetroLabel();
            this.lblNetflix = new MetroFramework.Controls.MetroLabel();
            this.lblAmazon = new MetroFramework.Controls.MetroLabel();
            this.lblHumbleBundle = new MetroFramework.Controls.MetroLabel();
            this.lblGandhi = new MetroFramework.Controls.MetroLabel();
            this.lblTwitter = new MetroFramework.Controls.MetroLabel();
            this.lblInstagram = new MetroFramework.Controls.MetroLabel();
            this.lblOthers = new MetroFramework.Controls.MetroLabel();
            this.PanelPasswords = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnExportPDF = new MetroFramework.Controls.MetroButton();
            this.btnExportTXT = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.ItemHeight = 23;
            this.cmbTheme.Items.AddRange(new object[] {
            "Dark",
            "Light",
            "Default"});
            this.cmbTheme.Location = new System.Drawing.Point(630, 104);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(121, 29);
            this.cmbTheme.TabIndex = 0;
            this.cmbTheme.UseSelectable = true;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(575, 104);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(49, 19);
            this.lblTheme.TabIndex = 1;
            this.lblTheme.Text = "Theme";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Location = new System.Drawing.Point(23, 108);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(43, 19);
            this.lblGmail.TabIndex = 2;
            this.lblGmail.Text = "Gmail";
            // 
            // lblSteam
            // 
            this.lblSteam.AutoSize = true;
            this.lblSteam.Location = new System.Drawing.Point(22, 138);
            this.lblSteam.Name = "lblSteam";
            this.lblSteam.Size = new System.Drawing.Size(46, 19);
            this.lblSteam.TabIndex = 3;
            this.lblSteam.Text = "Steam";
            // 
            // lblPaypal
            // 
            this.lblPaypal.AutoSize = true;
            this.lblPaypal.Location = new System.Drawing.Point(22, 168);
            this.lblPaypal.Name = "lblPaypal";
            this.lblPaypal.Size = new System.Drawing.Size(47, 19);
            this.lblPaypal.TabIndex = 5;
            this.lblPaypal.Text = "Paypal";
            // 
            // lblUnity
            // 
            this.lblUnity.AutoSize = true;
            this.lblUnity.Location = new System.Drawing.Point(22, 200);
            this.lblUnity.Name = "lblUnity";
            this.lblUnity.Size = new System.Drawing.Size(38, 19);
            this.lblUnity.TabIndex = 4;
            this.lblUnity.Text = "Unity";
            // 
            // lblFb
            // 
            this.lblFb.AutoSize = true;
            this.lblFb.Location = new System.Drawing.Point(22, 232);
            this.lblFb.Name = "lblFb";
            this.lblFb.Size = new System.Drawing.Size(65, 19);
            this.lblFb.TabIndex = 9;
            this.lblFb.Text = "Facebook";
            // 
            // lblNetflix
            // 
            this.lblNetflix.AutoSize = true;
            this.lblNetflix.Location = new System.Drawing.Point(22, 264);
            this.lblNetflix.Name = "lblNetflix";
            this.lblNetflix.Size = new System.Drawing.Size(46, 19);
            this.lblNetflix.TabIndex = 8;
            this.lblNetflix.Text = "Netflix";
            // 
            // lblAmazon
            // 
            this.lblAmazon.AutoSize = true;
            this.lblAmazon.Location = new System.Drawing.Point(22, 296);
            this.lblAmazon.Name = "lblAmazon";
            this.lblAmazon.Size = new System.Drawing.Size(58, 19);
            this.lblAmazon.TabIndex = 7;
            this.lblAmazon.Text = "Amazon";
            // 
            // lblHumbleBundle
            // 
            this.lblHumbleBundle.AutoSize = true;
            this.lblHumbleBundle.Location = new System.Drawing.Point(22, 328);
            this.lblHumbleBundle.Name = "lblHumbleBundle";
            this.lblHumbleBundle.Size = new System.Drawing.Size(95, 19);
            this.lblHumbleBundle.TabIndex = 6;
            this.lblHumbleBundle.Text = "HumbleBundle";
            // 
            // lblGandhi
            // 
            this.lblGandhi.AutoSize = true;
            this.lblGandhi.Location = new System.Drawing.Point(22, 359);
            this.lblGandhi.Name = "lblGandhi";
            this.lblGandhi.Size = new System.Drawing.Size(50, 19);
            this.lblGandhi.TabIndex = 13;
            this.lblGandhi.Text = "Gandhi";
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Location = new System.Drawing.Point(22, 392);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(47, 19);
            this.lblTwitter.TabIndex = 12;
            this.lblTwitter.Text = "Twitter";
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Location = new System.Drawing.Point(22, 422);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(67, 19);
            this.lblInstagram.TabIndex = 11;
            this.lblInstagram.Text = "Instagram";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Location = new System.Drawing.Point(22, 454);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(48, 19);
            this.lblOthers.TabIndex = 10;
            this.lblOthers.Text = "Others";
            // 
            // PanelPasswords
            // 
            this.PanelPasswords.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelPasswords.Location = new System.Drawing.Point(124, 104);
            this.PanelPasswords.Margin = new System.Windows.Forms.Padding(10);
            this.PanelPasswords.Name = "PanelPasswords";
            this.PanelPasswords.Size = new System.Drawing.Size(400, 400);
            this.PanelPasswords.TabIndex = 27;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(575, 160);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(176, 60);
            this.btnGenerate.TabIndex = 28;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(575, 252);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(176, 60);
            this.btnExportPDF.TabIndex = 29;
            this.btnExportPDF.Text = "Export (PDF)";
            this.btnExportPDF.UseSelectable = true;
            // 
            // btnExportTXT
            // 
            this.btnExportTXT.Location = new System.Drawing.Point(575, 344);
            this.btnExportTXT.Name = "btnExportTXT";
            this.btnExportTXT.Size = new System.Drawing.Size(176, 60);
            this.btnExportTXT.TabIndex = 30;
            this.btnExportTXT.Text = "Export (TXT)";
            this.btnExportTXT.UseSelectable = true;
            this.btnExportTXT.Click += new System.EventHandler(this.btnExportTXT_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btnExportTXT);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.PanelPasswords);
            this.Controls.Add(this.lblGandhi);
            this.Controls.Add(this.lblTwitter);
            this.Controls.Add(this.lblInstagram);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.lblFb);
            this.Controls.Add(this.lblNetflix);
            this.Controls.Add(this.lblAmazon);
            this.Controls.Add(this.lblHumbleBundle);
            this.Controls.Add(this.lblPaypal);
            this.Controls.Add(this.lblUnity);
            this.Controls.Add(this.lblSteam);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.cmbTheme);
            this.Name = "FormMain";
            this.Text = "Password Creator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbTheme;
        private MetroFramework.Controls.MetroLabel lblTheme;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel lblFb;
        private MetroFramework.Controls.MetroLabel lblNetflix;
        private MetroFramework.Controls.MetroLabel lblAmazon;
        private MetroFramework.Controls.MetroLabel lblHumbleBundle;
        private MetroFramework.Controls.MetroLabel lblPaypal;
        private MetroFramework.Controls.MetroLabel lblUnity;
        private MetroFramework.Controls.MetroLabel lblSteam;
        private MetroFramework.Controls.MetroLabel lblGmail;
        private MetroFramework.Controls.MetroLabel lblGandhi;
        private MetroFramework.Controls.MetroLabel lblTwitter;
        private MetroFramework.Controls.MetroLabel lblInstagram;
        private MetroFramework.Controls.MetroLabel lblOthers;
        private System.Windows.Forms.FlowLayoutPanel PanelPasswords;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroButton btnExportPDF;
        private MetroFramework.Controls.MetroButton btnExportTXT;
    }
}

