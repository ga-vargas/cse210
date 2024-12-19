using System;

// base class

public abstract class Activity
{
    // shared attributes
    private DateTime _date; // date of the activity
    private int _duration; // minutes duration

    // encapsulate attributes
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    // Constructor to initialize
    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // calculations to use in derived classes
    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} ({Duration} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F1} min per km";
    }
}