namespace HMS
{
    partial class DoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            DocId = new TextBox();
            DocName = new TextBox();
            DocExp = new TextBox();
            DocPass = new TextBox();
            DoctorGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1354, 128);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1098, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 29);
            label5.TabIndex = 28;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(526, 66);
            label2.Name = "label2";
            label2.Size = new Size(173, 48);
            label2.TabIndex = 1;
            label2.Text = "DOCTOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(316, 10);
            label1.Name = "label1";
            label1.Size = new Size(617, 48);
            label1.TabIndex = 0;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // DocId
            // 
            DocId.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DocId.ForeColor = Color.SlateBlue;
            DocId.Location = new Point(44, 189);
            DocId.Name = "DocId";
            DocId.Size = new Size(293, 30);
            DocId.TabIndex = 2;
            DocId.Text = "DoctorId";
            DocId.TextChanged += textBox1_TextChanged;
            // 
            // DocName
            // 
            DocName.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DocName.ForeColor = Color.SlateBlue;
            DocName.Location = new Point(44, 259);
            DocName.Name = "DocName";
            DocName.Size = new Size(293, 30);
            DocName.TabIndex = 3;
            DocName.Text = "DoctorName";
            // 
            // DocExp
            // 
            DocExp.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DocExp.ForeColor = Color.SlateBlue;
            DocExp.Location = new Point(44, 328);
            DocExp.Name = "DocExp";
            DocExp.Size = new Size(293, 30);
            DocExp.TabIndex = 4;
            DocExp.Text = "YearOfExperience";
            // 
            // DocPass
            // 
            DocPass.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DocPass.ForeColor = Color.SlateBlue;
            DocPass.Location = new Point(44, 393);
            DocPass.Name = "DocPass";
            DocPass.Size = new Size(293, 30);
            DocPass.TabIndex = 5;
            DocPass.Text = "Password";
            // 
            // DoctorGV
            // 
            DoctorGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorGV.Location = new Point(512, 164);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.RowHeadersWidth = 51;
            DoctorGV.RowTemplate.Height = 29;
            DoctorGV.Size = new Size(545, 594);
            DoctorGV.TabIndex = 6;
            DoctorGV.CellContentClick += DoctorGV_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(27, 476);
            button1.Name = "button1";
            button1.Size = new Size(113, 39);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(171, 476);
            button2.Name = "button2";
            button2.Size = new Size(113, 39);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(317, 476);
            button3.Name = "button3";
            button3.Size = new Size(113, 39);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateBlue;
            button4.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(171, 552);
            button4.Name = "button4";
            button4.Size = new Size(113, 39);
            button4.TabIndex = 10;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateBlue;
            button5.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(27, 552);
            button5.Name = "button5";
            button5.Size = new Size(113, 39);
            button5.TabIndex = 19;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 794);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DoctorGV);
            Controls.Add(DocPass);
            Controls.Add(DocExp);
            Controls.Add(DocName);
            Controls.Add(DocId);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox DocId;
        private TextBox DocName;
        private TextBox DocExp;
        private TextBox DocPass;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView DoctorGV;
        private Label label5;
        private Button button5;
    }
}