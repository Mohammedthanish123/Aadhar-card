using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdhaarCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtName.Text == "") {
            //    MessageBox.Show("err val");
            //    return;
            //}

            //if (txtName.Text.Trim() == String.Empty)
            //{
            //    MessageBox.Show("err val");
            //    return;
            //}

            txtName.BackColor = Color.White;
            txtAdhaar.BackColor = Color.White;

            if (txtName.Text.Trim().Length == 0)
            {
                txtName.BackColor = Color.Red;
                txtName.Focus();
                return;
            }

            if (txtAdhaar.Text.Length != 14)
            {
                txtAdhaar.BackColor = Color.Red;
                txtAdhaar.Focus();
                return;
            }
            PersonDetail personDetail = new PersonDetail();
            personDetail.PersonName = txtName.Text;
            personDetail.AdhaarNumber = txtAdhaar.Text;
            personDetail.DateOfBirth = dtpDateOfBirth.Value;

            bool result = personDetail.Save();

            if (result == true)
            {
                MessageBox.Show("Adhar registered successfully !!");
                txtName.Text = string.Empty;
                txtAdhaar.Text = string.Empty;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
