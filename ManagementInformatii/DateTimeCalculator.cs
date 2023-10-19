using Microsoft.VisualBasic;

namespace Lab7.ManagementInformatii;

internal static class DateTimeCalculator
{
    public static long YearsDifference(DateTime dateTime1, DateTime dateTime2)
    {
        long yearsDiff = DateAndTime.DateDiff(DateInterval.Year, dateTime1, dateTime2);
        return yearsDiff;
    }
}
