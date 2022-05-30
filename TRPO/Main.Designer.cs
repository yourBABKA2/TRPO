namespace TRPO
{
    partial class Main
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
            this.button_Pass = new System.Windows.Forms.Button();
            this.button_Gruz = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Pass
            // 
            this.button_Pass.Location = new System.Drawing.Point(12, 12);
            this.button_Pass.Name = "button_Pass";
            this.button_Pass.Size = new System.Drawing.Size(164, 55);
            this.button_Pass.TabIndex = 0;
            this.button_Pass.Text = "Действия с пассажирским транспортом";
            this.button_Pass.UseCompatibleTextRendering = true;
            this.button_Pass.UseVisualStyleBackColor = true;
            this.button_Pass.Click += new System.EventHandler(this.button_Pass_Click);
            // 
            // button_Gruz
            // 
            this.button_Gruz.Location = new System.Drawing.Point(332, 12);
            this.button_Gruz.Name = "button_Gruz";
            this.button_Gruz.Size = new System.Drawing.Size(164, 55);
            this.button_Gruz.TabIndex = 1;
            this.button_Gruz.Text = "Действия с грузовым транспортом";
            this.button_Gruz.UseVisualStyleBackColor = true;
            this.button_Gruz.Click += new System.EventHandler(this.button_Gruz_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(421, 211);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "Выход";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 246);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Gruz);
            this.Controls.Add(this.button_Pass);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Back;
        private Button button_Pass;
        private Button button_Gruz;
    }
}