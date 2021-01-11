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
        public static string currentForm = "";
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
            FormManageUser formManageUser = new FormManageUser();
            formManageUser.Show();
            currentForm = formManageUser.Name;
            this.Close();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            FormManageProduct formManageProduct = new FormManageProduct();
            formManageProduct.Show();
            currentForm = formManageProduct.Name;
            this.Close();
        }

        private void btnAdditionsManage_Click(object sender, EventArgs e)
        {
            FormManageAdditions formManageAddition = new FormManageAdditions();
            formManageAddition.Show();
            currentForm = formManageAddition.Name;
            this.Close();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            FormManageOrders formManageOrders = new FormManageOrders();
            formManageOrders.Show();
            currentForm = formManageOrders.Name;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManageOrderInfo formManageOrderInfo = new FormManageOrderInfo();
            formManageOrderInfo.Show();
            currentForm = formManageOrderInfo.Name; 
            this.Close();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnBackToLoginTab2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnBackToLoginTab3_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnBackToLoginTab4_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnBackToLoginTab5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (currentForm == this.Name)
            {
                Application.Exit();
            }
        }
    }
}
