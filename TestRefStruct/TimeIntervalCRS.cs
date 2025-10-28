namespace TestRefStruct;

public interface ICRS
{
    public DateTime StartTime { get; set; }
    public TimeSpan Duration { get; }
}

public ref struct TimeIntervalCRS(DateTime start, DateTime end) : ICRS
{
    public DateTime StartTime { get; set; } = start;
    public DateTime EndTime { get; set; } = end;
    public TimeSpan Duration => EndTime - StartTime;
}