﻿namespace MNIST_Main
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTestSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrainSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilesPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.digitUC1 = new MNIST_Main.DigitUC();
            this.btnNextDigit = new System.Windows.Forms.Button();
            this.btnPrevDigit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTestSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTrainSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFilesPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MNIST DB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // txtTestSize
            // 
            this.txtTestSize.Location = new System.Drawing.Point(105, 71);
            this.txtTestSize.Name = "txtTestSize";
            this.txtTestSize.Size = new System.Drawing.Size(55, 21);
            this.txtTestSize.TabIndex = 2;
            this.txtTestSize.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Testing Size:";
            // 
            // txtTrainSize
            // 
            this.txtTrainSize.Location = new System.Drawing.Point(105, 47);
            this.txtTrainSize.Name = "txtTrainSize";
            this.txtTrainSize.Size = new System.Drawing.Size(55, 21);
            this.txtTrainSize.TabIndex = 1;
            this.txtTrainSize.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Training Size:";
            // 
            // txtFilesPath
            // 
            this.txtFilesPath.Location = new System.Drawing.Point(95, 23);
            this.txtFilesPath.Name = "txtFilesPath";
            this.txtFilesPath.Size = new System.Drawing.Size(287, 21);
            this.txtFilesPath.TabIndex = 0;
            this.txtFilesPath.Text = "C:\\Working\\MNIST-and-Neural-Network-CSharp\\data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files Path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Back Propagation learnong";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonTrain_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Testing Size:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Training Size:";
            // 
            // digitUC1
            // 
            this.digitUC1.Location = new System.Drawing.Point(448, 27);
            this.digitUC1.Name = "digitUC1";
            this.digitUC1.Pixels = null;
            this.digitUC1.Size = new System.Drawing.Size(28, 28);
            this.digitUC1.TabIndex = 5;
            // 
            // btnNextDigit
            // 
            this.btnNextDigit.Location = new System.Drawing.Point(467, 54);
            this.btnNextDigit.Name = "btnNextDigit";
            this.btnNextDigit.Size = new System.Drawing.Size(21, 21);
            this.btnNextDigit.TabIndex = 6;
            this.btnNextDigit.Text = ">";
            this.btnNextDigit.UseVisualStyleBackColor = true;
            this.btnNextDigit.Click += new System.EventHandler(this.btnNextDigit_Click);
            // 
            // btnPrevDigit
            // 
            this.btnPrevDigit.Location = new System.Drawing.Point(434, 54);
            this.btnPrevDigit.Name = "btnPrevDigit";
            this.btnPrevDigit.Size = new System.Drawing.Size(21, 21);
            this.btnPrevDigit.TabIndex = 6;
            this.btnPrevDigit.Text = "<";
            this.btnPrevDigit.UseVisualStyleBackColor = true;
            this.btnPrevDigit.Click += new System.EventHandler(this.btnPrevDigit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 293);
            this.Controls.Add(this.btnPrevDigit);
            this.Controls.Add(this.btnNextDigit);
            this.Controls.Add(this.digitUC1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Neural Networks - MNIST";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTestSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrainSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilesPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private DigitUC digitUC1;
        private System.Windows.Forms.Button btnNextDigit;
        private System.Windows.Forms.Button btnPrevDigit;
    }
}

