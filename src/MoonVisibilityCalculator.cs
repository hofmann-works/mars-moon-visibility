using System;

namespace MarsMoonVisibility
{
    public class MoonVisibilityCalculator
    {
        // TBD: How to handle double Twilight rule?
        // D[ [ 4:00 ], [ 20:00] ];   P[ [ 20:00 ], [ 4:00] ]
        // also: D[ [ 3:00 ], [ 20:00] ];  P[ [ 20:00 ], [ 4:00] ]
        public static int GetOverlapMinutes(MarsTimeInterval intervalOne, MarsTimeInterval intervalTwo)
        {
            int intervalOneStart = intervalOne.getRelativeStartMinutes();
            int intervalOneEnd = intervalOne.getRelativeEndMinutes();
            int intervalTwoStart = intervalTwo.getRelativeStartMinutes();
            int intervalTwoEnd = intervalTwo.getRelativeEndMinutes();

            int overlap = 0;
            //bool twilightRule = false;

            if (DoIntervalsOverlap(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd))
            {
                overlap += CalcOverlap(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd);
            } else if (DoesTwilightRuleApply(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd))
            {
                overlap += 1;
            }

            // if both intervals are on the same day return overlap
            if (intervalOne.DaysDiffer == intervalTwo.DaysDiffer)
            {
                return overlap;
                //twilightRule = true;
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
            } else if (DoesTwilightRuleApply(intervalOneStart, intervalOneEnd, intervalTwoStart, intervalTwoEnd)) 
            {
                // TBD: Handle if twilight rule can be applied twice (&& (twilightRule == false))
                // TBD: Handle if twilight rule should be applied at: D[ [ 3:00 ], [ 20:00] ];  P[ [ 20:00 ], [ 4:00] ]  (&& overlap == 0)
                overlap += 1;
            }

            return overlap;
        }

        private static bool DoIntervalsOverlap(int intervalOneStart, int intervalOneEnd, int intervalTwoStart, int intervalTwoEnd)
        {
            if ((intervalTwoEnd > intervalOneStart) && (intervalTwoStart < intervalOneEnd))
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