namespace Connection.Forms
{
    partial class FormEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEmployeeHeader = new System.Windows.Forms.Panel();
            this.pbEmployeesClose = new System.Windows.Forms.PictureBox();
            this.lblManageEmployees = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.buttonEmployeeClear = new System.Windows.Forms.Button();
            this.buttonEmployeeDelete = new System.Windows.Forms.Button();
            this.buttonEmployeeUpdate = new System.Windows.Forms.Button();
            this.buttonEmployeeAdd = new System.Windows.Forms.Button();
            this.comboBoxEmployeeRole = new System.Windows.Forms.ComboBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.lblEmployeeAddress = new System.Windows.Forms.Label();
            this.txtEmployeeContact = new System.Windows.Forms.TextBox();
            this.lblEmployeeContact = new System.Windows.Forms.Label();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeJMB = new System.Windows.Forms.TextBox();
            this.lblEmployeeJMB = new System.Windows.Forms.Label();
            this.buttonEmployeeLoad = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.JMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEmployeeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeesClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployeeHeader
            // 
            this.panelEmployeeHeader.BackColor = System.Drawing.Color.Firebrick;
            this.panelEmployeeHeader.Controls.Add(this.pbEmployeesClose);
            this.panelEmployeeHeader.Controls.Add(this.lblManageEmployees);
            resources.ApplyResources(this.panelEmployeeHeader, "panelEmployeeHeader");
            this.panelEmployeeHeader.Name = "panelEmployeeHeader";
            // 
            // pbEmployeesClose
            // 
            this.pbEmployeesClose.BackColor = System.Drawing.Color.OldLace;
            this.pbEmployeesClose.Image = global::Connection.Properties.Resources.icons8_close_48;
            resources.ApplyResources(this.pbEmployeesClose, "pbEmployeesClose");
            this.pbEmployeesClose.Name = "pbEmployeesClose";
            this.pbEmployeesClose.TabStop = false;
            this.pbEmployeesClose.Click += new System.EventHandler(this.pbDonorClose_Click);
            // 
            // lblManageEmployees
            // 
            resources.ApplyResources(this.lblManageEmployees, "lblManageEmployees");
            this.lblManageEmployees.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblManageEmployees.Name = "lblManageEmployees";
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JMB,
            this.FirstName,
            this.LastName,
            this.Role});
            resources.ApplyResources(this.dgvEmployees, "dgvEmployees");
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.Height = 24;
            // 
            // buttonEmployeeClear
            // 
            this.buttonEmployeeClear.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.buttonEmployeeClear, "buttonEmployeeClear");
            this.buttonEmployeeClear.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonEmployeeClear.Name = "buttonEmployeeClear";
            this.buttonEmployeeClear.UseVisualStyleBackColor = false;
            this.buttonEmployeeClear.Click += new System.EventHandler(this.buttonEmployeeClear_Click);
            // 
            // buttonEmployeeDelete
            // 
            this.buttonEmployeeDelete.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.buttonEmployeeDelete, "buttonEmployeeDelete");
            this.buttonEmployeeDelete.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonEmployeeDelete.Name = "buttonEmployeeDelete";
            this.buttonEmployeeDelete.UseVisualStyleBackColor = false;
            this.buttonEmployeeDelete.Click += new System.EventHandler(this.buttonEmployeeDelete_Click);
            // 
            // buttonEmployeeUpdate
            // 
            this.buttonEmployeeUpdate.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.buttonEmployeeUpdate, "buttonEmployeeUpdate");
            this.buttonEmployeeUpdate.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonEmployeeUpdate.Name = "buttonEmployeeUpdate";
            this.buttonEmployeeUpdate.UseVisualStyleBackColor = false;
            this.buttonEmployeeUpdate.Click += new System.EventHandler(this.buttonEmployeeUpdate_Click);
            // 
            // buttonEmployeeAdd
            // 
            this.buttonEmployeeAdd.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.buttonEmployeeAdd, "buttonEmployeeAdd");
            this.buttonEmployeeAdd.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
            this.buttonEmployeeAdd.UseVisualStyleBackColor = false;
            this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonEmployeeAdd_Click);
            // 
            // comboBoxEmployeeRole
            // 
            resources.ApplyResources(this.comboBoxEmployeeRole, "comboBoxEmployeeRole");
            this.comboBoxEmployeeRole.FormattingEnabled = true;
            this.comboBoxEmployeeRole.Items.AddRange(new object[] {
            resources.GetString("comboBoxEmployeeRole.Items"),
            resources.GetString("comboBoxEmployeeRole.Items1"),
            resources.GetString("comboBoxEmployeeRole.Items2")});
            this.comboBoxEmployeeRole.Name = "comboBoxEmployeeRole";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtEmployeeAddress, "txtEmployeeAddress");
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            // 
            // lblEmployeeAddress
            // 
            resources.ApplyResources(this.lblEmployeeAddress, "lblEmployeeAddress");
            this.lblEmployeeAddress.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            // 
            // txtEmployeeContact
            // 
            this.txtEmployeeContact.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtEmployeeContact, "txtEmployeeContact");
            this.txtEmployeeContact.Name = "txtEmployeeContact";
            // 
            // lblEmployeeContact
            // 
            resources.ApplyResources(this.lblEmployeeContact, "lblEmployeeContact");
            this.lblEmployeeContact.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmployeeContact.Name = "lblEmployeeContact";
            // 
            // lblEmployeeRole
            // 
            resources.ApplyResources(this.lblEmployeeRole, "lblEmployeeRole");
            this.lblEmployeeRole.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtEmployeeLastName, "txtEmployeeLastName");
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            // 
            // lblEmployeeLastName
            // 
            resources.ApplyResources(this.lblEmployeeLastName, "lblEmployeeLastName");
            this.lblEmployeeLastName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtEmployeeFirstName, "txtEmployeeFirstName");
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            // 
            // lblEmployeeFirstName
            // 
            resources.ApplyResources(this.lblEmployeeFirstName, "lblEmployeeFirstName");
            this.lblEmployeeFirstName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            // 
            // txtEmployeeJMB
            // 
            this.txtEmployeeJMB.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtEmployeeJMB, "txtEmployeeJMB");
            this.txtEmployeeJMB.Name = "txtEmployeeJMB";
            // 
            // lblEmployeeJMB
            // 
            resources.ApplyResources(this.lblEmployeeJMB, "lblEmployeeJMB");
            this.lblEmployeeJMB.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEmployeeJMB.Name = "lblEmployeeJMB";
            // 
            // buttonEmployeeLoad
            // 
            this.buttonEmployeeLoad.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.buttonEmployeeLoad, "buttonEmployeeLoad");
            this.buttonEmployeeLoad.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonEmployeeLoad.Name = "buttonEmployeeLoad";
            this.buttonEmployeeLoad.UseVisualStyleBackColor = false;
            this.buttonEmployeeLoad.Click += new System.EventHandler(this.buttonEmployeeLoad_Click);
            // 
            // lbUserName
            // 
            resources.ApplyResources(this.lbUserName, "lbUserName");
            this.lbUserName.ForeColor = System.Drawing.Color.Firebrick;
            this.lbUserName.Name = "lbUserName";
            // 
            // tbUserName
            // 
            resources.ApplyResources(this.tbUserName, "tbUserName");
            this.tbUserName.Name = "tbUserName";
            // 
            // lbPassword
            // 
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.lbPassword.Name = "lbPassword";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
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
            // Role
            // 
            resources.ApplyResources(this.Role, "Role");
            this.Role.Name = "Role";
            // 
            // FormEmployees
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.buttonEmployeeLoad);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.buttonEmployeeClear);
            this.Controls.Add(this.buttonEmployeeDelete);
            this.Controls.Add(this.buttonEmployeeUpdate);
            this.Controls.Add(this.buttonEmployeeAdd);
            this.Controls.Add(this.comboBoxEmployeeRole);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.lblEmployeeAddress);
            this.Controls.Add(this.txtEmployeeContact);
            this.Controls.Add(this.lblEmployeeContact);
            this.Controls.Add(this.lblEmployeeRole);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.txtEmployeeFirstName);
            this.Controls.Add(this.lblEmployeeFirstName);
            this.Controls.Add(this.txtEmployeeJMB);
            this.Controls.Add(this.lblEmployeeJMB);
            this.Controls.Add(this.panelEmployeeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployees";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            this.panelEmployeeHeader.ResumeLayout(false);
            this.panelEmployeeHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeesClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployeeHeader;
        private System.Windows.Forms.PictureBox pbEmployeesClose;
        private System.Windows.Forms.Label lblManageEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button buttonEmployeeClear;
        private System.Windows.Forms.Button buttonEmployeeDelete;
        private System.Windows.Forms.Button buttonEmployeeUpdate;
        private System.Windows.Forms.Button buttonEmployeeAdd;
        private System.Windows.Forms.ComboBox comboBoxEmployeeRole;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.Label lblEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeContact;
        private System.Windows.Forms.Label lblEmployeeContact;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeJMB;
        private System.Windows.Forms.Label lblEmployeeJMB;
        private System.Windows.Forms.Button buttonEmployeeLoad;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}