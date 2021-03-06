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
    public partial class VacanciesForm : BaseForm
    {
        private BindingList<Vacancy> vacancies;

        public VacanciesForm()
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
            vacancies = new BindingList<Vacancy>();
            dataGridView_vacancies.DataSource = vacancies;
            dataGridView_vacancies.Columns["Deleted"].Visible = false;
            dataGridView_vacancies.Columns["Position"].Visible = false;
            dataGridView_vacancies.Columns["PositionId"].Visible = false;


            AddVacancies(await RestApi.VacancyService.GetAll(false));
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
            oldVacancy.Position = newVacancy.Position;
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

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
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
                    HandleError(exception);
                }
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
                                                || d.Position.Name.Contains(pattern)
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

        private void dataGridView_vacancies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_update.BackColor = Color.CadetBlue;
            button_update.Enabled = true;
            button_delete.BackColor = Color.CadetBlue;
            button_delete.Enabled = true;
        }
        
        private void VacanciesForm_Shown(object sender, EventArgs e)
        {
            dataGridView_vacancies.ClearSelection();
        }
    }
}