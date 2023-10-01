using Fatigue.Model;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using System;
using CenterSpace.Free;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
//using UnityEngine;

namespace Fatigue
{
    public partial class Form1 : Form
    {
        List<UserInfo1> userList1 = new List<UserInfo1>();
        List<UserInfo1> dataPrint1 = new List<UserInfo1>();
        List<UserInfo2> userList2 = new List<UserInfo2>();
        List<UserInfo2> dataPrint2 = new List<UserInfo2>();
        List<NormalDist> normalDists = new List<NormalDist>();
        public double nomStress = 90, Wei = 1.1, kneeCycles = 1e7, yearinS = 20, v0 = 0.159, effThick = 20, ReferThick = 25, SCF = 3.1;
        public double Td, n0, q, gammam1, gammam2, kneeStress, S1h, gammadm1, gammadm2, Damage, Life, tSize;

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
        public double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
         771.32342877765313, -176.61502916214059, 12.507343278686905,
         -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};
        public double Gamma(double z)
        {
            if (z < 0.5)
            {
                return Math.PI / (Math.Sin(Math.PI * z) * Gamma(1 - z));
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
            UserInfo2 us = new UserInfo2();
            Td = 60 * 60 * 24 * 365 * yearinS;
            txtTd.Text = Td.ToString();
            n0 = v0 * Td;
            txtn0.Text = n0.ToString();
            gammam1 = Gamma(1 + double.Parse(txtm1.Text) / Wei);
            gammam2 = Gamma(1 + double.Parse(txtm2.Text) / Wei);
            txtgammam1.Text = gammam1.ToString("F3");
            txtgammam2.Text = gammam2.ToString("F3");
            q = nomStress * SCF / Math.Pow((Math.Log(n0)), (1 / Wei));
            if (effThick <= ReferThick) txtThicksize.Text = 1.ToString();
            else txtThicksize.Text = Math.Pow(effThick / ReferThick, double.Parse(txtk.Text)).ToString("F3");
            tSize = double.Parse(txtThicksize.Text);
            txtq.Text = q.ToString("F3");
            kneeStress = Math.Pow(10, (double.Parse(txtlogad1.Text) - Math.Log10(kneeCycles)) / double.Parse(txtm1.Text));
            txtkneeStress.Text = kneeStress.ToString("F3");
            S1h = Math.Pow(kneeStress / q, Wei);
            txtS1h.Text = S1h.ToString("F3");
            alglib alglib = new alglib();
            gammadm1 = alglib.incompletegamma(1 + double.Parse(txtm1.Text) / Wei, S1h);
            gammadm2 = alglib.incompletegamma(1 + double.Parse(txtm2.Text) / Wei, S1h);
            txtgammadm1.Text = gammadm1.ToString("F3");
            txtgammadm2.Text = gammadm2.ToString("F3");
            Damage = (Math.Pow(tSize, double.Parse(txtm1.Text)) *
                n0 / (Math.Pow(10, double.Parse(txtlogad1.Text)))) *
                (Math.Pow(q, double.Parse(txtm1.Text))) *
                (1 - gammadm1) * gammam1 + (Math.Pow(tSize, double.Parse(txtm2.Text)) *
                n0 / (Math.Pow(10, double.Parse(txtlogad2.Text)))) *
                (Math.Pow(q, double.Parse(txtm2.Text))) * (gammadm2) * gammam2;
            txtDamage.Text = Damage.ToString("F3");
            Life = 20 / Damage;
            txtLife.Text = Life.ToString("F3");

            us.SNCurve = cBoxSN.Text;
            us.NomStress = double.Parse(txtnomStress.Text);
            us.SCF = double.Parse(txtSCF.Text);
            us.WeibullShape = double.Parse(txtWei.Text);
            us.CycleN1 = double.Parse(txtkneeCycles.Text);
            us.m1 = double.Parse(txtm1.Text);
            us.logam1 = double.Parse(txtlogad1.Text);
            us.m2 = double.Parse(txtm2.Text);
            us.logam2 = double.Parse(txtlogad2.Text);
            us.YearInService = double.Parse(txtYearinS.Text);
            us.V0 = double.Parse(txtv0.Text);
            us.EffectiveThickness = double.Parse(txteffThick.Text);
            us.ReferThickness = double.Parse(txtReferThick.Text);
            us.k = double.Parse(txtk.Text);
            us.Td = double.Parse(txtTd.Text);
            us.n0 = double.Parse(txtn0.Text);
            us.q = double.Parse(txtq.Text);
            us.ThickSize = double.Parse(txtThicksize.Text);
            us.Gammam1 = double.Parse(txtgammam1.Text);
            us.Gammam2 = double.Parse(txtgammam2.Text);
            us.Gammadism1 = double.Parse(txtgammadm1.Text);
            us.Gammadism2 = double.Parse(txtgammadm2.Text);
            us.S1 = double.Parse(txtkneeStress.Text);
            us.S1h = double.Parse(txtS1h.Text);
            us.D = double.Parse(txtDamage.Text);
            us.T = double.Parse(txtLife.Text);
            userList2.Add(us);
        }

        static double F(double x)
        {
            MathNet.Numerics.Distributions.Normal result = new MathNet.Numerics.Distributions.Normal();
            return result.CumulativeDistribution(x);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Khởi tạo một danh sách UserInfo2 (giả sử là userList2)
            //List<UserInfo2> userList2 = new List<UserInfo2>();

            // Lấy đường dẫn tệp Excel từ người dùng
            string filePath = GetExcelFilePath();

            if (string.IsNullOrEmpty(filePath))
            {
                // Người dùng đã hủy chọn tệp Excel
                return;
            }

            FileInfo excelFile = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                // Kiểm tra xem Sheet1 đã tồn tại trong tệp Excel hay chưa
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault(x => x.Name == "Sheet1");

                // Nếu Sheet1 đã tồn tại, xóa nó
                if (worksheet != null)
                {
                    package.Workbook.Worksheets.Delete(worksheet);
                }

                // Tạo một Sheet1 mới
                worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Ghi dữ liệu từ danh sách userList2 vào Sheet1
                int row = 1;
                int col = 1;
                foreach (UserInfo2 userInfo in userList2)
                {
                    // Ghi dữ liệu từ userInfo vào các ô trong Sheet1 ở đây
                    worksheet.Cells[row++, col].Value = userInfo.SNCurve;
                    worksheet.Cells[row++, col].Value = userInfo.NomStress;
                    worksheet.Cells[row++, col].Value = userInfo.SCF;
                    worksheet.Cells[row++, col].Value = userInfo.WeibullShape;
                    worksheet.Cells[row++, col].Value = userInfo.CycleN1;
                    worksheet.Cells[row++, col].Value = userInfo.m1;
                    worksheet.Cells[row++, col].Value = userInfo.logam1;
                    worksheet.Cells[row++, col].Value = userInfo.m2;
                    worksheet.Cells[row++, col].Value = userInfo.logam2;
                    worksheet.Cells[row++, col].Value = userInfo.YearInService;
                    worksheet.Cells[row++, col].Value = userInfo.V0;
                    worksheet.Cells[row++, col].Value = userInfo.EffectiveThickness;
                    worksheet.Cells[row++, col].Value = userInfo.ReferThickness;
                    worksheet.Cells[row++, col].Value = userInfo.k;
                    worksheet.Cells[row++, col].Value = userInfo.Td;
                    worksheet.Cells[row++, col].Value = userInfo.n0;
                    worksheet.Cells[row++, col].Value = userInfo.q;
                    worksheet.Cells[row++, col].Value = userInfo.ThickSize;
                    worksheet.Cells[row++, col].Value = userInfo.Gammam1;
                    worksheet.Cells[row++, col].Value = userInfo.Gammam2;
                    worksheet.Cells[row++, col].Value = userInfo.S1;
                    worksheet.Cells[row++, col].Value = userInfo.S1h;
                    worksheet.Cells[row++, col].Value = userInfo.Gammadism1;
                    worksheet.Cells[row++, col].Value = userInfo.Gammadism2;
                    worksheet.Cells[row++, col].Value = userInfo.D;
                    worksheet.Cells[row++, col].Value = userInfo.T;

                    // ...
                    row = 1;
                    col++;
                }

                // Lưu tệp Excel
                package.Save();
            }

            // Thông báo thành công
            MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.");
        }


        private string GetExcelFilePath()
        {
            // Hiển thị hộp thoại để chọn đường dẫn tệp Excel
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "FatigueData";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

