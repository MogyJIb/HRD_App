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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Учет посещаемости");
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
            this.treeView_directories = new System.Windows.Forms.TreeView();
            this.groupBox_directories = new System.Windows.Forms.GroupBox();
            this.groupBox_directories.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_directories
            // 
            this.treeView_directories.BackColor = System.Drawing.SystemColors.Window;
            this.treeView_directories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_directories.ForeColor = System.Drawing.Color.Black;
            this.treeView_directories.ItemHeight = 16;
            this.treeView_directories.Location = new System.Drawing.Point(4, 19);
            this.treeView_directories.Margin = new System.Windows.Forms.Padding(4);
            this.treeView_directories.Name = "treeView_directories";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Работающие";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "Уволенные";
            treeNode3.Name = "Узел0";
            treeNode3.Text = "Сотрудники";
            treeNode4.Name = "Узел6";
            treeNode4.Text = "Учет посещаемости";
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
            this.treeView_directories.Size = new System.Drawing.Size(262, 302);
            this.treeView_directories.TabIndex = 0;
            this.treeView_directories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_directories_AfterSelect);
            // 
            // groupBox_directories
            // 
            this.groupBox_directories.Controls.Add(this.treeView_directories);
            this.groupBox_directories.Location = new System.Drawing.Point(55, 3);
            this.groupBox_directories.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_directories.Name = "groupBox_directories";
            this.groupBox_directories.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_directories.Size = new System.Drawing.Size(270, 325);
            this.groupBox_directories.TabIndex = 0;
            this.groupBox_directories.TabStop = false;
            this.groupBox_directories.Text = "Справочники";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 332);
            this.Controls.Add(this.groupBox_directories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Отдел кадров";
            this.groupBox_directories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_directories;
        private System.Windows.Forms.GroupBox groupBox_directories;
    }
}