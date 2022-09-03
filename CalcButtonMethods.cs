namespace CSharpCalculator{

    internal delegate ICalcResult CalcMethod(string number);

    internal class CalcButtonMethods
    {
        private readonly ICalculator _calculator;

        internal CalcButtonMethods(ICalculator calculator)
        {
            _calculator = calculator;
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
            _calculator.MakeSum(Parser(number, out bool result, out string info));

            return new CalcResult(_calculator.Number.ToString(), result, info);
        }
        
        internal ICalcResult Subtract(string number) {
            _calculator.MakeDifference(Parser(number, out bool result, out string info));

            return new CalcResult(_calculator.Number.ToString(), result, info);
        }

        internal ICalcResult Multiply(string number)
        {
            _calculator.MakeProduct(Parser(number, out bool result, out string info));

            return new CalcResult(_calculator.Number.ToString(), result, info);
        }

        internal ICalcResult Divide(string number)
        {
            var decimalNumber = Parser(number, out bool result, out string info);

            if (decimalNumber == 0) {
                return new CalcResult(_calculator.Number.ToString(), false, "cannot divide by zero");
            }

            _calculator.MakeQuotient(decimalNumber);

            return new CalcResult(_calculator.Number.ToString(), result, info);
        }

        internal ICalcResult Clear()
        {
            _calculator.Number = 0;
            return new CalcResult(_calculator.Number.ToString(), true, "cleared");
        }

    }
}
