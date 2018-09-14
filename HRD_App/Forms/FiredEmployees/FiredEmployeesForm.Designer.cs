namespace HRD_App.Forms
{
    partial class FiredEmployeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_firedEmployees = new System.Windows.Forms.DataGridView();
            this.FiredEmployeeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDismissalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firedEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_firedEmployees
            // 
            this.dataGridView_firedEmployees.AllowUserToAddRows = false;
            this.dataGridView_firedEmployees.AllowUserToDeleteRows = false;
            this.dataGridView_firedEmployees.AllowUserToResizeColumns = false;
            this.dataGridView_firedEmployees.AllowUserToResizeRows = false;
            this.dataGridView_firedEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_firedEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_firedEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_firedEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_firedEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_firedEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_firedEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_firedEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FiredEmployeeIdColumn,
            this.EmployeeIdColumn,
            this.DateOfDismissalColumn,
            this.ReasonColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_firedEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_firedEmployees.EnableHeadersVisualStyles = false;
            this.dataGridView_firedEmployees.GridColor = System.Drawing.Color.White;
            this.dataGridView_firedEmployees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_firedEmployees.Location = new System.Drawing.Point(16, 47);
            this.dataGridView_firedEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_firedEmployees.MultiSelect = false;
            this.dataGridView_firedEmployees.Name = "dataGridView_firedEmployees";
            this.dataGridView_firedEmployees.ReadOnly = true;
            this.dataGridView_firedEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_firedEmployees.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_firedEmployees.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_firedEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_firedEmployees.Size = new System.Drawing.Size(947, 378);
            this.dataGridView_firedEmployees.TabIndex = 0;
            this.dataGridView_firedEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_firedEmployees_CellClick);
            // 
            // FiredEmployeeIdColumn
            // 
            this.FiredEmployeeIdColumn.DataPropertyName = "FiredEmployeeId";
            this.FiredEmployeeIdColumn.HeaderText = "Код";
            this.FiredEmployeeIdColumn.Name = "FiredEmployeeIdColumn";
            this.FiredEmployeeIdColumn.ReadOnly = true;
            // 
            // EmployeeIdColumn
            // 
            this.EmployeeIdColumn.DataPropertyName = "EmployeeId";
            this.EmployeeIdColumn.HeaderText = "Код сотрудника";
            this.EmployeeIdColumn.Name = "EmployeeIdColumn";
            this.EmployeeIdColumn.ReadOnly = true;
            // 
            // DateOfDismissalColumn
            // 
            this.DateOfDismissalColumn.DataPropertyName = "DateOfDismissal";
            this.DateOfDismissalColumn.HeaderText = "Дата увольнения";
            this.DateOfDismissalColumn.Name = "DateOfDismissalColumn";
            this.DateOfDismissalColumn.ReadOnly = true;
            // 
            // ReasonColumn
            // 
            this.ReasonColumn.DataPropertyName = "Reason";
            this.ReasonColumn.HeaderText = "Причина";
            this.ReasonColumn.Name = "ReasonColumn";
            this.ReasonColumn.ReadOnly = true;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.ForeColor = System.Drawing.Color.Gray;
            this.textBox_search.Location = new System.Drawing.Point(632, 17);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(328, 22);
            this.textBox_search.TabIndex = 16;
            this.textBox_search.Text = "Поиск";
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.Enter += new System.EventHandler(this.textBox_search_Enter);
            this.textBox_search.Leave += new System.EventHandler(this.textBox_search_Leave);
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_update.BackColor = System.Drawing.Color.CadetBlue;
            this.button_update.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(237, 432);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(213, 36);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Редактировать";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add.BackColor = System.Drawing.Color.CadetBlue;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(16, 432);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(213, 36);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_delete.BackColor = System.Drawing.Color.CadetBlue;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(459, 433);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(213, 36);
            this.button_delete.TabIndex = 19;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_search.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox_search.Image = global::HRD_App.Properties.Resources.baseline_search_white_18dp;
            this.pictureBox_search.Location = new System.Drawing.Point(923, 18);
            this.pictureBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(37, 22);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_search.TabIndex = 17;
            this.pictureBox_search.TabStop = false;
            // 
            // FiredEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 482);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_firedEmployees);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FiredEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уволенные сотрудники";
            this.Shown += new System.EventHandler(this.FiredEmployeesForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firedEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_firedEmployees;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiredEmployeeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDismissalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonColumn;
    }
}