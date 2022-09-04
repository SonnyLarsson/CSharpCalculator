using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCalculator
{
    internal interface IMeasuringThread
    {
        public void StartMeasuring(int waitSeconds);

        public void StopMeasuring();

        public void PauseMeasuring();
    }
}
