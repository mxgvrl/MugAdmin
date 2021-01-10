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
    public partial class FormManageOrders : Form
    {

        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

        public FormManageOrders()
        {
            InitializeComponent();
        }

        private void FormManageOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mugDBDataSet.User_Order". При необходимости она может быть перемещена или удалена.
            this.user_OrderTableAdapter.Fill(this.mugDBDataSet.User_Order);

        }

        private void comboboxEditFields(string query, TextBox tb)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"{query}";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                tb.Text = dataReader[0].ToString();
            }
            connection.Close();
        }

        private void comboboxDropDownInfo (string query, ComboBox cb)
        {
            cb.Items.Clear();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"{query}";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    cb.Items.Add(dataReader[i].ToString());
                }
            }
            connection.Close();
        }

        private void cbNameAdd_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select userName from Users;", cbNameAdd);
        }

        private void cbNameDelete_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select userName from Users;", cbNameDelete);
        }

        private void cbNameEdit_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select userName from Users;", cbNameEdit);
        }

        private void cbIdDelete_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select id from UserOrder;", cbIdDelete);
        }

        private void cbIdEdit_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select id from UserOrder;", cbIdEdit);
        }

        private void cbIdDelete_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select orderDate from User_Order where id = {cbIdDelete.Text}";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                dtpDateDelete.Text = dataReader[0].ToString();
            }
            connection.Close();

            connection.Open();
            var command1 = connection.CreateCommand();
            command1.CommandText = $"select userName from User_Order where id = {cbIdDelete.Text}";
            var dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                cbNameDelete.Text = dataReader1[0].ToString();
            }
            connection.Close();
        }

        private void cbIdEdit_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select orderDate from UserOrder where id = {cbIdEdit.Text}";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                dtpDateEdit.Text = dataReader[0].ToString();
            }
            connection.Close();

            connection.Open();
            var command1 = connection.CreateCommand();
            command1.CommandText = $"select userName from User_Order where id = {cbIdEdit.Text}";
            var dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                cbNameEdit.Text = dataReader1[0].ToString();
            }
            connection.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand();
            command.CommandText = $"insert into UserOrder (orderDate, userId) values(" +
                $"'{dtpDateAdd.Value}', " +
                $"(select userId from UserOrder where userId = (select id from Users where userName = '{cbNameAdd.Text}') ) );";

            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand();
            command.CommandText = $"delete from UserOrder where UserOrder.id = {cbIdDelete.Text};";

            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand();
            command.CommandText = $"UPDATE UserOrder " +
                $"SET userId = (select userId from UserOrder where userId = (select id from Users where userName = '{cbNameEdit.Text}') ), orderDate = '{dtpDateEdit.Value}' " +
                $"WHERE id = {cbIdEdit.Text};";
            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnBackOrderManage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
