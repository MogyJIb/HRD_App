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
    public partial class UpdateVacanciesForm : BaseForm
    {
        private Dictionary<int, Position> positions;
        private Vacancy vacancy;
        private event OnValueChangedListener<Vacancy> OnValueChanged;

        public UpdateVacanciesForm(int vacancyId, bool enabled)
        {
            InitializeComponent();

            setFieldsEnabled(enabled);

            positions = new Dictionary<int, Position>();
            loadPositionsList(positions);

            if (vacancyId != -1) setVacancy(vacancyId);
        }

        public UpdateVacanciesForm SetOnValueChangedListener(OnValueChangedListener<Vacancy> listener)
        {
            this.OnValueChanged += listener;
            return this;
        }

        private async void loadPositionsList(Dictionary<int, Position> positions)
        {
            (await RestApi.PositionService.GetAll(false)).ForEach(d => positions.Add(d.PositionId, d));
            comboBox_position.Items.AddRange(positions.Values.Select(d => d.Name).ToArray());
        }

        private void setFieldsEnabled(bool enabled)
        {
            textBox_id.Enabled = false;
            comboBox_position.Enabled = enabled;
            comboBox_number.Enabled = enabled;
        }

        private async void setVacancy(int vacancyId)
        {
            try
            {
                vacancy = await RestApi.VacancyService.Get(vacancyId);

                textBox_id.Text = vacancy.VacancyId.ToString();
                comboBox_position.Text = vacancy.Position.Name.ToString();
                comboBox_number.Text = vacancy.Number.ToString();
            }
            catch (Exception exception)
            {
                HandleError(exception);
            }
        }

        private async void button_save_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            try
            {
                Position position = positions.Values.First(d => d.Name == comboBox_position.Text);

                Vacancy vacancy = new Vacancy();
                vacancy.PositionId = position.PositionId;
                vacancy.Number = Int32.Parse(comboBox_number.Text);

                int id = (textBox_id.Text != "") ? Int32.Parse(textBox_id.Text) : -1;
                if (id == -1)
                    vacancy = await RestApi.VacancyService.Add(vacancy);
                else
                {
                    vacancy.VacancyId = id;
                    await RestApi.VacancyService.Update(id, vacancy);
                    vacancy.Position = position;
                }
                MessageBox.Show("Запись успешно сохранена!");

                OnValueChanged(vacancy);
                Close();
            }
            catch (Exception exception)
            {
                HandleError(exception);
            }
        }

        private bool Validate()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (comboBox_position.Text == "")
            {
                errorProvider.SetError(comboBox_position, "Поле обязательно для заполнения!");
                isValid = false;
            }

            if (comboBox_number.Text == "")
            {
                errorProvider.SetError(comboBox_number, "Поле обязательно для заполнения!");
                isValid = false;
            }
            
            try
            {
                Int32.Parse(comboBox_number.Text);
            }
            catch (Exception exception)
            {
                errorProvider.SetError(comboBox_number, "Неверный формат!");
                isValid = false;
            }

            return isValid;
        }
    }
}
