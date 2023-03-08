using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderServer
{
    public partial class OrderForm : System.Windows.Forms.Form
    {
        private int? selectRow = null;
        private int orderNumber = 1;
        private int clientNumber = 1;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ServerNetworkHandler.Instance().available(addOrder);
        }

        private void addOrder(List<string[]> orders)
        {
            foreach (string[] order in orders)
            {
                string orderNum = orderNumber.ToString();
                string clientNum = clientNumber.ToString();
                string menu = order[0];
                string count = order[1];
                string totalPrice = order[2];
                string orderTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string orderKey = DateTime.Now.ToString("yyyyMMddHHmmss") + orderNum.PadLeft(3, '0');

                OrderDbHandler.excuteSql("INSERT INTO tblOrder " +
                    "VALUES ('" + orderKey + "', " + orderNum + ", " + clientNum + ", '" + menu + "', " + count + ", " + totalPrice + ", '"+ orderTime + "')");

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = orderNum;
                listViewItem.SubItems.Add(clientNum);
                listViewItem.SubItems.Add(menu);
                listViewItem.SubItems.Add(count);
                listViewItem.SubItems.Add(orderTime);
                orderList.Items.Add(listViewItem);
                orderNumber = (orderNumber + 1) % 1000;
            }
            clientNumber = (clientNumber + 1) % 1000;
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

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderList.SelectedItems.Count != 0)
                selectRow = orderList.SelectedItems[0].Index;
            else
                selectRow = null;
        }
    }
}
