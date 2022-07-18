namespace CST_150_Week_2_Activity_4
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
            this.Seconds = new System.Windows.Forms.GroupBox();
            this.displaySecondsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.userSecondsInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayHoursLabel = new System.Windows.Forms.Label();
            this.displayDaysLabel = new System.Windows.Forms.Label();
            this.displayMinutesLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.unsuccessfulDigitAttempt = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.Seconds.SuspendLayout();
            this.SuspendLayout();
            // 
            // Seconds
            // 
            this.Seconds.Controls.Add(this.closeButton);
            this.Seconds.Controls.Add(this.unsuccessfulDigitAttempt);
            this.Seconds.Controls.Add(this.clearButton);
            this.Seconds.Controls.Add(this.testLabel);
            this.Seconds.Controls.Add(this.displayMinutesLabel);
            this.Seconds.Controls.Add(this.displayDaysLabel);
            this.Seconds.Controls.Add(this.displayHoursLabel);
            this.Seconds.Controls.Add(this.displaySecondsLabel);
            this.Seconds.Controls.Add(this.label6);
            this.Seconds.Controls.Add(this.label5);
            this.Seconds.Controls.Add(this.label3);
            this.Seconds.Controls.Add(this.label2);
            this.Seconds.Controls.Add(this.calculateButton);
            this.Seconds.Controls.Add(this.userSecondsInput);
            this.Seconds.Controls.Add(this.label1);
            this.Seconds.Location = new System.Drawing.Point(95, 49);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(507, 285);
            this.Seconds.TabIndex = 0;
            this.Seconds.TabStop = false;
            this.Seconds.Text = "Seconds";
            // 
            // displaySecondsLabel
            // 
            this.displaySecondsLabel.AutoSize = true;
            this.displaySecondsLabel.Location = new System.Drawing.Point(401, 160);
            this.displaySecondsLabel.Name = "displaySecondsLabel";
            this.displaySecondsLabel.Size = new System.Drawing.Size(0, 16);
            this.displaySecondsLabel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Seconds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minutes:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(120, 233);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(89, 36);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userSecondsInput
            // 
            this.userSecondsInput.Location = new System.Drawing.Point(169, 104);
            this.userSecondsInput.Name = "userSecondsInput";
            this.userSecondsInput.Size = new System.Drawing.Size(197, 22);
            this.userSecondsInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the number of seconds to display the length of time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayHoursLabel
            // 
            this.displayHoursLabel.AutoSize = true;
            this.displayHoursLabel.Location = new System.Drawing.Point(148, 160);
            this.displayHoursLabel.Name = "displayHoursLabel";
            this.displayHoursLabel.Size = new System.Drawing.Size(0, 16);
            this.displayHoursLabel.TabIndex = 1;
            // 
            // displayDaysLabel
            // 
            this.displayDaysLabel.AutoSize = true;
            this.displayDaysLabel.Location = new System.Drawing.Point(58, 160);
            this.displayDaysLabel.Name = "displayDaysLabel";
            this.displayDaysLabel.Size = new System.Drawing.Size(0, 16);
            this.displayDaysLabel.TabIndex = 1;
            // 
            // displayMinutesLabel
            // 
            this.displayMinutesLabel.AutoSize = true;
            this.displayMinutesLabel.Location = new System.Drawing.Point(274, 160);
            this.displayMinutesLabel.Name = "displayMinutesLabel";
            this.displayMinutesLabel.Size = new System.Drawing.Size(0, 16);
            this.displayMinutesLabel.TabIndex = 1;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(23, 209);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 16);
            this.testLabel.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(215, 233);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 36);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // unsuccessfulDigitAttempt
            // 
            this.unsuccessfulDigitAttempt.AutoSize = true;
            this.unsuccessfulDigitAttempt.ForeColor = System.Drawing.Color.Red;
            this.unsuccessfulDigitAttempt.Location = new System.Drawing.Point(85, 198);
            this.unsuccessfulDigitAttempt.Name = "unsuccessfulDigitAttempt";
            this.unsuccessfulDigitAttempt.Size = new System.Drawing.Size(0, 16);
            this.unsuccessfulDigitAttempt.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(312, 233);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(89, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(716, 359);
            this.Controls.Add(this.Seconds);
            this.Name = "Form1";
            this.Text = "Time Calculator";
            this.Seconds.ResumeLayout(false);
            this.Seconds.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Seconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox userSecondsInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label displaySecondsLabel;
        private System.Windows.Forms.Label displayHoursLabel;
        private System.Windows.Forms.Label displayDaysLabel;
        private System.Windows.Forms.Label displayMinutesLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label unsuccessfulDigitAttempt;
        private System.Windows.Forms.Button closeButton;
    }
}

