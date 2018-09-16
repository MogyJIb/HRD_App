using HRD_App.Errors;
using HRD_App.Forms;
using HRD_App.Rest;
using HRD_DataLibrary.Errors;
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

            textBox_login.Text = textBox_password.Text = "admin";
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
            if (!Validate()) return;

            try
            {
                Account account = new Account();
                account.Login = textBox_login.Text;
                account.Password = textBox_password.Text;

                await Authenticator.Login(account);
                Close();
            }
            catch (ApiException exception)
            {
                switch(exception.ErrorType)
                {
                    case ErrorType.NonExistentLogin:
                        errorProvider.SetError(textBox_login, exception.Message);
                        break;
                    case ErrorType.WrongPassword:
                        errorProvider.SetError(textBox_password, exception.Message);
                        break;
                    default:
                        Console.WriteLine(exception.Message);
                        Console.WriteLine(exception.StackTrace);
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}
