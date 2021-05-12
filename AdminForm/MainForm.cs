using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace AdminForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgvDanhSachMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BusinessLogicLayer.Instance.setCbbDanhMuc(cboDanhMuc);
            Show(0, null);
        }

        private void Show(int idDanhmuc, string tenMon)
        {
            dgvDanhSachMon.DataSource = BusinessLogicLayer.Instance.GetMonByIdDanhMucAndTenMon(idDanhmuc, tenMon);
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            CBBItem cbi = cboDanhMuc.SelectedItem as CBBItem;
            int idDanhMuc = cbi.Value;
            Show(idDanhMuc, ""); 
            
        }
    }
}
