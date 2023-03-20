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
    public partial class ModifyForm : Form
    {
        private int? selectRow = null;
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            fillListView(OrderDbHandler.Instance().ReadTable("tblMenu"));
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (inputCheck("SELECT * FROM tblMenu " +
                           "WHERE menu = '" + menuTextBox.Text + "'"))
            {
                OrderDbHandler.Instance().excuteSql("INSERT INTO tblMenu VALUES ('" + menuTextBox.Text + "', " + priceTextBox.Text + ")");
                fillListView(OrderDbHandler.Instance().ReadTable("tblMenu"));
                MessageBox.Show("메뉴가 추가 되었습니다.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectRow is int valueOfSelectRow)
            {
                OrderDbHandler.Instance().excuteSql("DELETE FROM tblMenu " +
                                         "WHERE  menu_num = " + menuList.Items[valueOfSelectRow].SubItems[0].Text);
                fillListView(OrderDbHandler.Instance().ReadTable("tblMenu"));
                MessageBox.Show("메뉴가 삭제 되었습니다.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string menu_num = menuList.SelectedItems[0].SubItems[0].Text;
            if (menuList.SelectedItems.Count != 0 && inputCheck("SELECT * FROM tblMenu " +
                                                                "WHERE menu = '" + menuTextBox.Text + "' AND menu_num != " + menu_num))
            {
                OrderDbHandler.Instance().excuteSql("UPDATE tblMenu SET menu = '" + menuTextBox.Text + "', price = '" + priceTextBox.Text + "' WHERE menu_num = '" + menu_num + "'");
                fillListView(OrderDbHandler.Instance().ReadTable("tblMenu"));
                MessageBox.Show("메뉴가 수정 되었습니다.");
            }
        }

        private bool inputCheck(string select)
        {
            if (OrderDbHandler.Instance().checkRecord(select))
            {
                MessageBox.Show("중복된 이름의 메뉴가 있습니다.");
                return false;
            }
            else if (!int.TryParse(priceTextBox.Text, out _))
            {
                MessageBox.Show("가격 형식이 잘못 되었습니다.");
                return false;
            }
            return true;
        }

        private void menuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuList.SelectedItems.Count != 0)
            {
                selectRow = menuList.SelectedItems[0].Index;
                menuTextBox.Text = menuList.SelectedItems[0].SubItems[1].Text;
                priceTextBox.Text = menuList.SelectedItems[0].SubItems[2].Text;
            }
            else
                reset();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();
        }

        private void ModifyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void fillListView(List<string[]> menus)
        {
            menuList.Items.Clear();
            List<string[]> sortedMenus = menus.OrderBy(p => p[1]).ToList();
            foreach (string[] menu in sortedMenus)
            {
                menu[0] = menu[0].PadLeft(8, '0');
                menuList.Items.Add(new ListViewItem(menu));
            }
            reset();
        }

        private void reset()
        {
            selectRow = null;
            menuTextBox.Text = "";
            priceTextBox.Text = "";
        }
    }
}
