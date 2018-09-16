using HRD_App.Rest;
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
    public partial class MainForm : BaseForm
    {
        List<Department> departments;
        List<Position> positions;
        List<Employee> employees;

        BindingList<Employee> gridViewEmployees;

        public MainForm()
        {
            InitializeComponent();

            Auth();

            Init();
        }

        private void InitTreeViewStructure()
        {
            for (int i = 0; i < departments.Count; i++)
            {
                TreeNode treeNode = new TreeNode(departments[i].Name);
                var depPos = positions.Where(p => p.DepartmentId == departments[i].DepartmentId).ToList();
                for (int j = 0; j < depPos.Count; j++)
                    treeNode.Nodes.Add(depPos[j].Name);

                treeView_structure.Nodes.Add(treeNode);
            }
        }

        private void treeView_structure_AfterSelect(object sender, TreeViewEventArgs ev)
        {
            string node = treeView_structure.SelectedNode.Text;
            gridViewEmployees = new BindingList<Employee>();
            employees.Where(e => e.Position.DepartmentName.Equals(node) || e.PositionName.Equals(node))
                .ToList()
                .ForEach(e => gridViewEmployees.Add(e));

            dataGridView_employees.ClearSelection();
            dataGridView_employees.AutoGenerateColumns = false;
            dataGridView_employees.DataSource = gridViewEmployees;
        }

        private void Init()
        {
            employees = RestApi.EmployeeService.GetAll(false).Result;
            departments = RestApi.DepartmentService.GetAll(false).Result;
            positions = RestApi.PositionService.GetAll(false).Result;
            InitTreeViewStructure();
        }

        private void Auth()
        {
            new AuthorizationForm().ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            dataGridView_employees.ClearSelection();
        }
        
        private void работающиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeesForm().ShowDialog();
        }

        private void уволенныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FiredEmployeesForm().ShowDialog();
        }

        private void учетОтработанногоВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkedTimesForm().ShowDialog();
        }

        private void учетОтпусковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HolidaysForm().ShowDialog();
        }

        private void учетПоощренийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RewardsForm().ShowDialog();
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentsForm().ShowDialog();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PositionsForm().ShowDialog();
        }

        private void вакансииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VacanciesForm().ShowDialog();
        }

        private void резюмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ResumesForm().ShowDialog();
        }

        private void dataGridView_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_employees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dataGridView_employees.CurrentRow.Index;
            int id = (int)dataGridView_employees[3, row].Value;
            new UpdateEmployeesForm(id, true)
                .SetOnValueChangedListener(employee =>
                {
                    UpdateEmployee(employee);
                })
                .ShowDialog();
        }

        private void UpdateEmployee(Employee newEmployee)
        {
            if (gridViewEmployees == null) return;

            Employee oldEmployee = gridViewEmployees
                .Where(d => d.EmployeeId == newEmployee.EmployeeId)
                .FirstOrDefault();

            if (oldEmployee == null) return;

            oldEmployee.PositionId = newEmployee.PositionId;
            oldEmployee.Deleted = newEmployee.Deleted;
            oldEmployee.FirstName = newEmployee.FirstName;
            oldEmployee.LastName = newEmployee.LastName;
            oldEmployee.Patronymic = newEmployee.Patronymic;
            oldEmployee.BirthDate = newEmployee.BirthDate;
            oldEmployee.Address = newEmployee.Address;
            oldEmployee.Phone = newEmployee.Phone;
            oldEmployee.Education = newEmployee.Education;
            oldEmployee.EmploymentDate = newEmployee.EmploymentDate;
            oldEmployee.Position = newEmployee.Position;
        }
    }
}
