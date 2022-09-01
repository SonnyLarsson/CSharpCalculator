using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCalculator
{
    internal interface ICalcResult {
        public string NumberString { get; }
        public bool Result { get; }
        public string Info { get; }
    }
}
