namespace TheoryTest
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionNoTextLabel = new System.Windows.Forms.Label();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.AnswerButton1 = new System.Windows.Forms.Button();
            this.AnswerButton2 = new System.Windows.Forms.Button();
            this.AnswerButton3 = new System.Windows.Forms.Button();
            this.AnswerButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QuestionNo:";
            // 
            // QuestionNoTextLabel
            // 
            this.QuestionNoTextLabel.AutoSize = true;
            this.QuestionNoTextLabel.Location = new System.Drawing.Point(160, 23);
            this.QuestionNoTextLabel.Name = "QuestionNoTextLabel";
            this.QuestionNoTextLabel.Size = new System.Drawing.Size(16, 13);
            this.QuestionNoTextLabel.TabIndex = 1;
            this.QuestionNoTextLabel.Text = "-1";
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Location = new System.Drawing.Point(87, 66);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(96, 13);
            this.QuestionTextLabel.TabIndex = 2;
            this.QuestionTextLabel.Text = "QuestionTextLabel";
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.Location = new System.Drawing.Point(24, 132);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton1.TabIndex = 3;
            this.AnswerButton1.Text = "button1";
            this.AnswerButton1.UseVisualStyleBackColor = true;
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.Location = new System.Drawing.Point(180, 132);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton2.TabIndex = 4;
            this.AnswerButton2.Text = "button2";
            this.AnswerButton2.UseVisualStyleBackColor = true;
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.Location = new System.Drawing.Point(24, 185);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton3.TabIndex = 5;
            this.AnswerButton3.Text = "button3";
            this.AnswerButton3.UseVisualStyleBackColor = true;
            // 
            // AnswerButton4
            // 
            this.AnswerButton4.Location = new System.Drawing.Point(180, 185);
            this.AnswerButton4.Name = "AnswerButton4";
            this.AnswerButton4.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton4.TabIndex = 6;
            this.AnswerButton4.Text = "button4";
            this.AnswerButton4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AnswerButton4);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.QuestionNoTextLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuestionNoTextLabel;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.Button AnswerButton1;
        private System.Windows.Forms.Button AnswerButton2;
        private System.Windows.Forms.Button AnswerButton3;
        private System.Windows.Forms.Button AnswerButton4;
    }
}