using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace channelCenter
{
    public partial class Doctor : Form
    {
        SqlConnection con = null;
        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input values
                if (string.IsNullOrWhiteSpace(txtPatientID.Text) || string.IsNullOrWhiteSpace(txtMedicine.Text) || string.IsNullOrWhiteSpace(txtSpecialNote.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

               

                SqlCommand cmd = new SqlCommand("UPDATE Patient_Details SET Medicine=@val7 ,SpecialNote = @val8 WHERE Patient_ID = @val1", con);
                cmd.Parameters.AddWithValue("@val1", txtPatientID.Text);
                cmd.Parameters.AddWithValue("@val2", txtPatientName.Text);
                cmd.Parameters.AddWithValue("@val3", txtAge.Text);
                cmd.Parameters.AddWithValue("@val7", txtMedicine.Text);
                cmd.Parameters.AddWithValue("@val8", txtSpecialNote.Text);
                

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
                        txtMedicine.Text = rdr["Medicine"].ToString();
                        txtSpecialNote.Text = rdr["SpecialNote"].ToString();
                        
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtAge.Clear();
            txtMedicine.Clear();
            txtSpecialNote.Clear();
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
