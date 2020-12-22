using System;

namespace MarsMoonVisibility
{
    public class MoonVisibilityCalculator
    {
        public static int CalculateOverlaps(MarsTimeInterval intervalOne, MarsTimeInterval intervalTwo)
        {
            int intervalOneStart = intervalOne.getRelativeStartMinutes();
            int intervalOneEnd = intervalOne.getRelativeEndMinutes();
            int intervalTwoStart = intervalTwo.getRelativeStartMinutes();
            int intervalTwoEnd = intervalTwo.getRelativeEndMinutes();

            int overlap = 0;

            if ((intervalTwoEnd >= intervalOneStart) && (intervalTwoStart <= intervalOneEnd))
            {
                overlap += Math.Min(intervalTwoEnd, intervalOneEnd) - Math.Max(intervalTwoStart, intervalOneStart);
                if ((intervalOneStart == intervalTwoEnd) || (intervalOneEnd == intervalTwoStart))
                    overlap += 1;
            }

            // if both intervals are on the same day return overlap
            if (intervalOne.DaysDiffer == intervalTwo.DaysDiffer)
            {
                return overlap;
            }

            // if intevals are on different days check for overlap on previous day:
            if (!(intervalOne.DaysDiffer))
            {
                intervalOneStart = intervalOne.getRelativeStartMinutesPreviousDay();
                intervalOneEnd = intervalOne.getRelativeEndMinutesPreviousDay();
            }
            if (!(intervalTwo.DaysDiffer))
            {
                intervalTwoStart = intervalTwo.getRelativeStartMinutesPreviousDay();
                intervalTwoEnd = intervalTwo.getRelativeEndMinutesPreviousDay();
            }


            if ((intervalTwoEnd >= intervalOneStart) && (intervalTwoStart <= intervalOneEnd))
            {
                overlap += Math.Min(intervalTwoEnd, intervalOneEnd) - Math.Max(intervalTwoStart, intervalOneStart);
                if ((intervalOneStart == intervalTwoEnd) || (intervalOneEnd == intervalTwoStart))
                    overlap += 1;

            }

            return overlap;
        }

    }
}