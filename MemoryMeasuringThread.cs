using System;
using System.Threading;

namespace CSharpCalculator
{
    internal class MemoryMeasuringThread: IMeasuringThread
    {
        private readonly Action<string> _infoDelegate;
        private bool _keepWorking;
        private ICalcResult _calcResult;
        Thread _measuringThread;
        ManualResetEvent _event = new ManualResetEvent(false);

        internal MemoryMeasuringThread(Action<string> infoDelegate, ICalcResult calcResult)
        {
            _infoDelegate = infoDelegate;
            _calcResult = calcResult;
        }

        public void StartMeasuring(int waitSeconds) {
            _keepWorking = true;
            if (_measuringThread == null)
            {
                _measuringThread = new Thread(() => Measure(waitSeconds));
                _measuringThread.Start();
            }
            _event.Set();
        }

        public void StopMeasuring()
        {
            _keepWorking = false;
            _measuringThread = null;
        }

        public void PauseMeasuring()
        {
            _event.Reset();
        }

        private void Measure(int waitSeconds = 2) {
            while (_keepWorking)
            {
                _event.WaitOne();
                MemoryMeasure();
                Thread.Sleep(waitSeconds * 1000);

            }
        }

        private void MemoryMeasure() {
            long applicationMemory = GC.GetTotalMemory(true);
            long stringMemory = StringMemoryMax((_calcResult == null) ? "0":_calcResult.NumberString);
            UpdateInfo($"This application currently uses {applicationMemory} bytes, and the current number fits in a string of {stringMemory} bytes.");
        }

        private long StringMemoryMax(string stringToMeasure)
        {
            long size = 24 + (stringToMeasure.Length * 2);
            size = RoundUpStringSize(size);
            return size;
        }

        private long RoundUpStringSize(long approximateSize) {
            if (approximateSize % 8 == 0) return approximateSize;
            long remainder = approximateSize % 8;
            approximateSize -= remainder;
            approximateSize += 8;
            return approximateSize;
        }

        private void UpdateInfo(string text) {
            _infoDelegate(text);
        }
    }
}
