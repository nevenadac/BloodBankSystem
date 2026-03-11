namespace Connection.Forms
{
    partial class FormDonations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonations));
            this.panelDonorHeader = new System.Windows.Forms.Panel();
            this.pbDonationsClose = new System.Windows.Forms.PictureBox();
            this.lblManageDonations = new System.Windows.Forms.Label();
            this.dgvDonations = new System.Windows.Forms.DataGridView();
            this.PintOfBlood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOdDonation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDonationClear = new System.Windows.Forms.Button();
            this.buttonDonationDelete = new System.Windows.Forms.Button();
            this.buttonDonationUpdate = new System.Windows.Forms.Button();
            this.buttonDonationAdd = new System.Windows.Forms.Button();
            this.txtDonationJMB = new System.Windows.Forms.TextBox();
            this.lblDonationJMB = new System.Windows.Forms.Label();
            this.txtDonationDate = new System.Windows.Forms.TextBox();
            this.lblDonationDate = new System.Windows.Forms.Label();
            this.txtDonationBlood = new System.Windows.Forms.TextBox();
            this.lblDonationBlood = new System.Windows.Forms.Label();
            this.buttonDonationsLoad = new System.Windows.Forms.Button();
            this.txtDonationID = new System.Windows.Forms.TextBox();
            this.lblDonationID = new System.Windows.Forms.Label();
            this.lbDeliveryID = new System.Windows.Forms.Label();
            this.tbDeliveryID = new System.Windows.Forms.TextBox();
            this.tbDonorsUserName = new System.Windows.Forms.TextBox();
            this.lbDonorsUserName = new System.Windows.Forms.Label();
            this.panelDonorHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonationsClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDonorHeader
            // 
            resources.ApplyResources(this.panelDonorHeader, "panelDonorHeader");
            this.panelDonorHeader.BackColor = System.Drawing.Color.Firebrick;
            this.panelDonorHeader.Controls.Add(this.pbDonationsClose);
            this.panelDonorHeader.Controls.Add(this.lblManageDonations);
            this.panelDonorHeader.Name = "panelDonorHeader";
            // 
            // pbDonationsClose
            // 
            resources.ApplyResources(this.pbDonationsClose, "pbDonationsClose");
            this.pbDonationsClose.BackColor = System.Drawing.Color.OldLace;
            this.pbDonationsClose.Image = global::Connection.Properties.Resources.icons8_close_48;
            this.pbDonationsClose.Name = "pbDonationsClose";
            this.pbDonationsClose.TabStop = false;
            this.pbDonationsClose.Click += new System.EventHandler(this.pbDonorClose_Click);
            // 
            // lblManageDonations
            // 
            resources.ApplyResources(this.lblManageDonations, "lblManageDonations");
            this.lblManageDonations.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblManageDonations.Name = "lblManageDonations";
            // 
            // dgvDonations
            // 
            resources.ApplyResources(this.dgvDonations, "dgvDonations");
            this.dgvDonations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PintOfBlood,
            this.DateOdDonation,
            this.UserName,
            this.JMB});
            this.dgvDonations.Name = "dgvDonations";
            this.dgvDonations.RowTemplate.Height = 24;
            // 
            // PintOfBlood
            // 
            resources.ApplyResources(this.PintOfBlood, "PintOfBlood");
            this.PintOfBlood.Name = "PintOfBlood";
            // 
            // DateOdDonation
            // 
            resources.ApplyResources(this.DateOdDonation, "DateOdDonation");
            this.DateOdDonation.Name = "DateOdDonation";
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.Name = "UserName";
            // 
            // JMB
            // 
            resources.ApplyResources(this.JMB, "JMB");
            this.JMB.Name = "JMB";
            // 
            // buttonDonationClear
            // 
            resources.ApplyResources(this.buttonDonationClear, "buttonDonationClear");
            this.buttonDonationClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonationClear.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonationClear.Name = "buttonDonationClear";
            this.buttonDonationClear.UseVisualStyleBackColor = false;
            this.buttonDonationClear.Click += new System.EventHandler(this.buttonDonationClear_Click);
            // 
            // buttonDonationDelete
            // 
            resources.ApplyResources(this.buttonDonationDelete, "buttonDonationDelete");
            this.buttonDonationDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonationDelete.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonationDelete.Name = "buttonDonationDelete";
            this.buttonDonationDelete.UseVisualStyleBackColor = false;
            this.buttonDonationDelete.Click += new System.EventHandler(this.buttonDonationDelete_Click);
            // 
            // buttonDonationUpdate
            // 
            resources.ApplyResources(this.buttonDonationUpdate, "buttonDonationUpdate");
            this.buttonDonationUpdate.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonationUpdate.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonationUpdate.Name = "buttonDonationUpdate";
            this.buttonDonationUpdate.UseVisualStyleBackColor = false;
            this.buttonDonationUpdate.Click += new System.EventHandler(this.buttonDonationUpdate_Click);
            // 
            // buttonDonationAdd
            // 
            resources.ApplyResources(this.buttonDonationAdd, "buttonDonationAdd");
            this.buttonDonationAdd.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonationAdd.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonationAdd.Name = "buttonDonationAdd";
            this.buttonDonationAdd.UseVisualStyleBackColor = false;
            this.buttonDonationAdd.Click += new System.EventHandler(this.buttonDonationAdd_Click);
            // 
            // txtDonationJMB
            // 
            resources.ApplyResources(this.txtDonationJMB, "txtDonationJMB");
            this.txtDonationJMB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonationJMB.Name = "txtDonationJMB";
            // 
            // lblDonationJMB
            // 
            resources.ApplyResources(this.lblDonationJMB, "lblDonationJMB");
            this.lblDonationJMB.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonationJMB.Name = "lblDonationJMB";
            // 
            // txtDonationDate
            // 
            resources.ApplyResources(this.txtDonationDate, "txtDonationDate");
            this.txtDonationDate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonationDate.Name = "txtDonationDate";
            // 
            // lblDonationDate
            // 
            resources.ApplyResources(this.lblDonationDate, "lblDonationDate");
            this.lblDonationDate.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonationDate.Name = "lblDonationDate";
            // 
            // txtDonationBlood
            // 
            resources.ApplyResources(this.txtDonationBlood, "txtDonationBlood");
            this.txtDonationBlood.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonationBlood.Name = "txtDonationBlood";
            // 
            // lblDonationBlood
            // 
            resources.ApplyResources(this.lblDonationBlood, "lblDonationBlood");
            this.lblDonationBlood.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonationBlood.Name = "lblDonationBlood";
            // 
            // buttonDonationsLoad
            // 
            resources.ApplyResources(this.buttonDonationsLoad, "buttonDonationsLoad");
            this.buttonDonationsLoad.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDonationsLoad.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonDonationsLoad.Name = "buttonDonationsLoad";
            this.buttonDonationsLoad.UseVisualStyleBackColor = false;
            this.buttonDonationsLoad.Click += new System.EventHandler(this.buttonDonationsLoad_Click);
            // 
            // txtDonationID
            // 
            resources.ApplyResources(this.txtDonationID, "txtDonationID");
            this.txtDonationID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDonationID.Name = "txtDonationID";
            // 
            // lblDonationID
            // 
            resources.ApplyResources(this.lblDonationID, "lblDonationID");
            this.lblDonationID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonationID.Name = "lblDonationID";
            // 
            // lbDeliveryID
            // 
            resources.ApplyResources(this.lbDeliveryID, "lbDeliveryID");
            this.lbDeliveryID.ForeColor = System.Drawing.Color.Firebrick;
            this.lbDeliveryID.Name = "lbDeliveryID";
            // 
            // tbDeliveryID
            // 
            resources.ApplyResources(this.tbDeliveryID, "tbDeliveryID");
            this.tbDeliveryID.Name = "tbDeliveryID";
            // 
            // tbDonorsUserName
            // 
            resources.ApplyResources(this.tbDonorsUserName, "tbDonorsUserName");
            this.tbDonorsUserName.Name = "tbDonorsUserName";
            // 
            // lbDonorsUserName
            // 
            resources.ApplyResources(this.lbDonorsUserName, "lbDonorsUserName");
            this.lbDonorsUserName.ForeColor = System.Drawing.Color.Firebrick;
            this.lbDonorsUserName.Name = "lbDonorsUserName";
            // 
            // FormDonations
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.lbDonorsUserName);
            this.Controls.Add(this.tbDonorsUserName);
            this.Controls.Add(this.tbDeliveryID);
            this.Controls.Add(this.lbDeliveryID);
            this.Controls.Add(this.lblDonationID);
            this.Controls.Add(this.txtDonationID);
            this.Controls.Add(this.buttonDonationsLoad);
            this.Controls.Add(this.dgvDonations);
            this.Controls.Add(this.buttonDonationClear);
            this.Controls.Add(this.buttonDonationDelete);
            this.Controls.Add(this.buttonDonationUpdate);
            this.Controls.Add(this.buttonDonationAdd);
            this.Controls.Add(this.txtDonationJMB);
            this.Controls.Add(this.lblDonationJMB);
            this.Controls.Add(this.txtDonationDate);
            this.Controls.Add(this.lblDonationDate);
            this.Controls.Add(this.txtDonationBlood);
            this.Controls.Add(this.lblDonationBlood);
            this.Controls.Add(this.panelDonorHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonations";
            this.Load += new System.EventHandler(this.FormDonations_Load);
            this.panelDonorHeader.ResumeLayout(false);
            this.panelDonorHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonationsClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDonorHeader;
        private System.Windows.Forms.PictureBox pbDonationsClose;
        private System.Windows.Forms.Label lblManageDonations;
        private System.Windows.Forms.DataGridView dgvDonations;
        private System.Windows.Forms.Button buttonDonationClear;
        private System.Windows.Forms.Button buttonDonationDelete;
        private System.Windows.Forms.Button buttonDonationUpdate;
        private System.Windows.Forms.Button buttonDonationAdd;
        private System.Windows.Forms.TextBox txtDonationJMB;
        private System.Windows.Forms.Label lblDonationJMB;
        private System.Windows.Forms.TextBox txtDonationDate;
        private System.Windows.Forms.Label lblDonationDate;
        private System.Windows.Forms.TextBox txtDonationBlood;
        private System.Windows.Forms.Label lblDonationBlood;
        private System.Windows.Forms.Button buttonDonationsLoad;
        private System.Windows.Forms.TextBox txtDonationID;
        private System.Windows.Forms.Label lblDonationID;
        private System.Windows.Forms.Label lbDeliveryID;
        private System.Windows.Forms.TextBox tbDeliveryID;
        private System.Windows.Forms.TextBox tbDonorsUserName;
        private System.Windows.Forms.Label lbDonorsUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PintOfBlood;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOdDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMB;
    }
}