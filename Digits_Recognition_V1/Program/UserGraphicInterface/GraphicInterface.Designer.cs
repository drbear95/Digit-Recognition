﻿namespace Program.UserGraphicInterface
{
    partial class GraphicInterface
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
            this.matrix = new System.Windows.Forms.PictureBox();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.txtOut1 = new System.Windows.Forms.TextBox();
            this.txtOut2 = new System.Windows.Forms.TextBox();
            this.txtOut3 = new System.Windows.Forms.TextBox();
            this.txtOut4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheckedValue = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.BackColor = System.Drawing.Color.Black;
            this.matrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.matrix.Location = new System.Drawing.Point(12, 12);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(100, 200);
            this.matrix.TabIndex = 0;
            this.matrix.TabStop = false;
            this.matrix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Matrix_MouseDown);
            this.matrix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Matrix_MouseMove);
            this.matrix.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Matrix_MouseUp);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Location = new System.Drawing.Point(118, 26);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(121, 21);
            this.cmbFontSize.TabIndex = 1;
            // 
            // txtOut1
            // 
            this.txtOut1.Location = new System.Drawing.Point(118, 77);
            this.txtOut1.Name = "txtOut1";
            this.txtOut1.Size = new System.Drawing.Size(40, 20);
            this.txtOut1.TabIndex = 2;
            // 
            // txtOut2
            // 
            this.txtOut2.Location = new System.Drawing.Point(164, 77);
            this.txtOut2.Name = "txtOut2";
            this.txtOut2.Size = new System.Drawing.Size(40, 20);
            this.txtOut2.TabIndex = 3;
            // 
            // txtOut3
            // 
            this.txtOut3.Location = new System.Drawing.Point(210, 77);
            this.txtOut3.Name = "txtOut3";
            this.txtOut3.Size = new System.Drawing.Size(40, 20);
            this.txtOut3.TabIndex = 4;
            // 
            // txtOut4
            // 
            this.txtOut4.Location = new System.Drawing.Point(256, 77);
            this.txtOut4.Name = "txtOut4";
            this.txtOut4.Size = new System.Drawing.Size(40, 20);
            this.txtOut4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wynik (dokładny)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rozmiar Czcionki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wykryta Liczba";
            // 
            // txtCheckedValue
            // 
            this.txtCheckedValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCheckedValue.Location = new System.Drawing.Point(118, 125);
            this.txtCheckedValue.Name = "txtCheckedValue";
            this.txtCheckedValue.Size = new System.Drawing.Size(40, 39);
            this.txtCheckedValue.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(118, 172);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 40);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Sprawdź";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Wyjdź";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Czyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // GraphicInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Program.Properties.Resources._0002D2JVEG335J9M_C122_F4;
            this.ClientSize = new System.Drawing.Size(299, 251);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtCheckedValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOut4);
            this.Controls.Add(this.txtOut3);
            this.Controls.Add(this.txtOut2);
            this.Controls.Add(this.txtOut1);
            this.Controls.Add(this.cmbFontSize);
            this.Controls.Add(this.matrix);
            this.Name = "GraphicInterface";
            this.Text = "GraphicInterface";
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox matrix;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.TextBox txtOut1;
        private System.Windows.Forms.TextBox txtOut2;
        private System.Windows.Forms.TextBox txtOut3;
        private System.Windows.Forms.TextBox txtOut4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheckedValue;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}