namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double _distance; // km

        public Running(string date, double minutes, double distance)
            : base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }
    }
}
