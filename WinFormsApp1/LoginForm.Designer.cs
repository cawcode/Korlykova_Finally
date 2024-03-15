﻿namespace WinFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Gold;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogin.Location = new Point(12, 138);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 29);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += btnLogin_Click_1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 34);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 27);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 87);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(200, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(12, 11);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(52, 20);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 64);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(280, 75);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 193);
            Controls.Add(label1);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaxiMax";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
        private Label label1;
    }
}