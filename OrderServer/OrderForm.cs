using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderServer
{
    public partial class OrderForm : System.Windows.Forms.Form
    {
        private int? selectRow = null;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ServerNetworkHandler.Instance().available();
            fillListView(OrderDbHandler.ReadTable("tblOrder"));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServerNetworkHandler.Instance().unavailable();
            this.Owner.Visible = true;
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            if (selectRow is int valueOfSelectRow)
            {
                OrderDbHandler.excuteSql("DELETE FROM tblOrder WHERE order_num = " + orderList.Items[valueOfSelectRow].SubItems[0].Text);
                orderList.Items.RemoveAt(orderList.SelectedIndices[0]);
                MessageBox.Show("주문음식이 취소 되었습니다.");
                selectRow = null;
            }
        }

        private void fillListView(List<string[]> orders)
        {
            orderList.Items.Clear();
            foreach (string[] order in orders)
                orderList.Items.Add(new ListViewItem(order));
        }

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderList.SelectedItems.Count != 0)
                selectRow = orderList.SelectedItems[0].Index;
            else
                selectRow = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            OrderDbHandler.excuteSql("INSERT INTO tblOrder VALUES (100, 100, '사이다', 2, '" + DateTime.Now.ToString(format)  + "')");
            fillListView(OrderDbHandler.ReadTable("tblOrder"));
        }
    }
}
