using System;

namespace MarsMoonVisibility
{
    public class MoonVisibilityCalculator
    {
        public static int GetOverlapMinutes(MarsTimeInterval intervalOne, MarsTimeInterval intervalTwo)
        {
            int intervalOneStart = intervalOne.getRelativeStartMinutes();
            int intervalOneEnd = intervalOne.getRelativeEndMinutes();
            int intervalTwoStart = intervalTwo.getRelativeStartMinutes();
            int intervalTwoEnd = intervalTwo.getRelativeEndMinutes();

            int overlap = 0;

            if (DoIntervalsOverlap(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd))
            {
                overlap += CalcOverlap(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd);
            }

            if (DoesTwilightRuleApply(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd))
            {
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


            if (DoIntervalsOverlap(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd))
            {
                overlap += CalcOverlap(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd);
            }
            if (DoesTwilightRuleApply(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd))
            {
                overlap += 1;
            }

            return overlap;
        }

        private static bool DoIntervalsOverlap(int intervalOneStart, int intervalOneEnd, int intervalTwoStart, int intervalTwoEnd)
        {
            if ((intervalTwoEnd >= intervalOneStart) && (intervalTwoStart <= intervalOneEnd))
                return true;

            return false;
        }

        private static int CalcOverlap(int intervalOneStart, int intervalOneEnd, int intervalTwoStart, int intervalTwoEnd)
        {
            return Math.Min(intervalTwoEnd, intervalOneEnd) - Math.Max(intervalTwoStart, intervalOneStart);
        }

        private static bool DoesTwilightRuleApply(int intervalOneStart, int intervalOneEnd, int intervalTwoStart, int intervalTwoEnd)
        {
            if ((intervalOneStart == intervalTwoEnd) || (intervalOneEnd == intervalTwoStart))
                return true;

            return false;
        }

    }
}