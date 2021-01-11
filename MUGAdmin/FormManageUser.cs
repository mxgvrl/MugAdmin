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
    public partial class FormManageUser : Form
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

        public FormManageUser()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mugDBDataSet);
        }

        private void FormManageUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mugDBDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.mugDBDataSet.Users);

            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select id from Users;";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    cbIdDelete.Items.Add(dataReader[i].ToString());
                }
            }
            connection.Close();
        }

        private void comboboxEditFields (string query, TextBox tb)
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbUserNameAdd.Text != "" && tbUserPasswordAdd.Text != "" && tbAdressAdd.Text != "" && cbRoleAdd.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"insert into Users values(" +
                    $"'{tbUserNameAdd.Text}', " +
                    $"'{tbUserPasswordAdd.Text}', " +
                    $"'{tbAdressAdd.Text}', " +
                    $"'{cbRoleAdd.Text}');";

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

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand();
            command.CommandText = $"delete from Users where Users.id = {cbIdDelete.Text};";
            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void cbIdEdit_Click(object sender, EventArgs e)
        {
            cbIdEdit.Items.Clear();
            connection.Open();
            var command1 = connection.CreateCommand();
            command1.CommandText = $"select id from Users;";
            var dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                for (var i = 0; i < dataReader1.FieldCount; i++)
                {
                    cbIdEdit.Items.Add(dataReader1[i].ToString());
                }
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void cbIdEdit_TextChanged(object sender, EventArgs e)
        {
            comboboxEditFields($"select userName from Users where id = {cbIdEdit.Text}", tbUserNameEdit);
            comboboxEditFields($"select userPassword from Users where id = {cbIdEdit.Text}", tbUserPasswordEdit);
            comboboxEditFields($"select adress from Users where id = {cbIdEdit.Text}", tbAdressEdit);
            comboboxEditCombobox($"select userRole from Users where id = {cbIdEdit.Text}", cbRoleEdit);
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            if (tbUserNameEdit.Text != "" && tbUserPasswordEdit.Text != "" && tbAdressEdit.Text != "" && cbRoleEdit.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"UPDATE Users " +
                    $"SET userName = '{tbUserNameEdit.Text}', userPassword = '{tbUserPasswordEdit.Text}', adress = '{tbAdressEdit.Text}', userRole = '{cbRoleEdit.Text}'" +
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

        private void cbIdDelete_Click(object sender, EventArgs e)
        {
            cbIdDelete.Items.Clear();
            connection.Open();
            var command1 = connection.CreateCommand();
            command1.CommandText = $"select id from Users;";
            var dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {
                for (var i = 0; i < dataReader1.FieldCount; i++)
                {
                    cbIdDelete.Items.Add(dataReader1[i].ToString());
                }
            }
            connection.Close();
        }

        private void cbIdDelete_TextChanged(object sender, EventArgs e)
        {
            comboboxEditFields($"select userName from Users where id = {cbIdDelete.Text}", tbUserNameDelete);
            comboboxEditFields($"select userPassword from Users where id = {cbIdDelete.Text}", tbUserPasswordDelete);
            comboboxEditFields($"select adress from Users where id = {cbIdDelete.Text}", tbAdressDelete);
            comboboxEditFields($"select userRole from Users where id = {cbIdDelete.Text}", tbRoleDelete);
        }

        private void FormManageUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            FormMain.currentForm = formMain.Name;
        }
    }
}
