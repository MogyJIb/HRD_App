namespace HRD_App.Forms
{
    partial class UpdateHolidaysForm
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
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_finalDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox_employeeId = new System.Windows.Forms.ComboBox();
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
            this.button_cancel.Location = new System.Drawing.Point(547, 116);
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
            this.button_save.Location = new System.Drawing.Point(415, 116);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(124, 36);
            this.button_save.TabIndex = 45;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(487, 39);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(183, 24);
            this.comboBox_type.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Отпускные:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Дата окончания:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Дата начала:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Код сотрудника:";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(145, 71);
            this.dateTimePicker_startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker_startDate.TabIndex = 48;
            this.dateTimePicker_startDate.Value = new System.DateTime(2018, 8, 27, 20, 18, 29, 0);
            // 
            // dateTimePicker_finalDate
            // 
            this.dateTimePicker_finalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_finalDate.Location = new System.Drawing.Point(487, 7);
            this.dateTimePicker_finalDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_finalDate.Name = "dateTimePicker_finalDate";
            this.dateTimePicker_finalDate.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker_finalDate.TabIndex = 49;
            this.dateTimePicker_finalDate.Value = new System.DateTime(2018, 8, 27, 20, 18, 29, 0);
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(487, 71);
            this.textBox_salary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(183, 22);
            this.textBox_salary.TabIndex = 50;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // comboBox_employeeId
            // 
            this.comboBox_employeeId.FormattingEnabled = true;
            this.comboBox_employeeId.Location = new System.Drawing.Point(145, 40);
            this.comboBox_employeeId.Name = "comboBox_employeeId";
            this.comboBox_employeeId.Size = new System.Drawing.Size(183, 24);
            this.comboBox_employeeId.TabIndex = 51;
            // 
            // UpdateHolidaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 166);
            this.Controls.Add(this.comboBox_employeeId);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.dateTimePicker_finalDate);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateHolidaysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учет отпусков";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_finalDate;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox comboBox_employeeId;
    }
}