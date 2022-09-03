
namespace CSharpCalculator
{
    internal class Calculator : ICalculator
    {
        private decimal _number;

        public decimal Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public void MakeProduct(decimal multiplier)
        {
            _number *= multiplier;
        }

        public void MakeSum(decimal addition)
        {
            _number += addition;
        }

        public void MakeDifference(decimal deduction)
        {
            _number -= deduction;
        }

        public void MakeQuotient(decimal divider)
        {
            _number /= divider;
        }
    }
}