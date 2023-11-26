using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class PharmacyLogin : Form
    {
        public PharmacyLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;


            if (ValidateLogin(enteredUsername, enteredPassword))
            {

                Pharmacy pha = new Pharmacy();
                pha.Show();
                Hide();
            }
            else
            {

                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool ValidateLogin(string username, string password)
        {

            string correctUsername = "pharmacy";
            string correctPassword = "123";


            return (username == correctUsername && password == correctPassword);
        }
    }
}
