using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace AdminForm
{
    public partial class ImagesForm : Form
    {
        public delegate void MyDel(int idAnh);
        public MyDel afterOk { get; set; }
        public ImagesForm()
        {
            InitializeComponent();
            dgvDanhSachAnh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ImagesForm_Load(object sender, EventArgs e)
        {
            dgvDanhSachAnh.DataSource = BusinessLogicLayer.Instance.GetAllAnhMinhHoa();
            dgvDanhSachAnh.Columns["Anh"].Visible = false;
            dgvDanhSachAnh.Columns["IdAnh"].Visible = false;
        }

        private void dgvDanhSachAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachAnh.Rows[e.RowIndex];
                int idAnh = int.Parse(row.Cells["IdAnh"].Value.ToString());
                picAnh.Image = Image.FromStream(BusinessLogicLayer.Instance.GetByteValuesOfAnh(idAnh), true);
                picAnh.Image.Tag = idAnh;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(picAnh.Image == null)
            {
                MessageBox.Show("Chưa chọn ảnh!");
                return;
            }
            afterOk((int)picAnh.Image.Tag);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDanhSachAnh.DataSource = BusinessLogicLayer.Instance.GetAnhMinhHoaByTenAnh(txtSearch.Text);
            dgvDanhSachAnh.Columns["Anh"].Visible = false;
            dgvDanhSachAnh.Columns["IdAnh"].Visible = false;
        }
    }
}
