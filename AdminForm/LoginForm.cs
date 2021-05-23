using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void form_close(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void form_unhide(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void ptadmin_Click(object sender, EventArgs e)
        {
            LogToAdmin lta = new LogToAdmin();
            lta.FormClosed += new FormClosedEventHandler(form_unhide);
            lta.Show();
            this.Hide();
        }

        private void ptcustomer_Click(object sender, EventArgs e)
        {
            OrderForm odf = new OrderForm();
            odf.FormClosed += new FormClosedEventHandler(form_close);
            odf.Show();
            this.Hide();
        }

        private void ptEixt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
