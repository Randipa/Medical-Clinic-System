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

   
    public partial class Pharmacy : Form
    {
        SqlConnection con = null;
        public Pharmacy()
        {
            InitializeComponent();
        }
        private void Pharmacy_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-ECV9KQG\\SQLEXPRESS;Initial Catalog=Patient_Details;Integrated Security=True";
            con = new SqlConnection(constring);

            con.Open();
            fillDataGridView();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMID.Text = row.Cells[0].Value.ToString();
                txtMName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();


            }


        }

        public void fillDataGridView()
        {
            try
            {
                String SqlQuery = "SELECT * FROM Medicine_Details";
                SqlDataAdapter adapter = new SqlDataAdapter(SqlQuery, con);
                DataSet ds= new DataSet();
                adapter.Fill(ds, "Medicine_Details");
                dataGridView1.DataSource= ds;
                dataGridView1.DataMember = "Medicine_Details";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void metroTextBox1_Click(object sender, EventArgs e)
        { 
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

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           try
            { 
                {
                    string sqlQuery = "SELECT * FROM Medicine_Details WHERE mName LIKE @searchText";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + textBox1.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Medicine_Details");

                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "Medicine_Details";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMedicine_Click(object sender, EventArgs e)
        {

        }

        private void txtSpecialNote_Click(object sender, EventArgs e)
        {

        }
    }
}
