using Fatigue.Model;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace Fatigue
{
    public partial class Form1 : Form
    {
        List<UserInfo1> userList1 = new List<UserInfo1>();
        List<UserInfo1> dataPrint1 = new List<UserInfo1>();
        List<UserInfo2> userList2 = new List<UserInfo2>();
        List<UserInfo2> dataPrint2 = new List<UserInfo2>();
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

