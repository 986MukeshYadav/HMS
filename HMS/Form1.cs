
using System.Data;
using System.Data.SqlClient;
namespace HMS
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Sem_5th\.NET_\21SOECE11647_MUKESH KUMAR YADAV_HOSPITAL MANAGEMENT SYSTEM\HMS\HMS\HMSdb.mdf"";Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DocNameTb.Text == "" || PassTb.Text == "")
                MessageBox.Show("Enter a UserName And Password");
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTbl where DocName='" + DocNameTb.Text + "' and DocPass ='" + PassTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }
                Con.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
