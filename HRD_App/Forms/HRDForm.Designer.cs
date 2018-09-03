namespace HRD_App.Forms
{
    partial class HRDForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Все");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Работающие");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Уволенные");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Сотрудники", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Учет посещаемости");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Учет отпусков");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Учет поощрений");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Табельный учет", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Отделы");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Должности");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Структура", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Вакансии");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Резюме");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_directories = new System.Windows.Forms.GroupBox();
            this.treeView_directories = new System.Windows.Forms.TreeView();
            this.panel_employees = new System.Windows.Forms.Panel();
            this.dataGridView_employees = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox_directories.SuspendLayout();
            this.panel_employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_directories
            // 
            this.groupBox_directories.Controls.Add(this.treeView_directories);
            this.groupBox_directories.Location = new System.Drawing.Point(12, 12);
            this.groupBox_directories.Name = "groupBox_directories";
            this.groupBox_directories.Size = new System.Drawing.Size(217, 286);
            this.groupBox_directories.TabIndex = 0;
            this.groupBox_directories.TabStop = false;
            this.groupBox_directories.Text = "Справочники";
            // 
            // treeView_directories
            // 
            this.treeView_directories.BackColor = System.Drawing.SystemColors.Window;
            this.treeView_directories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_directories.ForeColor = System.Drawing.Color.Black;
            this.treeView_directories.ItemHeight = 16;
            this.treeView_directories.Location = new System.Drawing.Point(3, 16);
            this.treeView_directories.Name = "treeView_directories";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Все";
            treeNode2.Name = "Узел3";
            treeNode2.Text = "Работающие";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "Уволенные";
            treeNode4.Name = "Узел0";
            treeNode4.Text = "Сотрудники";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "Учет посещаемости";
            treeNode6.Name = "Узел7";
            treeNode6.Text = "Учет отпусков";
            treeNode7.Name = "Узел8";
            treeNode7.Text = "Учет поощрений";
            treeNode8.Name = "Узел5";
            treeNode8.Text = "Табельный учет";
            treeNode9.Name = "Узел12";
            treeNode9.Text = "Отделы";
            treeNode10.Name = "Узел13";
            treeNode10.Text = "Должности";
            treeNode11.Name = "Узел9";
            treeNode11.Text = "Структура";
            treeNode12.Name = "Узел10";
            treeNode12.Text = "Вакансии";
            treeNode13.Name = "Узел11";
            treeNode13.Text = "Резюме";
            this.treeView_directories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode11,
            treeNode12,
            treeNode13});
            this.treeView_directories.Size = new System.Drawing.Size(211, 267);
            this.treeView_directories.TabIndex = 0;
            // 
            // panel_employees
            // 
            this.panel_employees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_employees.Controls.Add(this.dataGridView_employees);
            this.panel_employees.Location = new System.Drawing.Point(235, 38);
            this.panel_employees.Name = "panel_employees";
            this.panel_employees.Size = new System.Drawing.Size(717, 407);
            this.panel_employees.TabIndex = 1;
            // 
            // dataGridView_employees
            // 
            this.dataGridView_employees.AllowUserToDeleteRows = false;
            this.dataGridView_employees.AllowUserToResizeColumns = false;
            this.dataGridView_employees.AllowUserToResizeRows = false;
            this.dataGridView_employees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_employees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_employees.EnableHeadersVisualStyles = false;
            this.dataGridView_employees.GridColor = System.Drawing.Color.White;
            this.dataGridView_employees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_employees.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_employees.Name = "dataGridView_employees";
            this.dataGridView_employees.ReadOnly = true;
            this.dataGridView_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_employees.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_employees.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_employees.Size = new System.Drawing.Size(710, 313);
            this.dataGridView_employees.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Код";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Должность";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата рождения";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Адрес";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Телефон";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Образование";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Дата принятия на работу";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // textBox_search
            // 
            this.textBox_search.ForeColor = System.Drawing.Color.Gray;
            this.textBox_search.Location = new System.Drawing.Point(790, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(136, 20);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.Text = "Поиск";
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.CadetBlue;
            this.button_update.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(35, 339);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(160, 29);
            this.button_update.TabIndex = 8;
            this.button_update.Text = "Редактировать";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = global::HRD_App.Properties.Resources.search_48835;
            this.pictureBox_search.Location = new System.Drawing.Point(908, 14);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_search.TabIndex = 2;
            this.pictureBox_search.TabStop = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.CadetBlue;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(35, 304);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(160, 29);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            // 
            // HRDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 500);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.panel_employees);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.groupBox_directories);
            this.Name = "HRDForm";
            this.Text = "Отдел кадров";
            this.groupBox_directories.ResumeLayout(false);
            this.panel_employees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_directories;
        private System.Windows.Forms.TreeView treeView_directories;
        private System.Windows.Forms.Panel panel_employees;
        private System.Windows.Forms.DataGridView dataGridView_employees;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button_add;
    }
}