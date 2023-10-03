using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 H = new Form1();
            H.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show(); ;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm patientForm = new PatientForm();
            patientForm.Show(); ;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DiagnosisFrom H = new DiagnosisFrom();
            H.Show();
            this.Hide();
        }

        private void label5_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
