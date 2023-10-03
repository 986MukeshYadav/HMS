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



namespace HMS
{
    public partial class DiagnosisFrom : Form
    {
        public DiagnosisFrom()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Sem_5th\.NET_\21SOECE11647_MUKESH KUMAR YADAV_HOSPITAL MANAGEMENT SYSTEM\HMS\HMS\HMSdb.mdf"";Integrated Security=True");
        void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        string patname;
        void fetchpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId = " + PatientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientTb.Text = patname;
            }
            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || MedicineTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || MedicineTb.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTbl values('" + DiagId.Text + "','" + PatientIdCb.SelectedValue.ToString() + "','" + PatientTb.Text + "','" + SymptomsTb.Text + "','" + DiagnosisTb.Text + "','" + MedicineTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void PatientIdTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiagnosisFrom_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
            {
                MessageBox.Show("Enter The Diagnosis Id");
            }
            else
            {
                Con.Open();
                string query = "UPDATE DiagnosisTbl SET PatId = '" + PatientIdCb.SelectedValue.ToString() + "', PatName = '" + PatientTb.Text + "', Symptoms = '" + SymptomsTb.Text + "', Diagnosis = '" + DiagnosisTb.Text + "', Medicines = '" + MedicineTb.Text + "' WHERE DiagId = '" + DiagId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully updated");
                Con.Close();
                populate();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (DiagId.Text == "")
                MessageBox.Show("Enter The Diagnosis Id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId= " + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DiagId.Text = DiagnosisGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
                PatientIdCb.SelectedValue = DiagnosisGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                PatientTb.Text = DiagnosisGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                SymptomsTb.Text = DiagnosisGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
                DiagnosisTb.Text = DiagnosisGV.Rows[e.RowIndex].Cells[4].Value?.ToString();
                MedicineTb.Text = DiagnosisGV.Rows[e.RowIndex].Cells[5].Value?.ToString();
                PatientNamelbl.Text = DiagnosisGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                Diagnosislbl.Text = DiagnosisGV.Rows[e.RowIndex].Cells[4].Value?.ToString();
                Symptomslbl.Text = DiagnosisGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
                medicineslbl.Text = DiagnosisGV.Rows[e.RowIndex].Cells[5].Value?.ToString();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(PatientNamelbl.Text + "\n" + Diagnosislbl.Text + "\n" + Symptomslbl.Text + "\n" + medicineslbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130, 150));
            e.Graphics.DrawString(label10.Text , new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(230, 500));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {

                printPreviewDialog1.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DiagId.Text = "";
            PatientIdCb.Text = "";
            PatientTb.Text = "";
            SymptomsTb.Text = "";
            DiagnosisTb.Text = "";
            MedicineTb.Text = "";
        }

        private void PatientNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
