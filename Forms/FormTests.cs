using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection.DAL;
using Connection.BLL;

namespace Connection.Forms
{
    public partial class FormTests : Form
    {
        public FormTests()
        {
            InitializeComponent();

            /*
            ThemeManager.ApplyTheme(this);

            ThemeManager.ThemeChanged += OnThemeChanged;
            */
        }
        /*
        private void OnThemeChanged()
        {
            ThemeManager.ApplyTheme(this);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ThemeManager.ThemeChanged -= OnThemeChanged;
            base.OnFormClosed(e);
        }
        */
        public void Clear()
        {
            txtTestID.Text = "";
            txtTestDate.Text = "";
            txtTestDonationID.Text = "";
            txtTestJMB.Text = "";
            txtTestResult.Text = "";
            txtTypeID.Text = "";
            tbUsername.Text = "";
        }

        private void pbDonorClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void buttonTestClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonTestLoad_Click(object sender, EventArgs e)
        {
            dgvTests.Rows.Clear();
            foreach (Test test in TestAccess.getTest())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = test
                };
                row.CreateCells(dgvTests, test.TypeOfTestID.Description, test.TestResult, test.DateOfTest, test.DonationID.DonationID, test.Employee_Person_JMB.Person_JMB.JMB);
                dgvTests.Rows.Add(row);
            }
        }

        private void buttonTestAdd_Click(object sender, EventArgs e)
        {
            string testID = txtTestID.Text;
            string testResult = txtTestResult.Text;
            string DateOfTest = txtTestDate.Text;
            string DonationID = txtTestDonationID.Text;
            string type = txtTypeID.Text;
            string userName = tbUsername.Text;
            string JMB = txtTestJMB.Text;

            if (!string.IsNullOrEmpty(testID) && !string.IsNullOrEmpty(DateOfTest) && !string.IsNullOrEmpty(JMB)
                && !string.IsNullOrEmpty(DonationID) && !string.IsNullOrEmpty(testResult) && !string.IsNullOrEmpty(type)
                && !string.IsNullOrEmpty(userName))
            {
                int testId = int.Parse(testID);
                DateTime date = DateTime.Parse(DateOfTest);
                int donationID = int.Parse(DonationID);
                int typeID = int.Parse(type);
                TestAccess.insertTest(testId, date, JMB, userName, donationID, testResult, typeID);
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
            Clear();
        }

        private void buttonTestUpdate_Click(object sender, EventArgs e)
        {
            string testID = txtTestID.Text;
            string testResult = txtTestResult.Text;
            string DateOfTest = txtTestDate.Text;
            string DonationID = txtTestDonationID.Text;
            string type = txtTypeID.Text;
            string userName = tbUsername.Text;
            string JMB = txtTestJMB.Text;

            if (!string.IsNullOrEmpty(testID) && !string.IsNullOrEmpty(DateOfTest) && !string.IsNullOrEmpty(JMB)
                && !string.IsNullOrEmpty(DonationID) && !string.IsNullOrEmpty(testResult) && !string.IsNullOrEmpty(type)
                && !string.IsNullOrEmpty(userName))
            {
                int testId = int.Parse(testID);
                DateTime date = DateTime.Parse(DateOfTest);
                int donationID = int.Parse(DonationID);
                int typeID = int.Parse(type);
                TestAccess.updateTest(testId, date, JMB, userName, donationID, testResult, typeID);
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
            Clear();
        }


        private void buttonTestDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deletion is not supported by the database");
        }

        private void FormTests_Load(object sender, EventArgs e)
        {

        }
    }
}
