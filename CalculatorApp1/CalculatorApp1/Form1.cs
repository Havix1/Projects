using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((ResultBox.Text == "0") || isOperationPerformed)
                ResultBox.Clear();

            isOperationPerformed = false;
            Button button=(Button)sender;
            if(button.Text==".")
            {
                if(!ResultBox.Text.Contains("."))
                    ResultBox.Text = ResultBox.Text + button.Text;
            }
            else

            ResultBox.Text = ResultBox.Text + button.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button29.PerformClick();
                operationPerformed = button.Text;
                EquationBox.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(ResultBox.Text);
                EquationBox.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            resultValue = 0;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    ResultBox.Text = (resultValue + Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "-":
                    ResultBox.Text = (resultValue - Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "*":
                    ResultBox.Text = (resultValue * Double.Parse(ResultBox.Text)).ToString();
                    break;
                case "/":
                    ResultBox.Text = (resultValue / Double.Parse(ResultBox.Text)).ToString();
                    break;
              //  case "Sqrt":
                //    ResultBox.Text = (resultValue Math.Pow(ResultBox.Text).ToString();
                  //  break;
                default:
                    break;
            }
            resultValue = Double.Parse(ResultBox.Text);
            EquationBox.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 0)
            {
                ResultBox.Text = ResultBox.Text.Remove(ResultBox.Text.Length - 1, 1);
            }

        }
    }
}
