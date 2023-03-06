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
    public partial class LoginForm : Form
    {
        List<string[]> accounts; 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (string[] account in accounts)
                if (idTextBox.Text == account[0] && pwTextBox.Text == account[1])
                    success = true;

            if (success)
            {
                this.Visible = false;
                HomeForm homeForm = new HomeForm();
                homeForm.ShowDialog();
                homeForm.Dispose();
                this.Dispose();
            }
            else
                MessageBox.Show("로그인에 실패하였습니다.");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            accounts = OrderDbHandler.ReadTable("tblAccount");
        }
    }
}
