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
    public partial class WorkedTimesForm : BaseForm
    {
        private BindingList<WorkedTime> workedTimes;

        public WorkedTimesForm()
        {
            InitializeComponent();

            init();

            button_update.BackColor = Color.Gray;
            button_update.Enabled = false;
            button_delete.BackColor = Color.Gray;
            button_delete.Enabled = false;
        }

        public void init()
        {
            workedTimes = new BindingList<WorkedTime>();
            dataGridView_workedTimes.DataSource = workedTimes;
            dataGridView_workedTimes.Columns["Deleted"].Visible = false;
            dataGridView_workedTimes.Columns["Employee"].Visible = false;
            dataGridView_workedTimes.Columns["EmployeeName"].Visible = false;


            AddWorkedTimes(RestApi.WorkedTimeService.GetAll(false).Result);
            dataGridView_workedTimes.Refresh();
        }

        private void AddWorkedTimes(List<WorkedTime> workedTimes)
        {
            workedTimes
                    .OrderBy(t => t.WorkedTimeId)
                    .ToList()
                    .ForEach(d => this.workedTimes.Add(d));
        }

        private void UpdateWorkedTime(WorkedTime newWorkedTime)
        {
            WorkedTime oldWorkedTime = workedTimes
                .Where(d => d.WorkedTimeId == newWorkedTime.WorkedTimeId)
                .FirstOrDefault();

            if (oldWorkedTime == null) return;

            oldWorkedTime.EmployeeId = newWorkedTime.EmployeeId;
            oldWorkedTime.Deleted = newWorkedTime.Deleted;
            oldWorkedTime.Date = newWorkedTime.Date;
            oldWorkedTime.ArrivalTime = newWorkedTime.ArrivalTime;
            oldWorkedTime.LeavingTime = newWorkedTime.LeavingTime;
            oldWorkedTime.Employee = newWorkedTime.Employee;
        }

        private void DeleteWorkedTime(WorkedTime workedTime)
        {
            workedTime = workedTimes
                    .Where(d => d.WorkedTimeId == workedTime.WorkedTimeId)
                    .FirstOrDefault();

            if (workedTime != null)
                workedTimes.Remove(workedTime);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (workedTimes.Count < 1) return;

            int row = dataGridView_workedTimes.CurrentRow.Index;
            int id = (int)dataGridView_workedTimes[0, row].Value;
            new UpdateWorkedTimesForm(id, true)
                .SetOnValueChangedListener(workedTime =>
                {
                    UpdateWorkedTime(workedTime);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (workedTimes.Count < 1) return;

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int row = dataGridView_workedTimes.CurrentRow.Index;
                int id = (int)dataGridView_workedTimes[0, row].Value;

                try
                {
                    WorkedTime workedTime = await RestApi.WorkedTimeService.Delete(id);
                    DeleteWorkedTime(workedTime);
                    Filter();
                }
                catch (Exception exception)
                {
                    HandleError(exception);
                }
            }
        }

        private async void button_add_Click(object sender, EventArgs e)
        {
            new UpdateWorkedTimesForm(-1, true)
                .SetOnValueChangedListener(workedTime =>
                {
                    workedTimes.Add(workedTime);
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
                dataGridView_workedTimes.DataSource = workedTimes;
            else
                dataGridView_workedTimes.DataSource =
                    workedTimes.Where(d => d.WorkedTimeId.ToString().Contains(pattern)
                                                || d.EmployeeId.ToString().Contains(pattern)
                                                || d.Date.ToString().Contains(pattern)
                                                || d.ArrivalTime.ToString().Contains(pattern)
                                                || d.LeavingTime.ToString().Contains(pattern)
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

        private void dataGridView_workedTimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_update.BackColor = Color.CadetBlue;
            button_update.Enabled = true;
            button_delete.BackColor = Color.CadetBlue;
            button_delete.Enabled = true;
        }
        
        private void WorkedTimesForm_Shown(object sender, EventArgs e)
        {
            dataGridView_workedTimes.ClearSelection();
        }
    }
}