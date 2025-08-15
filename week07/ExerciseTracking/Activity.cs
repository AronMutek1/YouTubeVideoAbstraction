using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string _date;
        private double _minutes;

        public Activity(string date, double minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public string Date => _date;
        public double Minutes => _minutes;

        public abstract double GetDistance(); // km
        public abstract double GetSpeed();    // kph
        public abstract double GetPace();     // min/km

        public virtual string GetSummary()
        {
            return $"{Date} {GetType().Name} ({Minutes} min): " +
                   $"Distance {GetDistance():0.0} km, " +
                   $"Speed {GetSpeed():0.0} kph, " +
                   $"Pace: {GetPace():0.00} min per km";
        }
    }
}
