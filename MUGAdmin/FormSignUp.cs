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
    public partial class FormSignUp : Form
    {

        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
            }
            underline1.BackColor = Color.FromArgb(239, 198, 160);
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
            }
            tbPassword.PasswordChar = '*';
            underline3.BackColor = Color.FromArgb(239, 198, 160);
        }

        private void tbPasswordConfirm_Click(object sender, EventArgs e)
        {
            if (tbPasswordConfirm.Text == "Confirm password")
            {
                tbPasswordConfirm.Text = "";
            }
            tbPasswordConfirm.PasswordChar = '*';
            underline4.BackColor = Color.FromArgb(239, 198, 160);
        }

        private void tbUsername_MouseLeave(object sender, EventArgs e)
        {
            underline1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            underline3.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void tbPasswordConfirm_MouseLeave(object sender, EventArgs e)
        {
            underline4.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.Black;
            btnSignUp.ForeColor = Color.White;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.ForeColor = Color.Black;
        }

        private void linkSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text != "Username" && tbUsername.Text != "") && 
                (tbPassword.Text != "Password" && tbPassword.Text != "") && 
                tbPasswordConfirm.Text != "")
            {
                bool isUsernameFree = true;
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $"select * from Users where userName = '{tbUsername.Text}';";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    isUsernameFree = false;
                    MessageBox.Show("Choose another username");
                }
                connection.Close();
                if (isUsernameFree == true)
                {
                    if (tbPassword.Text == tbPasswordConfirm.Text)
                    {
                        var command1 = new SqlCommand();
                        command1.CommandText = $"insert into Users (userName, userPassword, userRole) values(" +
                            $"'{tbUsername.Text}', " +
                            $"'{tbPassword.Text}', " +
                            $"'admin');";

                        command1.Connection = connection;
                        connection.Open();
                        command1.ExecuteScalar();
                        connection.Close();

                        this.Close();
                        FormMain formMain = new FormMain();
                        formMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Passwords are not match");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        }
    }
}
