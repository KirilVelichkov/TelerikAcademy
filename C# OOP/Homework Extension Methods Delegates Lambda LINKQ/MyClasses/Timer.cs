using System;
using System.Threading;

namespace MyClasses
{
    public delegate void MyDelegate();

    public class Timer
    {

        private MyDelegate method;
        private int interval;
        private int times = -1;
        private Thread oThread;

        public Timer(MyDelegate method, int interval, int times)
            : this(method, interval)
        {
            this.times = times;

        }
        public Timer(MyDelegate method, int interval)
        {
            this.method = method;
            this.interval = interval;
            oThread = new Thread(new ThreadStart(Run));
            oThread.Start();
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(interval * 1000);
                this.method();
                if (this.times > 0)
                {
                    this.times--;
                    if (this.times == 0)
                    {
                        return;
                    }
                }
            }
        }

        public void Stop()
        {
            oThread.Abort();
        }

    }
}
