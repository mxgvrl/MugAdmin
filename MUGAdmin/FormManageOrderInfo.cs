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
    public partial class FormManageOrderInfo : Form
    {

        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

        public FormManageOrderInfo()
        {
            InitializeComponent();
        }

        private void FormManageOrderInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mugDBDataSet.Order_Composition". При необходимости она может быть перемещена или удалена.
            this.order_CompositionTableAdapter.Fill(this.mugDBDataSet.Order_Composition);

        }

        private void comboboxEditCombobox(string query, ComboBox cb)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"{query}";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cb.Text = dataReader[0].ToString();
            }
            connection.Close();
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

        private void comboboxDropDownInfo(string query, ComboBox cb)
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

        private void cbUserAdd_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select userName from Users;", cbUserAdd);
        }

        private void cbProductAdd_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select productName from Products;", cbProductAdd);
        }

        private void cbAdditionAdd_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select additionName from Additions;", cbAdditionAdd);
        }

        private void cbIdDelete_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select id from Order_Composition;", cbIdDelete);
        }

        private void cbUserDelete_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select userName from Users;", cbUserDelete);
        }

        private void cbProductDelete_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select productName from Products;", cbProductDelete);
        }

        private void cbAdditionDelete_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select additionName from Additions;", cbAdditionDelete);
        }

        private void cbIdEdit_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select id from Order_Composition;", cbIdEdit);
        }

        private void cbUserEdit_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select userName from Users;", cbUserEdit);
        }

        private void cbProductEdit_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select productName from Products;", cbProductEdit);
        }

        private void cbAdditionEdit_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select additionName from Additions;", cbAdditionEdit);
        }

        private void cbOrderAdd_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select id from UserOrder;", cbOrderAdd);
        }

        private void cbOrderDelete_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select id from UserOrder;", cbOrderDelete);
        }

        private void cbOrderEdit_Click(object sender, EventArgs e)
        {
            comboboxDropDownInfo("select id from UserOrder;", cbOrderEdit);
        }

        private void cbOrderAdd_TextChanged(object sender, EventArgs e)
        {
            comboboxEditCombobox($"select userName from Users where id = (select userId from UserOrder where id = {cbOrderAdd.Text}) ", cbUserAdd);
        }

        private void cbIdDelete_TextChanged(object sender, EventArgs e)
        {
            comboboxEditCombobox($"select orderId from OrderComposition where id = {cbIdDelete.Text} ", cbOrderDelete);
            comboboxEditCombobox($"select userName from Users where id = (select userId from UserOrder where id = {cbOrderDelete.Text}) ", cbUserDelete);
            comboboxEditCombobox($"select productName from Products where id = (select productId from OrderComposition where id = {cbIdDelete.Text}) ", cbProductDelete);
            comboboxEditCombobox($"select additionName from Additions where id = (select additionId from OrderComposition where id = {cbIdDelete.Text}) ", cbAdditionDelete);
            comboboxEditFields($"select orderCount from OrderComposition where id = {cbIdDelete.Text} ", tbCountDelete);
        }

        private void cbIdEdit_TextChanged(object sender, EventArgs e)
        {
            comboboxEditCombobox($"select orderId from OrderComposition where id = {cbIdEdit.Text} ", cbOrderEdit);
            comboboxEditCombobox($"select userName from Users where id = (select userId from UserOrder where id = {cbOrderEdit.Text}) ", cbUserEdit);
            comboboxEditCombobox($"select productName from Products where id = (select productId from OrderComposition where id = {cbIdEdit.Text}) ", cbProductEdit);
            comboboxEditCombobox($"select additionName from Additions where id = (select additionId from OrderComposition where id = {cbIdEdit.Text}) ", cbAdditionEdit);
            comboboxEditFields($"select orderCount from OrderComposition where id = {cbIdEdit.Text} ", tbCountEdit);
        }

        private void btnAddOrderInfo_Click(object sender, EventArgs e)
        {
            if (cbUserAdd.Text != "" && cbProductAdd.Text != "" && cbAdditionAdd.Text != "" && tbCountAdd.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"insert into OrderComposition values(" +
                    $"(select id from UserOrder where id = {cbOrderAdd.Text}), " +
                    $"(select id from Products where productName = '{cbProductAdd.Text}'), " +
                    $"(select id from Additions where additionName = '{cbAdditionAdd.Text}'), " +
                    $"{tbCountAdd.Text});";
                command.Connection = connection;
                connection.Open();
                command.ExecuteScalar();
                connection.Close();

                this.Close();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void btnDeleteOrderInfo_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand();
            command.CommandText = $"delete from OrderComposition where OrderComposition.id = {cbIdDelete.Text};";

            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnEditOrderInfo_Click(object sender, EventArgs e)
        {
            if (cbUserEdit.Text != "" && cbProductEdit.Text != "" && cbAdditionEdit.Text != "" && tbCountEdit.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"UPDATE OrderComposition " +
                    $"SET " +
                    $"orderId = (select id from UserOrder where id = {cbOrderEdit.Text}), " +
                    $"productId = (select id from Products where productName = '{cbProductEdit.Text}'), " +
                    $"additionId = (select id from Additions where additionName = '{cbAdditionEdit.Text}'), " +
                    $"orderCount = {tbCountEdit.Text} " +
                    $"WHERE id = {cbIdEdit.Text};";
                command.Connection = connection;
                connection.Open();
                command.ExecuteScalar();
                connection.Close();

                this.Close();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void btnBackOrderInfoManage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void tbCountAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbCountDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbCountEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void FormManageOrderInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            FormMain.currentForm = formMain.Name;
        }
    }
}
