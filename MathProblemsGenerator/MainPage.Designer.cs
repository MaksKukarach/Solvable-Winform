namespace MathProblemsGenerator
{
    partial class MainPage
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
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.equationsCheckBox = new System.Windows.Forms.CheckBox();
            this.calculationCheckBox = new System.Windows.Forms.CheckBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.BtnGoToSettings = new System.Windows.Forms.Button();
            this.addUserTxt = new System.Windows.Forms.TextBox();
            this.addUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // problemTextBox
            // 
            this.problemTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.problemTextBox.Location = new System.Drawing.Point(63, 158);
            this.problemTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problemTextBox.Name = "problemTextBox";
            this.problemTextBox.ReadOnly = true;
            this.problemTextBox.Size = new System.Drawing.Size(449, 43);
            this.problemTextBox.TabIndex = 0;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextBox.Location = new System.Drawing.Point(518, 158);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 43);
            this.answerTextBox.TabIndex = 1;
            // 
            // answerButton
            // 
            this.answerButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerButton.Location = new System.Drawing.Point(518, 251);
            this.answerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(99, 40);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "ENTER";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skipButton.Location = new System.Drawing.Point(518, 206);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(99, 40);
            this.skipButton.TabIndex = 3;
            this.skipButton.Text = "SKIP";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTextBox.Location = new System.Drawing.Point(63, 124);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.Size = new System.Drawing.Size(76, 29);
            this.scoreTextBox.TabIndex = 4;
            this.scoreTextBox.Text = "IQ: 0";
            // 
            // equationsCheckBox
            // 
            this.equationsCheckBox.AutoSize = true;
            this.equationsCheckBox.Checked = true;
            this.equationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.equationsCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equationsCheckBox.Location = new System.Drawing.Point(63, 237);
            this.equationsCheckBox.Name = "equationsCheckBox";
            this.equationsCheckBox.Size = new System.Drawing.Size(97, 25);
            this.equationsCheckBox.TabIndex = 5;
            this.equationsCheckBox.Text = "equations";
            this.equationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // calculationCheckBox
            // 
            this.calculationCheckBox.AutoSize = true;
            this.calculationCheckBox.Checked = true;
            this.calculationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.calculationCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculationCheckBox.Location = new System.Drawing.Point(63, 206);
            this.calculationCheckBox.Name = "calculationCheckBox";
            this.calculationCheckBox.Size = new System.Drawing.Size(173, 25);
            this.calculationCheckBox.TabIndex = 6;
            this.calculationCheckBox.Text = "calculation problems";
            this.calculationCheckBox.UseVisualStyleBackColor = true;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(518, 78);
            this.picResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(100, 75);
            this.picResult.TabIndex = 8;
            this.picResult.TabStop = false;
            // 
            // usersComboBox
            // 
            this.usersComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(63, 92);
            this.usersComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(137, 29);
            this.usersComboBox.TabIndex = 9;
            this.usersComboBox.Text = "User";
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // BtnGoToSettings
            // 
            this.BtnGoToSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGoToSettings.Location = new System.Drawing.Point(63, 268);
            this.BtnGoToSettings.Name = "BtnGoToSettings";
            this.BtnGoToSettings.Size = new System.Drawing.Size(97, 29);
            this.BtnGoToSettings.TabIndex = 10;
            this.BtnGoToSettings.Text = "SETTINGS";
            this.BtnGoToSettings.UseVisualStyleBackColor = true;
            this.BtnGoToSettings.Click += new System.EventHandler(this.BtnOpenSettings_Click);
            // 
            // addUserTxt
            // 
            this.addUserTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addUserTxt.Location = new System.Drawing.Point(206, 92);
            this.addUserTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUserTxt.Name = "addUserTxt";
            this.addUserTxt.Size = new System.Drawing.Size(124, 29);
            this.addUserTxt.TabIndex = 12;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(336, 96);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(51, 22);
            this.addUserBtn.TabIndex = 13;
            this.addUserBtn.Text = "ADD";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.addUserTxt);
            this.Controls.Add(this.BtnGoToSettings);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.calculationCheckBox);
            this.Controls.Add(this.equationsCheckBox);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.problemTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Solvable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox problemTextBox;
        private TextBox answerTextBox;
        private Button answerButton;
        private Button skipButton;
        private TextBox scoreTextBox;
        private CheckBox equationsCheckBox;
        private CheckBox calculationCheckBox;
        private PictureBox picResult;
        private ComboBox usersComboBox;
        private Button BtnGoToSettings;
        private TextBox addUserTxt;
        private Button addUserBtn;
    }
}