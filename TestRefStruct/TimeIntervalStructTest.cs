namespace TestRefStruct;

public class TimeIntervalStructTest
{
    public static void Run()
    {
        var timeIntervals = new List<TimeIntervalStruct>();
        var startTime = DateTime.Now;
        for (var i = 0; i < Constants.IntervalsCount; i++)
            timeIntervals.Add(new TimeIntervalStruct(startTime.AddHours(Random.Shared.Next(1000000)),
                startTime.AddSeconds(10)));
        var span = new Span<TimeIntervalStruct>(timeIntervals.ToArray());

        TestTimeSpan(span);

        TestTime(timeIntervals);
    }

    private static void TestTime(List<TimeIntervalStruct> timeIntervals)
    {
        var startTime = DateTime.Now;
        timeIntervals.Sort((t1, t2) => t1.StartTime.CompareTo(t2.StartTime));
        Console.WriteLine(DateTime.Now - startTime);
    }

    private static void TestTimeSpan(Span<TimeIntervalStruct> timeIntervals)
    {
        var startTime = DateTime.Now;
        timeIntervals.Sort((t1, t2) => t1.StartTime.CompareTo(t2.StartTime));
        Console.WriteLine(DateTime.Now - startTime);
    }
}