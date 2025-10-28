namespace TestRefStruct;

public struct TimeIntervalStruct(DateTime start, DateTime end)
{
    public DateTime StartTime { get; set; } = start;
    public DateTime EndTime { get; set; } = end;
    public TimeSpan Duration => EndTime - StartTime;
}