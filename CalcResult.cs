

namespace CSharpCalculator
{
    //todo: just turn into struct?
    internal class CalcResult: ICalcResult
    {
        public string NumberString { private set; get; }
        public bool Result { private set; get; }
        public string Info { private set; get; }

        internal CalcResult(string numberString, bool result = true, string info = "")
        {
            NumberString = numberString;
            Result = result;
            Info = info;
        }
    }
}
