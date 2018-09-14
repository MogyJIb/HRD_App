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
    public partial class FiredEmployeesForm : BaseForm
    {
        private BindingList<FiredEmployee> firedEmployees;

        public FiredEmployeesForm()
        {
            InitializeComponent();

            init();

            button_update.BackColor = Color.Gray;
            button_update.Enabled = false;
            button_delete.BackColor = Color.Gray;
            button_delete.Enabled = false;
        }

        public async void init()
        {
            firedEmployees = new BindingList<FiredEmployee>();
            dataGridView_firedEmployees.DataSource = firedEmployees;
            dataGridView_firedEmployees.Columns["Deleted"].Visible = false;
            dataGridView_firedEmployees.Columns["Employee"].Visible = false;
            dataGridView_firedEmployees.Columns["EmployeeName"].Visible = false;

            AddFiredEmployees(await RestApi.FiredEmployeeService.GetAll(false));
            dataGridView_firedEmployees.Refresh();
        }

        private void AddFiredEmployees(List<FiredEmployee> firedEmployees)
        {
            firedEmployees
                    .OrderBy(t => t.FiredEmployeeId)
                    .ToList()
                    .ForEach(d => this.firedEmployees.Add(d));
        }

        private void UpdateFiredEmployee(FiredEmployee newFiredEmployee)
        {
            FiredEmployee oldFiredEmployee = firedEmployees
                .Where(d => d.FiredEmployeeId == newFiredEmployee.FiredEmployeeId)
                .FirstOrDefault();

            if (oldFiredEmployee == null) return;

            oldFiredEmployee.Deleted = newFiredEmployee.Deleted;
            oldFiredEmployee.EmployeeId = newFiredEmployee.EmployeeId;
            oldFiredEmployee.DateOfDismissal = newFiredEmployee.DateOfDismissal;
            oldFiredEmployee.Reason = newFiredEmployee.Reason;
            oldFiredEmployee.Employee = newFiredEmployee.Employee;
        }

        private void DeleteFiredEmployee(FiredEmployee firedEmployee)
        {
            firedEmployee = firedEmployees
                    .Where(d => d.FiredEmployeeId == firedEmployee.FiredEmployeeId)
                    .FirstOrDefault();

            if (firedEmployee != null)
                firedEmployees.Remove(firedEmployee);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (firedEmployees.Count < 1) return;

            int row = dataGridView_firedEmployees.CurrentRow.Index;
            int id = (int)dataGridView_firedEmployees[0, row].Value;
            new UpdateFiredEmployeesForm(id, true)
                .SetOnValueChangedListener(firedEmployee =>
                {
                    UpdateFiredEmployee(firedEmployee);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (firedEmployees.Count < 1) return;

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int row = dataGridView_firedEmployees.CurrentRow.Index;
                int id = (int)dataGridView_firedEmployees[0, row].Value;

                try
                {
                    FiredEmployee firedEmployee = await RestApi.FiredEmployeeService.Delete(id);
                    DeleteFiredEmployee(firedEmployee);
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
            new UpdateFiredEmployeesForm(-1, true)
                .SetOnValueChangedListener(firedEmployee =>
                {
                    firedEmployees.Add(firedEmployee);
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
                dataGridView_firedEmployees.DataSource = firedEmployees;
            else
                dataGridView_firedEmployees.DataSource =
                    firedEmployees.Where(d => d.FiredEmployeeId.ToString().Contains(pattern)
                                                || d.EmployeeId.ToString().Contains(pattern)
                                                || d.DateOfDismissal.ToString().Contains(pattern)
                                                || d.Reason.Contains(pattern)
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

        private void dataGridView_firedEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_update.BackColor = Color.CadetBlue;
            button_update.Enabled = true;
            button_delete.BackColor = Color.CadetBlue;
            button_delete.Enabled = true;
        }
        
        private void FiredEmployeesForm_Shown(object sender, EventArgs e)
        {
            dataGridView_firedEmployees.ClearSelection();
        }
    }
}