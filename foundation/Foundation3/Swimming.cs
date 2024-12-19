using System;

// derived class for Swimming

public class Swimming : Activity
{
    // specific attribute
    private int _laps;

    // encapsulation property
    public int Laps
    {
        get {return _laps;}
        set {_laps = value;}
    }

    // Constructor to initialize
    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    // method to calculate distance
    public override float GetDistance()
    {
        return Laps * 50 / 1000f;  // laps = (50m each) to kilometers
    }

    // calculate speed
    public override float GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    // calculate pace
    public override float GetPace()
    {
        return Duration / GetDistance();
    }
}