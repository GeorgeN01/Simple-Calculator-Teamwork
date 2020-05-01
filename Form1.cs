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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //calculate button click
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Reading data from text boxes
            decimal operand1 = decimal.Parse(txtOperand1.Text); //taking operand1 entered by user
            decimal operand2 = decimal.Parse(txtOperand2.Text); //taking operand2 entered by user
            string operator1 = txtOperator.Text; //taking operator entered by user

            //calling method and passing parameters
            decimal result = Calculate(operand1, operator1, operand2);

            //display result in the result textbox
            txtResult.Text = String.Format($"{result.ToString("0.0000")}");
        }
        //method to calculate result of operation
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            //variable to store result
            decimal result = 0;

            //using switch passing operator1
            switch (operator1)
            {
                //addition
                case "+":
                    result = operand1 + operand2;
                    break;
                //subtraction
                case "-":
                    result = operand1 - operand2;
                    break;
                //multiplication
                case "*":
                    result = operand1 * operand2;
                    break;
                //division
                case "/":
                    result = operand1 / operand2;
                    break;
                
            }
            return result;//Returning result
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";//clear textbox
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";//clear textbox
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";//clear textbox
        }
    }
}
