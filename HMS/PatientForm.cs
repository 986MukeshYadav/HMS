using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace HMS
{
    public partial class PatientForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Sem_5th\.NET_\21SOECE11647_MUKESH KUMAR YADAV_HOSPITAL MANAGEMENT SYSTEM\HMS\HMS\HMSdb.mdf"";Integrated Security=True");

        public PatientForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (PatId.Text == "" || PatName.Text == "" || PatAd.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || MajorTb.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAd.Text + "','" + PatPhone.Text + "','" + PatAge.Text + "','" + GenderCb.SelectedItem.ToString() + "','" + BloodCb.SelectedItem.ToString() + "','" + MajorTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
                populate();
            }

        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (PatId.Text == "")
                MessageBox.Show("Enter The Patient Id");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId= " + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                PatId.Text = PatientGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
                PatName.Text = PatientGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                PatAd.Text = PatientGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                PatPhone.Text = PatientGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
                PatAge.Text = PatientGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                GenderCb.Text = PatientGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                BloodCb.Text = PatientGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                MajorTb.Text = PatientGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PatId.Text) || string.IsNullOrEmpty(PatName.Text) || string.IsNullOrEmpty(PatAd.Text) || string.IsNullOrEmpty(PatPhone.Text) || string.IsNullOrEmpty(PatAge.Text) || string.IsNullOrEmpty(MajorTb.Text))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE PatientTbl SET PatName = @PatName, PatAddress = @PatAd, PatPhone = @PatPhone, PatAge = @PatAge, PatGender = @PatGender, PatBlood = @PatBlood, PatDisease = @MajorTb WHERE PatId = @PatId";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                    cmd.Parameters.AddWithValue("@PatAd", PatAd.Text);
                    cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                    cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                    cmd.Parameters.AddWithValue("@PatGender", GenderCb.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@PatBlood", BloodCb.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@MajorTb", MajorTb.Text);
                    cmd.Parameters.AddWithValue("@PatId", PatId.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("No records were updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                }
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatId.Text = "";
            PatName.Text = "";
            PatAd.Text = "";
            PatPhone.Text = "";
            PatAge.Text = "";
            GenderCb.Text = "";
            BloodCb.Text = "";
            MajorTb.Text = "";
        }

        private void PatId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
