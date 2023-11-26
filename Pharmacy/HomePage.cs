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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
