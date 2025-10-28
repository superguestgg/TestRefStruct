namespace TestRefStruct;

public class TimeIntervalCRSTest
{
    public static unsafe void Run()
    {
        var timeIntervals = stackalloc TimeIntervalCRS[Constants.IntervalsCount];
        var startTime = DateTime.Now;

        for (var i = 0; i < Constants.IntervalsCount; i++)
            timeIntervals[i] = new TimeIntervalCRS(startTime.AddHours(Random.Shared.Next(1000000)),
                startTime.AddSeconds(10));

        //var s = new Span<ICRS>(timeIntervals, IntervalsCount);
        //s.Sort();
        // var timeIntervalsSpan = new Span<TimeIntervalCRS>(timeIntervals, IntervalsCount);
        startTime = DateTime.Now;
        QuickSort(timeIntervals, 0, Constants.IntervalsCount - 1);
        Console.WriteLine(DateTime.Now - startTime);
    }

    private static unsafe void QuickSort(TimeIntervalCRS* arr, int left, int right)
    {
        if (left < right)
        {
            var pivot = Partition(arr, left, right);
            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
        }
    }

    private static unsafe int Partition(TimeIntervalCRS* arr, int left, int right)
    {
        var pivot = arr[right];
        var i = left - 1;

        for (var j = left; j < right; j++)
            if (arr[j].StartTime < pivot.StartTime)
            {
                i++;
                Swap(arr + i, arr + j);
            }

        Swap(arr + i + 1, arr + right);
        return i + 1;
    }

    private static unsafe void Swap(TimeIntervalCRS* a, TimeIntervalCRS* b)
    {
        var temp = *a;
        *a = *b;
        *b = temp;
    }
}