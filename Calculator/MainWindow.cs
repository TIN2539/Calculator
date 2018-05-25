using System;
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

		private void CreateResult()
		{
			CalculatingTwoOperands();
			textBox.AppendText(result.ToString());
			button0.Enabled = true;
			ActivateOperationButton();
		}

		private void DivideButton_Click(object sender, EventArgs e)
		{
			SetOperation(divideButton.Text);
		}

		private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9')
			{
				SetTextToTextBox(e.KeyChar.ToString());
			}
			else if (e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '-' || e.KeyChar == '+')
			{
				SetOperation(e.KeyChar.ToString());
			}
			else if (e.KeyChar =='\r')
			{
				CreateResult();
			}
			else if (e.KeyChar == '\b')
			{
				ClearText();
			}
			else
			{
				e.Handled = false;
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

		private void ResultButton_Click(object sender, EventArgs e)
		{
			CreateResult();
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
	}
}