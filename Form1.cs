using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculation and Validation Logic (Methods for reuse)
        private void Calculate(string op)
        {
            // Condition and Parsing Control (Variables & Parsing / Conditions)
            if (!double.TryParse(textBox1.Text, out double num1))
            {
                MessageBox.Show("Please enter a valid number for the first number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBox2.Text, out double num2))
            {
                MessageBox.Show("Please enter a valid number for the second number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Division by zero control (Validation)
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox3.Text = "Error";
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate("/");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}