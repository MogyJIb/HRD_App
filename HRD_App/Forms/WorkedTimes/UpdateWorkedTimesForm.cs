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
    public partial class UpdateWorkedTimesForm : Form
    {
        private WorkedTime workedTime;
        private event OnValueChangedListener<WorkedTime> OnValueChanged;

        public UpdateWorkedTimesForm(int workedTimeId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            if (workedTimeId != -1) setWorkedTime(workedTimeId);
        }

        public UpdateWorkedTimesForm SetOnValueChangedListener(OnValueChangedListener<WorkedTime> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            textBox_employeeId.Enabled = enabled;
            dateTimePicker_date.Enabled = enabled;
            dateTimePicker_arrivalTime.Enabled = enabled;
            dateTimePicker_leavingTime.Enabled = enabled;
        }

        private async void setWorkedTime(int workedTimeId)
        {
            try
            {
                workedTime = await RestApi.WorkedTimeService.Get(workedTimeId);

                textBox_id.Text = workedTime.WorkedTimeId.ToString();
                textBox_employeeId.Text = workedTime.EmployeeId.ToString();
                dateTimePicker_date.Text = workedTime.Date.ToString();
                dateTimePicker_arrivalTime.Text = workedTime.ArrivalTime.ToString();
                dateTimePicker_leavingTime.Text = workedTime.LeavingTime.ToString();
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
                WorkedTime workedTime = new WorkedTime();
                workedTime.EmployeeId = Int32.Parse(textBox_employeeId.Text);
                workedTime.Date = dateTimePicker_date.Value.Date;
                workedTime.ArrivalTime = dateTimePicker_arrivalTime.Value.TimeOfDay;
                workedTime.LeavingTime = dateTimePicker_leavingTime.Value.TimeOfDay;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    workedTime = await RestApi.WorkedTimeService.Add(workedTime);
                else
                {
                    workedTime.WorkedTimeId = id;
                    await RestApi.WorkedTimeService.Update(id, workedTime);
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(workedTime);
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

            if (dateTimePicker_date.Text == "")
            {
                errorProvider.SetError(dateTimePicker_date, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_arrivalTime.Text == "")
            {
                errorProvider.SetError(dateTimePicker_arrivalTime, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_leavingTime.Text == "")
            {
                errorProvider.SetError(dateTimePicker_leavingTime, "Поле обязательно для заполнения!");
                isValid = false;
            }

            return isValid;
        }
    }
}
