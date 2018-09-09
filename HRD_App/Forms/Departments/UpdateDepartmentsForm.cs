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
    public partial class UpdateDepartmentsForm : Form
    {
        private Department department;
        private event OnValueChangedListener<Department> OnValueChanged;

        public UpdateDepartmentsForm(int departmentId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            if (departmentId != -1) setDepartment(departmentId);
        }

        public UpdateDepartmentsForm SetOnValueChangedListener(OnValueChangedListener<Department> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            maskedTextBox_phone.Enabled = enabled;
            textBox_cabinet.Enabled = enabled;
            textBox_name.Enabled = enabled;
        }

        private async void setDepartment(int departmentId)
        {
            try
            {
                department = await RestApi.DepartmentService.Get(departmentId);

                textBox_id.Text = department.DepartmentId.ToString();
                maskedTextBox_phone.Text = department.Phone;
                textBox_cabinet.Text = department.Cabinet.ToString();
                textBox_name.Text = department.Name;
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
                Department department = new Department();
                department.Name = textBox_name.Text;
                department.Cabinet = Int32.Parse(textBox_cabinet.Text);
                department.Phone = maskedTextBox_phone.Text;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    department = await RestApi.DepartmentService.Add(department);
                else
                {
                    department.DepartmentId = id;
                    await RestApi.DepartmentService.Update(id, department);
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(department);
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
            // TODO errorProvider.Clear();

            if (maskedTextBox_phone.Text == "")
            {
                // TODO errorProvider.SetError(textBox_login, "Поле обязательно для заполнения!");
                MessageBox.Show("Поле обязательно для заполнения!");
                isValid = false;
            }

            try
            {
                Int32.Parse(textBox_cabinet.Text);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_name.Text == "")
            {
                // TODO errorProvider.SetError(textBox_password, "Поле обязательно для заполнения!");
                MessageBox.Show("Поле обязательно для заполнения!");
                isValid = false;
            }

            return isValid;
        }
    }
}
