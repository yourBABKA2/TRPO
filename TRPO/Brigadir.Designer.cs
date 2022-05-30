namespace TRPO
{
    partial class Brigadir
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
            this.driversPersonel = new System.Windows.Forms.Button();
            this.mechanicsPersonel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driversPersonel
            // 
            this.driversPersonel.Location = new System.Drawing.Point(12, 12);
            this.driversPersonel.Name = "driversPersonel";
            this.driversPersonel.Size = new System.Drawing.Size(166, 56);
            this.driversPersonel.TabIndex = 1;
            this.driversPersonel.Text = "Просмотреть персонал (Водители)";
            this.driversPersonel.UseVisualStyleBackColor = true;
            this.driversPersonel.Click += new System.EventHandler(this.driversPersonel_Click);
            // 
            // mechanicsPersonel
            // 
            this.mechanicsPersonel.Location = new System.Drawing.Point(12, 74);
            this.mechanicsPersonel.Name = "mechanicsPersonel";
            this.mechanicsPersonel.Size = new System.Drawing.Size(166, 56);
            this.mechanicsPersonel.TabIndex = 2;
            this.mechanicsPersonel.Text = "Просмотреть персонал (Обс. персонал)";
            this.mechanicsPersonel.UseVisualStyleBackColor = true;
            this.mechanicsPersonel.Click += new System.EventHandler(this.mechanicsPersonel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Просмотреть свой цех";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Brigadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mechanicsPersonel);
            this.Controls.Add(this.driversPersonel);
            this.Name = "Brigadir";
            this.Text = "Brigadir";
            this.ResumeLayout(false);

        }

        #endregion
        private Button driversPersonel;
        private Button mechanicsPersonel;
        private Button button1;
    }
}