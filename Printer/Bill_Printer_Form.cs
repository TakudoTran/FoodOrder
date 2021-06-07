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

namespace Printer
{
    public partial class Bill_Printer_Form : Form
    {
        public int idBan { get; set; }
        public Bill_Printer_Form()
        {
            InitializeComponent();
            this.idBan = 1;
        }

        private void Bill_Printer_Form_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("TenMon", typeof(string));
            tb.Columns.Add("SoLuong", typeof(int));
            tb.Columns.Add("DonGia", typeof(int));
            List<BillToAcess> bill = new List<BillToAcess>();
            bill = BusinessLogicLayer.Instance.GetBillByTable_BLL(idBan);
            foreach (BillToAcess i in bill)
            {
                tb.Rows.Add(i.TenMon, i.SoLuong, i.GiaTien);
            }

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Printer.ReportBill.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Dataset1";
            rds.Value = tb;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
