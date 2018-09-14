using HRD_App.Errors;
using HRD_DataLibrary.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD_App.Forms
{
    public partial class BaseForm : Form
    {
        protected void HandleError(Exception exception)
        {
            if (exception is AuthanticationFaildException)
            {
                new AuthorizationForm().ShowDialog();
            }
            else
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}
