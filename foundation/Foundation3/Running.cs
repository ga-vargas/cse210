using System;

// derived class for running

public class Running : Activity
{
    // attribute for running
    private float _distance;

    // encapsulation
    public float Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    // constructor
    public Running(DateTime date, int duration, float distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    // return the distance
    public override float GetDistance()
    {
        return _distance;
    }

    // calculate speed
    public override float GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    // calculate Pace
    public override float GetPace()
    {
        return Duration / GetDistance();
    }
}
