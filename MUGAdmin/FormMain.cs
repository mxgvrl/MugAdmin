using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUGAdmin
{
    public partial class FormMain : Form
    {
        public static string currentForm = "FormMain";
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

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

        private void idComboBox_Click(object sender, EventArgs e)
        {
            cbOrderId.Items.Clear();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select id from OrderComposition";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    cbOrderId.Items.Add(dataReader[i].ToString());
                }
            }
            connection.Close();
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand();
            command.CommandText = $"update OrderComposition set isDone = 'Done' " +
                $"where id = {cbOrderId.Text};";

            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            currentForm = "FormManageOrderInfo";
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
            currentForm = this.Name;
        }
    }
}
