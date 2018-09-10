using HRD_App.Errors;
using HRD_App.Logic;
using HRD_App.Rest;
using HRD_App.Utils;
using HRD_DataLibrary.Errors;
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
    public partial class UpdateResumesForm : Form
    {
        private Dictionary<int, Vacancy> vacancies;
        private Resume resume;
        private event OnValueChangedListener<Resume> OnValueChanged;

        public UpdateResumesForm(int resumeId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            vacancies = new Dictionary<int, Vacancy>();
            loadVacanciesList(vacancies);

            if (resumeId != -1) setResume(resumeId);
        }

        public UpdateResumesForm SetOnValueChangedListener(OnValueChangedListener<Resume> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private async void loadVacanciesList(Dictionary<int, Vacancy> vacancies)
        {
            (await RestApi.VacancyService.GetAll(false)).ForEach(d => vacancies.Add(d.VacancyId, d));
            comboBox_vacancy.Items.AddRange(vacancies.Values.Select(d => d.Position.Name).ToArray());
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            comboBox_vacancy.Enabled = enabled;
            textBox_firstName.Enabled = enabled;
            textBox_lastName.Enabled = enabled;
            textBox_patronymic.Enabled = enabled;
            dateTimePicker_birthday.Enabled = enabled;
            textBox_email.Enabled = enabled;
            maskedTextBox_phone.Enabled = enabled;
            comboBox_education.Enabled = enabled;
            textBox_institution.Enabled = enabled;
            textBox_specialty.Enabled = enabled;
        }

        private async void setResume(int resumeId)
        {
            try
            {
                resume = await RestApi.ResumeService.Get(resumeId);

                textBox_id.Text = resume.ResumeId.ToString();
                comboBox_vacancy.Text = resume.Vacancy.Position.Name.ToString();
                textBox_firstName.Text = resume.FirstName;
                textBox_lastName.Text = resume.LastName;
                textBox_patronymic.Text = resume.Patronymic;
                dateTimePicker_birthday.Text = resume.BirthDate.ToString();
                textBox_email.Text = resume.Email;
                maskedTextBox_phone.Text = resume.Phone;
                comboBox_education.Text = resume.Education;
                textBox_institution.Text = resume.Institution.ToString();
                textBox_specialty.Text = resume.Specialty.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
                Close();
            }
        }

        private async void button_save_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            try
            {
                Vacancy vacancy = vacancies.Values.First(d => d.Position.Name == comboBox_vacancy.Text);

                Resume resume = new Resume();
                resume.VacancyId = vacancy.VacancyId;
                resume.FirstName = textBox_firstName.Text;
                resume.LastName = textBox_lastName.Text;
                resume.Patronymic = textBox_patronymic.Text;
                resume.BirthDate = dateTimePicker_birthday.Value.Date;
                resume.Email = textBox_email.Text;
                resume.Phone = maskedTextBox_phone.Text;
                resume.Education = comboBox_education.Text;
                resume.Institution = textBox_institution.Text;
                resume.Specialty = textBox_specialty.Text;

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    resume = await RestApi.ResumeService.Add(resume);
                else
                {
                    resume.ResumeId = id;
                    await RestApi.ResumeService.Update(id, resume);
                    resume.Vacancy = vacancy;
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(resume);
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }

        private bool Validate()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (comboBox_vacancy.Text == "")
            {
                errorProvider.SetError(comboBox_vacancy, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_firstName.Text == "")
            {
                errorProvider.SetError(textBox_firstName, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_lastName.Text == "")
            {
                errorProvider.SetError(textBox_lastName, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (textBox_patronymic.Text == "")
            {
                errorProvider.SetError(textBox_patronymic, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (dateTimePicker_birthday.Text == "")
            {
                errorProvider.SetError(dateTimePicker_birthday, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_email.Text == "")
            {
                errorProvider.SetError(textBox_email, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (maskedTextBox_phone.Text == "")
            {
                errorProvider.SetError(maskedTextBox_phone, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (comboBox_education.Text == "")
            {
                errorProvider.SetError(dateTimePicker_birthday, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_institution.Text == "")
            {
                errorProvider.SetError(textBox_institution, "Поле обязательно для заполнения!");
                isValid = false;
            }
            if (textBox_specialty.Text == "")
            {
                errorProvider.SetError(textBox_specialty, "Поле обязательно для заполнения!");
                isValid = false;
            }

            return isValid;
        }
    }
}
