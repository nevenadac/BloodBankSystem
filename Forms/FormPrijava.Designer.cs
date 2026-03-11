namespace Connection.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLoginFooter = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pbLoginClose = new System.Windows.Forms.PictureBox();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.btnDonor = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lblBackground = new System.Windows.Forms.Label();
            this.cbBackground = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.panelLoginFooter.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginFooter
            // 
            this.panelLoginFooter.BackColor = System.Drawing.Color.Firebrick;
            this.panelLoginFooter.Controls.Add(this.lblAppName);
            resources.ApplyResources(this.panelLoginFooter, "panelLoginFooter");
            this.panelLoginFooter.Name = "panelLoginFooter";
            // 
            // lblAppName
            // 
            resources.ApplyResources(this.lblAppName, "lblAppName");
            this.lblAppName.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblAppName.Name = "lblAppName";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Firebrick;
            this.pnlLogin.Controls.Add(this.pbLoginClose);
            this.pnlLogin.Controls.Add(this.lblLoginHeader);
            resources.ApplyResources(this.pnlLogin, "pnlLogin");
            this.pnlLogin.Name = "pnlLogin";
            // 
            // pbLoginClose
            // 
            this.pbLoginClose.BackColor = System.Drawing.Color.OldLace;
            this.pbLoginClose.Image = global::Connection.Properties.Resources.icons8_close_48;
            resources.ApplyResources(this.pbLoginClose, "pbLoginClose");
            this.pbLoginClose.Name = "pbLoginClose";
            this.pbLoginClose.TabStop = false;
            this.pbLoginClose.Click += new System.EventHandler(this.pbDonorClose_Click);
            // 
            // lblLoginHeader
            // 
            resources.ApplyResources(this.lblLoginHeader, "lblLoginHeader");
            this.lblLoginHeader.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblLoginHeader.Name = "lblLoginHeader";
            // 
            // btnDonor
            // 
            this.btnDonor.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.btnDonor, "btnDonor");
            this.btnDonor.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.UseVisualStyleBackColor = false;
            this.btnDonor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.btnEmployee, "btnEmployee");
            this.btnEmployee.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtLoginPassword, "txtLoginPassword");
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginPassword
            // 
            resources.ApplyResources(this.lblLoginPassword, "lblLoginPassword");
            this.lblLoginPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLoginPassword.Name = "lblLoginPassword";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtLoginUsername, "txtLoginUsername");
            this.txtLoginUsername.Name = "txtLoginUsername";
            // 
            // lblLoginUserName
            // 
            resources.ApplyResources(this.lblLoginUserName, "lblLoginUserName");
            this.lblLoginUserName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLoginUserName.Name = "lblLoginUserName";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbLanguage
            // 
            resources.ApplyResources(this.lbLanguage, "lbLanguage");
            this.lbLanguage.ForeColor = System.Drawing.Color.Firebrick;
            this.lbLanguage.Name = "lbLanguage";
            // 
            // lblBackground
            // 
            resources.ApplyResources(this.lblBackground, "lblBackground");
            this.lblBackground.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBackground.Name = "lblBackground";
            // 
            // cbBackground
            // 
            this.cbBackground.FormattingEnabled = true;
            resources.ApplyResources(this.cbBackground, "cbBackground");
            this.cbBackground.Name = "cbBackground";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::Connection.Properties.Resources.Blood_Bank_logo_2022_03;
            resources.ApplyResources(this.pictureBoxLogin, "pictureBoxLogin");
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.TabStop = false;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.cbBackground);
            this.Controls.Add(this.lblBackground);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.lblLoginUserName);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnDonor);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.panelLoginFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLoginFooter.ResumeLayout(false);
            this.panelLoginFooter.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginFooter;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pbLoginClose;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button btnDonor;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.ComboBox cbBackground;
    }
}