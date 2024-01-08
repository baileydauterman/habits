namespace Habits.Data
{
    public class Goal
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Interval Interval { get; set; } = Interval.Weekly;

        public Measurement Measurement { get; set; }

        public double GoalValue { get; set; } = 0;

        public double PercentProgress => TotalProgress / GoalValue * 100;

        public double TotalProgress => ProgressCheckins.Select(x => x.Progress).Sum();

        public List<ProgressCheckin> ProgressCheckins { get; set; } = new List<ProgressCheckin>();
    }

    public enum Interval
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum Measurement
    {
        lbs,
        miles,
    }
}
