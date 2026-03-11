using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using Connection.DAL;
using Connection.BLL;

namespace Connection.Forms
{

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        /*
        private void ComboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ThemeAccess.ApplyTheme(this, cbBackground.SelectedItem.ToString());
            
            ThemeManager.SetTheme(cbBackground.SelectedItem.ToString());
            ThemeManager.ApplyTheme(this);
        }
        */

        BLL.Login l = new BLL.Login();
        new LoginAccess dal = new LoginAccess();
        public void Clear()
        {
            txtLoginUsername.Text = "";
            txtLoginPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.userName = txtLoginUsername.Text;
            l.password = txtLoginPassword.Text;

            bool isSuccess = dal.loginCheck(l);

            if (isSuccess == true)
            {
                FormInfo forminfo = new FormInfo();
                forminfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed. Try again.");
            }
            Clear();
        }

        private void pbDonorClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string UserName = txtLoginUsername.Text;
            string Password = txtLoginPassword.Text;

            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                if (UserName == "Nevena" && Password == "student")
                {
                    try
                    {
                        FormPocetna pocetna1 = new FormPocetna();
                        pocetna1.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or password!");
                }
            }
            else
            {
                MessageBox.Show("Please enter your username and password!");
            }

            Clear();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            l.userName = txtLoginUsername.Text;
            l.password = txtLoginPassword.Text;

            bool isSuccess = dal.loginCheck(l);

            if(isSuccess==true)
            {
                FormEmployeeView employeeview = new FormEmployeeView();
                employeeview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed. Try again.");
            }
            Clear();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sr_Latn_BA");
                    break;

            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            /*
            cbBackground.Items.Add("Yellow");
            cbBackground.Items.Add("Black");
            cbBackground.Items.Add("Blue");

            cbBackground.SelectedIndex = 0;

            cbBackground.SelectedIndexChanged += ComboBoxThemes_SelectedIndexChanged;

            ThemeManager.ApplyTheme(this);
            */
        }
    }
}
