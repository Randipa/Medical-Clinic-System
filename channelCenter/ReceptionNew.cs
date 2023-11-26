using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace channelCenter
{
    public partial class ReceptionNew : Form
    {
        SqlConnection con = null;
        double doctor_charge;
        public ReceptionNew()
        {
            InitializeComponent();
        }

        private void ReceptionNew_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-ECV9KQG\\SQLEXPRESS;Initial Catalog=Patient_Details;Integrated Security=True";
            con = new SqlConnection(constring);
            con.Open();
        }

        // Check if Patient_ID already exists in the database
        private bool IsPatientIDAlreadyExists(string patientID)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Patient_Details WHERE Patient_ID = @patientID", con))
            {
                cmd.Parameters.AddWithValue("@patientID", patientID);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            
            string phonePattern = @"^\d{10}$"; 
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        private bool ValidateEmail(string email)
        {
            
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidatePhoneNumber(txtPhoneNO.Text))
                {
                    MessageBox.Show("Invalid phone number. Please enter a 10-digit number.");
                    return;
                }

                if (!ValidateEmail(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email address. Please enter a valid email.");
                    return;
                }

                // Validate input values
                if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtPatientName.Text) || string.IsNullOrWhiteSpace(txtAge.Text)
                    || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtPhoneNO.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Don't proceed if any field is empty
                }

                // Check for duplicate Patient_ID
                if (IsPatientIDAlreadyExists(txtPatientID.Text))
                {
                    MessageBox.Show("Patient_ID already exists. Please use a different Patient_ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                SqlCommand cmd = new SqlCommand("INSERT INTO Patient_Details (Patient_Name, Patient_ID, Age, Address, Phone_NO, Email) VALUES (@val2, @val1, @val3, @val4, @val5, @val6)", con);
                cmd.Parameters.AddWithValue("@val1", txtPatientID.Text);
                cmd.Parameters.AddWithValue("@val2", txtPatientName.Text);
                cmd.Parameters.AddWithValue("@val3", txtAge.Text);
                cmd.Parameters.AddWithValue("@val4", txtAddress.Text);
                cmd.Parameters.AddWithValue("@val5", txtPhoneNO.Text);
                cmd.Parameters.AddWithValue("@val6", txtEmail.Text);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Data sent!!");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


     

        private void btnView_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM  Patient_Details WHERE Patient_ID = @val1", con);
                    cmd.Parameters.AddWithValue("@val1", txtPatientID.Text);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        txtPatientName.Text = rdr["Patient_Name"].ToString();
                        txtAge.Text = rdr["Age"].ToString();
                        txtAddress.Text = rdr["Address"].ToString();
                        txtPhoneNO.Text = rdr["Phone_NO"].ToString();
                        txtEmail.Text = rdr["Email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong!!");
                    }
                    rdr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("UPDATE Patient_Details SET Patient_Name=@val2 , Age=@val3 , Address=@val4,Phone_No=@val5,Email=@val6 WHERE Patient_ID = @val1", con);
                cmd.Parameters.AddWithValue("@val1", txtPatientID.Text);
                cmd.Parameters.AddWithValue("@val2", txtPatientName.Text);
                cmd.Parameters.AddWithValue("@val3", txtAge.Text);
                cmd.Parameters.AddWithValue("@val4", txtAddress.Text);
                cmd.Parameters.AddWithValue("@val5", txtPhoneNO.Text);
                cmd.Parameters.AddWithValue("@val6", txtEmail.Text);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Data Update!!");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtPhoneNO.Clear();
            txtEmail.Clear();
            cmbDoctors.Items.Clear();
            txtDoctorCharge.Clear();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDoctors.Text == "VP - Mr.Manjula")
                {
                    doctor_charge = 1500.00;
                }
                else if (cmbDoctors.Text == "VOG - Mrs.Kumari")
                {
                    doctor_charge = 1800.00;
                }
                else if (cmbDoctors.Text == "Cardiologist - Mr.Janaka")
                {
                    doctor_charge = 2000.00;
                }
                else if (cmbDoctors.Text == "Surgeon - Mr.Thennakoon")
                {
                    doctor_charge = 2200.00;
                }
                else if (cmbDoctors.Text == "Neurologist - Mrs.Kanthi")
                {
                    doctor_charge = 2500.00;
                }
                else if (cmbDoctors.Text == "Dermatologist -Mr.Mahendra")
                {
                    doctor_charge = 2800.00;
                }
                else if (cmbDoctors.Text == "ENT - Mrs. Damayanthi")
                {
                    doctor_charge = 3000.00;
                }
                else
                {
                    MessageBox.Show("Please select a value!");
                }
                txtDoctorCharge.Text = doctor_charge.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Patient_Details WHERE Patient_ID = @val1", con);
                cmd.Parameters.AddWithValue("@val1", txtPatientID.Text);
                cmd.Parameters.AddWithValue("@val2", txtPatientName.Text);
                cmd.Parameters.AddWithValue("@val3", txtAge.Text);
                cmd.Parameters.AddWithValue("@val4", txtAddress.Text);
                cmd.Parameters.AddWithValue("@val5", txtPhoneNO.Text);
                cmd.Parameters.AddWithValue("@val6", txtEmail.Text);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Data Delete!!");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtPatientName_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNO_Click(object sender, EventArgs e)
        {
           
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
