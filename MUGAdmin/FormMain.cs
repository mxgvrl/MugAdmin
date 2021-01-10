using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUGAdmin
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.order_CompositionTableAdapter.Fill(this.mugDBDataSet.Order_Composition);
            this.additionsTableAdapter.Fill(this.mugDBDataSet.Additions);
            this.productsTableAdapter.Fill(this.mugDBDataSet.Products);
            this.usersTableAdapter.Fill(this.mugDBDataSet.Users);
            this.user_OrderTableAdapter.Fill(this.mugDBDataSet.User_Order);
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManageUser formManageUser = new FormManageUser();
            formManageUser.Show();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManageProduct formManageProduct = new FormManageProduct();
            formManageProduct.Show();
        }

        private void btnAdditionsManage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManageAdditions formManageAddition = new FormManageAdditions();
            formManageAddition.Show();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManageOrders formManageOrders = new FormManageOrders();
            formManageOrders.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManageOrderInfo formManageOrderInfo = new FormManageOrderInfo();
            formManageOrderInfo.Show();
        }
    }
}
