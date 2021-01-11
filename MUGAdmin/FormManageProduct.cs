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
    public partial class FormManageProduct : Form
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

        public FormManageProduct()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mugDBDataSet);
        }

        private void FormManageProduct_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.mugDBDataSet.Products);
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

        string filename = "";

        private void btnOpenFileAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            label6.Text = filename;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (tbProductNameAdd.Text != "" && filename != "" && tbGradeAdd.Text != "" && tbVolumeAdd.Text != "" && tbCompositionAdd.Text != "" && tbCostAdd.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"insert into Products (productName, grade, volume, composition, cost, productImage) " +
                    $"SELECT '{tbProductNameAdd.Text}', '{tbGradeAdd.Text}', {tbVolumeAdd.Text}, '{tbCompositionAdd.Text}', {tbCostAdd.Text}, BulkColumn " +
                    $"FROM Openrowset(Bulk '{filename}', Single_Blob) as img";

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
            command.CommandText = $"delete from Products where Products.id = {cbIdDelete.Text};";

            command.Connection = connection;
            connection.Open();
            command.ExecuteScalar();
            connection.Close();

            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void cbIdDelete_Click(object sender, EventArgs e)
        {
            cbIdDelete.Items.Clear();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select id from Products;";
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

        private void cbIdDelete_TextChanged(object sender, EventArgs e)
        {
            comboboxEditFields($"select productName from Products where id = {cbIdDelete.Text}", tbProductNameDelete);
            comboboxEditFields($"select grade from Products where id = {cbIdDelete.Text}", tbGradeDelete);
            comboboxEditFields($"select volume from Products where id = {cbIdDelete.Text}", tbVolumeDelete);
            comboboxEditFields($"select composition from Products where id = {cbIdDelete.Text}", tbCompositionDelete);
            comboboxEditFields($"select cost from Products where id = {cbIdDelete.Text}", tbCostDelete);
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (tbProductNameEdit.Text != "" && filename != "" && tbGradeEdit.Text != "" && tbVolumeEdit.Text != "" && tbCompositionEdit.Text != "" && tbCostEdit.Text != "")
            {
                var command = new SqlCommand();
                command.CommandText = $"UPDATE Products " +
                    $"SET productName = '{tbProductNameEdit.Text}', " +
                    $"grade = '{tbGradeEdit.Text}', " +
                    $"volume = {tbVolumeEdit.Text}, " +
                    $"composition = '{tbCompositionEdit.Text}', " +
                    $"cost = {tbCostEdit.Text}, " +
                    $"productImage = (SELECT BulkColumn FROM Openrowset(Bulk '{filename}', Single_Blob) as img)" +
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

        private void cbIdEdit_Click(object sender, EventArgs e)
        {
            cbIdEdit.Items.Clear();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select id from Products;";
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
            comboboxEditFields($"select productName from Products where id = {cbIdEdit.Text}", tbProductNameEdit);
            comboboxEditFields($"select grade from Products where id = {cbIdEdit.Text}", tbGradeEdit);
            comboboxEditFields($"select volume from Products where id = {cbIdEdit.Text}", tbVolumeEdit);
            comboboxEditFields($"select composition from Products where id = {cbIdEdit.Text}", tbCompositionEdit);
            comboboxEditFields($"select cost from Products where id = {cbIdEdit.Text}", tbCostEdit);
        }

        private void btnOpenFileUpdate_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            label1.Text = filename;
        }

        private void btnBackUserManage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void tbVolumeAdd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbVolumeEdit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormManageProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            FormMain.currentForm = formMain.Name;
        }
    }
}
