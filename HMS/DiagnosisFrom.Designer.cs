namespace HMS
{
    partial class DiagnosisFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisFrom));
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            DiagId = new TextBox();
            PatientIdCb = new ComboBox();
            PatientTb = new TextBox();
            SymptomsTb = new TextBox();
            DiagnosisTb = new TextBox();
            MedicineTb = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            label3 = new Label();
            diagsummary = new Panel();
            button1 = new Button();
            label10 = new Label();
            Diagnosislbl = new Label();
            medicineslbl = new Label();
            Symptomslbl = new Label();
            PatientNamelbl = new Label();
            label4 = new Label();
            DiagnosisGV = new DataGridView();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button6 = new Button();
            panel2.SuspendLayout();
            diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1354, 124);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1135, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 29);
            label5.TabIndex = 27;
            label5.Text = "X";
            label5.Click += label5_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(479, 57);
            label2.Name = "label2";
            label2.Size = new Size(216, 48);
            label2.TabIndex = 1;
            label2.Text = "DIAGNOSIS";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(617, 48);
            label1.TabIndex = 0;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DiagId
            // 
            DiagId.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DiagId.ForeColor = Color.SlateBlue;
            DiagId.Location = new Point(29, 180);
            DiagId.Name = "DiagId";
            DiagId.Size = new Size(203, 30);
            DiagId.TabIndex = 4;
            DiagId.Text = "DiagnosisId";
            // 
            // PatientIdCb
            // 
            PatientIdCb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatientIdCb.ForeColor = Color.SlateBlue;
            PatientIdCb.FormattingEnabled = true;
            PatientIdCb.Items.AddRange(new object[] { "Male", "Female" });
            PatientIdCb.Location = new Point(29, 233);
            PatientIdCb.Name = "PatientIdCb";
            PatientIdCb.Size = new Size(203, 30);
            PatientIdCb.TabIndex = 9;
            PatientIdCb.Text = "PatientId";
            PatientIdCb.SelectedIndexChanged += PatientIdTb_SelectedIndexChanged;
            PatientIdCb.SelectionChangeCommitted += PatientIdCb_SelectionChangeCommitted;
            // 
            // PatientTb
            // 
            PatientTb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PatientTb.ForeColor = Color.SlateBlue;
            PatientTb.Location = new Point(29, 289);
            PatientTb.Name = "PatientTb";
            PatientTb.Size = new Size(203, 30);
            PatientTb.TabIndex = 10;
            PatientTb.Text = "PatientName";
            // 
            // SymptomsTb
            // 
            SymptomsTb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SymptomsTb.ForeColor = Color.SlateBlue;
            SymptomsTb.Location = new Point(273, 180);
            SymptomsTb.Name = "SymptomsTb";
            SymptomsTb.Size = new Size(203, 30);
            SymptomsTb.TabIndex = 11;
            SymptomsTb.Text = "Symptoms";
            // 
            // DiagnosisTb
            // 
            DiagnosisTb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DiagnosisTb.ForeColor = Color.SlateBlue;
            DiagnosisTb.Location = new Point(273, 233);
            DiagnosisTb.Name = "DiagnosisTb";
            DiagnosisTb.Size = new Size(203, 30);
            DiagnosisTb.TabIndex = 12;
            DiagnosisTb.Text = "Diagnosis";
            DiagnosisTb.TextChanged += textBox4_TextChanged;
            // 
            // MedicineTb
            // 
            MedicineTb.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineTb.ForeColor = Color.SlateBlue;
            MedicineTb.Location = new Point(273, 289);
            MedicineTb.Name = "MedicineTb";
            MedicineTb.Size = new Size(210, 30);
            MedicineTb.TabIndex = 13;
            MedicineTb.Text = "Medicine";
            // 
            // button4
            // 
            button4.BackColor = Color.SlateBlue;
            button4.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(179, 438);
            button4.Name = "button4";
            button4.Size = new Size(113, 39);
            button4.TabIndex = 20;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(329, 359);
            button3.Name = "button3";
            button3.Size = new Size(113, 39);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(179, 359);
            button2.Name = "button2";
            button2.Size = new Size(113, 39);
            button2.TabIndex = 18;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateBlue;
            button5.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(29, 359);
            button5.Name = "button5";
            button5.Size = new Size(113, 39);
            button5.TabIndex = 17;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(438, 497);
            label3.Name = "label3";
            label3.Size = new Size(298, 48);
            label3.TabIndex = 22;
            label3.Text = "DIAGNOSIS LIST";
            // 
            // diagsummary
            // 
            diagsummary.Controls.Add(button1);
            diagsummary.Controls.Add(label10);
            diagsummary.Controls.Add(Diagnosislbl);
            diagsummary.Controls.Add(medicineslbl);
            diagsummary.Controls.Add(Symptomslbl);
            diagsummary.Controls.Add(PatientNamelbl);
            diagsummary.Controls.Add(label4);
            diagsummary.Location = new Point(500, 147);
            diagsummary.Name = "diagsummary";
            diagsummary.Size = new Size(652, 347);
            diagsummary.TabIndex = 24;
            diagsummary.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(276, 293);
            button1.Name = "button1";
            button1.Size = new Size(93, 41);
            button1.TabIndex = 26;
            button1.Text = "print";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.SlateBlue;
            label10.Location = new Point(172, 212);
            label10.Name = "label10";
            label10.Size = new Size(374, 29);
            label10.TabIndex = 8;
            label10.Text = "HOSPITALMANAGEMENTSYSTEM";
            label10.Click += label10_Click;
            // 
            // Diagnosislbl
            // 
            Diagnosislbl.AutoSize = true;
            Diagnosislbl.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Diagnosislbl.ForeColor = Color.SlateBlue;
            Diagnosislbl.Location = new Point(409, 63);
            Diagnosislbl.Name = "Diagnosislbl";
            Diagnosislbl.Size = new Size(105, 29);
            Diagnosislbl.TabIndex = 6;
            Diagnosislbl.Text = "Diagnosis";
            // 
            // medicineslbl
            // 
            medicineslbl.AutoSize = true;
            medicineslbl.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            medicineslbl.ForeColor = Color.SlateBlue;
            medicineslbl.Location = new Point(409, 132);
            medicineslbl.Name = "medicineslbl";
            medicineslbl.Size = new Size(111, 29);
            medicineslbl.TabIndex = 5;
            medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            Symptomslbl.AutoSize = true;
            Symptomslbl.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Symptomslbl.ForeColor = Color.SlateBlue;
            Symptomslbl.Location = new Point(93, 132);
            Symptomslbl.Name = "Symptomslbl";
            Symptomslbl.Size = new Size(116, 29);
            Symptomslbl.TabIndex = 4;
            Symptomslbl.Text = "Symptoms";
            // 
            // PatientNamelbl
            // 
            PatientNamelbl.AutoSize = true;
            PatientNamelbl.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PatientNamelbl.ForeColor = Color.SlateBlue;
            PatientNamelbl.Location = new Point(93, 63);
            PatientNamelbl.Name = "PatientNamelbl";
            PatientNamelbl.Size = new Size(143, 29);
            PatientNamelbl.TabIndex = 3;
            PatientNamelbl.Text = "PatientName";
            PatientNamelbl.Click += PatientNamelbl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateBlue;
            label4.Location = new Point(183, 10);
            label4.Name = "label4";
            label4.Size = new Size(257, 29);
            label4.TabIndex = 2;
            label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // DiagnosisGV
            // 
            DiagnosisGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DiagnosisGV.Location = new Point(212, 548);
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.RowHeadersWidth = 51;
            DiagnosisGV.RowTemplate.Height = 29;
            DiagnosisGV.Size = new Size(802, 212);
            DiagnosisGV.TabIndex = 25;
            DiagnosisGV.CellContentClick += DiagnosisGV_CellContentClick;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // button6
            // 
            button6.BackColor = Color.SlateBlue;
            button6.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.WhiteSmoke;
            button6.Location = new Point(29, 440);
            button6.Name = "button6";
            button6.Size = new Size(113, 39);
            button6.TabIndex = 26;
            button6.Text = "Reset";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // DiagnosisFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 781);
            Controls.Add(button6);
            Controls.Add(DiagnosisGV);
            Controls.Add(diagsummary);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(MedicineTb);
            Controls.Add(DiagnosisTb);
            Controls.Add(SymptomsTb);
            Controls.Add(PatientTb);
            Controls.Add(PatientIdCb);
            Controls.Add(DiagId);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiagnosisFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiagnosisFrom";
            Load += DiagnosisFrom_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            diagsummary.ResumeLayout(false);
            diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox DiagId;
        private ComboBox PatientIdCb;
        private TextBox PatientTb;
        private TextBox SymptomsTb;
        private TextBox DiagnosisTb;
        private TextBox MedicineTb;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Label label3;
        private Panel diagsummary;
        private Label label4;
        private Label label10;
        private Label Diagnosislbl;
        private Label medicineslbl;
        private Label Symptomslbl;
        private Label PatientNamelbl;
        private DataGridView DiagnosisGV;
        private Button button1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label5;
        private Button button6;
    }
}