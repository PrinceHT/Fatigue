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
            txtkneeCycles = new TextBox();
            txtWei = new TextBox();
            txtnomStress = new TextBox();
            txtYearinS = new TextBox();
            label9 = new Label();
            txtv0 = new TextBox();
            label10 = new Label();
            txteffThick = new TextBox();
            label11 = new Label();
            txtk = new TextBox();
            label12 = new Label();
            txtgammam1 = new TextBox();
            label13 = new Label();
            txtq = new TextBox();
            label14 = new Label();
            txtn0 = new TextBox();
            label15 = new Label();
            txtTd = new TextBox();
            label16 = new Label();
            txtLife = new TextBox();
            label17 = new Label();
            txtDamage = new TextBox();
            label18 = new Label();
            txtgammadm2 = new TextBox();
            label19 = new Label();
            txtgammadm1 = new TextBox();
            label20 = new Label();
            txtS1h = new TextBox();
            label21 = new Label();
            txtkneeStress = new TextBox();
            label22 = new Label();
            txtgammam2 = new TextBox();
            label23 = new Label();
            txtReferThick = new TextBox();
            label24 = new Label();
            btnCalculate = new Button();
            txtSCF = new TextBox();
            label25 = new Label();
            txtThicksize = new TextBox();
            label26 = new Label();
            btnExport = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgExcel).BeginInit();
            SuspendLayout();
            // 
            // dtgExcel
            // 
            dtgExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgExcel.Location = new Point(882, 12);
            dtgExcel.Name = "dtgExcel";
            dtgExcel.RowTemplate.Height = 25;
            dtgExcel.Size = new Size(534, 374);
            dtgExcel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "S-N Curves";
            // 
            // cBoxSN
            // 
            cBoxSN.FormattingEnabled = true;
            cBoxSN.Location = new Point(258, 12);
            cBoxSN.Name = "cBoxSN";
            cBoxSN.Size = new Size(121, 23);
            cBoxSN.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 3;
            label2.Text = "Nominal Stress Range (MPA)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 4;
            label3.Text = "Weibull shape parameter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 5;
            label4.Text = "Cycles at knee in S-N curve N1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 6;
            label5.Text = "m1 (N=<N1 cycles)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 189);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 7;
            label6.Text = "logad1 (N=<N1 cycles)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 9;
            label7.Text = "logad2 (N>N1 cycles)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 218);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 8;
            label8.Text = "m2 (N>N1 cycles)";
            // 
            // txtm1
            // 
            txtm1.Enabled = false;
            txtm1.Location = new Point(258, 157);
            txtm1.Name = "txtm1";
            txtm1.RightToLeft = RightToLeft.No;
            txtm1.Size = new Size(100, 23);
            txtm1.TabIndex = 10;
            // 
            // txtlogad1
            // 
            txtlogad1.Enabled = false;
            txtlogad1.Location = new Point(258, 186);
            txtlogad1.Name = "txtlogad1";
            txtlogad1.RightToLeft = RightToLeft.No;
            txtlogad1.Size = new Size(100, 23);
            txtlogad1.TabIndex = 11;
            // 
            // txtm2
            // 
            txtm2.Enabled = false;
            txtm2.Location = new Point(258, 215);
            txtm2.Name = "txtm2";
            txtm2.RightToLeft = RightToLeft.No;
            txtm2.Size = new Size(100, 23);
            txtm2.TabIndex = 12;
            // 
            // txtlogad2
            // 
            txtlogad2.Enabled = false;
            txtlogad2.Location = new Point(258, 244);
            txtlogad2.Name = "txtlogad2";
            txtlogad2.RightToLeft = RightToLeft.No;
            txtlogad2.Size = new Size(100, 23);
            txtlogad2.TabIndex = 13;
            // 
            // txtkneeCycles
            // 
            txtkneeCycles.Location = new Point(258, 128);
            txtkneeCycles.Name = "txtkneeCycles";
            txtkneeCycles.RightToLeft = RightToLeft.No;
            txtkneeCycles.Size = new Size(100, 23);
            txtkneeCycles.TabIndex = 16;
            txtkneeCycles.Text = "10000000";
            txtkneeCycles.TextChanged += txtkneeCycles_TextChanged;
            // 
            // txtWei
            // 
            txtWei.Location = new Point(258, 99);
            txtWei.Name = "txtWei";
            txtWei.RightToLeft = RightToLeft.No;
            txtWei.Size = new Size(100, 23);
            txtWei.TabIndex = 15;
            txtWei.Text = "1.1";
            txtWei.TextChanged += txtWei_TextChanged;
            // 
            // txtnomStress
            // 
            txtnomStress.Location = new Point(258, 41);
            txtnomStress.Name = "txtnomStress";
            txtnomStress.RightToLeft = RightToLeft.No;
            txtnomStress.Size = new Size(100, 23);
            txtnomStress.TabIndex = 14;
            txtnomStress.Text = "90";
            txtnomStress.TextChanged += txtnomStress_TextChanged;
            // 
            // txtYearinS
            // 
            txtYearinS.Location = new Point(258, 273);
            txtYearinS.Name = "txtYearinS";
            txtYearinS.RightToLeft = RightToLeft.No;
            txtYearinS.Size = new Size(100, 23);
            txtYearinS.TabIndex = 18;
            txtYearinS.Text = "20";
            txtYearinS.TextChanged += txtYearinS_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 276);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 17;
            label9.Text = "Year in service";
            // 
            // txtv0
            // 
            txtv0.Location = new Point(258, 302);
            txtv0.Name = "txtv0";
            txtv0.RightToLeft = RightToLeft.No;
            txtv0.Size = new Size(100, 23);
            txtv0.TabIndex = 20;
            txtv0.Text = "0.159";
            txtv0.TextChanged += txtv0_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 305);
            label10.Name = "label10";
            label10.Size = new Size(177, 15);
            label10.TabIndex = 19;
            label10.Text = "Zero up-crossing freequency: v0";
            // 
            // txteffThick
            // 
            txteffThick.Location = new Point(258, 331);
            txteffThick.Name = "txteffThick";
            txteffThick.RightToLeft = RightToLeft.No;
            txteffThick.Size = new Size(100, 23);
            txteffThick.TabIndex = 22;
            txteffThick.Text = "20";
            txteffThick.TextChanged += txteffThick_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 334);
            label11.Name = "label11";
            label11.Size = new Size(137, 15);
            label11.TabIndex = 21;
            label11.Text = "Effective thickness (mm)";
            // 
            // txtk
            // 
            txtk.Enabled = false;
            txtk.Location = new Point(667, 12);
            txtk.Name = "txtk";
            txtk.RightToLeft = RightToLeft.No;
            txtk.Size = new Size(100, 23);
            txtk.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(421, 15);
            label12.Name = "label12";
            label12.Size = new Size(120, 15);
            label12.TabIndex = 23;
            label12.Text = "Thickness exponent k";
            // 
            // txtgammam1
            // 
            txtgammam1.Enabled = false;
            txtgammam1.Location = new Point(667, 157);
            txtgammam1.Name = "txtgammam1";
            txtgammam1.RightToLeft = RightToLeft.No;
            txtgammam1.Size = new Size(100, 23);
            txtgammam1.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(421, 160);
            label13.Name = "label13";
            label13.Size = new Size(103, 15);
            label13.TabIndex = 31;
            label13.Text = "Gamma (1+m1/h)";
            // 
            // txtq
            // 
            txtq.Enabled = false;
            txtq.Location = new Point(667, 99);
            txtq.Name = "txtq";
            txtq.RightToLeft = RightToLeft.No;
            txtq.Size = new Size(100, 23);
            txtq.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(421, 102);
            label14.Name = "label14";
            label14.Size = new Size(146, 15);
            label14.TabIndex = 29;
            label14.Text = "Weibull scale parameter: q";
            // 
            // txtn0
            // 
            txtn0.Enabled = false;
            txtn0.Location = new Point(667, 70);
            txtn0.Name = "txtn0";
            txtn0.RightToLeft = RightToLeft.No;
            txtn0.Size = new Size(100, 23);
            txtn0.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(421, 73);
            label15.Name = "label15";
            label15.Size = new Size(176, 15);
            label15.TabIndex = 27;
            label15.Text = "Calculated number of cycles: n0";
            // 
            // txtTd
            // 
            txtTd.Enabled = false;
            txtTd.Location = new Point(667, 41);
            txtTd.Name = "txtTd";
            txtTd.RightToLeft = RightToLeft.No;
            txtTd.Size = new Size(100, 23);
            txtTd.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(421, 44);
            label16.Name = "label16";
            label16.Size = new Size(111, 15);
            label16.TabIndex = 25;
            label16.Text = "Td = Time in service";
            // 
            // txtLife
            // 
            txtLife.Enabled = false;
            txtLife.Location = new Point(667, 360);
            txtLife.Name = "txtLife";
            txtLife.RightToLeft = RightToLeft.No;
            txtLife.Size = new Size(100, 23);
            txtLife.TabIndex = 46;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(421, 363);
            label17.Name = "label17";
            label17.Size = new Size(156, 15);
            label17.TabIndex = 45;
            label17.Text = "Calculated life time T (years)";
            // 
            // txtDamage
            // 
            txtDamage.Enabled = false;
            txtDamage.Location = new Point(667, 331);
            txtDamage.Name = "txtDamage";
            txtDamage.RightToLeft = RightToLeft.No;
            txtDamage.Size = new Size(100, 23);
            txtDamage.TabIndex = 44;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(421, 334);
            label18.Name = "label18";
            label18.Size = new Size(163, 15);
            label18.TabIndex = 43;
            label18.Text = "Calculated fatigue damage: D";
            // 
            // txtgammadm2
            // 
            txtgammadm2.Enabled = false;
            txtgammadm2.Location = new Point(667, 302);
            txtgammadm2.Name = "txtgammadm2";
            txtgammadm2.RightToLeft = RightToLeft.No;
            txtgammadm2.Size = new Size(100, 23);
            txtgammadm2.TabIndex = 42;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(421, 305);
            label19.Name = "label19";
            label19.Size = new Size(232, 15);
            label19.TabIndex = 41;
            label19.Text = "Gamma distribution P((1+m2/h),(S1/q)^h)";
            // 
            // txtgammadm1
            // 
            txtgammadm1.Enabled = false;
            txtgammadm1.Location = new Point(667, 273);
            txtgammadm1.Name = "txtgammadm1";
            txtgammadm1.RightToLeft = RightToLeft.No;
            txtgammadm1.Size = new Size(100, 23);
            txtgammadm1.TabIndex = 40;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(421, 276);
            label20.Name = "label20";
            label20.Size = new Size(232, 15);
            label20.TabIndex = 39;
            label20.Text = "Gamma distribution P((1+m1/h),(S1/q)^h)";
            // 
            // txtS1h
            // 
            txtS1h.Enabled = false;
            txtS1h.Location = new Point(667, 244);
            txtS1h.Name = "txtS1h";
            txtS1h.RightToLeft = RightToLeft.No;
            txtS1h.Size = new Size(100, 23);
            txtS1h.TabIndex = 38;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(421, 247);
            label21.Name = "label21";
            label21.Size = new Size(54, 15);
            label21.TabIndex = 37;
            label21.Text = "(S1/q)^h";
            // 
            // txtkneeStress
            // 
            txtkneeStress.Enabled = false;
            txtkneeStress.Location = new Point(667, 215);
            txtkneeStress.Name = "txtkneeStress";
            txtkneeStress.RightToLeft = RightToLeft.No;
            txtkneeStress.Size = new Size(100, 23);
            txtkneeStress.TabIndex = 36;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(421, 218);
            label22.Name = "label22";
            label22.Size = new Size(164, 15);
            label22.TabIndex = 35;
            label22.Text = "Stress at knee in S-N curve: S1";
            // 
            // txtgammam2
            // 
            txtgammam2.Enabled = false;
            txtgammam2.Location = new Point(667, 186);
            txtgammam2.Name = "txtgammam2";
            txtgammam2.RightToLeft = RightToLeft.No;
            txtgammam2.Size = new Size(100, 23);
            txtgammam2.TabIndex = 34;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(421, 189);
            label23.Name = "label23";
            label23.Size = new Size(103, 15);
            label23.TabIndex = 33;
            label23.Text = "Gamma (1+m2/h)";
            // 
            // txtReferThick
            // 
            txtReferThick.Location = new Point(258, 360);
            txtReferThick.Name = "txtReferThick";
            txtReferThick.RightToLeft = RightToLeft.No;
            txtReferThick.Size = new Size(100, 23);
            txtReferThick.TabIndex = 48;
            txtReferThick.Text = "25";
            txtReferThick.TextChanged += txtReferThick_TextChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(12, 363);
            label24.Name = "label24";
            label24.Size = new Size(111, 15);
            label24.TabIndex = 47;
            label24.Text = "Reference thickness";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(779, 330);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 23);
            btnCalculate.TabIndex = 49;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtSCF
            // 
            txtSCF.Location = new Point(258, 70);
            txtSCF.Name = "txtSCF";
            txtSCF.RightToLeft = RightToLeft.No;
            txtSCF.Size = new Size(100, 23);
            txtSCF.TabIndex = 51;
            txtSCF.Text = "3.1";
            txtSCF.TextChanged += txtSCF_TextChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(12, 73);
            label25.Name = "label25";
            label25.Size = new Size(150, 15);
            label25.TabIndex = 50;
            label25.Text = "Hot spot stress factor (SCF)";
            // 
            // txtThicksize
            // 
            txtThicksize.Enabled = false;
            txtThicksize.Location = new Point(667, 128);
            txtThicksize.Name = "txtThicksize";
            txtThicksize.RightToLeft = RightToLeft.No;
            txtThicksize.Size = new Size(100, 23);
            txtThicksize.TabIndex = 53;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(421, 131);
            label26.Name = "label26";
            label26.Size = new Size(151, 15);
            label26.TabIndex = 52;
            label26.Text = "Thickness or size correction";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(779, 359);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 23);
            btnExport.TabIndex = 54;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // button1
            // 
            button1.Location = new Point(779, 15);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 55;
            button1.Text = "Plot 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 396);
            Controls.Add(button1);
            Controls.Add(btnExport);
            Controls.Add(txtThicksize);
            Controls.Add(label26);
            Controls.Add(txtSCF);
            Controls.Add(label25);
            Controls.Add(btnCalculate);
            Controls.Add(txtReferThick);
            Controls.Add(label24);
            Controls.Add(txtLife);
            Controls.Add(label17);
            Controls.Add(txtDamage);
            Controls.Add(label18);
            Controls.Add(txtgammadm2);
            Controls.Add(label19);
            Controls.Add(txtgammadm1);
            Controls.Add(label20);
            Controls.Add(txtS1h);
            Controls.Add(label21);
            Controls.Add(txtkneeStress);
            Controls.Add(label22);
            Controls.Add(txtgammam2);
            Controls.Add(label23);
            Controls.Add(txtgammam1);
            Controls.Add(label13);
            Controls.Add(txtq);
            Controls.Add(label14);
            Controls.Add(txtn0);
            Controls.Add(label15);
            Controls.Add(txtTd);
            Controls.Add(label16);
            Controls.Add(txtk);
            Controls.Add(label12);
            Controls.Add(txteffThick);
            Controls.Add(label11);
            Controls.Add(txtv0);
            Controls.Add(label10);
            Controls.Add(txtYearinS);
            Controls.Add(label9);
            Controls.Add(txtnomStress);
            Controls.Add(txtWei);
            Controls.Add(txtkneeCycles);
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
            Text = "FATIGUE CALCULATION";
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
        private TextBox txtkneeCycles;
        private TextBox txtWei;
        private TextBox txtnomStress;
        private TextBox txtYearinS;
        private Label label9;
        private TextBox txtv0;
        private Label label10;
        private TextBox txteffThick;
        private Label label11;
        private TextBox txtk;
        private Label label12;
        private TextBox txtgammam1;
        private Label label13;
        private TextBox txtq;
        private Label label14;
        private TextBox txtn0;
        private Label label15;
        private TextBox txtTd;
        private Label label16;
        private TextBox txtLife;
        private Label label17;
        private TextBox txtDamage;
        private Label label18;
        private TextBox txtgammadm2;
        private Label label19;
        private TextBox txtgammadm1;
        private Label label20;
        private TextBox txtS1h;
        private Label label21;
        private TextBox txtkneeStress;
        private Label label22;
        private TextBox txtgammam2;
        private Label label23;
        private TextBox txtReferThick;
        private Label label24;
        private Button btnCalculate;
        private TextBox txtSCF;
        private Label label25;
        private TextBox txtThicksize;
        private Label label26;
        private Button btnExport;
        private Button button1;
    }
}