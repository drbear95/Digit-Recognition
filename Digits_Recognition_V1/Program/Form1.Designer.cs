namespace Program
{
    partial class Form1
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
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnCollectData = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnDigitCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(12, 93);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 75);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Trenuj";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnCollectData
            // 
            this.btnCollectData.Location = new System.Drawing.Point(12, 12);
            this.btnCollectData.Name = "btnCollectData";
            this.btnCollectData.Size = new System.Drawing.Size(75, 75);
            this.btnCollectData.TabIndex = 0;
            this.btnCollectData.Text = "Zbieraj Dane";
            this.btnCollectData.UseVisualStyleBackColor = true;
            this.btnCollectData.Click += new System.EventHandler(this.btnCollectData_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 174);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 75);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Testuj Sieć";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnDigitCheck
            // 
            this.btnDigitCheck.Location = new System.Drawing.Point(117, 12);
            this.btnDigitCheck.Name = "btnDigitCheck";
            this.btnDigitCheck.Size = new System.Drawing.Size(80, 75);
            this.btnDigitCheck.TabIndex = 2;
            this.btnDigitCheck.Text = "Sprawdzanie Cyfr";
            this.btnDigitCheck.UseVisualStyleBackColor = true;
            this.btnDigitCheck.Click += new System.EventHandler(this.btnDigitCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program.Properties.Resources._0002D2JVEG335J9M_C122_F41;
            this.ClientSize = new System.Drawing.Size(204, 276);
            this.Controls.Add(this.btnDigitCheck);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCollectData);
            this.Controls.Add(this.btnTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnCollectData;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnDigitCheck;
    }
}

