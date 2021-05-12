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
            BusinessLogicLayer.Instance.SetColumnHeader(dgvDanhSachMon);


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
        private void btnTim_Click(object sender, EventArgs e)
        {
            CBBItem cbi = cboDanhMuc.SelectedItem as CBBItem;
            int idDanhMuc = cbi.Value;
            string st = txtSearch.Text;
            Show(idDanhMuc,st);

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm(0);
            f.actionAfterOk += new DetailForm.Mydel(Show);
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MonView mv = dgvDanhSachMon.CurrentRow.DataBoundItem as MonView;
            int idMon = mv.IdMon;
            DetailForm f2 = new DetailForm(idMon);
            f2.actionAfterOk += new DetailForm.Mydel(Show);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
    }
}
