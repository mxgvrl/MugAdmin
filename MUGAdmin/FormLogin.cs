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
    public partial class FormLogin : Form
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MugDB;Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isUserCorrect = false;
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from Users where userName = '{tbUsername.Text}';";
            var dataReader = command.ExecuteReader();
            if (dataReader.HasRows) 
            { 
               isUserCorrect = true;
            }
            connection.Close();

            if (isUserCorrect == true)
            {
                connection.Open();
                var command1 = connection.CreateCommand();
                command1.CommandText = $"select * from Users where userPassword = '{tbPassword.Text}';";
                var dataReader1 = command1.ExecuteReader();
                if (dataReader1.HasRows)
                {
                    this.Hide();
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Username is incorrect");
            }
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
            }
            underline1.BackColor = Color.FromArgb(239, 198, 160);
        }

        private void tbUsername_MouseLeave(object sender, EventArgs e)
        {
            underline1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
            }
            tbPassword.PasswordChar = '*';
            underline2.BackColor = Color.FromArgb(239, 198, 160);
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            underline2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Black;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.Black;
        }

        private void linkSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
