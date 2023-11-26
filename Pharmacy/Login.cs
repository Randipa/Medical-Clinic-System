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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnPharmacyLogin_Click(object sender, EventArgs e)
        {
            PharmacyLogin plog = new PharmacyLogin();
            plog.Show();
            Hide();
        }

        private void btnMedecineLogin_Click(object sender, EventArgs e)
        {
            Medicine_DetailsLogin mlog = new Medicine_DetailsLogin();
            mlog.Show();
            Hide();
        }
    }
}
