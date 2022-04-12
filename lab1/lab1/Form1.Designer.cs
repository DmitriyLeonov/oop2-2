namespace lab1
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
            this.secondDigitTextBox = new System.Windows.Forms.TextBox();
            this.firstDigitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.summButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondDigitTextBox
            // 
            this.secondDigitTextBox.Location = new System.Drawing.Point(208, 53);
            this.secondDigitTextBox.Name = "secondDigitTextBox";
            this.secondDigitTextBox.Size = new System.Drawing.Size(125, 27);
            this.secondDigitTextBox.TabIndex = 0;
            this.secondDigitTextBox.TextChanged += new System.EventHandler(this.secondDigitTextBox_TextChanged);
            // 
            // firstDigitTextBox
            // 
            this.firstDigitTextBox.Location = new System.Drawing.Point(50, 53);
            this.firstDigitTextBox.Name = "firstDigitTextBox";
            this.firstDigitTextBox.Size = new System.Drawing.Size(125, 27);
            this.firstDigitTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первое число";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второе число";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(457, 53);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(125, 27);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.TextChanged += new System.EventHandler(this.resultTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // summButton
            // 
            this.summButton.Location = new System.Drawing.Point(50, 122);
            this.summButton.Name = "summButton";
            this.summButton.Size = new System.Drawing.Size(94, 29);
            this.summButton.TabIndex = 6;
            this.summButton.Text = "+";
            this.summButton.UseVisualStyleBackColor = true;
            this.summButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(50, 166);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(94, 29);
            this.subtractionButton.TabIndex = 7;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(50, 213);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(94, 29);
            this.divisionButton.TabIndex = 8;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(50, 262);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(94, 29);
            this.multiplyButton.TabIndex = 9;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(50, 306);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(283, 29);
            this.divButton.TabIndex = 10;
            this.divButton.Text = "Остаток от деления";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // modButton
            // 
            this.modButton.Location = new System.Drawing.Point(50, 357);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(283, 29);
            this.modButton.TabIndex = 11;
            this.modButton.Text = " Целая часть деления";
            this.modButton.UseVisualStyleBackColor = true;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(208, 122);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(125, 29);
            this.cleanButton.TabIndex = 12;
            this.cleanButton.Text = "Очистить";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(208, 166);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 29);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Хранение";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(208, 213);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(125, 29);
            this.getButton.TabIndex = 14;
            this.getButton.Text = "Извлечение";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.summButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstDigitTextBox);
            this.Controls.Add(this.secondDigitTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox secondDigitTextBox;
        private TextBox firstDigitTextBox;
        private Label label1;
        private Label label2;
        private TextBox resultTextBox;
        private Label label3;
        private Button summButton;
        private Button subtractionButton;
        private Button divisionButton;
        private Button multiplyButton;
        private Button divButton;
        private Button modButton;
        private Button cleanButton;
        private Button saveButton;
        private Button getButton;
    }
}