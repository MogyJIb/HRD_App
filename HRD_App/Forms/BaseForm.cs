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
            if (exception is ApiException &&
                ((ApiException)exception).ErrorType == ErrorType.AuthanticationFaild)
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
