
namespace ZverevRadchenkovAzimov
{
    partial class login_user
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Label();
            this.login_name = new System.Windows.Forms.Label();
            this.login_surname = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(352, 29);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(191, 32);
            this.login.TabIndex = 0;
            this.login.Text = "Авторизация";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // login_name
            // 
            this.login_name.AutoSize = true;
            this.login_name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_name.Location = new System.Drawing.Point(38, 84);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(70, 29);
            this.login_name.TabIndex = 1;
            this.login_name.Text = "Имя:";
            this.login_name.Click += new System.EventHandler(this.login_name_Click);
            // 
            // login_surname
            // 
            this.login_surname.AutoSize = true;
            this.login_surname.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_surname.Location = new System.Drawing.Point(38, 130);
            this.login_surname.Name = "login_surname";
            this.login_surname.Size = new System.Drawing.Size(132, 29);
            this.login_surname.TabIndex = 2;
            this.login_surname.Text = "Фамилия:";
            this.login_surname.Click += new System.EventHandler(this.login_surname_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(114, 84);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(221, 29);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_surname.Location = new System.Drawing.Point(176, 130);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(262, 29);
            this.textBox_surname.TabIndex = 4;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(402, 175);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(117, 42);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // login_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 269);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.login_surname);
            this.Controls.Add(this.login_name);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "login_user";
            this.Text = "Авторизация пользователей";
            this.Load += new System.EventHandler(this.login_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label login_name;
        private System.Windows.Forms.Label login_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Button button_login;
    }
}

