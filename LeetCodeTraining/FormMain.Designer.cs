﻿namespace LeetCodeTraining
{
    partial class FormMain
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
            btnTestArray = new Button();
            txtArray = new TextBox();
            SuspendLayout();
            // 
            // btnTestArray
            // 
            btnTestArray.Location = new Point(114, 82);
            btnTestArray.Name = "btnTestArray";
            btnTestArray.Size = new Size(100, 23);
            btnTestArray.TabIndex = 0;
            btnTestArray.Text = "Test Array";
            btnTestArray.UseVisualStyleBackColor = true;
            //btnTestArray.Click += this.btnTestArray_Click;
            // 
            // txtArray
            // 
            txtArray.Location = new Point(114, 53);
            txtArray.Name = "txtArray";
            txtArray.Size = new Size(100, 23);
            txtArray.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 158);
            Controls.Add(txtArray);
            Controls.Add(btnTestArray);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestArray;
        private TextBox txtArray;
    }
}
