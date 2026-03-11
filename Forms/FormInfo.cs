using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection.BLL;
using Connection.DAL;
using MySql.Data.MySqlClient;

namespace Connection.Forms
{
    public partial class FormInfo : Form
    {
        public FormInfo()
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

        DonorAccess dal = new DonorAccess();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            allDonorCount();
        }
        public void allDonorCount()
        {
            lblApositiveNum.Text = dal.countDonors("A+");
            lblAnegativeNum.Text = dal.countDonors("A-");
            lblBpositiveNum.Text = dal.countDonors("B+");
            lblBnegativeNum.Text = dal.countDonors("B-");
            lblABpositiveNum.Text = dal.countDonors("AB+");
            lblABnegativeNum.Text = dal.countDonors("AB-");
            lbl0positiveNum.Text = dal.countDonors("0+");
            lbl0negativeNum.Text = dal.countDonors("0-");
        }
    }
}
