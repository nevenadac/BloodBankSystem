namespace Connection.Forms
{
    partial class FormDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDonorHeader = new System.Windows.Forms.Panel();
            this.pbDonorClose = new System.Windows.Forms.PictureBox();
            this.lblMenageDonors = new System.Windows.Forms.Label();
            this.lblDonorJMB = new System.Windows.Forms.Label();
            this.txtDonorJMB = new System.Windows.Forms.TextBox();
            this.txtDonorFirstName = new System.Windows.Forms.TextBox();
            this.lblDonorFirstName = new System.Windows.Forms.Label();
            this.txtDonorLastName = new System.Windows.Forms.TextBox();
            this.lblDonorLastName = new System.Windows.Forms.Label();
            this.lblDonorGender = new System.Windows.Forms.Label();
            this.lblDonorBloodGroup = new System.Windows.Forms.Label();
            this.txtDonorContact = new System.Windows.Forms.TextBox();
            this.lblDonorContact = new System.Windows.Forms.Label();
            this.txtDonorAddress = new System.Windows.Forms.TextBox();
            this.lblDonorAddress = new System.Windows.Forms.Label();
            this.comboBoxDonorGender = new System.Windows.Forms.ComboBox();
            this.comboBoxDonorBloodGroup = new System.Windows.Forms.ComboBox();
            this.buttonDonorAdd = new System.Windows.Forms.Button();
            this.buttonDonorUpdate = new System.Windows.Forms.Button();
            this.buttonDonorDelete = new System.Windows.Forms.Button();
            this.buttonDonorClear = new System.Windows.Forms.Button();
            this.dgvDonor = new System.Windows.Forms.DataGridView();
            this.JMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDonorLoad = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panelDonorHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonorClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDonorHeader
            // 
            resources.ApplyResources(this.panelDonorHeader, "panelDonorHeader");
            this.panelDonorHeader.BackColor = System.Drawing.Color.Firebrick;
            this.panelDonorHeader.Controls.Add(this.pbDonorClose);
            this.panelDonorHeader.Controls.Add(this.lblMenageDonors);
            this.panelDonorHeader.Name = "panelDonorHeader";
            // 
            // pbDonorClose
            // 
            resources.ApplyResources(this.pbDonorClose, "pbDonorClose");
            this.pbDonorClose.BackColor = System.Drawing.Color.OldLace;
            this.pbDonorClose.Image = global::Connection.Properties.Resources.icons8_close_48;
            this.pbDonorClose.Name = "pbDonorClose";
            this.pbDonorClose.TabStop = false;
            this.pbDonorClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMenageDonors
            // 
            resources.ApplyResources(this.lblMenageDonors, "lblMenageDonors");
            this.lblMenageDonors.Name = "lblMenageDonors";
            // 
            // lblDonorJMB
            // 
            resources.ApplyResources(this.lblDonorJMB, "lblDonorJMB");
            this.lblDonorJMB.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonorJMB.Name = "lblDonorJMB";
            // 
            // txtDonorJMB
            // 
            resources.ApplyResources(this.txtDonorJMB, "txtDonorJMB");
            this.txtDonorJMB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonorJMB.Name = "txtDonorJMB";
            // 
            // txtDonorFirstName
            // 
            resources.ApplyResources(this.txtDonorFirstName, "txtDonorFirstName");
            this.txtDonorFirstName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonorFirstName.Name = "txtDonorFirstName";
            // 
            // lblDonorFirstName
            // 
            resources.ApplyResources(this.lblDonorFirstName, "lblDonorFirstName");
            this.lblDonorFirstName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonorFirstName.Name = "lblDonorFirstName";
            // 
            // txtDonorLastName
            // 
            resources.ApplyResources(this.txtDonorLastName, "txtDonorLastName");
            this.txtDonorLastName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonorLastName.Name = "txtDonorLastName";
            // 
            // lblDonorLastName
            // 
            resources.ApplyResources(this.lblDonorLastName, "lblDonorLastName");
            this.lblDonorLastName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonorLastName.Name = "lblDonorLastName";
            // 
            // lblDonorGender
            // 
            resources.ApplyResources(this.lblDonorGender, "lblDonorGender");
            this.lblDonorGender.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonorGender.Name = "lblDonorGender";
            // 
            // lblDonorBloodGroup
            // 
            resources.ApplyResources(this.lblDonorBloodGroup, "lblDonorBloodGroup");
            this.lblDonorBloodGroup.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonorBloodGroup.Name = "lblDonorBloodGroup";
            // 
            // txtDonorContact
            // 
            resources.ApplyResources(this.txtDonorContact, "txtDonorContact");
            this.txtDonorContact.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonorContact.Name = "txtDonorContact";
            // 
            // lblDonorContact
            // 
            resources.ApplyResources(this.lblDonorContact, "lblDonorContact");
            this.lblDonorContact.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonorContact.Name = "lblDonorContact";
            // 
            // txtDonorAddress
            // 
            resources.ApplyResources(this.txtDonorAddress, "txtDonorAddress");
            this.txtDonorAddress.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonorAddress.Name = "txtDonorAddress";
            // 
            // lblDonorAddress
            // 
            resources.ApplyResources(this.lblDonorAddress, "lblDonorAddress");
            this.lblDonorAddress.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonorAddress.Name = "lblDonorAddress";
            // 
            // comboBoxDonorGender
            // 
            resources.ApplyResources(this.comboBoxDonorGender, "comboBoxDonorGender");
            this.comboBoxDonorGender.FormattingEnabled = true;
            this.comboBoxDonorGender.Items.AddRange(new object[] {
            resources.GetString("comboBoxDonorGender.Items"),
            resources.GetString("comboBoxDonorGender.Items1")});
            this.comboBoxDonorGender.Name = "comboBoxDonorGender";
            // 
            // comboBoxDonorBloodGroup
            // 
            resources.ApplyResources(this.comboBoxDonorBloodGroup, "comboBoxDonorBloodGroup");
            this.comboBoxDonorBloodGroup.FormattingEnabled = true;
            this.comboBoxDonorBloodGroup.Items.AddRange(new object[] {
            resources.GetString("comboBoxDonorBloodGroup.Items"),
            resources.GetString("comboBoxDonorBloodGroup.Items1"),
            resources.GetString("comboBoxDonorBloodGroup.Items2"),
            resources.GetString("comboBoxDonorBloodGroup.Items3"),
            resources.GetString("comboBoxDonorBloodGroup.Items4"),
            resources.GetString("comboBoxDonorBloodGroup.Items5"),
            resources.GetString("comboBoxDonorBloodGroup.Items6"),
            resources.GetString("comboBoxDonorBloodGroup.Items7")});
            this.comboBoxDonorBloodGroup.Name = "comboBoxDonorBloodGroup";
            // 
            // buttonDonorAdd
            // 
            resources.ApplyResources(this.buttonDonorAdd, "buttonDonorAdd");
            this.buttonDonorAdd.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonorAdd.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonorAdd.Name = "buttonDonorAdd";
            this.buttonDonorAdd.UseVisualStyleBackColor = false;
            this.buttonDonorAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDonorUpdate
            // 
            resources.ApplyResources(this.buttonDonorUpdate, "buttonDonorUpdate");
            this.buttonDonorUpdate.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonorUpdate.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonorUpdate.Name = "buttonDonorUpdate";
            this.buttonDonorUpdate.UseVisualStyleBackColor = false;
            this.buttonDonorUpdate.Click += new System.EventHandler(this.buttonDonorUpdate_Click);
            // 
            // buttonDonorDelete
            // 
            resources.ApplyResources(this.buttonDonorDelete, "buttonDonorDelete");
            this.buttonDonorDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonorDelete.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonorDelete.Name = "buttonDonorDelete";
            this.buttonDonorDelete.UseVisualStyleBackColor = false;
            this.buttonDonorDelete.Click += new System.EventHandler(this.buttonDonorDelete_Click);
            // 
            // buttonDonorClear
            // 
            resources.ApplyResources(this.buttonDonorClear, "buttonDonorClear");
            this.buttonDonorClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonorClear.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonorClear.Name = "buttonDonorClear";
            this.buttonDonorClear.UseVisualStyleBackColor = false;
            this.buttonDonorClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dgvDonor
            // 
            resources.ApplyResources(this.dgvDonor, "dgvDonor");
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDonor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JMB,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.BloodGroup});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonor.Name = "dgvDonor";
            this.dgvDonor.RowTemplate.Height = 24;
            // 
            // JMB
            // 
            resources.ApplyResources(this.JMB, "JMB");
            this.JMB.Name = "JMB";
            // 
            // FirstName
            // 
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            // 
            // Gender
            // 
            resources.ApplyResources(this.Gender, "Gender");
            this.Gender.Name = "Gender";
            // 
            // BloodGroup
            // 
            resources.ApplyResources(this.BloodGroup, "BloodGroup");
            this.BloodGroup.Name = "BloodGroup";
            // 
            // buttonDonorLoad
            // 
            resources.ApplyResources(this.buttonDonorLoad, "buttonDonorLoad");
            this.buttonDonorLoad.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonorLoad.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonorLoad.Name = "buttonDonorLoad";
            this.buttonDonorLoad.UseVisualStyleBackColor = false;
            this.buttonDonorLoad.Click += new System.EventHandler(this.buttonDonorLoad_Click);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // lbPassword
            // 
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.lbPassword.Name = "lbPassword";
            // 
            // tbUserName
            // 
            resources.ApplyResources(this.tbUserName, "tbUserName");
            this.tbUserName.Name = "tbUserName";
            // 
            // lbUserName
            // 
            resources.ApplyResources(this.lbUserName, "lbUserName");
            this.lbUserName.ForeColor = System.Drawing.Color.Firebrick;
            this.lbUserName.Name = "lbUserName";
            // 
            // FormDonor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.buttonDonorLoad);
            this.Controls.Add(this.dgvDonor);
            this.Controls.Add(this.buttonDonorClear);
            this.Controls.Add(this.buttonDonorDelete);
            this.Controls.Add(this.buttonDonorUpdate);
            this.Controls.Add(this.buttonDonorAdd);
            this.Controls.Add(this.comboBoxDonorBloodGroup);
            this.Controls.Add(this.comboBoxDonorGender);
            this.Controls.Add(this.txtDonorAddress);
            this.Controls.Add(this.lblDonorAddress);
            this.Controls.Add(this.txtDonorContact);
            this.Controls.Add(this.lblDonorContact);
            this.Controls.Add(this.lblDonorBloodGroup);
            this.Controls.Add(this.lblDonorGender);
            this.Controls.Add(this.txtDonorLastName);
            this.Controls.Add(this.lblDonorLastName);
            this.Controls.Add(this.txtDonorFirstName);
            this.Controls.Add(this.lblDonorFirstName);
            this.Controls.Add(this.txtDonorJMB);
            this.Controls.Add(this.lblDonorJMB);
            this.Controls.Add(this.panelDonorHeader);
            this.ForeColor = System.Drawing.Color.PeachPuff;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonor";
            this.Load += new System.EventHandler(this.FormDonor_Load);
            this.panelDonorHeader.ResumeLayout(false);
            this.panelDonorHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonorClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDonorHeader;
        private System.Windows.Forms.Label lblMenageDonors;
        private System.Windows.Forms.Label lblDonorJMB;
        private System.Windows.Forms.TextBox txtDonorJMB;
        private System.Windows.Forms.TextBox txtDonorFirstName;
        private System.Windows.Forms.Label lblDonorFirstName;
        private System.Windows.Forms.TextBox txtDonorLastName;
        private System.Windows.Forms.Label lblDonorLastName;
        private System.Windows.Forms.Label lblDonorGender;
        private System.Windows.Forms.Label lblDonorBloodGroup;
        private System.Windows.Forms.TextBox txtDonorContact;
        private System.Windows.Forms.Label lblDonorContact;
        private System.Windows.Forms.TextBox txtDonorAddress;
        private System.Windows.Forms.Label lblDonorAddress;
        private System.Windows.Forms.ComboBox comboBoxDonorGender;
        private System.Windows.Forms.ComboBox comboBoxDonorBloodGroup;
        private System.Windows.Forms.Button buttonDonorAdd;
        private System.Windows.Forms.Button buttonDonorUpdate;
        private System.Windows.Forms.Button buttonDonorDelete;
        private System.Windows.Forms.Button buttonDonorClear;
        private System.Windows.Forms.DataGridView dgvDonor;
        private System.Windows.Forms.PictureBox pbDonorClose;
        private System.Windows.Forms.Button buttonDonorLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserName;
    }
}