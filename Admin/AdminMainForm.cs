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

namespace Admin
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            dgvDanhSachMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BusinessLogicLayer.Instance.setCbbDanhMuc(cbDanhMuc);
            Show(0, null);
        }

        private void Show(int idDanhmuc, string tenMon)
        {
            CBBItem cbi = cbDanhMuc.SelectedItem as CBBItem;
            idDanhmuc = cbi.Value;
            dgvDanhSachMon.DataSource = BusinessLogicLayer.Instance.getListMonBySearch_BLL(idDanhmuc, tenMon);
        }
        private void button_Search(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            CBBItem cbi = cbDanhMuc.SelectedItem as CBBItem;
            int idDanhmuc = cbi.Value;
            Show(idDanhmuc, "");
        }
    }
}
