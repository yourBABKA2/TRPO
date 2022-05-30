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
            this.driversShow = new System.Windows.Forms.Button();
            this.mechanicsShow = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
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
            this.showRoutes.Click += new System.EventHandler(this.showRoutes_Click);
            // 
            // showGarages
            // 
            this.showGarages.Location = new System.Drawing.Point(12, 67);
            this.showGarages.Name = "showGarages";
            this.showGarages.Size = new System.Drawing.Size(123, 49);
            this.showGarages.TabIndex = 1;
            this.showGarages.Text = "Посмотреть цеха";
            this.showGarages.UseVisualStyleBackColor = true;
            this.showGarages.Click += new System.EventHandler(this.showGarages_Click);
            // 
            // driversShow
            // 
            this.driversShow.Location = new System.Drawing.Point(215, 12);
            this.driversShow.Name = "driversShow";
            this.driversShow.Size = new System.Drawing.Size(123, 49);
            this.driversShow.TabIndex = 2;
            this.driversShow.Text = "Посмотреть водителей";
            this.driversShow.UseVisualStyleBackColor = true;
            this.driversShow.Click += new System.EventHandler(this.driversShow_Click);
            // 
            // mechanicsShow
            // 
            this.mechanicsShow.Location = new System.Drawing.Point(215, 67);
            this.mechanicsShow.Name = "mechanicsShow";
            this.mechanicsShow.Size = new System.Drawing.Size(123, 49);
            this.mechanicsShow.TabIndex = 3;
            this.mechanicsShow.Text = "Посмотреть обс. персонал";
            this.mechanicsShow.UseVisualStyleBackColor = true;
            this.mechanicsShow.Click += new System.EventHandler(this.mechanicsShow_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(134, 133);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 185);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mechanicsShow);
            this.Controls.Add(this.driversShow);
            this.Controls.Add(this.showGarages);
            this.Controls.Add(this.showRoutes);
            this.Name = "Master";
            this.Text = "Master";
            this.ResumeLayout(false);

        }

        #endregion

        private Button showRoutes;
        private Button showGarages;
        private Button driversShow;
        private Button mechanicsShow;
        private Button exitButton;
    }
}