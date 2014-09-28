using System;
using System.Threading;

class AsyncTimer
{
    private Action<string> action;
    private int interval;
    private int ticks;

    public AsyncTimer(Action<string> method, int interval, int ticks)
    {
        this.Interval = interval;
        this.Ticks = ticks;
        this.action = method;
    }

    public int Interval
    {
        get
        {
            return this.interval;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Interval can't be negative!");
            }

            this.interval = value;
        }
    }

    public int Ticks
    {
        get
        {
            return this.ticks;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Time can't be negative!");
            }

            this.ticks = value;
        }
    }

    private void Action()
    {
        while (this.Ticks > 0)
        {
            Thread.Sleep(this.Interval);

            if (action != null)
            {
                action(this.Ticks + "");
            }

            this.Ticks--;
        }
    }

    public void Start()
    {
        Thread thread = new Thread(this.Action);
        thread.Start();
    }
}
