using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderServer
{
    public partial class HomeForm : System.Windows.Forms.Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void orderModeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OrderForm orderForm = new OrderForm();
            orderForm.Owner = this;
            orderForm.ShowDialog();
            orderForm.Dispose();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void modifyModeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.Owner = this;
            modifyForm.ShowDialog();
            modifyForm.Dispose();
        }
    }
}
