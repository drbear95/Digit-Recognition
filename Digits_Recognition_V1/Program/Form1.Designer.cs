namespace Program
{
    partial class MainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnCollectData = new System.Windows.Forms.Button();
            this.btnDigitCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrain.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnTrain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrain.Location = new System.Drawing.Point(111, 12);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(83, 75);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Trenuj";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnCollectData
            // 
            this.btnCollectData.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCollectData.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnCollectData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCollectData.Location = new System.Drawing.Point(12, 12);
            this.btnCollectData.Name = "btnCollectData";
            this.btnCollectData.Size = new System.Drawing.Size(83, 75);
            this.btnCollectData.TabIndex = 0;
            this.btnCollectData.Text = "Zbieraj Dane";
            this.btnCollectData.UseVisualStyleBackColor = false;
            this.btnCollectData.Click += new System.EventHandler(this.btnCollectData_Click);
            // 
            // btnDigitCheck
            // 
            this.btnDigitCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDigitCheck.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnDigitCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDigitCheck.Location = new System.Drawing.Point(12, 189);
            this.btnDigitCheck.Name = "btnDigitCheck";
            this.btnDigitCheck.Size = new System.Drawing.Size(182, 75);
            this.btnDigitCheck.TabIndex = 2;
            this.btnDigitCheck.Text = "Sprawdź cyfry";
            this.btnDigitCheck.UseVisualStyleBackColor = false;
            this.btnDigitCheck.Click += new System.EventHandler(this.btnDigitCheck_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program.Properties.Resources._0002D2JVEG335J9M_C122_F41;
            this.ClientSize = new System.Drawing.Size(206, 276);
            this.Controls.Add(this.btnDigitCheck);
            this.Controls.Add(this.btnCollectData);
            this.Controls.Add(this.btnTrain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnCollectData;
        private System.Windows.Forms.Button btnDigitCheck;
    }
}

