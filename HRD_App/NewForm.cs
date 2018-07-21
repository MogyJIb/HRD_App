using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRD_App.Rest;
using HRD_DataLibrary.Models;

namespace HRD_App
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private async void button_update_Click(object sender, EventArgs e)
        {
            IDepartmentService departmentService = new RestApi().DepartmentService();
            var departments = await departmentService.GetDepartments();
            try
            {         
                label_department.Text = String.Join("\n", departments);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
       
    }
}
