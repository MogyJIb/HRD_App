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
    public partial class UpdateEmployeesForm : Form
    {
        private Dictionary<int, Position> positions;
        private Employee employee;
        private event OnValueChangedListener<Employee> OnValueChanged;

        public UpdateEmployeesForm(int employeeId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            positions = new Dictionary<int, Position>();
            loadPositionsList(positions);

            if (employeeId != -1) setEmployee(employeeId);
        }

        public UpdateEmployeesForm SetOnValueChangedListener(OnValueChangedListener<Employee> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private async void loadPositionsList(Dictionary<int, Position> positions)
        {
            (await RestApi.PositionService.GetAll(false)).ForEach(p => positions.Add(p.PositionId, p));
            comboBox_position.Items.AddRange(positions.Values.Select(p => p.Name).ToArray());
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            comboBox_position.Enabled = enabled;
            textBox_firstName.Enabled = enabled;
            textBox_lastName.Enabled = enabled;
            textBox_patronymic.Enabled = enabled;
            dateTimePicker_birthday.Enabled = enabled;
            textBox_address.Enabled = enabled;
            maskedTextBox_phone.Enabled = enabled;
            comboBox_education.Enabled = enabled;
            dateTimePicker_employmentDate.Enabled = enabled;
        }

        private async void setEmployee(int employeeId)
        {
            try
            {
                employee = await RestApi.EmployeeService.Get(employeeId);

                textBox_id.Text = employee.EmployeeId.ToString();
                comboBox_position.Text = employee.Position.Name;
                textBox_firstName.Text = employee.FirstName;
                textBox_lastName.Text = employee.LastName;
                textBox_patronymic.Text = employee.Patronymic;
                dateTimePicker_birthday.Text = employee.BirthDate.ToString();
                textBox_address.Text = employee.Address;
                maskedTextBox_phone.Text = employee.Phone;
                comboBox_education.Text = employee.Education;
                dateTimePicker_employmentDate.Text = employee.EmploymentDate.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
                Close();
            }
        }

        private async void button_save_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            try
            {
                Position position = positions.Values.First(d => d.Name == comboBox_position.Text);

                Employee employee = new Employee();
                employee.PositionId = position.PositionId;
                employee.FirstName = textBox_firstName.Text;
                employee.LastName = textBox_lastName.Text;
                employee.Patronymic = textBox_patronymic.Text;
                employee.BirthDate = dateTimePicker_birthday.Value.Date;
                employee.Address = textBox_address.Text;
                employee.Phone = maskedTextBox_phone.Text;
                employee.Education = comboBox_education.Text;
                employee.EmploymentDate = dateTimePicker_employmentDate.Value.Date;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    employee = await RestApi.EmployeeService.Add(employee);
                else
                {
                    employee.EmployeeId = id;
                    await RestApi.EmployeeService.Update(id, employee);
                    employee.Position = position;
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(employee);
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }

        private bool Validate()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (comboBox_position.Text == "")
            {
                errorProvider.SetError(comboBox_position, "Поле обязательно для заполнения!");
                isValid = false;
            }
            
            if (textBox_firstName.Text == "")
            {
                errorProvider.SetError(textBox_firstName, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_lastName.Text == "")
            {
                errorProvider.SetError(textBox_lastName, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_patronymic.Text == "")
            {
                errorProvider.SetError(textBox_patronymic, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_birthday.Text == "")
            {
                errorProvider.SetError(dateTimePicker_birthday, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_address.Text == "")
            {
                errorProvider.SetError(textBox_address, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (maskedTextBox_phone.Text == "")
            {
                errorProvider.SetError(maskedTextBox_phone, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (comboBox_education.Text == "")
            {
                errorProvider.SetError(dateTimePicker_birthday, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (dateTimePicker_employmentDate.Text == "")
            {
                errorProvider.SetError(dateTimePicker_employmentDate, "Поле обязательно для заполнения!");
                isValid = false;
            }

            return isValid;
        }
    }
}
