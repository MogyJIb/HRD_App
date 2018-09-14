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
        public MainForm()
        {
            InitializeComponent();

            Auth();
        }

        private void treeView_directories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string form = treeView_directories.SelectedNode.Text;

            try
            {
                switch (form)
                {
                    case "Работающие":
                        new EmployeesForm().ShowDialog();
                        break;
                    case "Уволенные":
                        new FiredEmployeesForm().ShowDialog();
                        break;
                    case "Учет отработанного времени":
                        new WorkedTimesForm().ShowDialog();
                        break;
                    case "Учет отпусков":
                        new HolidaysForm().ShowDialog();
                        break;
                    case "Учет поощрений":
                        new RewardsForm().ShowDialog();
                        break;
                    case "Резюме":
                        new ResumesForm().ShowDialog();
                        break;
                    case "Вакансии":
                        new VacanciesForm().ShowDialog();
                        break;
                    case "Отделы":
                        new DepartmentsForm().ShowDialog();
                        break;
                    case "Должности":
                        new PositionsForm().ShowDialog();
                        break;
                }

            } catch(Exception exception)
            {
                HandleError(exception);
            }
        }

        private void Auth()
        {
            new AuthorizationForm().ShowDialog();
        }
    }
}
