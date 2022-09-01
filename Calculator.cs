
namespace CSharpCalculator
{
    internal class Calculator : ICalculator
    {
        private decimal number;

        public decimal Number
        {
            get { return number; }
            set { number = value; }
        }

        public void MakeProduct(decimal multiplier)
        {
            number *= multiplier;
        }

        public void MakeSum(decimal addition)
        {
            number += addition;
        }

        public void MakeDifference(decimal deduction)
        {
            number -= deduction;
        }

        public void MakeQuotient(decimal divider)
        {
            number /= divider;
        }
    }
}