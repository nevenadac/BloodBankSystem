namespace Connection.Forms
{
    partial class FormTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTests));
            this.panelTestsHeader = new System.Windows.Forms.Panel();
            this.pbTestsClose = new System.Windows.Forms.PictureBox();
            this.lblManageTests = new System.Windows.Forms.Label();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person_JMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTestClear = new System.Windows.Forms.Button();
            this.buttonTestDelete = new System.Windows.Forms.Button();
            this.buttonTestUpdate = new System.Windows.Forms.Button();
            this.buttonTestAdd = new System.Windows.Forms.Button();
            this.lblTestDonationID = new System.Windows.Forms.Label();
            this.txtTestJMB = new System.Windows.Forms.TextBox();
            this.lblTestJMB = new System.Windows.Forms.Label();
            this.txtTestDate = new System.Windows.Forms.TextBox();
            this.lblTestDate = new System.Windows.Forms.Label();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.lblTestID = new System.Windows.Forms.Label();
            this.txtTestResult = new System.Windows.Forms.TextBox();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.txtTestDonationID = new System.Windows.Forms.TextBox();
            this.buttonTestLoad = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.lvlTypeID = new System.Windows.Forms.Label();
            this.lbEmployeeUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panelTestsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestsClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTestsHeader
            // 
            resources.ApplyResources(this.panelTestsHeader, "panelTestsHeader");
            this.panelTestsHeader.BackColor = System.Drawing.Color.Firebrick;
            this.panelTestsHeader.Controls.Add(this.pbTestsClose);
            this.panelTestsHeader.Controls.Add(this.lblManageTests);
            this.panelTestsHeader.Name = "panelTestsHeader";
            // 
            // pbTestsClose
            // 
            resources.ApplyResources(this.pbTestsClose, "pbTestsClose");
            this.pbTestsClose.BackColor = System.Drawing.Color.OldLace;
            this.pbTestsClose.Image = global::Connection.Properties.Resources.icons8_close_48;
            this.pbTestsClose.Name = "pbTestsClose";
            this.pbTestsClose.TabStop = false;
            this.pbTestsClose.Click += new System.EventHandler(this.pbDonorClose_Click);
            // 
            // lblManageTests
            // 
            resources.ApplyResources(this.lblManageTests, "lblManageTests");
            this.lblManageTests.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblManageTests.Name = "lblManageTests";
            // 
            // dgvTests
            // 
            resources.ApplyResources(this.dgvTests, "dgvTests");
            this.dgvTests.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.TestResult,
            this.DateOfTest,
            this.DonationID,
            this.Person_JMB});
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.RowTemplate.Height = 24;
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.Name = "Description";
            // 
            // TestResult
            // 
            resources.ApplyResources(this.TestResult, "TestResult");
            this.TestResult.Name = "TestResult";
            // 
            // DateOfTest
            // 
            resources.ApplyResources(this.DateOfTest, "DateOfTest");
            this.DateOfTest.Name = "DateOfTest";
            // 
            // DonationID
            // 
            resources.ApplyResources(this.DonationID, "DonationID");
            this.DonationID.Name = "DonationID";
            // 
            // Person_JMB
            // 
            resources.ApplyResources(this.Person_JMB, "Person_JMB");
            this.Person_JMB.Name = "Person_JMB";
            // 
            // buttonTestClear
            // 
            resources.ApplyResources(this.buttonTestClear, "buttonTestClear");
            this.buttonTestClear.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTestClear.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonTestClear.Name = "buttonTestClear";
            this.buttonTestClear.UseVisualStyleBackColor = false;
            this.buttonTestClear.Click += new System.EventHandler(this.buttonTestClear_Click);
            // 
            // buttonTestDelete
            // 
            resources.ApplyResources(this.buttonTestDelete, "buttonTestDelete");
            this.buttonTestDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTestDelete.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonTestDelete.Name = "buttonTestDelete";
            this.buttonTestDelete.UseVisualStyleBackColor = false;
            this.buttonTestDelete.Click += new System.EventHandler(this.buttonTestDelete_Click);
            // 
            // buttonTestUpdate
            // 
            resources.ApplyResources(this.buttonTestUpdate, "buttonTestUpdate");
            this.buttonTestUpdate.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTestUpdate.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonTestUpdate.Name = "buttonTestUpdate";
            this.buttonTestUpdate.UseVisualStyleBackColor = false;
            this.buttonTestUpdate.Click += new System.EventHandler(this.buttonTestUpdate_Click);
            // 
            // buttonTestAdd
            // 
            resources.ApplyResources(this.buttonTestAdd, "buttonTestAdd");
            this.buttonTestAdd.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTestAdd.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonTestAdd.Name = "buttonTestAdd";
            this.buttonTestAdd.UseVisualStyleBackColor = false;
            this.buttonTestAdd.Click += new System.EventHandler(this.buttonTestAdd_Click);
            // 
            // lblTestDonationID
            // 
            resources.ApplyResources(this.lblTestDonationID, "lblTestDonationID");
            this.lblTestDonationID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTestDonationID.Name = "lblTestDonationID";
            // 
            // txtTestJMB
            // 
            resources.ApplyResources(this.txtTestJMB, "txtTestJMB");
            this.txtTestJMB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTestJMB.Name = "txtTestJMB";
            // 
            // lblTestJMB
            // 
            resources.ApplyResources(this.lblTestJMB, "lblTestJMB");
            this.lblTestJMB.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTestJMB.Name = "lblTestJMB";
            // 
            // txtTestDate
            // 
            resources.ApplyResources(this.txtTestDate, "txtTestDate");
            this.txtTestDate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTestDate.Name = "txtTestDate";
            // 
            // lblTestDate
            // 
            resources.ApplyResources(this.lblTestDate, "lblTestDate");
            this.lblTestDate.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTestDate.Name = "lblTestDate";
            // 
            // txtTestID
            // 
            resources.ApplyResources(this.txtTestID, "txtTestID");
            this.txtTestID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTestID.Name = "txtTestID";
            // 
            // lblTestID
            // 
            resources.ApplyResources(this.lblTestID, "lblTestID");
            this.lblTestID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTestID.Name = "lblTestID";
            // 
            // txtTestResult
            // 
            resources.ApplyResources(this.txtTestResult, "txtTestResult");
            this.txtTestResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTestResult.Name = "txtTestResult";
            // 
            // lblTestResult
            // 
            resources.ApplyResources(this.lblTestResult, "lblTestResult");
            this.lblTestResult.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTestResult.Name = "lblTestResult";
            // 
            // txtTestDonationID
            // 
            resources.ApplyResources(this.txtTestDonationID, "txtTestDonationID");
            this.txtTestDonationID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTestDonationID.Name = "txtTestDonationID";
            // 
            // buttonTestLoad
            // 
            resources.ApplyResources(this.buttonTestLoad, "buttonTestLoad");
            this.buttonTestLoad.BackColor = System.Drawing.Color.Firebrick;
            this.buttonTestLoad.ForeColor = System.Drawing.Color.PeachPuff;
            this.buttonTestLoad.Name = "buttonTestLoad";
            this.buttonTestLoad.UseVisualStyleBackColor = false;
            this.buttonTestLoad.Click += new System.EventHandler(this.buttonTestLoad_Click);
            // 
            // txtTypeID
            // 
            resources.ApplyResources(this.txtTypeID, "txtTypeID");
            this.txtTypeID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTypeID.Name = "txtTypeID";
            // 
            // lvlTypeID
            // 
            resources.ApplyResources(this.lvlTypeID, "lvlTypeID");
            this.lvlTypeID.ForeColor = System.Drawing.Color.Firebrick;
            this.lvlTypeID.Name = "lvlTypeID";
            // 
            // lbEmployeeUsername
            // 
            resources.ApplyResources(this.lbEmployeeUsername, "lbEmployeeUsername");
            this.lbEmployeeUsername.ForeColor = System.Drawing.Color.Firebrick;
            this.lbEmployeeUsername.Name = "lbEmployeeUsername";
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.Name = "tbUsername";
            // 
            // FormTests
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbEmployeeUsername);
            this.Controls.Add(this.lvlTypeID);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.buttonTestLoad);
            this.Controls.Add(this.txtTestDonationID);
            this.Controls.Add(this.txtTestResult);
            this.Controls.Add(this.lblTestResult);
            this.Controls.Add(this.dgvTests);
            this.Controls.Add(this.buttonTestClear);
            this.Controls.Add(this.buttonTestDelete);
            this.Controls.Add(this.buttonTestUpdate);
            this.Controls.Add(this.buttonTestAdd);
            this.Controls.Add(this.lblTestDonationID);
            this.Controls.Add(this.txtTestJMB);
            this.Controls.Add(this.lblTestJMB);
            this.Controls.Add(this.txtTestDate);
            this.Controls.Add(this.lblTestDate);
            this.Controls.Add(this.txtTestID);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.panelTestsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTests";
            this.Load += new System.EventHandler(this.FormTests_Load);
            this.panelTestsHeader.ResumeLayout(false);
            this.panelTestsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestsClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTestsHeader;
        private System.Windows.Forms.PictureBox pbTestsClose;
        private System.Windows.Forms.Label lblManageTests;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Button buttonTestClear;
        private System.Windows.Forms.Button buttonTestDelete;
        private System.Windows.Forms.Button buttonTestUpdate;
        private System.Windows.Forms.Button buttonTestAdd;
        private System.Windows.Forms.Label lblTestDonationID;
        private System.Windows.Forms.TextBox txtTestJMB;
        private System.Windows.Forms.Label lblTestJMB;
        private System.Windows.Forms.TextBox txtTestDate;
        private System.Windows.Forms.Label lblTestDate;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.TextBox txtTestResult;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.TextBox txtTestDonationID;
        private System.Windows.Forms.Button buttonTestLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person_JMB;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label lvlTypeID;
        private System.Windows.Forms.Label lbEmployeeUsername;
        private System.Windows.Forms.TextBox tbUsername;
    }
}