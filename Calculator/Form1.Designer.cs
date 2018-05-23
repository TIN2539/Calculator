namespace Calculator
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
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.resultButton = new System.Windows.Forms.Button();
			this.plusButton = new System.Windows.Forms.Button();
			this.minusButton = new System.Windows.Forms.Button();
			this.divideButton = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.resultBox = new System.Windows.Forms.TextBox();
			this.ceButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 119);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.TabStop = false;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(174, 119);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.TabStop = false;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 90);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.TabStop = false;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(93, 90);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 5;
			this.button5.TabStop = false;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(174, 90);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 6;
			this.button6.TabStop = false;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(12, 61);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 7;
			this.button7.TabStop = false;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(93, 119);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.TabStop = false;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(93, 61);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 8;
			this.button8.TabStop = false;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(174, 61);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 9;
			this.button9.TabStop = false;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9_Click);
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(93, 148);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(75, 23);
			this.button0.TabIndex = 0;
			this.button0.TabStop = false;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Button0_Click);
			// 
			// resultButton
			// 
			this.resultButton.Enabled = false;
			this.resultButton.Location = new System.Drawing.Point(174, 148);
			this.resultButton.Name = "resultButton";
			this.resultButton.Size = new System.Drawing.Size(75, 23);
			this.resultButton.TabIndex = 14;
			this.resultButton.TabStop = false;
			this.resultButton.Text = "=";
			this.resultButton.UseVisualStyleBackColor = true;
			this.resultButton.Click += new System.EventHandler(this.ResultButton_Click);
			// 
			// plusButton
			// 
			this.plusButton.Enabled = false;
			this.plusButton.Location = new System.Drawing.Point(266, 148);
			this.plusButton.Name = "plusButton";
			this.plusButton.Size = new System.Drawing.Size(75, 23);
			this.plusButton.TabIndex = 13;
			this.plusButton.TabStop = false;
			this.plusButton.Text = "+";
			this.plusButton.UseVisualStyleBackColor = true;
			this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
			// 
			// minusButton
			// 
			this.minusButton.Enabled = false;
			this.minusButton.Location = new System.Drawing.Point(266, 119);
			this.minusButton.Name = "minusButton";
			this.minusButton.Size = new System.Drawing.Size(75, 23);
			this.minusButton.TabIndex = 12;
			this.minusButton.TabStop = false;
			this.minusButton.Text = "-";
			this.minusButton.UseVisualStyleBackColor = true;
			this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
			// 
			// divideButton
			// 
			this.divideButton.Enabled = false;
			this.divideButton.Location = new System.Drawing.Point(266, 61);
			this.divideButton.Name = "divideButton";
			this.divideButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.divideButton.Size = new System.Drawing.Size(76, 23);
			this.divideButton.TabIndex = 10;
			this.divideButton.TabStop = false;
			this.divideButton.Text = "/";
			this.divideButton.UseVisualStyleBackColor = true;
			this.divideButton.Click += new System.EventHandler(this.DivideButton_Click);
			// 
			// multiplyButton
			// 
			this.multiplyButton.Enabled = false;
			this.multiplyButton.Location = new System.Drawing.Point(266, 90);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(75, 23);
			this.multiplyButton.TabIndex = 11;
			this.multiplyButton.TabStop = false;
			this.multiplyButton.Text = "*";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(12, 29);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(329, 20);
			this.textBox.TabIndex = 16;
			this.textBox.TabStop = false;
			this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// resultBox
			// 
			this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.resultBox.Location = new System.Drawing.Point(12, 10);
			this.resultBox.Name = "resultBox";
			this.resultBox.ReadOnly = true;
			this.resultBox.Size = new System.Drawing.Size(328, 13);
			this.resultBox.TabIndex = 17;
			this.resultBox.TabStop = false;
			this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.resultBox.ReadOnlyChanged += new System.EventHandler(this.ResultBox_ReadOnlyChanged);
			// 
			// ceButton
			// 
			this.ceButton.Enabled = false;
			this.ceButton.Location = new System.Drawing.Point(12, 147);
			this.ceButton.Name = "ceButton";
			this.ceButton.Size = new System.Drawing.Size(75, 23);
			this.ceButton.TabIndex = 15;
			this.ceButton.TabStop = false;
			this.ceButton.Text = "CE";
			this.ceButton.UseVisualStyleBackColor = true;
			this.ceButton.Click += new System.EventHandler(this.CEButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 182);
			this.Controls.Add(this.ceButton);
			this.Controls.Add(this.resultBox);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.plusButton);
			this.Controls.Add(this.minusButton);
			this.Controls.Add(this.divideButton);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.resultButton);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button resultButton;
		private System.Windows.Forms.Button plusButton;
		private System.Windows.Forms.Button minusButton;
		private System.Windows.Forms.Button divideButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TextBox resultBox;
		private System.Windows.Forms.Button ceButton;
	}
}

