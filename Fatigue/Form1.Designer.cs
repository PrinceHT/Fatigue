namespace Fatigue
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
            dtgExcel = new DataGridView();
            label1 = new Label();
            cBoxSN = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtm1 = new TextBox();
            txtlogad1 = new TextBox();
            txtm2 = new TextBox();
            txtlogad2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgExcel).BeginInit();
            SuspendLayout();
            // 
            // dtgExcel
            // 
            dtgExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgExcel.Location = new Point(482, 12);
            dtgExcel.Name = "dtgExcel";
            dtgExcel.RowTemplate.Height = 25;
            dtgExcel.Size = new Size(934, 626);
            dtgExcel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "S-N Curves";
            // 
            // cBoxSN
            // 
            cBoxSN.FormattingEnabled = true;
            cBoxSN.Location = new Point(258, 33);
            cBoxSN.Name = "cBoxSN";
            cBoxSN.Size = new Size(121, 23);
            cBoxSN.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 3;
            label2.Text = "Nominal Stress Range (MPA)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 4;
            label3.Text = "Weibull shape parameter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 5;
            label4.Text = "Cycles at knee in S-N curve N1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 173);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 6;
            label5.Text = "m1 (N=<N1 cycles)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 207);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 7;
            label6.Text = "logad1 (N=<N1 cycles)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 278);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 9;
            label7.Text = "logad2 (N>N1 cycles)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 244);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 8;
            label8.Text = "m2 (N>N1 cycles)";
            // 
            // txtm1
            // 
            txtm1.Enabled = false;
            txtm1.Location = new Point(258, 170);
            txtm1.Name = "txtm1";
            txtm1.Size = new Size(100, 23);
            txtm1.TabIndex = 10;
            // 
            // txtlogad1
            // 
            txtlogad1.Enabled = false;
            txtlogad1.Location = new Point(258, 204);
            txtlogad1.Name = "txtlogad1";
            txtlogad1.Size = new Size(100, 23);
            txtlogad1.TabIndex = 11;
            // 
            // txtm2
            // 
            txtm2.Enabled = false;
            txtm2.Location = new Point(258, 241);
            txtm2.Name = "txtm2";
            txtm2.Size = new Size(100, 23);
            txtm2.TabIndex = 12;
            // 
            // txtlogad2
            // 
            txtlogad2.Enabled = false;
            txtlogad2.Location = new Point(258, 275);
            txtlogad2.Name = "txtlogad2";
            txtlogad2.Size = new Size(100, 23);
            txtlogad2.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(258, 131);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(258, 97);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(258, 65);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 650);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(txtlogad2);
            Controls.Add(txtm2);
            Controls.Add(txtlogad1);
            Controls.Add(txtm1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cBoxSN);
            Controls.Add(label1);
            Controls.Add(dtgExcel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgExcel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgExcel;
        private Label label1;
        private ComboBox cBoxSN;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtm1;
        private TextBox txtlogad1;
        private TextBox txtm2;
        private TextBox txtlogad2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}