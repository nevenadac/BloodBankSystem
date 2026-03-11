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
    public partial class FormDonor : Form
    {
        public FormDonor()
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
            txtDonorJMB.Text = "";
            txtDonorFirstName.Text = "";
            txtDonorLastName.Text = "";
            txtDonorAddress.Text = "";
            txtDonorContact.Text = "";
            comboBoxDonorBloodGroup.Text = "";
            comboBoxDonorGender.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string JMB = txtDonorJMB.Text;
            string firstName = txtDonorFirstName.Text;
            string lastName = txtDonorLastName.Text;
            string address = txtDonorAddress.Text;
            string contact = txtDonorContact.Text;
            string gender = comboBoxDonorGender.Text;
            string bloodGroup = comboBoxDonorBloodGroup.Text;
            string userName = tbUserName.Text;
            string password = tbPassword.Text;

            if (!string.IsNullOrEmpty(JMB) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(contact) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(bloodGroup)
                && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password)) 
            {
                DonorAccess.insertDonor(JMB, firstName, lastName, address, contact, gender, bloodGroup, userName);
                // AccountAccess.insertAccount(userName, password, );
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
        }

        private void buttonDonorLoad_Click(object sender, EventArgs e)
        {
            dgvDonor.Rows.Clear();
            foreach (Donor donor in DonorAccess.getDonor())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = donor
                };
                row.CreateCells(dgvDonor, donor.Person_JMB.JMB, donor.Person_JMB.FirstName, donor.Person_JMB.LastName, donor.Gender, donor.BloodGroup);
                dgvDonor.Rows.Add(row);
            }
        }

        private void buttonDonorUpdate_Click(object sender, EventArgs e)
        {
            string JMB = txtDonorJMB.Text;
            string firstName = txtDonorFirstName.Text;
            string lastName = txtDonorLastName.Text;
            string address = txtDonorAddress.Text;
            string contact = txtDonorContact.Text;
            string gender = comboBoxDonorGender.Text;
            string bloodGroup = comboBoxDonorBloodGroup.Text;
            string userName = tbUserName.Text;
            string password = tbPassword.Text;

            if (!string.IsNullOrEmpty(JMB) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(bloodGroup) && !string.IsNullOrEmpty(userName))
            {
                DonorAccess.updateDonor(JMB, gender, bloodGroup, userName);
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
        }

        private void buttonDonorDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deletion is not supported by the database");
        }

        private void FormDonor_Load(object sender, EventArgs e)
        {

        }
    }
}
