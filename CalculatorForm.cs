using System;
using System.Globalization;
using System.Windows.Forms;

namespace CSharpCalculator
{
    public partial class CalculatorForm : Form
    {
        private CalcButtonMethods _calc;
        private ICalcResult _calcResult;
        private IValidator _validation;
        private IMeasuringThread _memoryMeasurer;
        private string _previousSumString;
        private bool _measuring;

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
            CurrentSumLabel.Text = "0";
            ResultLabel.Text = "";

            ButtonDecimalSeparator.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            _previousSumString = "0";
            _calc = new CalcButtonMethods(calculator);
            _validation = new Validator();

            MemoryLabel.Text = "";

            _measuring = false;
        }

        #region CalcNumber

        private void CalcNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_validation.IsNumber(e.KeyChar, CalcNumber.Text)) e.Handled = true;
        }

        private void CalcNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (CalcNumber.Text.StartsWith("00"))
            {
                CalcNumber.Text = CalcNumber.Text[1..];
                CalcNumber.SelectionStart = CalcNumber.Text.Length;
                CalcNumber.SelectionLength = 0;
            }
            if (CalcNumber.Text.StartsWith(",")) CalcNumber.Text = "0" + CalcNumber.Text;
        }

        private void CalcNumber_Click(object sender, EventArgs e)
        {
            if (CalcNumber.Text == "0") CalcNumber.Text = "";
        }

        #endregion

        #region calc_buttons

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

        #endregion

        #region calc_button_actions

        private void ButtonAction(ECalcButtonActions currentAction)
        {
            ResolveOperation(currentAction);
            CalcNumber.Text = "0";
        }

        private void ResolveOperation(ECalcButtonActions currentAction)
        {
            _previousSumString = _calcResult == null ? "0" : _calcResult.NumberString;
            switch (currentAction)
            {
                case ECalcButtonActions.Add:
                    _calcResult = _calc.Add(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "+");
                    break;
                case ECalcButtonActions.Subtract:
                    _calcResult = _calc.Subtract(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "-");
                    break;
                case ECalcButtonActions.Multiply:
                    _calcResult = _calc.Multiply(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "*");
                    break;
                case ECalcButtonActions.Divide:
                    _calcResult = _calc.Divide(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "/");
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region input_buttons

        private void Button1_Click(object sender, EventArgs e)
        {
            AddCalcNumber("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddCalcNumber("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddCalcNumber("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddCalcNumber("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AddCalcNumber("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddCalcNumber("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AddCalcNumber("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AddCalcNumber("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddCalcNumber("9");
        }

        private void ButtonDecimalSeparator_Click(object sender, EventArgs e)
        {
            if (CalcNumber.Text == "") CalcNumber.Text = "0";

            if (!CalcNumber.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                CalcNumber.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            AddCalcNumber("0");
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            _calcResult = _calc.Clear();
            CalcNumber.Text = _calcResult.NumberString;
            CurrentSumLabel.Text = _calcResult.NumberString;
            ResultLabel.Text = _calcResult.Info;
        }

        #endregion

        private void ResolveInput(string sumString, string operation)
        {
            if (CalcNumber.Text != "")
            {
                var operationString = $"{_previousSumString} {operation} {CalcNumber.Text}";
                ResultLabel.Text = $"{operationString} = {sumString}";
                CurrentSumLabel.Text = sumString;
            }
        }

        private void AddCalcNumber(string numberString)
        {
            if (CalcNumber.Text == "0") {
                CalcNumber.Text = numberString;
            } else {
                CalcNumber.Text += numberString;
            }            
        }

        private void UpdateLabel(string text)
        {
            try
            {
                Invoke(new MethodInvoker(() => MemoryLabel.Text = text));
            }
            catch (InvalidOperationException)
            {
                MemoryLabel.Text = "";
            }
        }

        private void ButtonMemory_Click(object sender, EventArgs e)
        {
            if (_memoryMeasurer == null) {
                _memoryMeasurer = new MemoryMeasuringThread(UpdateLabel, _calcResult);
            }

            if (_measuring)
            {
                _memoryMeasurer.PauseMeasuring();
                ButtonMemory.Text = "4";
            }
            
            if (!_measuring) { 
                _memoryMeasurer.StartMeasuring(2);
                ButtonMemory.Text = ";";
            }

            _measuring = !_measuring;
        }

        private void ButtonStopMeasuringMemory_Click(object sender, EventArgs e)
        {
            if (_memoryMeasurer != null)
            {
                _memoryMeasurer.StopMeasuring();
                _measuring = false;

                MemoryLabel.Text = "";
                ButtonMemory.Text = "4";
            }
        }

        #endregion

        #region calc_button_actions

        private void ButtonAction(ECalcButtonActions currentAction)
        {
            ResolveOperation(currentAction);
            CalcNumber.Text = "0";
        }

        private void ResolveOperation(ECalcButtonActions currentAction)
        {
            _previousSumString = _calcResult == null ? "0" : _calcResult.NumberString;
            switch (currentAction)
            {
                case ECalcButtonActions.Add:
                    _calcResult = _calc.Add(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "+");
                    break;
                case ECalcButtonActions.Subtract:
                    _calcResult = _calc.Subtract(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "-");
                    break;
                case ECalcButtonActions.Multiply:
                    _calcResult = _calc.Multiply(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "*");
                    break;
                case ECalcButtonActions.Divide:
                    _calcResult = _calc.Divide(CalcNumber.Text);
                    ResolveInput(_calcResult.NumberString, "/");
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region input_buttons

        private void Button1_Click(object sender, EventArgs e)
        {
            AddCalcNumber("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddCalcNumber("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddCalcNumber("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddCalcNumber("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AddCalcNumber("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddCalcNumber("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AddCalcNumber("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AddCalcNumber("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddCalcNumber("9");
        }

        private void ButtonDecimalSeparator_Click(object sender, EventArgs e)
        {
            if (CalcNumber.Text == "") CalcNumber.Text = "0";

            if (!CalcNumber.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                CalcNumber.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            AddCalcNumber("0");
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            _calcResult = _calc.Clear();
            CalcNumber.Text = _calcResult.NumberString;
            CurrentSumLabel.Text = _calcResult.NumberString;
            ResultLabel.Text = _calcResult.Info;
        }

        #endregion

        private void ResolveInput(string sumString, string operation)
        {
            if (CalcNumber.Text != "")
            {
                var operationString = $"{_previousSumString} {operation} {CalcNumber.Text}";
                ResultLabel.Text = $"{operationString} = {sumString}";
                CurrentSumLabel.Text = sumString;
            }
        }

        private void AddCalcNumber(string numberString)
        {
            if (CalcNumber.Text == "0") {
                CalcNumber.Text = numberString;
            } else {
                CalcNumber.Text += numberString;
            }            
        }
    }
}
