namespace TestRefStruct;

public class TimeIntervalClass
{
    public TimeIntervalClass(DateTime start, DateTime end)
    {
        StartTime = start;
        EndTime = end;
    }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public TimeSpan Duration => EndTime - StartTime;
    
}