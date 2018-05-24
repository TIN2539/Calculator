using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MainWindow : Form
	{
		private int firstOperand;
		private string operation;
		private int result;
		private int secondOperand;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void ActivateOperationButton()
		{
			if (textBox.TextLength == 0 && resultBox.TextLength >= 0)
			{
				resultButton.Enabled = false;
				plusButton.Enabled = false;
				minusButton.Enabled = false;
				divideButton.Enabled = false;
				multiplyButton.Enabled = false;
			}
			else if (textBox.TextLength > 0 && resultBox.TextLength == 0)
			{
				if (result.ToString() != textBox.Text)
				{
					resultButton.Enabled = false;
					plusButton.Enabled = true;
					minusButton.Enabled = true;
					divideButton.Enabled = true;
					multiplyButton.Enabled = true;
				}
				else
				{
					resultButton.Enabled = false;
					plusButton.Enabled = false;
					minusButton.Enabled = false;
					divideButton.Enabled = false;
					multiplyButton.Enabled = false;
				}
			}
			else if (textBox.TextLength > 0 && resultBox.TextLength > 0)
			{
				resultButton.Enabled = true;
				plusButton.Enabled = false;
				minusButton.Enabled = false;
				divideButton.Enabled = false;
				multiplyButton.Enabled = false;
			}
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button0.Text);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button1.Text);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button2.Text);
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button3.Text);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button4.Text);
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button5.Text);
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button6.Text);
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button7.Text);
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button8.Text);
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			SetTextToTextBox(button9.Text);
		}

		private void CalculatingTwoOperands()
		{
			secondOperand = int.Parse(textBox.Text);
			resultBox.Clear();
			textBox.Clear();
			if (operation == "+")
			{
				result = firstOperand + secondOperand;
			}
			else if (operation == "-")
			{
				result = firstOperand - secondOperand;
			}
			else if (operation == "/")
			{
				result = firstOperand / secondOperand;
			}
			else if (operation == "*")
			{
				result = firstOperand * secondOperand;
			}
		}

		private void CEButton_Click(object sender, EventArgs e)
		{
			ClearText();
			CheckCEButtonEnable();
		}

		private void CheckCEButtonEnable()
		{
			ceButton.Enabled = resultBox.TextLength > 0 || textBox.TextLength > 0;
		}

		private void ClearText()
		{
			if (resultBox.TextLength >= 0 && textBox.TextLength > 0)
			{
				textBox.Clear();
				button0.Enabled = !(operation == "/");
			}
			else if (textBox.TextLength == 0 && resultBox.TextLength > 0)
			{
				resultBox.Clear();
				button0.Enabled = true;
			}
			ActivateOperationButton();
		}

		private void DivideButton_Click(object sender, EventArgs e)
		{
			SetOperation(divideButton.Text);
		}

		private void MainWindow_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.NumPad0:
				case Keys.D0:
					if (button0.Enabled)
					{
						Button0_Click(this, new EventArgs());
					}
					break;
				case Keys.NumPad1:
				case Keys.D1:
					Button1_Click(this, new EventArgs());
					break;
				case Keys.NumPad2:
				case Keys.D2:
					Button2_Click(this, new EventArgs());
					break;
				case Keys.NumPad3:
				case Keys.D3:
					Button3_Click(this, new EventArgs());
					break;
				case Keys.NumPad4:
				case Keys.D4:
					Button4_Click(this, new EventArgs());
					break;
				case Keys.NumPad5:
				case Keys.D5:
					Button5_Click(this, new EventArgs());
					break;
				case Keys.NumPad6:
				case Keys.D6:
					Button6_Click(this, new EventArgs());
					break;
				case Keys.NumPad7:
				case Keys.D7:
					Button7_Click(this, new EventArgs());
					break;
				case Keys.NumPad8:
				case Keys.D8:
					Button8_Click(this, new EventArgs());
					break;
				case Keys.NumPad9:
				case Keys.D9:
					Button9_Click(this, new EventArgs());
					break;
				case Keys.Enter:
					if (resultButton.Enabled)
					{
						ResultButton_Click(this, new EventArgs());
					}
					break;
				case Keys.Oemplus:
				case Keys.Add:
					if (plusButton.Enabled)
					{
						PlusButton_Click(this, new EventArgs());
					}
					break;
				case Keys.OemMinus:
				case Keys.Subtract:
					if (minusButton.Enabled)
					{
						MinusButton_Click(this, new EventArgs());
					}
					break;
				case Keys.Divide:
					if (divideButton.Enabled)
					{
						DivideButton_Click(this, new EventArgs());
					}
					break;
				case Keys.Multiply:
					if (multiplyButton.Enabled)
					{
						MultiplyButton_Click(this, new EventArgs());
					}
					break;
				case Keys.Delete:
				case Keys.Back:
					if (ceButton.Enabled)
					{
						CEButton_Click(this, new EventArgs());
					}
					break;
			}
		}

		private void MinusButton_Click(object sender, EventArgs e)
		{
			SetOperation(minusButton.Text);
		}

		private void MultiplyButton_Click(object sender, EventArgs e)
		{
			SetOperation(multiplyButton.Text);
		}

		private void PlusButton_Click(object sender, EventArgs e)
		{
			SetOperation(plusButton.Text);
		}

		private void ResultBox_ReadOnlyChanged(object sender, EventArgs e)
		{
			CheckCEButtonEnable();
		}

		private void ResultButton_Click(object sender, EventArgs e)
		{
			CalculatingTwoOperands();
			textBox.AppendText(result.ToString());
			button0.Enabled = true;
			ceButton.Enabled = false;
			ActivateOperationButton();
		}

		private void SetOperation(string text)
		{
			firstOperand = int.Parse(textBox.Text);
			operation = text;
			button0.Enabled = !(operation == "/");
			resultBox.AppendText($"{textBox.Text} {text}");
			textBox.Clear();
			ActivateOperationButton();
		}

		private void SetTextToTextBox(string text)
		{
			if (result.ToString() == textBox.Text)
			{
				textBox.Clear();
			}
			textBox.AppendText(text);
			button0.Enabled = true;
			ActivateOperationButton();
		}

		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			CheckCEButtonEnable();
		}
	}
}