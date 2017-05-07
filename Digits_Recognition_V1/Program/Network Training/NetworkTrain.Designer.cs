namespace Program.Network_Training
{
    partial class NetworkTrain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNumInputs = new System.Windows.Forms.TextBox();
            this.txtNumOutputs = new System.Windows.Forms.TextBox();
            this.txtNumLayers = new System.Windows.Forms.TextBox();
            this.txtNumNeurHidden = new System.Windows.Forms.TextBox();
            this.txtDesiredError = new System.Windows.Forms.TextBox();
            this.txtNumEpoch = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.cmbActivationFunctionHidden = new System.Windows.Forms.ComboBox();
            this.cmbActivationFunctionOutput = new System.Windows.Forms.ComboBox();
            this.cmbTrainAlgorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNumInputs
            // 
            this.txtNumInputs.Enabled = false;
            this.txtNumInputs.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtNumInputs.Location = new System.Drawing.Point(196, 11);
            this.txtNumInputs.Name = "txtNumInputs";
            this.txtNumInputs.Size = new System.Drawing.Size(100, 28);
            this.txtNumInputs.TabIndex = 2;
            this.txtNumInputs.Text = "20000";
            // 
            // txtNumOutputs
            // 
            this.txtNumOutputs.Enabled = false;
            this.txtNumOutputs.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtNumOutputs.Location = new System.Drawing.Point(196, 45);
            this.txtNumOutputs.Name = "txtNumOutputs";
            this.txtNumOutputs.Size = new System.Drawing.Size(100, 28);
            this.txtNumOutputs.TabIndex = 3;
            this.txtNumOutputs.Text = "4";
            // 
            // txtNumLayers
            // 
            this.txtNumLayers.Enabled = false;
            this.txtNumLayers.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtNumLayers.Location = new System.Drawing.Point(196, 79);
            this.txtNumLayers.Name = "txtNumLayers";
            this.txtNumLayers.Size = new System.Drawing.Size(100, 28);
            this.txtNumLayers.TabIndex = 4;
            this.txtNumLayers.Text = "3";
            // 
            // txtNumNeurHidden
            // 
            this.txtNumNeurHidden.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtNumNeurHidden.Location = new System.Drawing.Point(196, 187);
            this.txtNumNeurHidden.Name = "txtNumNeurHidden";
            this.txtNumNeurHidden.Size = new System.Drawing.Size(101, 28);
            this.txtNumNeurHidden.TabIndex = 5;
            this.txtNumNeurHidden.Text = "20";
            // 
            // txtDesiredError
            // 
            this.txtDesiredError.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtDesiredError.Location = new System.Drawing.Point(196, 113);
            this.txtDesiredError.Name = "txtDesiredError";
            this.txtDesiredError.Size = new System.Drawing.Size(100, 28);
            this.txtDesiredError.TabIndex = 6;
            this.txtDesiredError.Text = "0";
            // 
            // txtNumEpoch
            // 
            this.txtNumEpoch.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtNumEpoch.Location = new System.Drawing.Point(196, 147);
            this.txtNumEpoch.Name = "txtNumEpoch";
            this.txtNumEpoch.Size = new System.Drawing.Size(100, 28);
            this.txtNumEpoch.TabIndex = 7;
            this.txtNumEpoch.Text = "1000";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(441, 388);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 30);
            this.btnTrain.TabIndex = 9;
            this.btnTrain.Text = "Trenuj";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 19);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Ilość wejść";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ilość wyjść";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ilość warstw";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 42);
            this.label4.TabIndex = 14;
            this.label4.Text = "Liczba neuronów w warstwie ukrytej";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Błąd Pożądany";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Liczba Epok";
            // 
            // txtReport
            // 
            this.txtReport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtReport.Location = new System.Drawing.Point(331, 11);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(185, 369);
            this.txtReport.TabIndex = 19;
            // 
            // cmbActivationFunctionHidden
            // 
            this.cmbActivationFunctionHidden.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.cmbActivationFunctionHidden.FormattingEnabled = true;
            this.cmbActivationFunctionHidden.Location = new System.Drawing.Point(196, 253);
            this.cmbActivationFunctionHidden.Name = "cmbActivationFunctionHidden";
            this.cmbActivationFunctionHidden.Size = new System.Drawing.Size(121, 30);
            this.cmbActivationFunctionHidden.TabIndex = 20;
            // 
            // cmbActivationFunctionOutput
            // 
            this.cmbActivationFunctionOutput.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.cmbActivationFunctionOutput.FormattingEnabled = true;
            this.cmbActivationFunctionOutput.Location = new System.Drawing.Point(196, 302);
            this.cmbActivationFunctionOutput.Name = "cmbActivationFunctionOutput";
            this.cmbActivationFunctionOutput.Size = new System.Drawing.Size(121, 30);
            this.cmbActivationFunctionOutput.TabIndex = 21;
            // 
            // cmbTrainAlgorithm
            // 
            this.cmbTrainAlgorithm.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.cmbTrainAlgorithm.FormattingEnabled = true;
            this.cmbTrainAlgorithm.Location = new System.Drawing.Point(196, 350);
            this.cmbTrainAlgorithm.Name = "cmbTrainAlgorithm";
            this.cmbTrainAlgorithm.Size = new System.Drawing.Size(121, 30);
            this.cmbTrainAlgorithm.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Funkcja aktywacji warstwy ukrytej";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 41);
            this.label7.TabIndex = 24;
            this.label7.Text = "Funkcja aktywacji wyjścia";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 30);
            this.label9.TabIndex = 25;
            this.label9.Text = "Algorytm trenowania";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NetworkTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Program.Properties.Resources._0002D2JVEG335J9M_C122_F4;
            this.ClientSize = new System.Drawing.Size(528, 430);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTrainAlgorithm);
            this.Controls.Add(this.cmbActivationFunctionOutput);
            this.Controls.Add(this.cmbActivationFunctionHidden);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.txtNumEpoch);
            this.Controls.Add(this.txtDesiredError);
            this.Controls.Add(this.txtNumNeurHidden);
            this.Controls.Add(this.txtNumLayers);
            this.Controls.Add(this.txtNumOutputs);
            this.Controls.Add(this.txtNumInputs);
            this.Name = "NetworkTrain";
            this.Text = "NetworkTrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNumInputs;
        private System.Windows.Forms.TextBox txtNumOutputs;
        private System.Windows.Forms.TextBox txtNumLayers;
        private System.Windows.Forms.TextBox txtNumNeurHidden;
        private System.Windows.Forms.TextBox txtDesiredError;
        private System.Windows.Forms.TextBox txtNumEpoch;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.ComboBox cmbActivationFunctionHidden;
        private System.Windows.Forms.ComboBox cmbActivationFunctionOutput;
        private System.Windows.Forms.ComboBox cmbTrainAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
    }
}