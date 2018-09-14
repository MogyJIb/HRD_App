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
    public partial class ResumesForm : BaseForm
    {
        private BindingList<Resume> resumes;

        public ResumesForm()
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
            resumes = new BindingList<Resume>();
            dataGridView_resumes.DataSource = resumes;
            dataGridView_resumes.Columns["Deleted"].Visible = false;
            dataGridView_resumes.Columns["Vacancy"].Visible = false;
            dataGridView_resumes.Columns["VacancyId"].Visible = false;


            AddResumes(await RestApi.ResumeService.GetAll(false));
            dataGridView_resumes.Refresh();
        }

        private void AddResumes(List<Resume> resumes)
        {
            resumes
                    .OrderBy(t => t.ResumeId)
                    .ToList()
                    .ForEach(d => this.resumes.Add(d));
        }

        private void UpdateResume(Resume newResume)
        {
            Resume oldResume = resumes
                .Where(d => d.ResumeId == newResume.ResumeId)
                .FirstOrDefault();

            if (oldResume == null) return;

            oldResume.VacancyId = newResume.VacancyId;
            oldResume.Deleted = newResume.Deleted;
            oldResume.FirstName = newResume.FirstName;
            oldResume.LastName = newResume.LastName;
            oldResume.Patronymic = newResume.Patronymic;
            oldResume.BirthDate = newResume.BirthDate;
            oldResume.Email = newResume.Email;
            oldResume.Phone = newResume.Phone;
            oldResume.Education = newResume.Education;
            oldResume.Institution = newResume.Institution;
            oldResume.Specialty = newResume.Specialty;
            oldResume.Vacancy = newResume.Vacancy;
        }

        private void DeleteResume(Resume resume)
        {
            resume = resumes
                    .Where(d => d.ResumeId == resume.ResumeId)
                    .FirstOrDefault();

            if (resume != null)
                resumes.Remove(resume);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (resumes.Count < 1) return;

            int row = dataGridView_resumes.CurrentRow.Index;
            int id = (int)dataGridView_resumes[0, row].Value;
            new UpdateResumesForm(id, true)
                .SetOnValueChangedListener(resume =>
                {
                    UpdateResume(resume);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (resumes.Count < 1) return;

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int row = dataGridView_resumes.CurrentRow.Index;
                int id = (int)dataGridView_resumes[0, row].Value;

                try
                {
                    Resume resume = await RestApi.ResumeService.Delete(id);
                    DeleteResume(resume);
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
            new UpdateResumesForm(-1, true)
                .SetOnValueChangedListener(resume =>
                {
                    resumes.Add(resume);
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
                dataGridView_resumes.DataSource = resumes;
            else
                dataGridView_resumes.DataSource =
                    resumes.Where(d => d.ResumeId.ToString().Contains(pattern)
                                                || d.Vacancy.Position.Name.Contains(pattern)
                                                || d.FirstName.Contains(pattern)
                                                || d.LastName.ToString().Contains(pattern)
                                                || d.Patronymic.Contains(pattern)
                                                || d.BirthDate.ToString().Contains(pattern)
                                                || d.Email.Contains(pattern)
                                                || d.Phone.Contains(pattern)
                                                || d.Education.Contains(pattern)
                                                || d.Institution.Contains(pattern)
                                                || d.Specialty.Contains(pattern)
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

        private void dataGridView_resumes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_update.BackColor = Color.CadetBlue;
            button_update.Enabled = true;
            button_delete.BackColor = Color.CadetBlue;
            button_delete.Enabled = true;
        }
        
        private void ResumesForm_Shown(object sender, EventArgs e)
        {
            dataGridView_resumes.ClearSelection();
        }
    }
}