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
        private BindingList<Department> departments;

        public DepartmentsForm()
        {
            InitializeComponent();

            new AuthorizationForm().ShowDialog();

            init();
        }

        public void init()
        {
            departments = new BindingList<Department>();
            dataGridView_departments.DataSource = departments;
            dataGridView_departments.Columns["Deleted"].Visible = false;


            AddDepartments(RestApi.DepartmentService.GetAll(false).Result);
            dataGridView_departments.Refresh();
        }

        private void AddDepartments(List<Department> departments)
        {
            departments
                    .OrderBy(t => t.DepartmentId)
                    .ToList()
                    .ForEach(d => this.departments.Add(d));
        }

        private void UpdateDepartment(Department newDepartment)
        {
            Department oldDepartment = departments
                .Where(d => d.DepartmentId == newDepartment.DepartmentId)
                .FirstOrDefault();

            if (oldDepartment == null) return;

            oldDepartment.Cabinet = newDepartment.Cabinet;
            oldDepartment.Deleted = newDepartment.Deleted;
            oldDepartment.Name = newDepartment.Name;
            oldDepartment.Phone = newDepartment.Phone;
        }

        private void DeleteDepartment(Department department)
        {
            department = departments
                    .Where(d => d.DepartmentId == department.DepartmentId)
                    .FirstOrDefault();

            if (department != null)
                departments.Remove(department);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (departments.Count < 1) return;

            int row = dataGridView_departments.CurrentRow.Index;
            int id = (int)dataGridView_departments[0, row].Value;
            new UpdateDepartmentsForm(id, true)
                .SetOnValueChangedListener(department =>
                {
                    UpdateDepartment(department);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (departments.Count < 1) return;

            DialogResult result= MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int row = dataGridView_departments.CurrentRow.Index;
                int id = (int)dataGridView_departments[0, row].Value;

                try
                {
                    Department department = await RestApi.DepartmentService.Delete(id);
                    DeleteDepartment(department);
                    Filter();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
            }
        }

        private async void button_add_Click(object sender, EventArgs e)
        {
            new UpdateDepartmentsForm(-1, true)
                .SetOnValueChangedListener(department =>
                {
                    departments.Add(department);
                    Filter();
                })
                .ShowDialog();
        }

        private async void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            string pattern = textBox_search.Text;
            if (pattern == "" || pattern == "Поиск")
                dataGridView_departments.DataSource = departments;
            else
                dataGridView_departments.DataSource =
                    departments.Where(d => d.DepartmentId.ToString().Contains(pattern)
                                                || d.Name.Contains(pattern)
                                                || d.Phone.Contains(pattern)
                                                || d.Cabinet.ToString().Contains(pattern)
                                ).ToList();
        }


        private void textBox_search_Enter(object sender, EventArgs e)
        {
            if (textBox_search.ForeColor == Color.Black)
                return;
            textBox_search.Text = "";
            textBox_search.ForeColor = Color.Black;
        }

        private void textBox_search_Leave(object sender, EventArgs e)
        {
            if (textBox_search.Text == "")
            {
                textBox_search.ForeColor = Color.Gray;
                textBox_search.Text = "Поиск";
            }
        }
    }
}