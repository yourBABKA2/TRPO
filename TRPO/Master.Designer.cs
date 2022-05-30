namespace TRPO
{
    partial class Master
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
            this.showRoutes = new System.Windows.Forms.Button();
            this.showGarages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showRoutes
            // 
            this.showRoutes.Location = new System.Drawing.Point(12, 12);
            this.showRoutes.Name = "showRoutes";
            this.showRoutes.Size = new System.Drawing.Size(123, 49);
            this.showRoutes.TabIndex = 0;
            this.showRoutes.Text = "Посмотреть маршруты";
            this.showRoutes.UseVisualStyleBackColor = true;
            // 
            // showGarages
            // 
            this.showGarages.Location = new System.Drawing.Point(12, 67);
            this.showGarages.Name = "showGarages";
            this.showGarages.Size = new System.Drawing.Size(123, 49);
            this.showGarages.TabIndex = 1;
            this.showGarages.Text = "Посмотреть цеха";
            this.showGarages.UseVisualStyleBackColor = true;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 291);
            this.Controls.Add(this.showGarages);
            this.Controls.Add(this.showRoutes);
            this.Name = "Master";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Master_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button showRoutes;
        private Button showGarages;
    }
}