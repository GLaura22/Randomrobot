﻿namespace Randomrobot
{
    partial class Form1 //partal = ez az osztaly tobb fajlban is megtalalhato
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cimke1 = new System.Windows.Forms.Label();
            this.cimke2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.robotPicBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cimke1
            // 
            this.cimke1.AutoSize = true;
            this.cimke1.Location = new System.Drawing.Point(40, 92);
            this.cimke1.Name = "cimke1";
            this.cimke1.Size = new System.Drawing.Size(59, 25);
            this.cimke1.TabIndex = 1;
            this.cimke1.Text = "label1";
            // 
            // cimke2
            // 
            this.cimke2.AutoSize = true;
            this.cimke2.Location = new System.Drawing.Point(40, 142);
            this.cimke2.Name = "cimke2";
            this.cimke2.Size = new System.Drawing.Size(59, 25);
            this.cimke2.TabIndex = 2;
            this.cimke2.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // robotPicBox
            // 
            this.robotPicBox.Location = new System.Drawing.Point(320, 211);
            this.robotPicBox.Name = "robotPicBox";
            this.robotPicBox.Size = new System.Drawing.Size(199, 187);
            this.robotPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.robotPicBox.TabIndex = 4;
            this.robotPicBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(413, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 34);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.robotPicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cimke2);
            this.Controls.Add(this.cimke1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label cimke1;
        private Label cimke2;
        private PictureBox pictureBox1;
        private PictureBox robotPicBox;
        private ProgressBar progressBar1;
    }
}