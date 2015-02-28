using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ValidationTest
{
    public partial class TestValidation : Form
    {
        //private StringBuilder errors;
        //private Regex validator;
        Validator validatit = new Validator();

        public static String MessageOut="";
        public TestValidation()
        {
            InitializeComponent();
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            string validator = @"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$";
            if (!validatit.TextValidator(txtFirstName, validator,20, "First Name", out MessageOut))
           {
                MessageBox.Show(MessageOut);
                txtFirstName.Focus();
                txtFirstName.SelectAll();
           }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            string lastnamevalid = @"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$";
            if (!validatit.TextValidator(txtLastName, lastnamevalid, 20, "Last Name", out MessageOut))
            {
                MessageBox.Show(MessageOut);
                txtLastName.Focus();
                txtLastName.SelectAll();
            }
        }

        private void ageTextBox_Leave(object sender, EventArgs e)
        {
            string age = @"^\d{1,2}$";
            if (!validatit.TextValidator(ageTextBox, age, 2, "Age", out MessageOut))
            {
                MessageBox.Show(MessageOut);
                ageTextBox.Focus();
                ageTextBox.SelectAll();
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            string email = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!validatit.TextValidator(EmailTextBox, email, 30, "Email", out MessageOut))
            {
                MessageBox.Show(MessageOut);
                EmailTextBox.Focus();
                EmailTextBox.SelectAll();
            }
        }

        private void genderTextBox_Leave(object sender, EventArgs e)
        {
            string gender = @"^([M|m]ale|[F|f]emale)$";
            if (!validatit.TextValidator(genderTextBox, gender, 8, "Gender", out MessageOut))
            {
                MessageBox.Show(MessageOut);
                genderTextBox.Focus();
                genderTextBox.SelectAll();
            }

        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            string address = @"^[0-9]+(\s[a-zA-Z]+)+$";
            if (!validatit.TextValidator(addressTextBox, address, 30, "Address", out MessageOut))
            {
                MessageBox.Show(MessageOut);
                addressTextBox.Focus();
                addressTextBox.SelectAll();
            }

        }

        private void zipCodeTextBox_Leave(object sender, EventArgs e)
        {
            string postalcode = @"^\d{5}$";
            if (!validatit.TextValidator(zipCodeTextBox, postalcode, 5, "Postal Code", out MessageOut))
            {
                MessageBox.Show(MessageOut);
                zipCodeTextBox.Focus();
                zipCodeTextBox.SelectAll();
            }

        }

    }
}
