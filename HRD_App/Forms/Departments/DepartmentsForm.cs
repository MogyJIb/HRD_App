using HRD_App.Errors;
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

namespace HRD_App.Forms
{
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();

            new AuthorizationForm().ShowDialog();

            init();
        }

        private async void init()
        {
            try
            {
                var departments = await RestApi.DepartmentService.GetDepartments();
                MessageBox.Show(string.Join<Department>(",  ", departments.ToArray()));
            }
            catch(ApiException exception)
            {
                MessageBox.Show(exception.ErrorType + "    " + exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
