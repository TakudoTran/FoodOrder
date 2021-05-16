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

            dgvDSDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowDanhMuc();
            BusinessLogicLayer.Instance.SetColumnHeaderDM(dgvDSDanhMuc);
        }

        private void Show(int idDanhmuc, string tenMon)
        {
            dgvDanhSachMon.DataSource = BusinessLogicLayer.Instance.GetMonByIdDanhMucAndTenMon(idDanhmuc, tenMon);
        }
        private void ShowDanhMuc()
        {
            dgvDSDanhMuc.DataSource = BusinessLogicLayer.Instance.GetAllDanhMuc();
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

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Text = BusinessLogicLayer.Instance.GetMaxIdDanhMuc() + 1 + "";
            txtMaDanhMuc.Enabled = true;
            DanhMuc dm = new DanhMuc
            {
                IdDanhMuc = int.Parse(txtMaDanhMuc.Text),
                TenDanhMuc = txtTenDanhMuc.Text,
            };

            BusinessLogicLayer.Instance.ThemDanhMuc(dm);

            ShowDanhMuc();
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            if (dgvDSDanhMuc.SelectedRows.Count != 1)
            {
                MessageBox.Show("Chọn 1 Danh Mục để sửa!");
                return;
            }

            DanhMuc dm = new DanhMuc
            {
                IdDanhMuc = int.Parse(txtMaDanhMuc.Text),
                TenDanhMuc = txtTenDanhMuc.Text
            };


            BusinessLogicLayer.Instance.SuaDanhMuc(dm);

            ShowDanhMuc();
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (dgvDSDanhMuc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất 1 danh mục để xóa!");
                return;
            }
            foreach (DataGridViewRow i in dgvDSDanhMuc.SelectedRows)
            {
                DanhMuc dgv = i.DataBoundItem as DanhMuc;
                int idDanhMuc = dgv.IdDanhMuc;
                DialogResult result = MessageBox.Show("Muốn xóa Danh Mục: " + dgv.TenDanhMuc + "?",
                    "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BusinessLogicLayer.Instance.XoaDanhMuc(idDanhMuc))
                    {
                        MessageBox.Show("Đã xóa Danh Mục: " + dgv.TenDanhMuc);
                    }
                    else MessageBox.Show("Lỗi xóa! Danh Mục này đã được dùng cho Món");
                }
            }
            ShowDanhMuc();
        }

        private void dgvDSDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSDanhMuc.Rows[e.RowIndex];
                txtMaDanhMuc.Text = row.Cells["IdDanhMuc"].Value.ToString();
                txtTenDanhMuc.Text = row.Cells["TenDanhMuc"].Value.ToString();
            }
        }
    }
}
