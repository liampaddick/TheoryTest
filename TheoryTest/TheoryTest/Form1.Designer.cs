namespace TheoryTest
{
    partial class Form1
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
            this.StartTestButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MainMenuText = new System.Windows.Forms.Label();
            this.AnswerButton1 = new System.Windows.Forms.Button();
            this.AnswerButton2 = new System.Windows.Forms.Button();
            this.AnswerButton3 = new System.Windows.Forms.Button();
            this.AnswerButton4 = new System.Windows.Forms.Button();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartTestButton
            // 
            this.StartTestButton.Location = new System.Drawing.Point(104, 65);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(75, 23);
            this.StartTestButton.TabIndex = 0;
            this.StartTestButton.Text = "Start Test";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(104, 109);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenuText
            // 
            this.MainMenuText.AutoSize = true;
            this.MainMenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuText.Location = new System.Drawing.Point(46, 9);
            this.MainMenuText.Name = "MainMenuText";
            this.MainMenuText.Size = new System.Drawing.Size(189, 39);
            this.MainMenuText.TabIndex = 2;
            this.MainMenuText.Text = "TheoryTest";
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.Location = new System.Drawing.Point(13, 150);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.Size = new System.Drawing.Size(89, 23);
            this.AnswerButton1.TabIndex = 3;
            this.AnswerButton1.Text = "AnswerButton1";
            this.AnswerButton1.UseVisualStyleBackColor = true;
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.Location = new System.Drawing.Point(183, 150);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.Size = new System.Drawing.Size(89, 23);
            this.AnswerButton2.TabIndex = 4;
            this.AnswerButton2.Text = "AnswerButton2";
            this.AnswerButton2.UseVisualStyleBackColor = true;
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.Location = new System.Drawing.Point(13, 226);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.Size = new System.Drawing.Size(89, 23);
            this.AnswerButton3.TabIndex = 5;
            this.AnswerButton3.Text = "AnswerButton3";
            this.AnswerButton3.UseVisualStyleBackColor = true;
            // 
            // AnswerButton4
            // 
            this.AnswerButton4.Location = new System.Drawing.Point(183, 226);
            this.AnswerButton4.Name = "AnswerButton4";
            this.AnswerButton4.Size = new System.Drawing.Size(89, 23);
            this.AnswerButton4.TabIndex = 6;
            this.AnswerButton4.Text = "AnswerButton4";
            this.AnswerButton4.UseVisualStyleBackColor = true;
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QuestionTextLabel.Location = new System.Drawing.Point(49, 86);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(189, 20);
            this.QuestionTextLabel.TabIndex = 7;
            this.QuestionTextLabel.Text = "Question Text Goes Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.AnswerButton4);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.MainMenuText);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StartTestButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label MainMenuText;
        private System.Windows.Forms.Button AnswerButton1;
        private System.Windows.Forms.Button AnswerButton2;
        private System.Windows.Forms.Button AnswerButton3;
        private System.Windows.Forms.Button AnswerButton4;
        private System.Windows.Forms.Label QuestionTextLabel;
    }
}

