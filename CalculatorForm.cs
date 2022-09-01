using System;
using System.Windows.Forms;


namespace CSharpCalculator
{
    public partial class CalculatorForm : Form
    {
        private CalcButtonMethods calc;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            var calculator = new Calculator();
            calculator.Number = 0;
            CalcNumber.Text = calculator.Number.ToString();
            
            calc = new CalcButtonMethods(calculator);
        }

        private void CalcNumber_Click(object sender, EventArgs e)
        {
            CalcNumber.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ResolveResult(calc.Add(CalcNumber.Text));
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            ResolveResult(calc.Subtract(CalcNumber.Text));
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            ResolveResult(calc.Multiply(CalcNumber.Text));
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            ResolveResult(calc.Divide(CalcNumber.Text));
        }

        private void ResolveResult(ICalcResult result) {
            if (result != null)
            {
                if (result.Result)
                {
                    CalcNumber.Text = "0";
                    ResultLabel.Text = result.NumberString;
                }

                if (!result.Result)
                {
                    ResultLabel.Text = $"{result.NumberString} \n {result.Info}";
                }
            }
            else { 
                ResultLabel.Text = "ERROR";
            }
        }


    }
}
