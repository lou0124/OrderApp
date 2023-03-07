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
        public OrderClientForm()
        {
            InitializeComponent();
        }

        private void OrderClient_Load(object sender, EventArgs e)
        {
            clientNetworkHandler = new ClientNetworkHandler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientNetworkHandler.getMenus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientNetworkHandler.order();
        }
    }
}
