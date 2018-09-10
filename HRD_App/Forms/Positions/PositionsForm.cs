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
    public partial class PositionsForm : Form
    {
        private BindingList<Position> positions;

        public PositionsForm()
        {
            InitializeComponent();

            new AuthorizationForm().ShowDialog();

            init();
        }

        public void init()
        {
            positions = new BindingList<Position>();
            dataGridView_positions.DataSource = positions;
            dataGridView_positions.Columns["Deleted"].Visible = false;
            dataGridView_positions.Columns["Department"].Visible = false;
            dataGridView_positions.Columns["DepartmentId"].Visible = false;


            AddPositions(RestApi.PositionService.GetAll(false).Result);
            dataGridView_positions.Refresh();
        }

        private void AddPositions(List<Position> positions)
        {
            positions
                    .OrderBy(t => t.PositionId)
                    .ToList()
                    .ForEach(d => this.positions.Add(d));
        }

        private void UpdatePosition(Position newPosition)
        {
            Position oldPosition = positions
                .Where(d => d.PositionId == newPosition.PositionId)
                .FirstOrDefault();

            if (oldPosition == null) return;

            oldPosition.Deleted = newPosition.Deleted;
            oldPosition.DepartmentId = newPosition.DepartmentId;
            oldPosition.Duties = newPosition.Duties;
            oldPosition.Name = newPosition.Name;
            oldPosition.Requirements = newPosition.Requirements;
            oldPosition.Salary = newPosition.Salary;
            oldPosition.Department = newPosition.Department;
        }

        private void DeletePosition(Position position)
        {
            position = positions
                    .Where(d => d.PositionId == position.PositionId)
                    .FirstOrDefault();

            if (position != null)
                positions.Remove(position);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (positions.Count < 1) return;

            int row = dataGridView_positions.CurrentRow.Index;
            int id = (int)dataGridView_positions[0, row].Value;
            new UpdatePositionsForm(id, true)
                .SetOnValueChangedListener(position =>
                {
                    UpdatePosition(position);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (positions.Count < 1) return;

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int row = dataGridView_positions.CurrentRow.Index;
                int id = (int)dataGridView_positions[0, row].Value;

                try
                {
                    Position position = await RestApi.PositionService.Delete(id);
                    DeletePosition(position);
                    Filter();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
            }
        }

        private async void button_add_Click(object sender, EventArgs e)
        {
            new UpdatePositionsForm(-1, true)
                .SetOnValueChangedListener(position =>
                {
                    positions.Add(position);
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
                dataGridView_positions.DataSource = positions;
            else
                dataGridView_positions.DataSource =
                    positions.Where(d => d.PositionId.ToString().Contains(pattern)
                                                || d.Department.Name.Contains(pattern)
                                                || d.Name.Contains(pattern)
                                                || d.Requirements.Contains(pattern)
                                                || d.Duties.Contains(pattern)
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