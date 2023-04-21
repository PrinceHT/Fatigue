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
            this.dtgExcel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxSN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtm1 = new System.Windows.Forms.TextBox();
            this.txtlogad1 = new System.Windows.Forms.TextBox();
            this.txtm2 = new System.Windows.Forms.TextBox();
            this.txtlogad2 = new System.Windows.Forms.TextBox();
            this.txtkneeCycles = new System.Windows.Forms.TextBox();
            this.txtWei = new System.Windows.Forms.TextBox();
            this.txtnomStress = new System.Windows.Forms.TextBox();
            this.txtYearinS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtv0 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txteffThick = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtk = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtgammam1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtq = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtn0 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLife = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDamage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtgammadm2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtgammadm1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtS1h = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtkneeStress = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtgammam2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtReferThick = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSCF = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgExcel
            // 
            this.dtgExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExcel.Location = new System.Drawing.Point(882, 12);
            this.dtgExcel.Name = "dtgExcel";
            this.dtgExcel.RowTemplate.Height = 25;
            this.dtgExcel.Size = new System.Drawing.Size(534, 374);
            this.dtgExcel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "S-N Curves";
            // 
            // cBoxSN
            // 
            this.cBoxSN.FormattingEnabled = true;
            this.cBoxSN.Location = new System.Drawing.Point(258, 12);
            this.cBoxSN.Name = "cBoxSN";
            this.cBoxSN.Size = new System.Drawing.Size(121, 23);
            this.cBoxSN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nominal Stress Range (MPA)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weibull shape parameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cycles at knee in S-N curve N1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "m1 (N=<N1 cycles)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "logad1 (N=<N1 cycles)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "logad2 (N>N1 cycles)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "m2 (N>N1 cycles)";
            // 
            // txtm1
            // 
            this.txtm1.Enabled = false;
            this.txtm1.Location = new System.Drawing.Point(258, 157);
            this.txtm1.Name = "txtm1";
            this.txtm1.Size = new System.Drawing.Size(100, 23);
            this.txtm1.TabIndex = 10;
            // 
            // txtlogad1
            // 
            this.txtlogad1.Enabled = false;
            this.txtlogad1.Location = new System.Drawing.Point(258, 186);
            this.txtlogad1.Name = "txtlogad1";
            this.txtlogad1.Size = new System.Drawing.Size(100, 23);
            this.txtlogad1.TabIndex = 11;
            // 
            // txtm2
            // 
            this.txtm2.Enabled = false;
            this.txtm2.Location = new System.Drawing.Point(258, 215);
            this.txtm2.Name = "txtm2";
            this.txtm2.Size = new System.Drawing.Size(100, 23);
            this.txtm2.TabIndex = 12;
            // 
            // txtlogad2
            // 
            this.txtlogad2.Enabled = false;
            this.txtlogad2.Location = new System.Drawing.Point(258, 244);
            this.txtlogad2.Name = "txtlogad2";
            this.txtlogad2.Size = new System.Drawing.Size(100, 23);
            this.txtlogad2.TabIndex = 13;
            // 
            // txtkneeCycles
            // 
            this.txtkneeCycles.Location = new System.Drawing.Point(258, 128);
            this.txtkneeCycles.Name = "txtkneeCycles";
            this.txtkneeCycles.Size = new System.Drawing.Size(100, 23);
            this.txtkneeCycles.TabIndex = 16;
            this.txtkneeCycles.Text = "10000000";
            this.txtkneeCycles.TextChanged += new System.EventHandler(this.txtkneeCycles_TextChanged);
            // 
            // txtWei
            // 
            this.txtWei.Location = new System.Drawing.Point(258, 99);
            this.txtWei.Name = "txtWei";
            this.txtWei.Size = new System.Drawing.Size(100, 23);
            this.txtWei.TabIndex = 15;
            this.txtWei.Text = "1.1";
            this.txtWei.TextChanged += new System.EventHandler(this.txtWei_TextChanged);
            // 
            // txtnomStress
            // 
            this.txtnomStress.Location = new System.Drawing.Point(258, 41);
            this.txtnomStress.Name = "txtnomStress";
            this.txtnomStress.Size = new System.Drawing.Size(100, 23);
            this.txtnomStress.TabIndex = 14;
            this.txtnomStress.Text = "131.61";
            this.txtnomStress.TextChanged += new System.EventHandler(this.txtnomStress_TextChanged);
            // 
            // txtYearinS
            // 
            this.txtYearinS.Location = new System.Drawing.Point(258, 273);
            this.txtYearinS.Name = "txtYearinS";
            this.txtYearinS.Size = new System.Drawing.Size(100, 23);
            this.txtYearinS.TabIndex = 18;
            this.txtYearinS.Text = "20";
            this.txtYearinS.TextChanged += new System.EventHandler(this.txtYearinS_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Year in service";
            // 
            // txtv0
            // 
            this.txtv0.Location = new System.Drawing.Point(258, 302);
            this.txtv0.Name = "txtv0";
            this.txtv0.Size = new System.Drawing.Size(100, 23);
            this.txtv0.TabIndex = 20;
            this.txtv0.Text = "0.159";
            this.txtv0.TextChanged += new System.EventHandler(this.txtv0_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Zero up-crossing freequency: v0";
            // 
            // txteffThick
            // 
            this.txteffThick.Location = new System.Drawing.Point(258, 331);
            this.txteffThick.Name = "txteffThick";
            this.txteffThick.Size = new System.Drawing.Size(100, 23);
            this.txteffThick.TabIndex = 22;
            this.txteffThick.Text = "30";
            this.txteffThick.TextChanged += new System.EventHandler(this.txteffThick_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Effective thickness (mm)";
            // 
            // txtk
            // 
            this.txtk.Enabled = false;
            this.txtk.Location = new System.Drawing.Point(667, 41);
            this.txtk.Name = "txtk";
            this.txtk.Size = new System.Drawing.Size(100, 23);
            this.txtk.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Thickness exponent k";
            // 
            // txtgammam1
            // 
            this.txtgammam1.Enabled = false;
            this.txtgammam1.Location = new System.Drawing.Point(667, 157);
            this.txtgammam1.Name = "txtgammam1";
            this.txtgammam1.Size = new System.Drawing.Size(100, 23);
            this.txtgammam1.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(421, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Gamma (1+m1/h)";
            // 
            // txtq
            // 
            this.txtq.Enabled = false;
            this.txtq.Location = new System.Drawing.Point(667, 128);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(100, 23);
            this.txtq.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(421, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Weibull scale parameter: q";
            // 
            // txtn0
            // 
            this.txtn0.Enabled = false;
            this.txtn0.Location = new System.Drawing.Point(667, 99);
            this.txtn0.Name = "txtn0";
            this.txtn0.Size = new System.Drawing.Size(100, 23);
            this.txtn0.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(421, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Calculated number of cycles: n0";
            // 
            // txtTd
            // 
            this.txtTd.Enabled = false;
            this.txtTd.Location = new System.Drawing.Point(667, 70);
            this.txtTd.Name = "txtTd";
            this.txtTd.Size = new System.Drawing.Size(100, 23);
            this.txtTd.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 15);
            this.label16.TabIndex = 25;
            this.label16.Text = "Td = Time in service";
            // 
            // txtLife
            // 
            this.txtLife.Enabled = false;
            this.txtLife.Location = new System.Drawing.Point(667, 360);
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(100, 23);
            this.txtLife.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(421, 363);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 15);
            this.label17.TabIndex = 45;
            this.label17.Text = "Calculated life time T (years)";
            // 
            // txtDamage
            // 
            this.txtDamage.Enabled = false;
            this.txtDamage.Location = new System.Drawing.Point(667, 331);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(100, 23);
            this.txtDamage.TabIndex = 44;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(421, 334);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 15);
            this.label18.TabIndex = 43;
            this.label18.Text = "Calculated fatigue damage: D";
            // 
            // txtgammadm2
            // 
            this.txtgammadm2.Enabled = false;
            this.txtgammadm2.Location = new System.Drawing.Point(667, 302);
            this.txtgammadm2.Name = "txtgammadm2";
            this.txtgammadm2.Size = new System.Drawing.Size(100, 23);
            this.txtgammadm2.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(421, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(232, 15);
            this.label19.TabIndex = 41;
            this.label19.Text = "Gamma distribution P((1+m2/h),(S1/q)^h)";
            // 
            // txtgammadm1
            // 
            this.txtgammadm1.Enabled = false;
            this.txtgammadm1.Location = new System.Drawing.Point(667, 273);
            this.txtgammadm1.Name = "txtgammadm1";
            this.txtgammadm1.Size = new System.Drawing.Size(100, 23);
            this.txtgammadm1.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(421, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(232, 15);
            this.label20.TabIndex = 39;
            this.label20.Text = "Gamma distribution P((1+m1/h),(S1/q)^h)";
            // 
            // txtS1h
            // 
            this.txtS1h.Enabled = false;
            this.txtS1h.Location = new System.Drawing.Point(667, 244);
            this.txtS1h.Name = "txtS1h";
            this.txtS1h.Size = new System.Drawing.Size(100, 23);
            this.txtS1h.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(421, 247);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 15);
            this.label21.TabIndex = 37;
            this.label21.Text = "(S1/q)^h";
            // 
            // txtkneeStress
            // 
            this.txtkneeStress.Enabled = false;
            this.txtkneeStress.Location = new System.Drawing.Point(667, 215);
            this.txtkneeStress.Name = "txtkneeStress";
            this.txtkneeStress.Size = new System.Drawing.Size(100, 23);
            this.txtkneeStress.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(421, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(164, 15);
            this.label22.TabIndex = 35;
            this.label22.Text = "Stress at knee in S-N curve: S1";
            // 
            // txtgammam2
            // 
            this.txtgammam2.Enabled = false;
            this.txtgammam2.Location = new System.Drawing.Point(667, 186);
            this.txtgammam2.Name = "txtgammam2";
            this.txtgammam2.Size = new System.Drawing.Size(100, 23);
            this.txtgammam2.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(421, 189);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 15);
            this.label23.TabIndex = 33;
            this.label23.Text = "Gamma (1+m2/h)";
            // 
            // txtReferThick
            // 
            this.txtReferThick.Location = new System.Drawing.Point(258, 360);
            this.txtReferThick.Name = "txtReferThick";
            this.txtReferThick.Size = new System.Drawing.Size(100, 23);
            this.txtReferThick.TabIndex = 48;
            this.txtReferThick.Text = "25";
            this.txtReferThick.TextChanged += new System.EventHandler(this.txtReferThick_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 363);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 15);
            this.label24.TabIndex = 47;
            this.label24.Text = "Reference thickness";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(779, 330);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 49;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSCF
            // 
            this.txtSCF.Location = new System.Drawing.Point(258, 70);
            this.txtSCF.Name = "txtSCF";
            this.txtSCF.Size = new System.Drawing.Size(100, 23);
            this.txtSCF.TabIndex = 51;
            this.txtSCF.Text = "3";
            this.txtSCF.TextChanged += new System.EventHandler(this.txtSCF_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(150, 15);
            this.label25.TabIndex = 50;
            this.label25.Text = "Hot spot stress factor (SCF)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 396);
            this.Controls.Add(this.txtSCF);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtReferThick);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtLife);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDamage);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtgammadm2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtgammadm1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtS1h);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtkneeStress);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtgammam2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtgammam1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtn0);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTd);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtk);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txteffThick);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtv0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtYearinS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnomStress);
            this.Controls.Add(this.txtWei);
            this.Controls.Add(this.txtkneeCycles);
            this.Controls.Add(this.txtlogad2);
            this.Controls.Add(this.txtm2);
            this.Controls.Add(this.txtlogad1);
            this.Controls.Add(this.txtm1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxSN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}