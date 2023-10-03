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

namespace HMS
{
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Sem_5th\.NET_\21SOECE11647_MUKESH KUMAR YADAV_HOSPITAL MANAGEMENT SYSTEM\HMS\HMS\HMSdb.mdf"";Integrated Security=True");
        public DoctorForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DocId.Text == "" || DocName.Text == "" || DocExp.Text == "" || DocPass.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "insert into doctorTbl values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Enter The Doctor Id");
            else
            {
                Con.Open();
                string query = "delete from DoctorTbl where DocId= " + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DocId.Text = DoctorGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
                DocName.Text = DoctorGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                DocExp.Text = DoctorGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                DocPass.Text = DoctorGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorTbl set DocName = '" + DocName.Text + "', DocExp = '" + DocExp.Text + "', DocPass = '" + DocPass.Text + "' where DocId = '" + DocId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Sucessfully updated");
            Con.Close();
            populate();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DocId.Text = "";
            DocName.Text = "";
            DocExp.Text = "";
            DocPass.Text = "";
        }
    }
}
