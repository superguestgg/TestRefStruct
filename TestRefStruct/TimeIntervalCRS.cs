namespace TestRefStruct;

public interface ICRS
{
    public DateTime StartTime { get; set; }
    public TimeSpan Duration { get; }
}
public ref struct TimeIntervalCRS : ICRS
{
    public TimeIntervalCRS(DateTime start, DateTime end)
    {
        StartTime = start;
        EndTime = end;
    }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public TimeSpan Duration => EndTime - StartTime;
}