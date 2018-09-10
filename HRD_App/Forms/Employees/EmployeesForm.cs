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
    public partial class EmployeesForm : Form
    {
        private BindingList<Employee> employees;

        public EmployeesForm()
        {
            InitializeComponent();

            new AuthorizationForm().ShowDialog();

            init();
        }

        public void init()
        {
            employees = new BindingList<Employee>();
            dataGridView_employees.DataSource = employees;
            dataGridView_employees.Columns["Deleted"].Visible = false;


            AddEmployees(RestApi.EmployeeService.GetAll(false).Result);
            dataGridView_employees.Refresh();
        }

        private void AddEmployees(List<Employee> employees)
        {
            employees
                    .OrderBy(t => t.EmployeeId)
                    .ToList()
                    .ForEach(d => this.employees.Add(d));
        }

        private void UpdateEmployee(Employee newEmployee)
        {
            Employee oldEmployee = employees
                .Where(d => d.EmployeeId == newEmployee.EmployeeId)
                .FirstOrDefault();

            if (oldEmployee == null) return;

            oldEmployee.PositionId = newEmployee.PositionId;
            oldEmployee.Deleted = newEmployee.Deleted;
            oldEmployee.FirstName = newEmployee.FirstName;
            oldEmployee.LastName = newEmployee.LastName;
            oldEmployee.Patronymic = newEmployee.Patronymic;
            oldEmployee.BirthDate = newEmployee.BirthDate;
            oldEmployee.Address = newEmployee.Address;
            oldEmployee.Phone = newEmployee.Phone;
            oldEmployee.Education = newEmployee.Education;
            oldEmployee.EmploymentDate = newEmployee.EmploymentDate;
        }

        private void DeleteEmployee(Employee employee)
        {
            employee = employees
                    .Where(d => d.EmployeeId == employee.EmployeeId)
                    .FirstOrDefault();

            if (employee != null)
                employees.Remove(employee);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (employees.Count < 1) return;

            int row = dataGridView_employees.CurrentRow.Index;
            int id = (int)dataGridView_employees[0, row].Value;
            new UpdateEmployeesForm(id, true)
                .SetOnValueChangedListener(employee =>
                {
                    UpdateEmployee(employee);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (employees.Count < 1) return;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int row = dataGridView_employees.CurrentRow.Index;
                int id = (int)dataGridView_employees[0, row].Value;

                try
                {
                    Employee employee = await RestApi.EmployeeService.Delete(id);
                    DeleteEmployee(employee);
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
            new UpdateEmployeesForm(-1, true)
                .SetOnValueChangedListener(employee =>
                {
                    employees.Add(employee);
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
                dataGridView_employees.DataSource = employees;
            else
                dataGridView_employees.DataSource =
                    employees.Where(d => d.EmployeeId.ToString().Contains(pattern)
                                                || d.FirstName.Contains(pattern)
                                                || d.LastName.ToString().Contains(pattern)
                                                || d.Patronymic.Contains(pattern)
                                                || d.BirthDate.ToString().Contains(pattern)
                                                || d.Address.ToString().Contains(pattern)
                                                || d.Phone.Contains(pattern)
                                                || d.Education.Contains(pattern)
                                                || d.EmploymentDate.ToString().Contains(pattern)
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