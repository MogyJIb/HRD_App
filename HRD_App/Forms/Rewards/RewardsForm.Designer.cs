namespace HRD_App.Forms
{
    partial class RewardsForm
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
            this.dataGridView_rewards = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rewards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_rewards
            // 
            this.dataGridView_rewards.AllowUserToDeleteRows = false;
            this.dataGridView_rewards.AllowUserToResizeColumns = false;
            this.dataGridView_rewards.AllowUserToResizeRows = false;
            this.dataGridView_rewards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_rewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_rewards.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_rewards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_rewards.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_rewards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_rewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_rewards.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_rewards.EnableHeadersVisualStyles = false;
            this.dataGridView_rewards.GridColor = System.Drawing.Color.White;
            this.dataGridView_rewards.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_rewards.Location = new System.Drawing.Point(12, 38);
            this.dataGridView_rewards.Name = "dataGridView_rewards";
            this.dataGridView_rewards.ReadOnly = true;
            this.dataGridView_rewards.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_rewards.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_rewards.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_rewards.Size = new System.Drawing.Size(709, 307);
            this.dataGridView_rewards.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Код";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код сотрудника";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Причина";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_search.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox_search.Image = global::HRD_App.Properties.Resources.baseline_search_white_18dp;
            this.pictureBox_search.Location = new System.Drawing.Point(692, 15);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(28, 18);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_search.TabIndex = 17;
            this.pictureBox_search.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.ForeColor = System.Drawing.Color.Gray;
            this.textBox_search.Location = new System.Drawing.Point(474, 14);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(247, 20);
            this.textBox_search.TabIndex = 16;
            this.textBox_search.Text = "Поиск";
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
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
            this.button_update.Location = new System.Drawing.Point(177, 351);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(160, 29);
            this.button_update.TabIndex = 15;
            this.button_update.Text = "Редактировать";
            this.button_update.UseVisualStyleBackColor = false;
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
            this.button_add.Location = new System.Drawing.Point(11, 351);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(160, 29);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
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
            this.button_delete.Location = new System.Drawing.Point(343, 352);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(160, 29);
            this.button_delete.TabIndex = 19;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // RewardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 392);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_rewards);
            this.Name = "RewardsForm";
            this.Text = "Учет поощрений";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rewards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_rewards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
    }
}