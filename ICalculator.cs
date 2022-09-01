namespace CSharpCalculator
{
    public interface ICalculator
    {
        public decimal Number { get; set; }

        public void MakeProduct(decimal multiplier);

        public void MakeSum(decimal addition);

        public void MakeDifference(decimal deduction);

        public void MakeQuotient(decimal divider);
    }
}
