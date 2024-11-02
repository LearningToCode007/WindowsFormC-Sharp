using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace MIS_WForm
{
    public partial class Student : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Student()
        {
           
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=BABLUSHAIKH\SQLEXPRESS;Initial Catalog=db_student;Integrated Security=True");
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            con.Open();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Cancel();
            txtstid.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtstid.Text.ToString())  && !string.IsNullOrEmpty(txtdeptName.Text.ToString()) && !string.IsNullOrEmpty(txtcollegeName.Text.ToString()))
            {

                cmd = new SqlCommand("StudentAction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@st_roll_no", txtstid.Text);
                cmd.Parameters.AddWithValue("@st_name", txtstName.Text.ToString());
                cmd.Parameters.AddWithValue("@st_email", txtstEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@st_phone_no", txtstphone.Text);
                cmd.Parameters.AddWithValue("@dept_name", txtdeptName.Text.ToString());
                cmd.Parameters.AddWithValue("@dept_strength", txtstrength.Text);
                cmd.Parameters.AddWithValue("@clg_name", txtcollegeName.Text.ToString());
                cmd.Parameters.AddWithValue("@clg_email", txtclgemail.Text.ToString());
                cmd.Parameters.AddWithValue("@clg_address", txtcollegeAddress.Text.ToString());
                cmd.Parameters.AddWithValue("@code", 'I');
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GET();
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cancel();
            txtstid.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtstid.Text != string.Empty)
            {
                txtstid.Enabled = false;
                cmd = new SqlCommand("StudentGet", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@st_roll_no", txtstid.Text);

                  dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtstName.Text = dr["st_name"].ToString();
                    txtstEmail.Text = dr["st_email"].ToString();
                    txtstphone.Text = dr["st_phone_no"].ToString();
                    txtstrength.Text = dr["dept_strength"].ToString();
                    txtdeptName.Text = dr["dept_name"].ToString();
                    txtclgemail.Text = dr["clg_email"].ToString();
                    txtcollegeAddress.Text = dr["clg_address"].ToString();
                    txtcollegeName.Text = dr["clg_name"].ToString();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnclear.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No record found with this ID", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Please enter Student ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cancel() {
            txtcollegeAddress.Text = "";
            txtcollegeName.Text = "";
            txtdeptName.Text = "";
            txtstrength.Text = "";
            txtstid.Text = "";
            txtstName.Text = "";
            txtstphone.Text = "";
            txtstEmail.Text = "";
            txtclgemail.Text = "";



        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtstid.Text.ToString()) && !string.IsNullOrEmpty(txtdeptName.Text.ToString()) && !string.IsNullOrEmpty(txtcollegeName.Text.ToString()))
            {

                cmd = new SqlCommand("StudentAction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@st_roll_no", txtstid.Text);
                cmd.Parameters.AddWithValue("@st_name", txtstName.Text.ToString());
                cmd.Parameters.AddWithValue("@st_email", txtstEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@st_phone_no", txtstphone.Text);
                cmd.Parameters.AddWithValue("@dept_name", txtdeptName.Text.ToString());
                cmd.Parameters.AddWithValue("@dept_strength", txtstrength.Text);
                cmd.Parameters.AddWithValue("@clg_name", txtcollegeName.Text.ToString());
                cmd.Parameters.AddWithValue("@clg_email", txtclgemail.Text.ToString());
                cmd.Parameters.AddWithValue("@clg_address", txtcollegeAddress.Text.ToString());
                cmd.Parameters.AddWithValue("@code", 'U');
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GET();
            }
            else
            {
                MessageBox.Show("Please enter valid details", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cancel();
            txtstid.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtstid.Text.ToString()) )
            {

                cmd = new SqlCommand("StudentAction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@st_roll_no", txtstid.Text);
                cmd.Parameters.AddWithValue("@code", 'D');
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Delete successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GET();
            }
            else
            {
                MessageBox.Show("Please enter Student ID", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cancel();
            txtstid.Enabled = true;
        }
        public void GET() {

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("StudentAllGet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtstphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtstrength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtstid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtcollegeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
