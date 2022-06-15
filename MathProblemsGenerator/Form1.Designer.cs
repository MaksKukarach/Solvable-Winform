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
            this.skipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // problemTextBox
            // 
            this.problemTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.problemTextBox.Location = new System.Drawing.Point(54, 139);
            this.problemTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problemTextBox.Name = "problemTextBox";
            this.problemTextBox.ReadOnly = true;
            this.problemTextBox.Size = new System.Drawing.Size(449, 43);
            this.problemTextBox.TabIndex = 0;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextBox.Location = new System.Drawing.Point(508, 139);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(106, 43);
            this.answerTextBox.TabIndex = 1;
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerButton.Location = new System.Drawing.Point(508, 232);
            this.answerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(105, 40);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "ENTER";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skipButton.Location = new System.Drawing.Point(508, 187);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(105, 40);
            this.skipButton.TabIndex = 3;
            this.skipButton.Text = "SKIP";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 340);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.problemTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox problemTextBox;
        private TextBox answerTextBox;
        private Button answerButton;
        private Button skipButton;
    }
}