namespace HRD_App.Forms
{
    partial class UpdateResumesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.maskedTextBox_phone = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_education = new System.Windows.Forms.ComboBox();
            this.comboBox_vacancy = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_institution = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_specialty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(145, 7);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(183, 22);
            this.textBox_id.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Код:";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.CadetBlue;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(616, 198);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 36);
            this.button_cancel.TabIndex = 46;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.CadetBlue;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(484, 198);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(124, 36);
            this.button_save.TabIndex = 45;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox_phone
            // 
            this.maskedTextBox_phone.Location = new System.Drawing.Point(556, 7);
            this.maskedTextBox_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox_phone.Mask = "+375 00 000-00-00";
            this.maskedTextBox_phone.Name = "maskedTextBox_phone";
            this.maskedTextBox_phone.Size = new System.Drawing.Size(183, 22);
            this.maskedTextBox_phone.TabIndex = 37;
            // 
            // comboBox_education
            // 
            this.comboBox_education.FormattingEnabled = true;
            this.comboBox_education.Location = new System.Drawing.Point(556, 71);
            this.comboBox_education.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_education.Name = "comboBox_education";
            this.comboBox_education.Size = new System.Drawing.Size(183, 24);
            this.comboBox_education.TabIndex = 39;
            // 
            // comboBox_vacancy
            // 
            this.comboBox_vacancy.FormattingEnabled = true;
            this.comboBox_vacancy.Location = new System.Drawing.Point(145, 39);
            this.comboBox_vacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_vacancy.Name = "comboBox_vacancy";
            this.comboBox_vacancy.Size = new System.Drawing.Size(183, 24);
            this.comboBox_vacancy.TabIndex = 33;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(145, 169);
            this.dateTimePicker_birthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker_birthday.TabIndex = 34;
            this.dateTimePicker_birthday.Value = new System.DateTime(2018, 8, 27, 20, 18, 29, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Образование:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Телефон:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(556, 39);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(183, 22);
            this.textBox_email.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Должность:";
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Location = new System.Drawing.Point(145, 137);
            this.textBox_patronymic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(183, 22);
            this.textBox_patronymic.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Отчество:";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(145, 105);
            this.textBox_firstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(183, 22);
            this.textBox_firstName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Имя:";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(145, 73);
            this.textBox_lastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(183, 22);
            this.textBox_lastName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Фамилия:";
            // 
            // textBox_institution
            // 
            this.textBox_institution.Location = new System.Drawing.Point(556, 103);
            this.textBox_institution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_institution.Name = "textBox_institution";
            this.textBox_institution.Size = new System.Drawing.Size(183, 22);
            this.textBox_institution.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Учреждение образования:";
            // 
            // textBox_specialty
            // 
            this.textBox_specialty.Location = new System.Drawing.Point(556, 135);
            this.textBox_specialty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_specialty.Name = "textBox_specialty";
            this.textBox_specialty.Size = new System.Drawing.Size(183, 22);
            this.textBox_specialty.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Специальность:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UpdateResumesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 250);
            this.Controls.Add(this.textBox_specialty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_institution);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.maskedTextBox_phone);
            this.Controls.Add(this.comboBox_education);
            this.Controls.Add(this.comboBox_vacancy);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_patronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateResumesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Резюме";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_phone;
        private System.Windows.Forms.ComboBox comboBox_education;
        private System.Windows.Forms.ComboBox comboBox_vacancy;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_patronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_institution;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_specialty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}