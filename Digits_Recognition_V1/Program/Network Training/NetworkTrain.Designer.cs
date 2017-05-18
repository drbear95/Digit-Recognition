using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkTrain));
            this.txtNumInputs = new System.Windows.Forms.TextBox();
            this.txtNumOutputs = new System.Windows.Forms.TextBox();
            this.txtNumLayers = new System.Windows.Forms.TextBox();
            this.txtNumNeurHidden = new System.Windows.Forms.TextBox();
            this.txtDesiredError = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.cmbActivationFunctionHidden = new System.Windows.Forms.ComboBox();
            this.cmbActivationFunctionOutput = new System.Windows.Forms.ComboBox();
            this.cmbTrainAlgorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrainRate = new System.Windows.Forms.Label();
            this.txtMomentum = new System.Windows.Forms.TextBox();
            this.txtLearningRate = new System.Windows.Forms.TextBox();
            this.btnInputHelp = new System.Windows.Forms.Button();
            this.btnOutputHelp = new System.Windows.Forms.Button();
            this.btnLayersHelp = new System.Windows.Forms.Button();
            this.btnErrorHelp = new System.Windows.Forms.Button();
            this.btnNeuronsQuantityHelp = new System.Windows.Forms.Button();
            this.btnMomentumHelp = new System.Windows.Forms.Button();
            this.btnTrainRateHelp = new System.Windows.Forms.Button();
            this.btnActivationFunctionHiddenHelp = new System.Windows.Forms.Button();
            this.btnActivationFunctionOutHelp = new System.Windows.Forms.Button();
            this.btnTrainAlgorithmRate = new System.Windows.Forms.Button();
            this.btnHideHelp = new System.Windows.Forms.Button();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumInputs
            // 
            this.txtNumInputs.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtNumInputs.Location = new System.Drawing.Point(196, 11);
            this.txtNumInputs.Name = "txtNumInputs";
            this.txtNumInputs.Size = new System.Drawing.Size(100, 28);
            this.txtNumInputs.TabIndex = 2;
            this.txtNumInputs.Text = "1250";
            // 
            // txtNumOutputs
            // 
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
            this.txtNumNeurHidden.Location = new System.Drawing.Point(195, 147);
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
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(472, 389);
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
            this.label4.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 33);
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
            // txtReport
            // 
            this.txtReport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtReport.Location = new System.Drawing.Point(362, 12);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Momentum";
            // 
            // txtTrainRate
            // 
            this.txtTrainRate.AutoSize = true;
            this.txtTrainRate.BackColor = System.Drawing.Color.Black;
            this.txtTrainRate.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.txtTrainRate.ForeColor = System.Drawing.Color.White;
            this.txtTrainRate.Location = new System.Drawing.Point(12, 221);
            this.txtTrainRate.Name = "txtTrainRate";
            this.txtTrainRate.Size = new System.Drawing.Size(176, 19);
            this.txtTrainRate.TabIndex = 28;
            this.txtTrainRate.Text = "Współczynnik uczenia";
            // 
            // txtMomentum
            // 
            this.txtMomentum.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtMomentum.Location = new System.Drawing.Point(195, 181);
            this.txtMomentum.Name = "txtMomentum";
            this.txtMomentum.Size = new System.Drawing.Size(101, 28);
            this.txtMomentum.TabIndex = 29;
            this.txtMomentum.Text = "0";
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.txtLearningRate.Location = new System.Drawing.Point(195, 215);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(101, 28);
            this.txtLearningRate.TabIndex = 30;
            this.txtLearningRate.Text = "0";
            // 
            // btnInputHelp
            // 
            this.btnInputHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnInputHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInputHelp.Location = new System.Drawing.Point(302, 11);
            this.btnInputHelp.Name = "btnInputHelp";
            this.btnInputHelp.Size = new System.Drawing.Size(28, 28);
            this.btnInputHelp.TabIndex = 32;
            this.btnInputHelp.UseVisualStyleBackColor = true;
            this.btnInputHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnOutputHelp
            // 
            this.btnOutputHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnOutputHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutputHelp.Location = new System.Drawing.Point(302, 45);
            this.btnOutputHelp.Name = "btnOutputHelp";
            this.btnOutputHelp.Size = new System.Drawing.Size(28, 28);
            this.btnOutputHelp.TabIndex = 33;
            this.btnOutputHelp.UseVisualStyleBackColor = true;
            this.btnOutputHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnLayersHelp
            // 
            this.btnLayersHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnLayersHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLayersHelp.Location = new System.Drawing.Point(302, 79);
            this.btnLayersHelp.Name = "btnLayersHelp";
            this.btnLayersHelp.Size = new System.Drawing.Size(28, 28);
            this.btnLayersHelp.TabIndex = 34;
            this.btnLayersHelp.UseVisualStyleBackColor = true;
            this.btnLayersHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnErrorHelp
            // 
            this.btnErrorHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnErrorHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnErrorHelp.Location = new System.Drawing.Point(302, 113);
            this.btnErrorHelp.Name = "btnErrorHelp";
            this.btnErrorHelp.Size = new System.Drawing.Size(28, 28);
            this.btnErrorHelp.TabIndex = 35;
            this.btnErrorHelp.UseVisualStyleBackColor = true;
            this.btnErrorHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnNeuronsQuantityHelp
            // 
            this.btnNeuronsQuantityHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnNeuronsQuantityHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNeuronsQuantityHelp.Location = new System.Drawing.Point(302, 147);
            this.btnNeuronsQuantityHelp.Name = "btnNeuronsQuantityHelp";
            this.btnNeuronsQuantityHelp.Size = new System.Drawing.Size(28, 28);
            this.btnNeuronsQuantityHelp.TabIndex = 36;
            this.btnNeuronsQuantityHelp.UseVisualStyleBackColor = true;
            this.btnNeuronsQuantityHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnMomentumHelp
            // 
            this.btnMomentumHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnMomentumHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMomentumHelp.Location = new System.Drawing.Point(302, 181);
            this.btnMomentumHelp.Name = "btnMomentumHelp";
            this.btnMomentumHelp.Size = new System.Drawing.Size(28, 28);
            this.btnMomentumHelp.TabIndex = 37;
            this.btnMomentumHelp.UseVisualStyleBackColor = true;
            this.btnMomentumHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnTrainRateHelp
            // 
            this.btnTrainRateHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnTrainRateHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrainRateHelp.Location = new System.Drawing.Point(302, 215);
            this.btnTrainRateHelp.Name = "btnTrainRateHelp";
            this.btnTrainRateHelp.Size = new System.Drawing.Size(28, 28);
            this.btnTrainRateHelp.TabIndex = 38;
            this.btnTrainRateHelp.UseVisualStyleBackColor = true;
            this.btnTrainRateHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnActivationFunctionHiddenHelp
            // 
            this.btnActivationFunctionHiddenHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnActivationFunctionHiddenHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivationFunctionHiddenHelp.Location = new System.Drawing.Point(323, 255);
            this.btnActivationFunctionHiddenHelp.Name = "btnActivationFunctionHiddenHelp";
            this.btnActivationFunctionHiddenHelp.Size = new System.Drawing.Size(30, 30);
            this.btnActivationFunctionHiddenHelp.TabIndex = 39;
            this.btnActivationFunctionHiddenHelp.UseVisualStyleBackColor = true;
            this.btnActivationFunctionHiddenHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnActivationFunctionOutHelp
            // 
            this.btnActivationFunctionOutHelp.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnActivationFunctionOutHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivationFunctionOutHelp.Location = new System.Drawing.Point(323, 302);
            this.btnActivationFunctionOutHelp.Name = "btnActivationFunctionOutHelp";
            this.btnActivationFunctionOutHelp.Size = new System.Drawing.Size(30, 30);
            this.btnActivationFunctionOutHelp.TabIndex = 41;
            this.btnActivationFunctionOutHelp.UseVisualStyleBackColor = true;
            this.btnActivationFunctionOutHelp.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnTrainAlgorithmRate
            // 
            this.btnTrainAlgorithmRate.BackgroundImage = global::Program.Properties.Resources.Help_icon;
            this.btnTrainAlgorithmRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrainAlgorithmRate.Location = new System.Drawing.Point(323, 350);
            this.btnTrainAlgorithmRate.Name = "btnTrainAlgorithmRate";
            this.btnTrainAlgorithmRate.Size = new System.Drawing.Size(30, 30);
            this.btnTrainAlgorithmRate.TabIndex = 42;
            this.btnTrainAlgorithmRate.UseVisualStyleBackColor = true;
            this.btnTrainAlgorithmRate.Click += new System.EventHandler(this.HelpClick);
            // 
            // btnHideHelp
            // 
            this.btnHideHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHideHelp.BackgroundImage = global::Program.Properties.Resources.oxygen_icons_org_oxygen_actions_go_previous_6;
            this.btnHideHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHideHelp.FlatAppearance.BorderSize = 0;
            this.btnHideHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideHelp.Location = new System.Drawing.Point(548, 231);
            this.btnHideHelp.Name = "btnHideHelp";
            this.btnHideHelp.Size = new System.Drawing.Size(32, 32);
            this.btnHideHelp.TabIndex = 43;
            this.btnHideHelp.UseVisualStyleBackColor = false;
            this.btnHideHelp.Click += new System.EventHandler(this.btnHideHelp_Click);
            // 
            // txtHelp
            // 
            this.txtHelp.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txtHelp.Location = new System.Drawing.Point(582, 11);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHelp.Size = new System.Drawing.Size(215, 369);
            this.txtHelp.TabIndex = 44;
            // 
            // NetworkTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Program.Properties.Resources._0002D2JVEG335J9M_C122_F4;
            this.ClientSize = new System.Drawing.Size(806, 431);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.btnHideHelp);
            this.Controls.Add(this.btnTrainAlgorithmRate);
            this.Controls.Add(this.btnActivationFunctionOutHelp);
            this.Controls.Add(this.btnActivationFunctionHiddenHelp);
            this.Controls.Add(this.btnTrainRateHelp);
            this.Controls.Add(this.btnMomentumHelp);
            this.Controls.Add(this.btnNeuronsQuantityHelp);
            this.Controls.Add(this.btnErrorHelp);
            this.Controls.Add(this.btnLayersHelp);
            this.Controls.Add(this.btnOutputHelp);
            this.Controls.Add(this.btnInputHelp);
            this.Controls.Add(this.txtLearningRate);
            this.Controls.Add(this.txtMomentum);
            this.Controls.Add(this.txtTrainRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTrainAlgorithm);
            this.Controls.Add(this.cmbActivationFunctionOutput);
            this.Controls.Add(this.cmbActivationFunctionHidden);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.txtDesiredError);
            this.Controls.Add(this.txtNumNeurHidden);
            this.Controls.Add(this.txtNumLayers);
            this.Controls.Add(this.txtNumOutputs);
            this.Controls.Add(this.txtNumInputs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetworkTrain";
            this.Text = "NetworkTrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumInputs;
        private System.Windows.Forms.TextBox txtNumOutputs;
        private System.Windows.Forms.TextBox txtNumLayers;
        private System.Windows.Forms.TextBox txtNumNeurHidden;
        private System.Windows.Forms.TextBox txtDesiredError;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.ComboBox cmbActivationFunctionHidden;
        private System.Windows.Forms.ComboBox cmbActivationFunctionOutput;
        private System.Windows.Forms.ComboBox cmbTrainAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTrainRate;
        private System.Windows.Forms.TextBox txtMomentum;
        private System.Windows.Forms.TextBox txtLearningRate;
        private System.Windows.Forms.Button btnInputHelp;
        private System.Windows.Forms.Button btnOutputHelp;
        private System.Windows.Forms.Button btnLayersHelp;
        private System.Windows.Forms.Button btnErrorHelp;
        private System.Windows.Forms.Button btnNeuronsQuantityHelp;
        private System.Windows.Forms.Button btnMomentumHelp;
        private System.Windows.Forms.Button btnTrainRateHelp;
        private System.Windows.Forms.Button btnActivationFunctionHiddenHelp;
        private System.Windows.Forms.Button btnActivationFunctionOutHelp;
        private System.Windows.Forms.Button btnTrainAlgorithmRate;
        private System.Windows.Forms.Button btnHideHelp;
        private System.Windows.Forms.TextBox txtHelp;
    }
}