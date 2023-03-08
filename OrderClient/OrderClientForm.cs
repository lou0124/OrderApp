using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderClient
{
    public partial class OrderClientForm : Form
    {
        ClientNetworkHandler clientNetworkHandler = null;
        private int? menuSelectRow = null;
        private int? orderSelectRow = null;
        public OrderClientForm()
        {
            InitializeComponent();
        }

        private void OrderClient_Load(object sender, EventArgs e)
        {
            clientNetworkHandler = new ClientNetworkHandler();
            clientNetworkHandler.connect();
            fillListView(clientNetworkHandler.getMenus());
        }

        private void containButton_Click(object sender, EventArgs e)
        {
            if (menuSelectRow is int valueOfSelectRow)
            {
                ListViewItem listViewItem = new ListViewItem();
                string price = menuList.Items[valueOfSelectRow].SubItems[1].Text;
                listViewItem.Text = menuList.Items[valueOfSelectRow].SubItems[0].Text;
                listViewItem.SubItems.Add("1");
                listViewItem.SubItems.Add(price);
                orderList.Items.Add(listViewItem);
                totalPriceLabel.Text = (int.Parse(totalPriceLabel.Text) + int.Parse(price)).ToString();
                menuSelectRow = null;
            }
        }

        private void fillListView(List<string[]> menus)
        {
            menuList.Items.Clear();
            List<string[]> sortedMenus = menus.OrderBy(p => p[0]).ToList();
            foreach (string[] menu in sortedMenus)
                menuList.Items.Add(new ListViewItem(menu));
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            clientNetworkHandler.order();
        }

        private void menuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuList.SelectedItems.Count != 0)
                menuSelectRow = menuList.SelectedItems[0].Index;
            else
                menuSelectRow = null;
            orderSelectRow = null;
        }

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderList.SelectedItems.Count != 0)
                orderSelectRow = orderList.SelectedItems[0].Index;
            else
                orderSelectRow = null;
            menuSelectRow = null;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (orderSelectRow is int valueOfSelectRow)
            {
                int count = int.Parse(orderList.Items[valueOfSelectRow].SubItems[1].Text);
                int totalPrice = int.Parse(orderList.Items[valueOfSelectRow].SubItems[2].Text);
                int price = totalPrice / count;
                count += 1;
                totalPrice += price;
                totalPriceLabel.Text = (int.Parse(totalPriceLabel.Text) + price).ToString();
                orderList.Items[valueOfSelectRow].SubItems[1].Text = count.ToString();
                orderList.Items[valueOfSelectRow].SubItems[2].Text = totalPrice.ToString();
                orderList.Focus();
                orderList.Items[valueOfSelectRow].Selected = true;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (orderSelectRow is int valueOfSelectRow)
            {
                int count = int.Parse(orderList.Items[valueOfSelectRow].SubItems[1].Text);
                int totalPrice = int.Parse(orderList.Items[valueOfSelectRow].SubItems[2].Text);
                int price = totalPrice / count;
                if (count > 1)
                {
                    count -= 1;
                    totalPrice -= price;
                    totalPriceLabel.Text = (int.Parse(totalPriceLabel.Text) - price).ToString();
                }
                else 
                {
                    orderList.Items.RemoveAt(orderList.SelectedIndices[0]);
                    MessageBox.Show("상품이 취소되었습니다.");
                    return;
                }
                orderList.Items[valueOfSelectRow].SubItems[1].Text = count.ToString();
                orderList.Items[valueOfSelectRow].SubItems[2].Text = totalPrice.ToString();
                orderList.Focus();
                orderList.Items[valueOfSelectRow].Selected = true;
            }
        }
    }
}
