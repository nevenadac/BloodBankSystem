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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
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
        private void Clear()
        {
            txtEmployeeAddress.Text = "";
            txtEmployeeContact.Text = "";
            txtEmployeeFirstName.Text = "";
            txtEmployeeJMB.Text = "";
            txtEmployeeLastName.Text = "";
            comboBoxEmployeeRole.Text = "";
            tbUserName.Text = "";
            tbPassword.Text = "";
        }

        private void pbDonorClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonEmployeeClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            string JMB = txtEmployeeJMB.Text;
            string firstName = txtEmployeeFirstName.Text;
            string lastName = txtEmployeeLastName.Text;
            string address = txtEmployeeAddress.Text;
            string contact = txtEmployeeContact.Text;
            string role = comboBoxEmployeeRole.Text;
            string userName = tbUserName.Text;
            string password = tbPassword.Text;

            if (!string.IsNullOrEmpty(JMB) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(contact) && !string.IsNullOrEmpty(role) && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                EmployeeAccess.insertEmployee(JMB, firstName, lastName, address, contact, role, userName, password);
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
        }

        private void buttonEmployeeLoad_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();
            foreach (Employee employee in EmployeeAccess.getEmployee())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = employee
                };
                row.CreateCells(dgvEmployees, employee.Person_JMB.JMB, employee.Person_JMB.FirstName, employee.Person_JMB.LastName, employee.Role);
                dgvEmployees.Rows.Add(row);
            }
        }

        private void buttonEmployeeUpdate_Click(object sender, EventArgs e)
        {
            string JMB = txtEmployeeJMB.Text;
            string firstName = txtEmployeeFirstName.Text;
            string lastName = txtEmployeeLastName.Text;
            string address = txtEmployeeAddress.Text;
            string contact = txtEmployeeContact.Text;
            string role = comboBoxEmployeeRole.Text;

            if (!string.IsNullOrEmpty(JMB) && !string.IsNullOrEmpty(role))
            {
                EmployeeAccess.updateEmployee(JMB, role);
            }
            else
            {
                MessageBox.Show("Please enter all of the information!");
            }
        }

        private void buttonEmployeeDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deletion is not supported by the database");
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
