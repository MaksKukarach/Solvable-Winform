namespace MathProblemsGenerator
{
    partial class Form1
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
            this.problemTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // problemTextBox
            // 
            this.problemTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.problemTextBox.Location = new System.Drawing.Point(64, 189);
            this.problemTextBox.Name = "problemTextBox";
            this.problemTextBox.ReadOnly = true;
            this.problemTextBox.Size = new System.Drawing.Size(513, 52);
            this.problemTextBox.TabIndex = 0;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextBox.Location = new System.Drawing.Point(583, 189);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(120, 52);
            this.answerTextBox.TabIndex = 1;
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerButton.Location = new System.Drawing.Point(583, 247);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(120, 54);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "ENTER";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.problemTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox problemTextBox;
        private TextBox answerTextBox;
        private Button answerButton;
    }
}