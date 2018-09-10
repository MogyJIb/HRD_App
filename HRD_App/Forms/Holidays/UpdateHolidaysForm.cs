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
    public partial class UpdateHolidaysForm : Form
    {
        private Holiday holiday;
        private event OnValueChangedListener<Holiday> OnValueChanged;

        public UpdateHolidaysForm(int holidayId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            if (holidayId != -1) setHoliday(holidayId);
        }

        public UpdateHolidaysForm SetOnValueChangedListener(OnValueChangedListener<Holiday> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            textBox_employeeId.Enabled = enabled;
            dateTimePicker_startDate.Enabled = enabled;
            dateTimePicker_finalDate.Enabled = enabled;
            textBox_salary.Enabled = enabled;
            comboBox_type.Enabled = enabled;
        }

        private async void setHoliday(int holidayId)
        {
            try
            {
                holiday = await RestApi.HolidayService.Get(holidayId);

                textBox_id.Text = holiday.HolidayId.ToString();
                textBox_employeeId.Text = holiday.EmployeeId.ToString();
                dateTimePicker_startDate.Text = holiday.StartDate.ToString();
                dateTimePicker_finalDate.Text = holiday.FinalDate.ToString();
                textBox_salary.Text = holiday.Salary.ToString();
                comboBox_type.Text = holiday.Salary.ToString();
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
                Holiday holiday = new Holiday();
                holiday.EmployeeId = Int32.Parse(textBox_employeeId.Text);
                holiday.StartDate = dateTimePicker_startDate.Value.Date;
                holiday.FinalDate = dateTimePicker_finalDate.Value.Date;
                holiday.Salary = Double.Parse(textBox_salary.Text);
                holiday.Type = comboBox_type.Text;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    holiday = await RestApi.HolidayService.Add(holiday);
                else
                {
                    holiday.HolidayId = id;
                    await RestApi.HolidayService.Update(id, holiday);
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(holiday);
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

            if (textBox_employeeId.Text == "")
            {
                errorProvider.SetError(textBox_employeeId, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_startDate.Text == "")
            {
                errorProvider.SetError(dateTimePicker_startDate, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_finalDate.Text == "")
            {
                errorProvider.SetError(dateTimePicker_finalDate, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_salary.Text == "")
            {
                errorProvider.SetError(textBox_salary, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (comboBox_type.Text == "")
            {
                errorProvider.SetError(comboBox_type, "Поле обязательно для заполнения!");
                isValid = false;
            }

            try
            {
                Double.Parse(textBox_salary.Text);
            }
            catch (Exception exception)
            {
                errorProvider.SetError(textBox_salary, "Неверный формат!");
                isValid = false;
            }
            
            return isValid;
        }
    }
}
