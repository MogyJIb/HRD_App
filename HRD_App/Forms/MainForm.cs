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
