using Fatigue.Model;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using System;
using CenterSpace.Free;

namespace Fatigue
{
    public partial class Form1 : Form
    {
        List<UserInfo1> userList1 = new List<UserInfo1>();
        List<UserInfo1> dataPrint1 = new List<UserInfo1>();
        List<UserInfo2> userList2 = new List<UserInfo2>();
        List<UserInfo2> dataPrint2 = new List<UserInfo2>();
        List<NormalDist> normalDists = new List<NormalDist>();
        public double nomStress = 131.61, Wei = 1.1, kneeCycles = 1e7, yearinS = 20, v0 = 0.159, effThick = 30, ReferThick = 25, SCF = 3;
        public double Td, n0, q, gammam1, gammam2, kneeStress, S1h, gammadm1, gammadm2, Damage, Life;

        private void txtSCF_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txtSCF.Text, out SCF))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void txtReferThick_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txtReferThick.Text, out ReferThick))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void txtv0_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txtv0.Text, out v0))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void txtWei_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txtWei.Text, out Wei))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void txtkneeCycles_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txtkneeCycles.Text, out kneeCycles))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void txteffThick_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txteffThick.Text, out effThick))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void txtYearinS_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txtYearinS.Text, out yearinS))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void txtnomStress_TextChanged(object sender, EventArgs e)
        {
            bool isSuccess;
            if (Double.TryParse(txtnomStress.Text, out nomStress))
                isSuccess = true;
            else
                MessageBox.Show("Re-put the correct value", "Notice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }
        public int g = 7;
        //public double test = 51 / 11;
        public double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
         771.32342877765313, -176.61502916214059, 12.507343278686905,
         -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};
        public double Gamma(double z)
        {
            if (z < 0.5)
            {
                return Math.PI / (Math.Sin(Math.PI * z) * Gamma(1 - z)) ;
            }
            else
            {
                z -= 1;
                double x = p[0];
                for (int i = 1; i < g + 2; i++)
                {
                    x += p[i] / (z + i);
                }
                double t = z + g + 0.5;
                return Math.Sqrt(2 * Math.PI) * (Math.Pow(t, z + 0.5)) * Math.Exp(-t) * x;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Td = 60 * 60 * 24 * 365 * yearinS;
            txtTd.Text = Td.ToString();
            n0 = v0 * Td;
            txtn0.Text = n0.ToString();
            gammam1 = Gamma(1 + double.Parse(txtm1.Text) / Wei);
            gammam2 = Gamma(1 + double.Parse(txtm2.Text) / Wei);
            txtgammam1.Text = gammam1.ToString();
            txtgammam2.Text = gammam2.ToString();
            q = nomStress * SCF / Math.Pow((Math.Log(n0)), (1 / Wei));
            txtq.Text = q.ToString();
            kneeStress = Math.Pow(10, (double.Parse(txtlogad1.Text) - Math.Log10(kneeCycles)) / double.Parse(txtm1.Text));
            txtkneeStress.Text = kneeStress.ToString();
            S1h = Math.Pow(kneeStress / q, Wei);
            txtS1h.Text = S1h.ToString();
            //gammadm1 = Math.Pow(S1h,double.Parse(txtm1.Text) / Wei) * Math.Pow(Math.E, -S1h) / Gamma(1 + double.Parse(txtm1.Text) / Wei);
            //gammadm1 = Math.Pow(S1h, double.Parse(txtm1.Text) / Wei) * Math.Pow(Math.E, -S1h);
            //gammadm1=Gamma(1+double.Parse(txtm1.Text) / Wei);
            //gammadm2 = Math.Pow(S1h, double.Parse(txtm2.Text) / Wei) * Math.Pow(Math.E, -S1h) /gammam2;
            //txtgammadm1.Text = gammadm1.ToString();
            //txtgammadm2.Text = gammadm2.ToString();
            NormalDist dist1 = new NormalDist(Wei*q,Wei*Math.Pow(q,2));
            gammadm1 = dist1.CDF(1 + double.Parse(txtm1.Text) / Wei);
            NormalDist dist2 = new NormalDist(1 + double.Parse(txtm2.Text) / Wei, 1);
            gammadm2 = dist2.CDF(S1h);
            txtgammadm1.Text = gammadm1.ToString();
            txtgammadm2.Text = gammadm2.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            userList1.Clear();
            using (ExcelPackage package = new ExcelPackage(new FileInfo("FatigueData.xlsx")))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                int rowCount = workSheet.Dimension.Rows;

                int ColCount = workSheet.Dimension.Columns;
                for (int row = 3; row <= rowCount; row++)
                {
                    UserInfo1 us = new UserInfo1();
                    for (int col = 1; col <= ColCount; col++)
                    {
                        try
                        {
                            var cellValue = workSheet.Cells[row, col].Value;
                            if (cellValue != null)
                            {
                                us.SetData1(col - 1, cellValue.ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("Error: " + ex.Message);
                        }


                    }
                    userList1.Add(us);
                    Debug.WriteLine(us.ToString());
                }
                dataPrint1 = userList1;
                dtgExcel.DataSource = userList1;
                cBoxSN.DataSource = userList1;
                cBoxSN.DisplayMember = "SN";
                txtm1.DataBindings.Add(new Binding("Text", cBoxSN.DataSource, "m1"));
                txtlogad1.DataBindings.Add(new Binding("Text", cBoxSN.DataSource, "logd1"));
                txtm2.Text = "5";
                txtlogad2.DataBindings.Add(new Binding("Text", cBoxSN.DataSource, "logd2"));
                txtk.DataBindings.Add(new Binding("Text", cBoxSN.DataSource, "k"));
            }

        }

    }
}

