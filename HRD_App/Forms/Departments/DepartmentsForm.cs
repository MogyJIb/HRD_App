using HRD_App.Errors;
using HRD_App.Rest;
using HRD_App.Utils;
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

            AddDepartments();
        }

        private void AddDepartments()
        {
            try
            {
                var departments = RestApi.DepartmentService.GetAll(false).Result;
                departments = departments.OrderBy(t => t.Name).ToList();

                dataGridView_departments.Rows.Clear();
                foreach (Department department in departments)
                    AddDepartment(department);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
            }
        }

        private void AddDepartment(Department department)
        {
            dataGridView_departments.Rows.Add(
                           new object[]
                           {
                                department.DepartmentId,
                                department.Name,
                                department.Cabinet,
                                department.Phone
                           });
        }

        private void UpdateDepartment(Department department, int row)
        {
            dataGridView_departments.Rows.RemoveAt(row);
            dataGridView_departments.Rows.Insert(row, 
                           new object[]
                           {
                                department.DepartmentId,
                                department.Name,
                                department.Cabinet,
                                department.Phone
                           });
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int row = dataGridView_departments.CurrentRow.Index;
            int id = (int)dataGridView_departments[0, row].Value;
            new UpdateDepartmentsForm(id, true)
                .SetOnValueChangedListener(department => UpdateDepartment(department, row))
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            int row = dataGridView_departments.CurrentRow.Index;
            int id = (int)dataGridView_departments[0, row].Value;
            await RestApi.DepartmentService.Delete(id);
            dataGridView_departments.Rows.RemoveAt(row);
        }

        private async void button_add_Click(object sender, EventArgs e)
        {
            new UpdateDepartmentsForm(-1, true)
                .SetOnValueChangedListener(department => AddDepartment(department))
                .ShowDialog();
        }
    }
}
