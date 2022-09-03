using System;
using System.Globalization;
using System.Windows.Forms;


namespace CSharpCalculator
{
    public partial class CalculatorForm : Form
    {
        private CalcButtonMethods calc;
        private ICalcResult calcResult;      
        private string currentNumber;
        private string sumString;
        private string previousSumString;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            var calculator = new Calculator
            {
                Number = 0
            };

            CalcNumber.Text = calculator.Number.ToString();
            previousSumString = "0";
            ButtonDecimalSeparator.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            CurrentSumLabel.Text = "0";
            ResultLabel.Text = "";

            calc = new CalcButtonMethods(calculator);
        }

        private void CalcNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumber(e.KeyChar, CalcNumber.Text)) e.Handled = true;
        }

        private void CalcNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (CalcNumber.Text.StartsWith("00"))
            {
                CalcNumber.Text = CalcNumber.Text[1..];
                CalcNumber.SelectionStart = CalcNumber.Text.Length;
                CalcNumber.SelectionLength = 0;
            }
            if (CalcNumber.Text.StartsWith(",")) CalcNumber.Text = "0" + CalcNumber.Text ;
        }

        private void CalcNumber_Click(object sender, EventArgs e)
        {
            if (CalcNumber.Text == "0") CalcNumber.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ButtonAction(ECalcButtonActions.Add);
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            ButtonAction(ECalcButtonActions.Subtract);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            ButtonAction(ECalcButtonActions.Multiply);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            ButtonAction(ECalcButtonActions.Divide);
        }

        private void ButtonAction(ECalcButtonActions currentAction)
        {
            currentNumber = CalcNumber.Text;
            ResolveOperation(currentAction);
            CalcNumber.Text = "0";
        }

        private void ResolveOperation(ECalcButtonActions currentAction)
        {
            previousSumString = calcResult == null ? "0" : calcResult.NumberString;
            switch (currentAction)
            {
                case ECalcButtonActions.Equals:
                    sumString = calcResult.NumberString;
                    break;
                case ECalcButtonActions.Add:
                    calcResult = calc.Add(CalcNumber.Text);
                    ResolveInput(calcResult.NumberString, "+");
                    break;
                case ECalcButtonActions.Subtract:
                    calcResult = calc.Subtract(CalcNumber.Text);
                    ResolveInput(calcResult.NumberString, "-");
                    break;
                case ECalcButtonActions.Multiply:
                    calcResult = calc.Multiply(CalcNumber.Text);
                    ResolveInput(calcResult.NumberString, "*");
                    break;
                case ECalcButtonActions.Divide:
                    calcResult = calc.Divide(CalcNumber.Text);
                    ResolveInput(calcResult.NumberString, "/");
                    break;
                default:
                    break;
            }
        }

        private void ResolveInput(string sumString, string operation)
        { 
            if (CalcNumber.Text != "")
            {
                var operationString = $"{previousSumString} {operation} {CalcNumber.Text}";
                ResultLabel.Text = $"{operationString} = {sumString}";
                CurrentSumLabel.Text = sumString;
            }
        }

        private bool IsNumber(char entry, string text)
        {
            char decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (entry == decimalSeparator && text.IndexOf(decimalSeparator) != -1) return false;
            if (!char.IsDigit(entry) && entry != decimalSeparator && entry != (char)Keys.Back) return false;

            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "9";
        }

        private void ButtonDecimalSeparator_Click(object sender, EventArgs e)
        {
            if (CalcNumber.Text == "") CalcNumber.Text = "0";

            if (!CalcNumber.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)) {
                CalcNumber.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }
            
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ClearNumberZero();
            CalcNumber.Text += "0";
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            calcResult = calc.Clear();
            CalcNumber.Text = calcResult.NumberString;
            CurrentSumLabel.Text = calcResult.NumberString;
            ResultLabel.Text = calcResult.Info;
        }

        private void ClearNumberZero() {
            if (CalcNumber.Text == "0") CalcNumber.Text = "";
        }
    }
}
