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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            DataSet dataSet = OrderDbHandler.Instance().getData("tblOrder");
            dataGridView.DataSource = dataSet.Tables[0];
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }
    }
}
