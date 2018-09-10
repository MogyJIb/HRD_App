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
    public partial class UpdatePositionsForm : Form
    {
        private Dictionary<int, Department> departments;
        private Position position;
        private event OnValueChangedListener<Position> OnValueChanged;

        public UpdatePositionsForm(int positionId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            departments = new Dictionary<int, Department>();
            loadDepartmentsList(departments);

            if (positionId != -1) setPosition(positionId);
        }

        public UpdatePositionsForm SetOnValueChangedListener(OnValueChangedListener<Position> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private async void loadDepartmentsList(Dictionary<int, Department> departments)
        {
            (await RestApi.DepartmentService.GetAll(false)).ForEach(d =>  departments.Add(d.DepartmentId, d));
            comboBox_department.Items.AddRange(departments.Values.Select(d => d.Name).ToArray());
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            comboBox_department.Enabled = enabled;
            textBox_name.Enabled = enabled;
            textBox_duties.Enabled = enabled;
            textBox_salary.Enabled = enabled;
            textBox_requirements.Enabled = enabled;
        }

        private async void setPosition(int positionId)
        {
            try
            {
                position = await RestApi.PositionService.Get(positionId);

                textBox_id.Text = position.PositionId.ToString();
                comboBox_department.Text = position.Department.Name;
                textBox_name.Text = position.Name;
                textBox_duties.Text = position.Duties;
                textBox_salary.Text = position.Salary.ToString();
                textBox_requirements.Text = position.Requirements;
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
                Department department = departments.Values.First(d => d.Name == comboBox_department.Text);

                Position position = new Position();
                position.Name = textBox_name.Text;
                position.DepartmentId = department.DepartmentId;
                position.Duties = textBox_duties.Text;
                position.Salary = Double.Parse(textBox_salary.Text);
                position.Requirements = textBox_requirements.Text;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    position = await RestApi.PositionService.Add(position);
                else
                {
                    position.PositionId = id;
                    await RestApi.PositionService.Update(id, position);
                    position.Department = department;
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(position);
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

            if (comboBox_department.Text == "")
            {
                errorProvider.SetError(comboBox_department, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_name.Text == "")
            {
                errorProvider.SetError(textBox_name, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_duties.Text == "")
            {
                errorProvider.SetError(textBox_duties, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_salary.Text == "")
            {
                errorProvider.SetError(textBox_salary, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_requirements.Text == "")
            {
                errorProvider.SetError(textBox_requirements, "Поле обязательно для заполнения!");
                isValid = false;
            }

            try
            {
                Double.Parse(textBox_salary.Text);
            }
            catch(Exception exception)
            {
                errorProvider.SetError(textBox_salary, "Неверный формат!");
                isValid = false;
            }
            
            return isValid;
        }
    }
}
