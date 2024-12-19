using System;

// derived class for cycling
public class Cycling : Activity
{
    // specific attribute
    private float _speed;

    // encapsulation
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    // Constructor
    public Cycling(DateTime date, int duration, float speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    // method to calculate distance
    public override float GetDistance()
    {
        return (Speed * Duration) / 60;
    }

    // return speed
    public override float GetSpeed()
    {
        return Speed;
    }

    // calculate pace
    public override float GetPace()
    {
        return 60 / Speed;
    }
}