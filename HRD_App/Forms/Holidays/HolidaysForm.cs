﻿using HRD_App.Errors;
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
    public partial class HolidaysForm : Form
    {
        private BindingList<Holiday> holidays;

        public HolidaysForm()
        {
            InitializeComponent();

            new AuthorizationForm().ShowDialog();

            init();
        }

        public void init()
        {
            holidays = new BindingList<Holiday>();
            dataGridView_holidays.DataSource = holidays;
            dataGridView_holidays.Columns["Deleted"].Visible = false;


            AddHolidays(RestApi.HolidayService.GetAll(false).Result);
            dataGridView_holidays.Refresh();
        }

        private void AddHolidays(List<Holiday> holidays)
        {
            holidays
                    .OrderBy(t => t.HolidayId)
                    .ToList()
                    .ForEach(d => this.holidays.Add(d));
        }

        private void UpdateHoliday(Holiday newHoliday)
        {
            Holiday oldHoliday = holidays
                .Where(d => d.HolidayId == newHoliday.HolidayId)
                .FirstOrDefault();

            if (oldHoliday == null) return;

            oldHoliday.Deleted = newHoliday.Deleted;
            oldHoliday.EmployeeId = newHoliday.EmployeeId;
            oldHoliday.StartDate = newHoliday.StartDate;
            oldHoliday.FinalDate = newHoliday.FinalDate;
            oldHoliday.Type = newHoliday.Type;
            oldHoliday.Salary = newHoliday.Salary;
        }

        private void DeleteHoliday(Holiday holiday)
        {
            holiday = holidays
                    .Where(d => d.HolidayId == holiday.HolidayId)
                    .FirstOrDefault();

            if (holiday != null)
                holidays.Remove(holiday);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (holidays.Count < 1) return;

            int row = dataGridView_holidays.CurrentRow.Index;
            int id = (int)dataGridView_holidays[0, row].Value;
            new UpdateHolidaysForm(id, true)
                .SetOnValueChangedListener(holiday =>
                {
                    UpdateHoliday(holiday);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (holidays.Count < 1) return;

            int row = dataGridView_holidays.CurrentRow.Index;
            int id = (int)dataGridView_holidays[0, row].Value;

            try
            {
                Holiday holiday = await RestApi.HolidayService.Delete(id);
                DeleteHoliday(holiday);
                Filter();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }

        private async void button_add_Click(object sender, EventArgs e)
        {
            new UpdateHolidaysForm(-1, true)
                .SetOnValueChangedListener(holiday =>
                {
                    holidays.Add(holiday);
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
                dataGridView_holidays.DataSource = holidays;
            else
                dataGridView_holidays.DataSource =
                    holidays.Where(d => d.HolidayId.ToString().Contains(pattern)
                                                || d.StartDate.ToString().Contains(pattern)
                                                || d.FinalDate.ToString().Contains(pattern)
                                                || d.Type.Contains(pattern)
                                                || d.Salary.ToString().Contains(pattern)
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