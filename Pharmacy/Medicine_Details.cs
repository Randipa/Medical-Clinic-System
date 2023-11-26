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

namespace Pharmacy
{
    public partial class Medicine_Details : Form
    {
        SqlConnection con = null;
        public Medicine_Details()
        {
            InitializeComponent();
           
        }

        private void lblPatientID_Click(object sender, EventArgs e)
        {

        }

        private bool IsMIDAlreadyExists(string mID)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Medicine_Details WHERE mID = @mID", con))
            {
                cmd.Parameters.AddWithValue("@mID", mID);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void fillDataGridView()
        {
            try
            {
               
                String SqlQuery = "SELECT * FROM Medicine_Details";
                SqlDataAdapter adapter = new SqlDataAdapter(SqlQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Medicine_Details");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Medicine_Details";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input values
                if (string.IsNullOrWhiteSpace(txtMID.Text) || string.IsNullOrWhiteSpace(txtMName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check for duplicate mID
                if (IsMIDAlreadyExists(txtMID.Text))
                {
                    MessageBox.Show("mID already exists. Please use a different mID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate mPrice as a double
                if (!double.TryParse(txtPrice.Text, out double mPrice))
                {
                    MessageBox.Show("Invalid mPrice. Please enter a valid numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Medicine_Details (mID, mName,mPrice) VALUES (@val1, @val2, @val3)", con);
                cmd.Parameters.AddWithValue("@val1", txtMID.Text);
                cmd.Parameters.AddWithValue("@val2", txtMName.Text);
                cmd.Parameters.AddWithValue("@val3", txtPrice.Text);
                

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Data sent!!");
                    fillDataGridView();
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

                    SqlCommand cmd = new SqlCommand("SELECT * FROM  Medicine_Details WHERE mID = @val1", con);
                    cmd.Parameters.AddWithValue("@val1", txtMID.Text);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        txtMID.Text = rdr["mID"].ToString();
                        txtMName.Text = rdr["mName"].ToString();
                        txtPrice.Text = rdr["mPrice"].ToString();
                       
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

                SqlCommand cmd = new SqlCommand("UPDATE Medicine_Details SET mName=@val2, mPrice=@val3  WHERE mID = @val1", con);
                cmd.Parameters.AddWithValue("@val1", txtMID.Text);
                cmd.Parameters.AddWithValue("@val2", txtMName.Text);
                cmd.Parameters.AddWithValue("@val3", txtPrice.Text);
                

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Data Update!!");
                    fillDataGridView();
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
            txtMID.Clear();
            txtMName.Clear();
            txtPrice.Clear();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Medicine_Details WHERE mID = @val1", con);
                cmd.Parameters.AddWithValue("@val1", txtMID.Text);
                cmd.Parameters.AddWithValue("@val2", txtMName.Text);
                cmd.Parameters.AddWithValue("@val3", txtPrice.Text);
                

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Data Delete!!");
                    fillDataGridView();
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

        private void Medicine_Details_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-ECV9KQG\\SQLEXPRESS;Initial Catalog=Patient_Details;Integrated Security=True";
            con = new SqlConnection(constring);
            
            con.Open();
            fillDataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 ) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMID.Text = row.Cells[0].Value.ToString();
                txtMName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();


            }


        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                if (row.Cells[2].Value != null && decimal.TryParse(row.Cells[2].Value.ToString(), out decimal price))
                {
                    total += price;
                }
            }

            MessageBox.Show($"Total Medicine Price Rs.: {total.ToString("C")}");
        }

        private void txtMID_Click(object sender, EventArgs e)
        {

        }
    }
}
