namespace TestRefStruct;

public class TimeIntervalClassTest
{
    private static int IntervalsCount = 5000000;
    public static void Run()
    {
        var timeIntervals = new List<TimeIntervalClass>();
        var startTime = DateTime.Now;
        for (var i = 0; i < IntervalsCount; i++)
        {
            timeIntervals.Add(new TimeIntervalClass(startTime.AddHours(Random.Shared.Next(1000000)), startTime.AddSeconds(10)));
        }
        
        TestTime(timeIntervals);
    }

    private static void TestTime(List<TimeIntervalClass>  timeIntervals)
    {
        var startTime = DateTime.Now;
        timeIntervals.Sort((t1,t2) => t1.StartTime.CompareTo(t2.StartTime));
        Console.WriteLine(DateTime.Now - startTime);
    }
}