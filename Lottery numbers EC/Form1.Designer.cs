namespace Lottery_numbers_EC
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fifthLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstLabel.Location = new System.Drawing.Point(153, 178);
            this.firstLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(122, 47);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLabel
            // 
            this.secondLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.secondLabel.Location = new System.Drawing.Point(348, 178);
            this.secondLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(130, 47);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondLabel.UseWaitCursor = true;
            // 
            // thirdLabel
            // 
            this.thirdLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.thirdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdLabel.Location = new System.Drawing.Point(540, 178);
            this.thirdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(126, 46);
            this.thirdLabel.TabIndex = 2;
            this.thirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourthLabel
            // 
            this.fourthLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fourthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourthLabel.Location = new System.Drawing.Point(713, 178);
            this.fourthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(128, 46);
            this.fourthLabel.TabIndex = 3;
            this.fourthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(301, 317);
            this.generateButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(189, 60);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(554, 317);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 58);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // fifthLabel
            // 
            this.fifthLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fifthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fifthLabel.Location = new System.Drawing.Point(886, 178);
            this.fifthLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fifthLabel.Name = "fifthLabel";
            this.fifthLabel.Size = new System.Drawing.Size(117, 46);
            this.fifthLabel.TabIndex = 6;
            this.fifthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(363, 84);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(394, 29);
            this.title.TabIndex = 7;
            this.title.Text = "LOTTERY NUMBER GENERATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 457);
            this.Controls.Add(this.title);
            this.Controls.Add(this.fifthLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Lottery Numbers ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label fifthLabel;
        private System.Windows.Forms.Label title;
    }
}

