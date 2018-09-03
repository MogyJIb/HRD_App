using HRD_App.Rest;
using HRD_DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD_App
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        
        private void TextBox_Enter(TextBox textBox)
        {
            if (textBox.ForeColor == Color.Black)
                return;
            textBox.Text = "";
            if (textBox.Equals(textBox_password))
                textBox.UseSystemPasswordChar = true;
            textBox.ForeColor = Color.Black;
        }

        private void TextBox_Leave(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                if(textBox.Equals(textBox_password))
                    textBox.UseSystemPasswordChar = false;
                textBox.ForeColor = Color.Gray;
                if (textBox.Equals(textBox_login))
                    textBox.Text = "Логин";
                else
                    textBox.Text = "Пароль";
            }
        }
        
        private void textBox_login_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(textBox_login);
        }

        private void textBox_login_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(textBox_login);
        }
        
        private void textBox_password_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(textBox_password);
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(textBox_password);
        }

        private bool Validate()
        {
            bool isValid=true;
            errorProvider.Clear();

            if (textBox_login.Text == "" || textBox_login.Text == "Логин")
            {
                errorProvider.SetError(textBox_login, "Поле обязательно для заполнения!");
                isValid= false;
            }
            if (textBox_password.Text == "" || textBox_password.Text == "Пароль")
            {
                errorProvider.SetError(textBox_password, "Поле обязательно для заполнения!");
                isValid = false;
            }
            
            return isValid;
        }

        private async void button_authorization_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                IAccountService accountService = new RestApi().AccountService;
                try
                {
                    Account account = new Account();
                    account.Login = textBox_login.Text;
                    account.Password = textBox_password.Text;

                    await accountService.Login(account);
                    MessageBox.Show("Авторизация выполнена");
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.StackTrace);
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
