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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Работающие");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Уволенные");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Сотрудники", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Учет отработанного времени");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Учет отпусков");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Учет поощрений");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Табельный учет", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Отделы");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Должности");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Структура", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Вакансии");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Резюме");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView_directories = new System.Windows.Forms.TreeView();
            this.groupBox_directories = new System.Windows.Forms.GroupBox();
            this.groupBox_structure = new System.Windows.Forms.GroupBox();
            this.treeView_structure = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_directories.SuspendLayout();
            this.groupBox_structure.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_directories
            // 
            this.treeView_directories.BackColor = System.Drawing.SystemColors.Window;
            this.treeView_directories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_directories.ForeColor = System.Drawing.Color.Black;
            this.treeView_directories.ItemHeight = 16;
            this.treeView_directories.Location = new System.Drawing.Point(3, 16);
            this.treeView_directories.Name = "treeView_directories";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Работающие";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "Уволенные";
            treeNode3.Name = "Узел0";
            treeNode3.Text = "Сотрудники";
            treeNode4.Name = "Узел6";
            treeNode4.Text = "Учет отработанного времени";
            treeNode5.Name = "Узел7";
            treeNode5.Text = "Учет отпусков";
            treeNode6.Name = "Узел8";
            treeNode6.Text = "Учет поощрений";
            treeNode7.Name = "Узел5";
            treeNode7.Text = "Табельный учет";
            treeNode8.Name = "Узел12";
            treeNode8.Text = "Отделы";
            treeNode9.Name = "Узел13";
            treeNode9.Text = "Должности";
            treeNode10.Name = "Узел9";
            treeNode10.Text = "Структура";
            treeNode11.Name = "Узел10";
            treeNode11.Text = "Вакансии";
            treeNode12.Name = "Узел11";
            treeNode12.Text = "Резюме";
            this.treeView_directories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView_directories.Size = new System.Drawing.Size(196, 245);
            this.treeView_directories.TabIndex = 0;
            this.treeView_directories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_directories_AfterSelect);
            // 
            // groupBox_directories
            // 
            this.groupBox_directories.Controls.Add(this.treeView_directories);
            this.groupBox_directories.Location = new System.Drawing.Point(12, 12);
            this.groupBox_directories.Name = "groupBox_directories";
            this.groupBox_directories.Size = new System.Drawing.Size(202, 264);
            this.groupBox_directories.TabIndex = 0;
            this.groupBox_directories.TabStop = false;
            this.groupBox_directories.Text = "Справочники";
            // 
            // groupBox_structure
            // 
            this.groupBox_structure.Controls.Add(this.treeView_structure);
            this.groupBox_structure.Location = new System.Drawing.Point(3, 3);
            this.groupBox_structure.Name = "groupBox_structure";
            this.groupBox_structure.Size = new System.Drawing.Size(216, 351);
            this.groupBox_structure.TabIndex = 1;
            this.groupBox_structure.TabStop = false;
            this.groupBox_structure.Text = "Структура";
            // 
            // treeView_structure
            // 
            this.treeView_structure.BackColor = System.Drawing.SystemColors.Window;
            this.treeView_structure.ForeColor = System.Drawing.Color.Black;
            this.treeView_structure.ItemHeight = 16;
            this.treeView_structure.Location = new System.Drawing.Point(3, 16);
            this.treeView_structure.Name = "treeView_structure";
            this.treeView_structure.Size = new System.Drawing.Size(207, 245);
            this.treeView_structure.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox_structure);
            this.panel1.Location = new System.Drawing.Point(238, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 350);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(225, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_directories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.groupBox_directories.ResumeLayout(false);
            this.groupBox_structure.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_directories;
        private System.Windows.Forms.GroupBox groupBox_directories;
        private System.Windows.Forms.GroupBox groupBox_structure;
        private System.Windows.Forms.TreeView treeView_structure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}