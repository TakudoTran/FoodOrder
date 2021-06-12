using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using DTO;
using BLL;

namespace AdminForm
{
    public partial class Printer_Form : Form
    {
        public List<BillToAcess> BillThanhToan { get; set; }
        public Printer_Form(List<BillToAcess> Bill)
        {
            InitializeComponent();
            this.BillThanhToan = Bill;
        }

        private void Bill_Printer_Form_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TenMon", typeof(string));
                tb.Columns.Add("SoLuong", typeof(int));
                tb.Columns.Add("DonGia", typeof(int));
                foreach (BillToAcess i in BillThanhToan)
                {
                    tb.Rows.Add(i.TenMon, i.SoLuong, i.GiaTien);
                }
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdminForm.ReportBill.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = tb;
                reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
