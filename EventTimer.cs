using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningProgram;
using System.Timers;

namespace LearningProgram
{
    public class EventTimer
    {
        private readonly System.Timers.Timer Atimer;

        public event EventHandler? Elapsed;

        public EventTimer(double interval)
        {
            Atimer = new System.Timers.Timer(interval);
            Atimer.Elapsed += OnElapsed;
        }

        public void Start()
        {
            Atimer.Start();
        }

        public void Stop()
        {
            Atimer.Stop();
        }

        protected virtual void OnElapsed(object? sender, ElapsedEventArgs e)
        {
            if(Elapsed != null)
            {
                Elapsed(this, EventArgs.Empty);
            }
        }
    }

    public class TimerHandler
    {
        public void OnTimerElapsed(object? sender, EventArgs e)
        {
            Console.WriteLine("Timer elapsed event triggered!");
        }
    }
}