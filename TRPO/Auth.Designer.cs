namespace TRPO
{
    partial class Auth
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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Auth = new System.Windows.Forms.Button();
            this.brigadirForm = new System.Windows.Forms.Button();
            this.button_Main = new System.Windows.Forms.Button();
            this.button_Master = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Login.Location = new System.Drawing.Point(113, 100);
            this.textBox_Login.Multiline = true;
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(150, 35);
            this.textBox_Login.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password.Location = new System.Drawing.Point(113, 169);
            this.textBox_Password.Multiline = true;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(150, 35);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_Auth
            // 
            this.button_Auth.Location = new System.Drawing.Point(137, 226);
            this.button_Auth.Name = "button_Auth";
            this.button_Auth.Size = new System.Drawing.Size(100, 33);
            this.button_Auth.TabIndex = 2;
            this.button_Auth.Text = "Войти";
            this.button_Auth.UseVisualStyleBackColor = true;
            this.button_Auth.Click += new System.EventHandler(this.button_Auth_Click);
            // 
            // brigadirForm
            // 
            this.brigadirForm.Location = new System.Drawing.Point(12, 12);
            this.brigadirForm.Name = "brigadirForm";
            this.brigadirForm.Size = new System.Drawing.Size(75, 23);
            this.brigadirForm.TabIndex = 3;
            this.brigadirForm.Text = "бригадир";
            this.brigadirForm.UseVisualStyleBackColor = true;
            this.brigadirForm.Click += new System.EventHandler(this.brigadirForm_Click);
            // 
            // button_Main
            // 
            this.button_Main.Location = new System.Drawing.Point(12, 100);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(75, 23);
            this.button_Main.TabIndex = 4;
            this.button_Main.Text = "Начальник";
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // button_Master
            // 
            this.button_Master.Location = new System.Drawing.Point(12, 52);
            this.button_Master.Name = "button_Master";
            this.button_Master.Size = new System.Drawing.Size(75, 23);
            this.button_Master.TabIndex = 5;
            this.button_Master.Text = "Мастер";
            this.button_Master.UseVisualStyleBackColor = true;
            this.button_Master.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(268, 354);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(100, 33);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Выйти";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 399);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Master);
            this.Controls.Add(this.button_Main);
            this.Controls.Add(this.brigadirForm);
            this.Controls.Add(this.button_Auth);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Login;
        private TextBox textBox_Password;
        private Button button_Auth;
        private Button brigadirForm;
        private Button button_Main;
        private Button button_Master;
        private Button button_Exit;
    }
}