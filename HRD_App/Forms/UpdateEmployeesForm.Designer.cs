﻿namespace HRD_App.Forms
{
    partial class UpdateEmployeesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_employmentDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_education = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_phone = new System.Windows.Forms.MaskedTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(109, 32);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(138, 20);
            this.textBox_lastName.TabIndex = 2;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(109, 58);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(138, 20);
            this.textBox_firstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Location = new System.Drawing.Point(109, 84);
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(138, 20);
            this.textBox_patronymic.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата рождения:";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(417, 32);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(138, 20);
            this.textBox_address.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Адрес:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Телефон:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Образование:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Дата принятия на работу:";
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(417, 6);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker_birthday.TabIndex = 6;
            this.dateTimePicker_birthday.Value = new System.DateTime(2018, 8, 27, 20, 18, 29, 0);
            // 
            // comboBox_position
            // 
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Location = new System.Drawing.Point(109, 110);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(138, 21);
            this.comboBox_position.TabIndex = 5;
            // 
            // dateTimePicker_employmentDate
            // 
            this.dateTimePicker_employmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_employmentDate.Location = new System.Drawing.Point(417, 110);
            this.dateTimePicker_employmentDate.Name = "dateTimePicker_employmentDate";
            this.dateTimePicker_employmentDate.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker_employmentDate.TabIndex = 10;
            this.dateTimePicker_employmentDate.Value = new System.DateTime(2018, 8, 27, 20, 18, 29, 0);
            // 
            // comboBox_education
            // 
            this.comboBox_education.FormattingEnabled = true;
            this.comboBox_education.Location = new System.Drawing.Point(417, 84);
            this.comboBox_education.Name = "comboBox_education";
            this.comboBox_education.Size = new System.Drawing.Size(138, 21);
            this.comboBox_education.TabIndex = 9;
            // 
            // maskedTextBox_phone
            // 
            this.maskedTextBox_phone.Location = new System.Drawing.Point(417, 58);
            this.maskedTextBox_phone.Mask = "+375 00 000-00-00";
            this.maskedTextBox_phone.Name = "maskedTextBox_phone";
            this.maskedTextBox_phone.Size = new System.Drawing.Size(138, 20);
            this.maskedTextBox_phone.TabIndex = 8;
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
            this.button_save.Location = new System.Drawing.Point(365, 146);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(93, 29);
            this.button_save.TabIndex = 23;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
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
            this.button_cancel.Location = new System.Drawing.Point(464, 146);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(93, 29);
            this.button_cancel.TabIndex = 24;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = false;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(109, 6);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(138, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Код:";
            // 
            // UpdateEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(569, 185);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.maskedTextBox_phone);
            this.Controls.Add(this.comboBox_education);
            this.Controls.Add(this.dateTimePicker_employmentDate);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_patronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "UpdateEmployeesForm";
            this.Text = "Сотрудники";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_patronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.DateTimePicker dateTimePicker_employmentDate;
        private System.Windows.Forms.ComboBox comboBox_education;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_phone;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label10;
    }
}