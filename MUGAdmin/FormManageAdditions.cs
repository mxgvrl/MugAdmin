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
    public partial class FormManageAdditions : Form
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

        public FormManageAdditions()
        {
            InitializeComponent();
        }

        private void additionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.additionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mugDBDataSet);

        }

        private void FormManageAdditions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mugDBDataSet.Additions". При необходимости она может быть перемещена или удалена.
            this.additionsTableAdapter.Fill(this.mugDBDataSet.Additions);

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

        private void btnAddAddition_Click(object sender, EventArgs e)
        {
            if (tbAdditionNameAdd.Text != "" && tbAdditionCountAdd.Text != "" && tbCostAdd.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"insert into Additions values(" +
                    $"'{tbAdditionNameAdd.Text}', " +
                    $"{tbAdditionCountAdd.Text}, " +
                    $"{tbCostAdd.Text});";

                command.Connection = connection;
                connection.Open();
                command.ExecuteScalar();
                connection.Close();

                MessageBox.Show("Added succesfully");
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }

        private void btnBackAdditionManage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void cbIdDelete_TextChanged(object sender, EventArgs e)
        {
            comboboxEditFields($"select additionName from Additions where additionName = '{cbIdDelete.Text}'", tbAdditionNameDelete);
            comboboxEditFields($"select additionCount from Additions where additionName = '{cbIdDelete.Text}'", tbAdditionCountDelete);
            comboboxEditFields($"select cost from Additions where additionName = '{cbIdDelete.Text}'", tbCostDelete);
        }

        private void cbIdDelete_Click(object sender, EventArgs e)
        {
            cbIdDelete.Items.Clear();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select additionName from Additions;";
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

        private void btnEditAddition_Click(object sender, EventArgs e)
        {
            if (tbAdditionNameEdit.Text != "" && tbAdditionCountEdit.Text != "" && tbCostEdit.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"UPDATE Additions " +
                    $"SET additionName = '{tbAdditionNameEdit.Text}', additionCount = {tbAdditionCountEdit.Text}, cost = {tbCostEdit.Text} " +
                    $"WHERE additionName = '{cbIdEdit.Text}';";
                command.Connection = connection;
                connection.Open();
                command.ExecuteScalar();
                connection.Close();

                MessageBox.Show("Edited succesfully");
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }   
        }

        private void cbIdEdit_Click(object sender, EventArgs e)
        {
            cbIdEdit.Items.Clear();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select additionName from Additions;";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    cbIdEdit.Items.Add(dataReader[i].ToString());
                }
            }
            connection.Close();
        }

        private void cbIdEdit_TextChanged(object sender, EventArgs e)
        {
            comboboxEditFields($"select additionName from Additions where additionName = '{cbIdEdit.Text}'", tbAdditionNameEdit);
            comboboxEditFields($"select additionCount from Additions where additionName = '{cbIdEdit.Text}'", tbAdditionCountEdit);
            comboboxEditFields($"select cost from Additions where additionName = '{cbIdEdit.Text}'", tbCostEdit);
        }

        private void btnDeleteAddition_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand();
            command.CommandText = $"delete from Additions where Additions.additionName = '{cbIdDelete.Text}';";

            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            MessageBox.Show("Deleted succesfully");
        }

        private void tbAdditionCountAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbCostAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbAdditionCountDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbCostDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbAdditionCountEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tbCostEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void FormManageAdditions_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            FormMain.currentForm = formMain.Name;
        }
    }
}
