using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class MessageYesNo : Form
    {
        public MessageYesNo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public  System.Windows.Forms.DialogResult _btnResult = new DialogResult();
        public Image MessageIcon
        {
            get
            {
                return picIcon.Image;
            }
            set
            {
                picIcon.Image = value;
            }
        }
        public string Message
        {
            get
            {
                return lblMessage.Text;
            }
            set
            {
                lblMessage.Text = value;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            _btnResult = DialogResult.Yes;
            this.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            _btnResult = DialogResult.No;
            this.Dispose();
        }
    }
}
