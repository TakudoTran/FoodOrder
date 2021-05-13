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


namespace AdminForm
{
    public partial class DetailForm : Form
    {

        public int idMonOfMainForm { get; set; }
        public delegate void Mydel(int idDanhMuc, string tenMon);
        public Mydel actionAfterOk { get; set; }
        public DetailForm(int idMon)
        {
            InitializeComponent();
            this.idMonOfMainForm = idMon;
            setCBB();
            setUI();
        }
        private void setUI()
        {
            if (this.idMonOfMainForm != 0)
            {
                Mon mon = BusinessLogicLayer.Instance.GetMonByIdMon(this.idMonOfMainForm);
                txtIdMon.Text = mon.IdMon +"";
                txtTenMon.Text = mon.TenMon;
                txtGiaTien.Text = mon.GiaTien + "";
                txtSoLanGoiMon.Text = mon.SoLanGoiMon + "";
                AnhMinhHoa anh = BusinessLogicLayer.Instance.GetIdAnhByIdAnh(mon.IdAnh);
                picHinhAnh.Image = Image.FromStream(BusinessLogicLayer.Instance.GetByteValuesOfAnh(anh.IdAnh), true);
                picHinhAnh.Image.Tag = anh.IdAnh;
                //  cboLSH.SelectedIndex = s.ID_Lop - 1 ;
                int index = 0;
                foreach (CBBItem i in cboDanhMuc.Items)
                {
                    if (mon.IdDanhMuc == i.Value) break;
                    index++;
                }
                cboDanhMuc.SelectedIndex = index;

                txtIdMon.Enabled = false;
                btnOk.Text = "Update";
            }
            else
            {
                txtIdMon.Text = BusinessLogicLayer.Instance.GetMaxIdMon() + 1 + "";
                txtIdMon.Enabled = false;
                btnOk.Text = "Add";
            }

        }
        private void setCBB()
        {
            BusinessLogicLayer.Instance.SetCbbDetailForm(cboDanhMuc);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Mon mon = new Mon
            {
                IdMon = int.Parse(txtIdMon.Text),
                TenMon = txtTenMon.Text,
                GiaTien = int.Parse(txtGiaTien.Text),
                SoLanGoiMon = int.Parse(txtSoLanGoiMon.Text),
                IdDanhMuc = ((CBBItem)cboDanhMuc.SelectedItem).Value,
                IdAnh = (int)picHinhAnh.Image.Tag
            };

            if (BusinessLogicLayer.Instance.ExcuteDB_BLL(mon, this.idMonOfMainForm))
            {
                DialogResult = DialogResult.OK;
            }
            else DialogResult = DialogResult.Cancel;

            actionAfterOk(0, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "JPG (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
                    string teAnh = openFileDialog.FileName.Substring(openFileDialog.FileName.LastIndexOf("\\"));

                    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs); 
                    byte[] anh = br.ReadBytes((int)fs.Length);
                    BusinessLogicLayer.Instance.ThemAnhVaoDb(teAnh, anh);
                    picHinhAnh.Image.Tag = BusinessLogicLayer.Instance.GetMaxIdAnh();

                }                        
            }
        }
    }
}
