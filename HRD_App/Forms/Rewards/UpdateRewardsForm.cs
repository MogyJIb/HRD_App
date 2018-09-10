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
    public partial class UpdateRewardsForm : Form
    {
        private Dictionary<int, Employee> employees;
        private Reward reward;
        private event OnValueChangedListener<Reward> OnValueChanged;

        public UpdateRewardsForm(int rewardId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            employees = new Dictionary<int, Employee>();
            loadEmployeesList(employees);

            if (rewardId != -1) setReward(rewardId);
        }

        public UpdateRewardsForm SetOnValueChangedListener(OnValueChangedListener<Reward> listener)
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
            dateTimePicker_date.Enabled = enabled;
            textBox_amount.Enabled = enabled;
            textBox_reason.Enabled = enabled;
        }

        private async void setReward(int rewardId)
        {
            try
            {
                reward = await RestApi.RewardService.Get(rewardId);

                textBox_id.Text = reward.RewardId.ToString();
                comboBox_employeeId.Text = reward.EmployeeId.ToString();
                dateTimePicker_date.Text = reward.Date.ToString();
                textBox_amount.Text = reward.Amount.ToString();
                textBox_reason.Text = reward.Reason;
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
                Employee employee = employees[Int32.Parse(comboBox_employeeId.Text)];

                Reward reward = new Reward();
                reward.EmployeeId = employee.EmployeeId;
                reward.Date = dateTimePicker_date.Value.Date;
                reward.Amount = Double.Parse(textBox_amount.Text);
                reward.Reason = textBox_reason.Text;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    reward = await RestApi.RewardService.Add(reward);
                else
                {
                    reward.RewardId = id;
                    await RestApi.RewardService.Update(id, reward);
                    reward.Employee = employee;
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(reward);
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

            if (comboBox_employeeId.Text == "")
            {
                errorProvider.SetError(comboBox_employeeId, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_date.Text == "")
            {
                errorProvider.SetError(dateTimePicker_date, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_amount.Text == "")
            {
                errorProvider.SetError(textBox_amount, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_reason.Text == "")
            {
                errorProvider.SetError(textBox_reason, "Поле обязательно для заполнения!");
                isValid = false;
            }

            try
            {
                Double.Parse(textBox_amount.Text);
            }
            catch (Exception exception)
            {
                errorProvider.SetError(textBox_amount, "Неверный формат!");
                isValid = false;
            }

            return isValid;
        }
    }
}
