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
    public partial class FormDonations : Form
    {
        public FormDonations()
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
            txtDonationID.Text = "";
            txtDonationBlood.Text = "";
            txtDonationDate.Text = "";
            txtDonationJMB.Text = "";
            tbDonorsUserName.Text = "";
            tbDeliveryID.Text = "";
        }


        private void pbDonorClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonDonationClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDonationsLoad_Click(object sender, EventArgs e)
        {
            dgvDonations.Rows.Clear();
            foreach (Donation donation in DonationAccess.getDonation())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = donation
                };
                row.CreateCells(dgvDonations, donation.PintOfBlood, donation.DateOfDonation, donation.Donor_Account_UserName.Account_UserName.UserName, donation.Donor_Person_JMB.Person_JMB.JMB);
                dgvDonations.Rows.Add(row);
            }
        }

        private void buttonDonationAdd_Click(object sender, EventArgs e)
        {
            string DonationID = txtDonationID.Text;
            string PintOfBlood = txtDonationBlood.Text;
            string DateOfDonation = txtDonationDate.Text;
            string DeliveryID = tbDeliveryID.Text;
            string DonorUserName = tbDonorsUserName.Text;
            string DonorJMB = txtDonationJMB.Text;

            if (!string.IsNullOrEmpty(DonationID) && !string.IsNullOrEmpty(PintOfBlood) && !string.IsNullOrEmpty(DateOfDonation) 
                && !string.IsNullOrEmpty(DonorJMB) && !string.IsNullOrEmpty(DonorUserName) && !string.IsNullOrEmpty(DeliveryID))
            {
                int id = int.Parse(DonationID);
                decimal quantity = decimal.Parse(PintOfBlood);
                DateTime date = DateTime.Parse(DateOfDonation);
                int delId = int.Parse(DeliveryID);
                DonationAccess.insertDonation(id, quantity, date, delId, DonorJMB, DonorUserName);
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
            Clear();
        }

        private void buttonDonationUpdate_Click(object sender, EventArgs e)
        {
            string DonationID = txtDonationID.Text;
            string PintOfBlood = txtDonationBlood.Text;
            string DateOfDonation = txtDonationDate.Text;
            string DeliveryID = tbDeliveryID.Text;
            string DonorJMB = txtDonationJMB.Text;
            string DonorUserName = tbDonorsUserName.Text;

            if (!string.IsNullOrEmpty(DonationID) && !string.IsNullOrEmpty(PintOfBlood) && !string.IsNullOrEmpty(DateOfDonation)
                && !string.IsNullOrEmpty(DonorJMB) && !string.IsNullOrEmpty(DonorUserName) && !string.IsNullOrEmpty(DeliveryID))
            {
                int id = int.Parse(DonationID);
                decimal quantity = decimal.Parse(PintOfBlood);
                DateTime date = DateTime.Parse(DateOfDonation);
                int delId = int.Parse(DeliveryID);
                DonationAccess.updateDonation(id, quantity, date, delId, DonorJMB, DonorUserName);
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
            Clear();
        }

        private void buttonDonationDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deletion is not supported by the database");
        }

        private void FormDonations_Load(object sender, EventArgs e)
        {

        }
    }
}
