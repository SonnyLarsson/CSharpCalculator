namespace CSharpCalculator{

    internal delegate ICalcResult CalcMethod(string number);

    internal class CalcButtonMethods
    {
        private readonly ICalculator calculator;

        internal CalcButtonMethods(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        private decimal Parser(string numberString, out bool result, out string info) {
            var success = decimal.TryParse(numberString, out decimal number);

            if (success)
            {
                result = true;
                info = "valid number";
                return number;
            }

            result = false;
            info = "not a valid decimal number";
            return 0;
        }

        internal ICalcResult Add(string number) {
            calculator.MakeSum(Parser(number, out bool result, out string info));

            return new CalcResult(calculator.Number.ToString(), result, info);
        }
        
        internal ICalcResult Subtract(string number) {
            calculator.MakeDifference(Parser(number, out bool result, out string info));

            return new CalcResult(calculator.Number.ToString(), result, info);
        }

        internal ICalcResult Multiply(string number)
        {
            calculator.MakeProduct(Parser(number, out bool result, out string info));

            return new CalcResult(calculator.Number.ToString(), result, info);
        }

        internal ICalcResult Divide(string number)
        {
            var decimalNumber = Parser(number, out bool result, out string info);

            if (decimalNumber == 0) {
                return new CalcResult(calculator.Number.ToString(), false, "cannot divide by zero");
            }

            calculator.MakeQuotient(decimalNumber);

            return new CalcResult(calculator.Number.ToString(), result, info);
        }

        internal ICalcResult Clear()
        {
            calculator.Number = 0;
            return new CalcResult(calculator.Number.ToString(), true, "cleared");
        }

    }
}
