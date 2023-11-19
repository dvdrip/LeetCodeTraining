namespace LeetCodeTest
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
            textArray = new TextBox();
            SuspendLayout();
            // 
            // btnTestArray
            // 
            btnTestArray.Location = new Point(72, 115);
            btnTestArray.Name = "btnTestArray";
            btnTestArray.Size = new Size(274, 23);
            btnTestArray.TabIndex = 0;
            btnTestArray.Text = "Test Array";
            btnTestArray.UseVisualStyleBackColor = true;
            btnTestArray.Click += button1_Click;
            // 
            // textArray
            // 
            textArray.Location = new Point(72, 86);
            textArray.Name = "textArray";
            textArray.Size = new Size(274, 23);
            textArray.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 225);
            Controls.Add(textArray);
            Controls.Add(btnTestArray);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestArray;
        private TextBox textArray;
    }
}
