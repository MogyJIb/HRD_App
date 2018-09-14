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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Работающие");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Уволенные");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Сотрудники", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Учет отработанного времени");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Учет отпусков");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Учет поощрений");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Табельный учет", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Отделы");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Должности");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Структура", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Вакансии");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Резюме");
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
            treeNode13.Name = "Узел3";
            treeNode13.Text = "Работающие";
            treeNode14.Name = "Узел4";
            treeNode14.Text = "Уволенные";
            treeNode15.Name = "Узел0";
            treeNode15.Text = "Сотрудники";
            treeNode16.Name = "Узел6";
            treeNode16.Text = "Учет отработанного времени";
            treeNode17.Name = "Узел7";
            treeNode17.Text = "Учет отпусков";
            treeNode18.Name = "Узел8";
            treeNode18.Text = "Учет поощрений";
            treeNode19.Name = "Узел5";
            treeNode19.Text = "Табельный учет";
            treeNode20.Name = "Узел12";
            treeNode20.Text = "Отделы";
            treeNode21.Name = "Узел13";
            treeNode21.Text = "Должности";
            treeNode22.Name = "Узел9";
            treeNode22.Text = "Структура";
            treeNode23.Name = "Узел10";
            treeNode23.Text = "Вакансии";
            treeNode24.Name = "Узел11";
            treeNode24.Text = "Резюме";
            this.treeView_directories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode19,
            treeNode22,
            treeNode23,
            treeNode24});
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.groupBox_directories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_directories;
        private System.Windows.Forms.GroupBox groupBox_directories;
    }
}