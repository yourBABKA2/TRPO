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
            this.driversChange = new System.Windows.Forms.Button();
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
            // 
            // mechanicsPersonel
            // 
            this.mechanicsPersonel.Location = new System.Drawing.Point(12, 168);
            this.mechanicsPersonel.Name = "mechanicsPersonel";
            this.mechanicsPersonel.Size = new System.Drawing.Size(166, 56);
            this.mechanicsPersonel.TabIndex = 2;
            this.mechanicsPersonel.Text = "Просмотреть персонал (Обс. персонал)";
            this.mechanicsPersonel.UseVisualStyleBackColor = true;
            // 
            // driversChange
            // 
            this.driversChange.Location = new System.Drawing.Point(12, 74);
            this.driversChange.Name = "driversChange";
            this.driversChange.Size = new System.Drawing.Size(166, 56);
            this.driversChange.TabIndex = 3;
            this.driversChange.Text = "Переназначить водителей";
            this.driversChange.UseVisualStyleBackColor = true;
            // 
            // Brigadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 236);
            this.Controls.Add(this.driversChange);
            this.Controls.Add(this.mechanicsPersonel);
            this.Controls.Add(this.driversPersonel);
            this.Name = "Brigadir";
            this.Text = "Brigadir";
            this.ResumeLayout(false);

        }

        #endregion
        private Button driversPersonel;
        private Button mechanicsPersonel;
        private Button driversChange;
    }
}