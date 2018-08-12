namespace HRD_App
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_authorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_login.ForeColor = System.Drawing.Color.Gray;
            this.textBox_login.Location = new System.Drawing.Point(101, 37);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(213, 22);
            this.textBox_login.TabIndex = 1;
            this.textBox_login.TabStop = false;
            this.textBox_login.Text = "Логин";
            this.textBox_login.Enter += new System.EventHandler(this.textBox_login_Enter);
            this.textBox_login.Leave += new System.EventHandler(this.textBox_login_Leave);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_password.ForeColor = System.Drawing.Color.Gray;
            this.textBox_password.Location = new System.Drawing.Point(101, 69);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(213, 22);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.TabStop = false;
            this.textBox_password.Text = "Пароль";
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Enter);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // button_authorization
            // 
            this.button_authorization.BackColor = System.Drawing.Color.CadetBlue;
            this.button_authorization.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_authorization.FlatAppearance.BorderSize = 0;
            this.button_authorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_authorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_authorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_authorization.ForeColor = System.Drawing.Color.White;
            this.button_authorization.Location = new System.Drawing.Point(101, 101);
            this.button_authorization.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.Size = new System.Drawing.Size(213, 36);
            this.button_authorization.TabIndex = 3;
            this.button_authorization.Text = "Войти";
            this.button_authorization.UseVisualStyleBackColor = false;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 180);
            this.Controls.Add(this.button_authorization);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_authorization;
    }
}

