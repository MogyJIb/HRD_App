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
    public partial class VacanciesForm : Form
    {
        private BindingList<Vacancy> vacancies;

        public VacanciesForm()
        {
            InitializeComponent();

            new AuthorizationForm().ShowDialog();

            init();
        }

        public void init()
        {
            vacancies = new BindingList<Vacancy>();
            dataGridView_vacancies.DataSource = vacancies;
            dataGridView_vacancies.Columns["Deleted"].Visible = false;


            AddVacancies(RestApi.VacancyService.GetAll(false).Result);
            dataGridView_vacancies.Refresh();
        }

        private void AddVacancies(List<Vacancy> vacancies)
        {
            vacancies
                    .OrderBy(t => t.VacancyId)
                    .ToList()
                    .ForEach(d => this.vacancies.Add(d));
        }

        private void UpdateVacancy(Vacancy newVacancy)
        {
            Vacancy oldVacancy = vacancies
                .Where(d => d.VacancyId == newVacancy.VacancyId)
                .FirstOrDefault();

            if (oldVacancy == null) return;

            oldVacancy.PositionId = newVacancy.PositionId;
            oldVacancy.Deleted = newVacancy.Deleted;
            oldVacancy.Number = newVacancy.Number;
        }

        private void DeleteVacancy(Vacancy vacancy)
        {
            vacancy = vacancies
                    .Where(d => d.VacancyId == vacancy.VacancyId)
                    .FirstOrDefault();

            if (vacancy != null)
                vacancies.Remove(vacancy);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (vacancies.Count < 1) return;

            int row = dataGridView_vacancies.CurrentRow.Index;
            int id = (int)dataGridView_vacancies[0, row].Value;
            new UpdateVacanciesForm(id, true)
                .SetOnValueChangedListener(vacancy =>
                {
                    UpdateVacancy(vacancy);
                    Filter();
                })
                .ShowDialog();
        }

        private async void button_delete_Click(object sender, EventArgs e)
        {
            if (vacancies.Count < 1) return;

            int row = dataGridView_vacancies.CurrentRow.Index;
            int id = (int)dataGridView_vacancies[0, row].Value;

            try
            {
                Vacancy vacancy = await RestApi.VacancyService.Delete(id);
                DeleteVacancy(vacancy);
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
            new UpdateVacanciesForm(-1, true)
                .SetOnValueChangedListener(vacancy =>
                {
                    vacancies.Add(vacancy);
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
                dataGridView_vacancies.DataSource = vacancies;
            else
                dataGridView_vacancies.DataSource =
                    vacancies.Where(d => d.VacancyId.ToString().Contains(pattern)
                                                || d.Number.ToString().Contains(pattern)
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