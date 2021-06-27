using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using MyAlgo;

namespace AdminForm
{
    public partial class MainForm : Form
    {
        List<BillToAcess> finalBill { get; set; }
        List<BillChuaTinhTien> BillsThanhToan { get; set; }
        public MainForm()
        {
            InitializeComponent();
            #region QL mon
            dgvDanhSachMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BusinessLogicLayer.Instance.setCbbDanhMuc(cboDanhMuc);
            BusinessLogicLayer.Instance.setCbbDanhMucBan(cbbBanAn);
            Show(0, null);
            BusinessLogicLayer.Instance.SetColumnHeaderMon(dgvDanhSachMon);
            BusinessLogicLayer.Instance.setCbbSortType(cboSortType);
            #endregion
            #region QL danhMuc
            dgvDSDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowDanhMuc();
            BusinessLogicLayer.Instance.SetColumnHeaderDM(dgvDSDanhMuc);
            SetComboboxLoai();
            #endregion
            #region QL Ban
            cbbBanAn.SelectedIndex = 0;
            finalBill = new List<BillToAcess>();
          
            #endregion
        }
        private int CurrentBill = 0;
        #region QL Mon
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
        private void cboDanhMuc_Click(object sender, EventArgs e)
        {
            cboDanhMuc.Items.Clear();
            BusinessLogicLayer.Instance.setCbbDanhMuc(cboDanhMuc);
            cboDanhMuc.SelectedIndex = 0;
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
            txtSearch.ForeColor = Color.Black;
            if(txtSearch.Text != "Tên món (không dấu), giá")
            {
                CBBItem cbi = cboDanhMuc.SelectedItem as CBBItem;
                int idDanhMuc = cbi.Value;
                string st = txtSearch.Text;
                Show(idDanhMuc, st);
            }

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
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Chưa chọn folder hình ảnh!");
                return;
            }
            string folderPath = txtFolder.Text;
            foreach (string imgPath in Directory.GetFiles(folderPath))
            {
                byte[] Anh = null;
                FileStream fileStream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                Anh = binaryReader.ReadBytes((int)fileStream.Length);
                string imgName = imgPath.Substring(imgPath.LastIndexOf(@"\"));
                BusinessLogicLayer.Instance.ThemAnhVaoDb(imgName, Anh);

                Image img = Image.FromFile(imgPath);
                picAnh.Image = img;

            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = fbd.SelectedPath;
                    txtFolder.Text = folderPath;
                    //MessageBox.Show(folderPath);
                }

            }
        }

        private void btnLoadDefaultImg_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.Instance.DefaultImages();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachMon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất 1 món để xóa!");
                return;
            }
            foreach (DataGridViewRow i in dgvDanhSachMon.SelectedRows)
            {
                MonView mon = i.DataBoundItem as MonView;
                int IdMon = mon.IdMon;
                DialogResult result = MessageBox.Show("Muốn xóa Món: " + mon.TenMon + "?",
                    "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BusinessLogicLayer.Instance.XoaMon(IdMon))
                    {
                        MessageBox.Show("Đã xóa Món: " + mon.TenMon);
                    }
                    else MessageBox.Show("Lỗi xóa! ");
                }
            }
            int id = ((CBBItem)cboDanhMuc.SelectedItem).Value;
            Show(id, "");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            if (cboSortType.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn kiểu sắp xếp!");
                return;
            }
            string name = txtSearch.Text;
            if (txtSearch.Text == "Tên món (không dấu) / giá tiền")
            {
                name = "";
            }
            CBBItem cbLop = cboDanhMuc.SelectedItem as CBBItem;
            int IDLop = cbLop.Value;
            CBBItem cbSort = cboSortType.SelectedItem as CBBItem;
            int idSort = cbSort.Value;
            dgvDanhSachMon.DataSource = BusinessLogicLayer.Instance.Sort(idSort, IDLop, name);

        }
        #endregion

        #region QL Danh muc
        private void ShowDanhMuc()
        {
            dgvDSDanhMuc.DataSource = BusinessLogicLayer.Instance.GetAllDanhMuc();
        }
        private void SetComboboxLoai()
        {
            cbLoaiDM.Items.AddRange(BusinessLogicLayer.Instance.GetDataLoai().ToArray());
        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            if (cbLoaiDM.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Loại !!!");
                return;
            }
            txtMaDanhMuc.Text = BusinessLogicLayer.Instance.GetMaxIdDanhMuc() + 1 + "";
            txtMaDanhMuc.Enabled = true;
            DanhMuc dm = new DanhMuc
            {
                IdDanhMuc = int.Parse(txtMaDanhMuc.Text),
                TenDanhMuc = txtTenDanhMuc.Text,
                Loai = cbLoaiDM.SelectedItem.ToString()
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
                TenDanhMuc = txtTenDanhMuc.Text,
                Loai = cbLoaiDM.SelectedItem.ToString()
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

                int index = 0;
                foreach (string i in cbLoaiDM.Items)
                {
                    if (row.Cells["Loai"].Value.ToString().Equals(i))
                    {
                        break;
                    }
                    index++;
                }
                if (index == cbLoaiDM.Items.Count) cbLoaiDM.SelectedIndex = -1;
                else cbLoaiDM.SelectedIndex = index;
            }
        }


        #endregion

        #region QL Ban
        int idBan = 1;
        private void InHoaDon_Click(object sender, EventArgs e)
        {
            if (finalBill == null || listView1.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng xem hóa đơn trước khi xuất!");
                return;
            }

            bool OK = false;
            DialogResult res = MessageBox.Show("In hóa đơn cho bàn " + ((CBBItem)cbbBanAn.SelectedItem).Value + " ?",
                "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                try
                {
                    int idBan = ((CBBItem)cbbBanAn.SelectedItem).Value;
                    int TongTien = Convert.ToInt32(tongtien.Text);
                    foreach (BillChuaTinhTien i in BillsThanhToan)
                    {
                        if (BusinessLogicLayer.Instance.SetHoaDon_BLL(TongTien, i.BillNo))
                        {
                            OK = true;
                        }
                    }
                    if (OK)
                    {
                        Printer_Form f = new Printer_Form(finalBill);
                        f.Show();
                        foreach (BillToAcess i in finalBill)
                        {
                            BusinessLogicLayer.Instance.DeleteBillDetail_BLL(i.BillNo);
                            //chỉ còn 1 bill sau khi gộp nhiều bill để thanh toán
                            for (int j = 0; j < BillsThanhToan.Count - 1; j++)
                            {
                                BusinessLogicLayer.Instance.Del_Bill(BillsThanhToan[j].BillNo);
                            }
                        }
                    }
                    else MessageBox.Show("Failed!");
                    //Xoa bill da thanh toan
                    LayBillChuaThanhToan();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bill: values not found!");
                }
            }
            
        }
        private void Default_Bill(object sender, EventArgs e)
        {
            try
            {
                if (BusinessLogicLayer.Instance.Load_Default_Bill_BLL()) MessageBox.Show("Add susscess");
                else MessageBox.Show("Add Fail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LayBillChuaThanhToan()
        {
            ClearBilldetail();
            lvBill.Items.Clear();
            idBan = ((CBBItem)cbbBanAn.SelectedItem).Value;
            List<BillChuaTinhTien> list = BusinessLogicLayer.Instance.GetTop5BillChuaTinhTien(idBan);
            foreach (BillChuaTinhTien i in list)
            {
                ListViewItem lvi = new ListViewItem(i.BillNo + "");
                lvi.SubItems.Add(i.NgayLapBill + "");
                lvi.Tag = i;
                lvBill.Items.Add(lvi);
            }
        }
        private void ClearBilldetail()
        {
            listView1.Items.Clear();
            tongtien.Text = "";
        }
        private void cbbBanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            finalBill = null;
            LayBillChuaThanhToan();
        }
        private List<BillToAcess> ChiTietHoaDon(List<BillChuaTinhTien> list)
        {
            List<BillToAcess> res = new List<BillToAcess>();
            foreach (BillChuaTinhTien i in list)
            {
                res.AddRange(BusinessLogicLayer.Instance.GetDetail_BillChuaTinTien(i.BillNo));
            }
            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearBilldetail();
            BillsThanhToan = new List<BillChuaTinhTien>();
            if (lvBill.SelectedItems.Count == 0) return;

            foreach (ListViewItem j in lvBill.SelectedItems)
            {
                BillChuaTinhTien bill = j.Tag as BillChuaTinhTien;
                BillsThanhToan.Add(bill);
            }
            finalBill = ChiTietHoaDon(BillsThanhToan);
            int TongTien = 0;
            int index = 1;
            foreach (BillToAcess i in finalBill)
            {
                CurrentBill = i.BillNo;
                string[] row = { index + "", i.TenMon, i.SoLuong.ToString(), i.GiaTien.ToString(), (i.GiaTien * i.SoLuong).ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                TongTien += i.GiaTien * i.SoLuong;
                index++;
            }
            tongtien.Text = TongTien.ToString();
            tongtien.ReadOnly = true;
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count > 1)
            {
                btnXem_tab1.Text = "Gộp hóa đơn";
            }
            else
            {
                btnXem_tab1.Text = "Xem đơn";
            }

        }
        private void btnXoa_tab1_Click(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!");
                return;
            }
            for (int i = 0; i < lvBill.SelectedItems.Count; i++)
            {
                BillChuaTinhTien selectedBill = lvBill.SelectedItems[i].Tag as BillChuaTinhTien;
                DialogResult res = MessageBox.Show("Bàn " + ((CBBItem)cbbBanAn.SelectedItem).Value + " - Xác nhận xóa ID_Bill: " + selectedBill.BillNo + " Time: " + selectedBill.NgayLapBill,
                    "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (BusinessLogicLayer.Instance.DeleteBillDetail_BLL(selectedBill.BillNo))
                    {
                        if (BusinessLogicLayer.Instance.Del_Bill(selectedBill.BillNo))
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                        else MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            LayBillChuaThanhToan();
            ClearBilldetail();
        }

        #endregion


    }
}
