using System;

namespace CSharpCalculator
{
    internal class Validator: IValidator
    {
        public bool IsNumber(char entry, string text)
        {
            char decimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (entry == decimalSeparator && text.IndexOf(decimalSeparator) != -1) return false;
            if (!char.IsDigit(entry) && entry != decimalSeparator && entry != (char)System.Windows.Forms.Keys.Back) return false;

            return true;
        }
    }
}
