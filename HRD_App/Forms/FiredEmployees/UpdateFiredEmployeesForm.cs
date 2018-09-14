using HRD_App.Errors;
using HRD_App.Logic;
using HRD_App.Rest;
using HRD_App.Utils;
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

namespace HRD_App.Forms
{
    public partial class UpdateFiredEmployeesForm : BaseForm
    {
        private Dictionary<int, Employee> employees;
        private FiredEmployee firedEmployee;
        private event OnValueChangedListener<FiredEmployee> OnValueChanged;

        public UpdateFiredEmployeesForm(int firedEmployeeId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            employees = new Dictionary<int, Employee>();
            loadEmployeesList(employees);

            if (firedEmployeeId != -1) setFiredEmployee(firedEmployeeId);
        }

        public UpdateFiredEmployeesForm SetOnValueChangedListener(OnValueChangedListener<FiredEmployee> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private async void loadEmployeesList(Dictionary<int, Employee> employees)
        {
            (await RestApi.EmployeeService.GetAll(false)).ForEach(p => employees.Add(p.EmployeeId, p));
            comboBox_employeeId.Items.AddRange(employees.Keys.Select(e => e.ToString()).ToArray());
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            comboBox_employeeId.Enabled = enabled;
            dateTimePicker_dateOfDismissal.Enabled = enabled;
            textBox_reason.Enabled = enabled;
        }

        private async void setFiredEmployee(int firedEmployeeId)
        {
            try
            {
                firedEmployee = await RestApi.FiredEmployeeService.Get(firedEmployeeId);

                textBox_id.Text = firedEmployee.FiredEmployeeId.ToString();
                comboBox_employeeId.Text = firedEmployee.EmployeeId.ToString();
                dateTimePicker_dateOfDismissal.Text = firedEmployee.DateOfDismissal.ToString();
                textBox_reason.Text = firedEmployee.Reason.ToString();
            }
            catch (Exception exception)
            {
                HandleError(exception);
            }
        }

        private async void button_save_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            try
            {
                Employee employee = employees[Int32.Parse(comboBox_employeeId.Text)];

                FiredEmployee firedEmployee = new FiredEmployee();
                firedEmployee.EmployeeId = employee.EmployeeId;
                firedEmployee.DateOfDismissal = dateTimePicker_dateOfDismissal.Value.Date;
                firedEmployee.Reason = textBox_reason.Text;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    firedEmployee = await RestApi.FiredEmployeeService.Add(firedEmployee);
                else
                {
                    firedEmployee.FiredEmployeeId = id;
                    await RestApi.FiredEmployeeService.Update(id, firedEmployee);
                    firedEmployee.Employee = employee;
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(firedEmployee);
                Close();
            }
            catch (Exception exception)
            {
                HandleError(exception);
            }
        }

        private bool Validate()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (comboBox_employeeId.Text == "")
            {
                errorProvider.SetError(comboBox_employeeId, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_dateOfDismissal.Text == "")
            {
                errorProvider.SetError(dateTimePicker_dateOfDismissal, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_dateOfDismissal.Text == "")
            {
                errorProvider.SetError(dateTimePicker_dateOfDismissal, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_reason.Text == "")
            {
                errorProvider.SetError(textBox_reason, "Поле обязательно для заполнения!");
                isValid = false;
            }
            
            return isValid;
        }
    }
}
