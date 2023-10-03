namespace HMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            button1 = new Button();
            DocNameTb = new TextBox();
            PassTb = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 99);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(768, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 29);
            label5.TabIndex = 28;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(336, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 48);
            label1.TabIndex = 0;
            label1.Text = "HMS";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(242, 345);
            button1.Name = "button1";
            button1.Size = new Size(316, 49);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DocNameTb
            // 
            DocNameTb.BorderStyle = BorderStyle.FixedSingle;
            DocNameTb.CausesValidation = false;
            DocNameTb.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DocNameTb.ForeColor = Color.SlateBlue;
            DocNameTb.Location = new Point(242, 178);
            DocNameTb.Name = "DocNameTb";
            DocNameTb.Size = new Size(316, 34);
            DocNameTb.TabIndex = 2;
            DocNameTb.Text = "DocName";
            DocNameTb.TextChanged += textBox1_TextChanged;
            // 
            // PassTb
            // 
            PassTb.BorderStyle = BorderStyle.FixedSingle;
            PassTb.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassTb.ForeColor = Color.SlateBlue;
            PassTb.Location = new Point(242, 249);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(316, 34);
            PassTb.TabIndex = 3;
            PassTb.Text = "DocPassword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(372, 431);
            label2.Name = "label2";
            label2.Size = new Size(65, 29);
            label2.TabIndex = 4;
            label2.Text = "Clear";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(label2);
            Controls.Add(PassTb);
            Controls.Add(DocNameTb);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox DocNameTb;
        private TextBox PassTb;
        private Label label2;
        private Label label5;
    }
}