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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

