using System;

namespace MarsMoonVisibility
{
    public class MoonVisibilityCalculator
    {
        public static int CalculateOverlaps(MarsTimeInterval moonA, MarsTimeInterval moonB)
        {
            int moonARise = moonA.getRelativeRiseMinutes();
            int moonASet = moonA.getRelativeSetMinutes();
            int moonBRise = moonB.getRelativeRiseMinutes();
            int moonBSet = moonB.getRelativeSetMinutes();

            int overlap = 0;

            if ((moonBSet >= moonARise) && (moonBRise <= moonASet))
            {
                overlap = Math.Min(moonBSet, moonASet) - Math.Max(moonBRise, moonARise);
                if (overlap == 0)
                    overlap = 1;

                return overlap;
            }

            // check for overlap on previous day:
            moonB.ToPreviousDay();
            moonBRise = moonB.getRelativeRiseMinutes();
            moonBSet = moonB.getRelativeSetMinutes();


            if ((moonBSet >= moonARise) && (moonBRise <= moonASet))
            {
                overlap = Math.Min(moonBSet, moonASet) - Math.Max(moonBRise, moonARise);
                if (overlap == 0)
                    overlap = 1;

                return overlap;
            }

            return 0;
        }
    }
}