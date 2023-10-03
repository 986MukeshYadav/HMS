namespace HMS
{
    partial class PatientForm
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
            PatId = new TextBox();
            PatName = new TextBox();
            PatAd = new TextBox();
            PatPhone = new TextBox();
            PatAge = new TextBox();
            GenderCb = new ComboBox();
            BloodCb = new ComboBox();
            MajorTb = new TextBox();
            PatientGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            label3 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1354, 124);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1260, 0);
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
            label2.Location = new Point(511, 67);
            label2.Name = "label2";
            label2.Size = new Size(174, 48);
            label2.TabIndex = 1;
            label2.Text = "PATIENT";
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
            // 
            // PatId
            // 
            PatId.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatId.ForeColor = Color.SlateBlue;
            PatId.Location = new Point(22, 181);
            PatId.Name = "PatId";
            PatId.Size = new Size(293, 30);
            PatId.TabIndex = 3;
            PatId.Text = "PatientId";
            PatId.TextChanged += PatId_TextChanged;
            // 
            // PatName
            // 
            PatName.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatName.ForeColor = Color.SlateBlue;
            PatName.Location = new Point(22, 236);
            PatName.Name = "PatName";
            PatName.Size = new Size(293, 30);
            PatName.TabIndex = 4;
            PatName.Text = "PatientName";
            // 
            // PatAd
            // 
            PatAd.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatAd.ForeColor = Color.SlateBlue;
            PatAd.Location = new Point(22, 284);
            PatAd.Name = "PatAd";
            PatAd.Size = new Size(293, 30);
            PatAd.TabIndex = 5;
            PatAd.Text = "PatientAddress";
            // 
            // PatPhone
            // 
            PatPhone.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatPhone.ForeColor = Color.SlateBlue;
            PatPhone.Location = new Point(22, 337);
            PatPhone.Name = "PatPhone";
            PatPhone.Size = new Size(293, 30);
            PatPhone.TabIndex = 6;
            PatPhone.Text = "PatientPhone";
            // 
            // PatAge
            // 
            PatAge.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatAge.ForeColor = Color.SlateBlue;
            PatAge.Location = new Point(22, 387);
            PatAge.Name = "PatAge";
            PatAge.Size = new Size(293, 30);
            PatAge.TabIndex = 7;
            PatAge.Text = "PatientAge";
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCb.ForeColor = Color.SlateBlue;
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(22, 438);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(293, 30);
            GenderCb.TabIndex = 8;
            GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            BloodCb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BloodCb.ForeColor = Color.SlateBlue;
            BloodCb.FormattingEnabled = true;
            BloodCb.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            BloodCb.Location = new Point(22, 484);
            BloodCb.Name = "BloodCb";
            BloodCb.Size = new Size(293, 30);
            BloodCb.TabIndex = 9;
            BloodCb.Text = "BloodGroup";
            BloodCb.SelectedIndexChanged += GenderCb_SelectedIndexChanged;
            // 
            // MajorTb
            // 
            MajorTb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MajorTb.ForeColor = Color.SlateBlue;
            MajorTb.Location = new Point(22, 537);
            MajorTb.Name = "MajorTb";
            MajorTb.Size = new Size(293, 30);
            MajorTb.TabIndex = 10;
            MajorTb.Text = "MajorDisease";
            // 
            // PatientGV
            // 
            PatientGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGV.Location = new Point(346, 194);
            PatientGV.Name = "PatientGV";
            PatientGV.RowHeadersWidth = 51;
            PatientGV.RowTemplate.Height = 29;
            PatientGV.Size = new Size(945, 560);
            PatientGV.TabIndex = 11;
            PatientGV.CellContentClick += PatientGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateBlue;
            button4.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(125, 669);
            button4.Name = "button4";
            button4.Size = new Size(93, 39);
            button4.TabIndex = 16;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(239, 606);
            button3.Name = "button3";
            button3.Size = new Size(85, 39);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(125, 606);
            button2.Name = "button2";
            button2.Size = new Size(93, 39);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateBlue;
            button5.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(12, 606);
            button5.Name = "button5";
            button5.Size = new Size(97, 39);
            button5.TabIndex = 13;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(662, 143);
            label3.Name = "label3";
            label3.Size = new Size(274, 48);
            label3.TabIndex = 17;
            label3.Text = "PATIENTS LIST";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(16, 669);
            button1.Name = "button1";
            button1.Size = new Size(93, 39);
            button1.TabIndex = 18;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 781);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(PatientGV);
            Controls.Add(MajorTb);
            Controls.Add(BloodCb);
            Controls.Add(GenderCb);
            Controls.Add(PatAge);
            Controls.Add(PatPhone);
            Controls.Add(PatAd);
            Controls.Add(PatName);
            Controls.Add(PatId);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            Load += PatientForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox PatId;
        private TextBox PatName;
        private TextBox PatAd;
        private TextBox PatPhone;
        private TextBox PatAge;
        private ComboBox GenderCb;
        private ComboBox BloodCb;
        private TextBox MajorTb;
        private DataGridView PatientGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Label label3;
        private Label label5;
        private Button button1;
    }
}