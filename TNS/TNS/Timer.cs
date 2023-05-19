using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace TNS
{
    internal class Timer
    {
        public delegate void TimerCreationEventHandler();
    internal class ShutdownTimer
    {
        int _runningTime = 10;

        public event TimerCreationEventHandler TimerCreationEvent;
        DispatcherTimer _timer;
        public ShutdownTimer(int runningTime)
        {
            _runningTime = runningTime;

            _timer = new DispatcherTimer();

            _timer.Tick += new EventHandler(timerTick);
            _timer.Interval = new TimeSpan(0, 0, _runningTime);
        }

        public void Run()
        {
            TimerCreationEvent?.Invoke();
            _timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            Manager.CodVhoda++;
            _timer.Stop();
        }
    }
    }
}
