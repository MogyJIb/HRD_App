namespace HRD_App.Forms
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работающиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволенныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.табельныйУчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетОтработанногоВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетОтпусковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетПоощренийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.структураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вакансииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резюмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_structure = new System.Windows.Forms.GroupBox();
            this.treeView_structure = new System.Windows.Forms.TreeView();
            this.groupBox_employees = new System.Windows.Forms.GroupBox();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.groupBox_structure.SuspendLayout();
            this.groupBox_employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.табельныйУчетToolStripMenuItem,
            this.структураToolStripMenuItem,
            this.вакансииToolStripMenuItem,
            this.резюмеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1051, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работающиеToolStripMenuItem,
            this.уволенныеToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // работающиеToolStripMenuItem
            // 
            this.работающиеToolStripMenuItem.Name = "работающиеToolStripMenuItem";
            this.работающиеToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.работающиеToolStripMenuItem.Text = "Работающие";
            this.работающиеToolStripMenuItem.Click += new System.EventHandler(this.работающиеToolStripMenuItem_Click);
            // 
            // уволенныеToolStripMenuItem
            // 
            this.уволенныеToolStripMenuItem.Name = "уволенныеToolStripMenuItem";
            this.уволенныеToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.уволенныеToolStripMenuItem.Text = "Уволенные";
            this.уволенныеToolStripMenuItem.Click += new System.EventHandler(this.уволенныеToolStripMenuItem_Click);
            // 
            // табельныйУчетToolStripMenuItem
            // 
            this.табельныйУчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учетОтработанногоВремениToolStripMenuItem,
            this.учетОтпусковToolStripMenuItem,
            this.учетПоощренийToolStripMenuItem});
            this.табельныйУчетToolStripMenuItem.Name = "табельныйУчетToolStripMenuItem";
            this.табельныйУчетToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.табельныйУчетToolStripMenuItem.Text = "Табельный учет";
            // 
            // учетОтработанногоВремениToolStripMenuItem
            // 
            this.учетОтработанногоВремениToolStripMenuItem.Name = "учетОтработанногоВремениToolStripMenuItem";
            this.учетОтработанногоВремениToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.учетОтработанногоВремениToolStripMenuItem.Text = "Учет отработанного времени";
            this.учетОтработанногоВремениToolStripMenuItem.Click += new System.EventHandler(this.учетОтработанногоВремениToolStripMenuItem_Click);
            // 
            // учетОтпусковToolStripMenuItem
            // 
            this.учетОтпусковToolStripMenuItem.Name = "учетОтпусковToolStripMenuItem";
            this.учетОтпусковToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.учетОтпусковToolStripMenuItem.Text = "Учет отпусков";
            this.учетОтпусковToolStripMenuItem.Click += new System.EventHandler(this.учетОтпусковToolStripMenuItem_Click);
            // 
            // учетПоощренийToolStripMenuItem
            // 
            this.учетПоощренийToolStripMenuItem.Name = "учетПоощренийToolStripMenuItem";
            this.учетПоощренийToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.учетПоощренийToolStripMenuItem.Text = "Учет поощрений";
            this.учетПоощренийToolStripMenuItem.Click += new System.EventHandler(this.учетПоощренийToolStripMenuItem_Click);
            // 
            // структураToolStripMenuItem
            // 
            this.структураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отделыToolStripMenuItem,
            this.должностиToolStripMenuItem});
            this.структураToolStripMenuItem.Name = "структураToolStripMenuItem";
            this.структураToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.структураToolStripMenuItem.Text = "Структура";
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.отделыToolStripMenuItem.Text = "Отделы";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // вакансииToolStripMenuItem
            // 
            this.вакансииToolStripMenuItem.Name = "вакансииToolStripMenuItem";
            this.вакансииToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.вакансииToolStripMenuItem.Text = "Вакансии";
            this.вакансииToolStripMenuItem.Click += new System.EventHandler(this.вакансииToolStripMenuItem_Click);
            // 
            // резюмеToolStripMenuItem
            // 
            this.резюмеToolStripMenuItem.Name = "резюмеToolStripMenuItem";
            this.резюмеToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.резюмеToolStripMenuItem.Text = "Резюме";
            this.резюмеToolStripMenuItem.Click += new System.EventHandler(this.резюмеToolStripMenuItem_Click);
            // 
            // groupBox_structure
            // 
            this.groupBox_structure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_structure.Controls.Add(this.treeView_structure);
            this.groupBox_structure.Location = new System.Drawing.Point(13, 32);
            this.groupBox_structure.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_structure.Name = "groupBox_structure";
            this.groupBox_structure.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_structure.Size = new System.Drawing.Size(500, 405);
            this.groupBox_structure.TabIndex = 1;
            this.groupBox_structure.TabStop = false;
            this.groupBox_structure.Text = "Структура";
            // 
            // treeView_structure
            // 
            this.treeView_structure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView_structure.BackColor = System.Drawing.SystemColors.Window;
            this.treeView_structure.ForeColor = System.Drawing.Color.Black;
            this.treeView_structure.ItemHeight = 16;
            this.treeView_structure.Location = new System.Drawing.Point(4, 19);
            this.treeView_structure.Margin = new System.Windows.Forms.Padding(4);
            this.treeView_structure.Name = "treeView_structure";
            this.treeView_structure.Size = new System.Drawing.Size(492, 382);
            this.treeView_structure.TabIndex = 0;
            this.treeView_structure.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_structure_AfterSelect);
            // 
            // groupBox_employees
            // 
            this.groupBox_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_employees.Controls.Add(this.dataGridView_employees);
            this.groupBox_employees.Location = new System.Drawing.Point(521, 32);
            this.groupBox_employees.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_employees.Name = "groupBox_employees";
            this.groupBox_employees.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_employees.Size = new System.Drawing.Size(517, 409);
            this.groupBox_employees.TabIndex = 2;
            this.groupBox_employees.TabStop = false;
            this.groupBox_employees.Text = "Сотрудники";
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AllowUserToAddRows = false;
            this.dataGridView_employees.AllowUserToDeleteRows = false;
            this.dataGridView_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employees.ColumnHeadersVisible = false;
            this.dataGridView_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_employees.EnableHeadersVisualStyles = false;
            this.dataGridView_employees.GridColor = System.Drawing.Color.White;
            this.dataGridView_employees.Location = new System.Drawing.Point(4, 19);
            this.dataGridView_employees.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_employees.MultiSelect = false;
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.ReadOnly = true;
            this.dataGridView_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_employees.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_employees.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employees.Size = new System.Drawing.Size(509, 386);
            this.dataGridView_employees.TabIndex = 0;
            this.dataGridView_employees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employees_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LastName";
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Patronymic";
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EmployeeId";
            this.Column4.HeaderText = "Код";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 460);
            this.Controls.Add(this.groupBox_structure);
            this.Controls.Add(this.groupBox_employees);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_structure.ResumeLayout(false);
            this.groupBox_employees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работающиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уволенныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem табельныйУчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетОтработанногоВремениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетОтпусковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетПоощренийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem структураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резюмеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_structure;
        private System.Windows.Forms.TreeView treeView_structure;
        private System.Windows.Forms.GroupBox groupBox_employees;
        private System.Windows.Forms.DataGridView dataGridView_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}