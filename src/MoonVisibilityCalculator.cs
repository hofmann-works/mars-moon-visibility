

using System;

namespace MarsMoonVisibility
{
    public class MoonVisibilityCalculator
    {
        public static int CalculateOverlaps(MarsTime deimosRise, MarsTime deimosSet, MarsTime phobosRise, MarsTime phobosSet)
        {
            int deimosRiseMinutes = deimosRise.ToMinutes();
            int deimosSetMinutes = deimosSet.ToMinutes();
            int phobosRiseMinutes = phobosRise.ToMinutes();
            int phobosSetMinutes = phobosSet.ToMinutes();

            int overlap = 0;

            if (deimosRiseMinutes > deimosSetMinutes)
            {
                deimosRiseMinutes -= MarsTime.maxHour*100;
            }

            if (phobosRiseMinutes > phobosSetMinutes)
            {
                phobosRiseMinutes -= MarsTime.maxHour * 100;
            }

            if ((phobosSetMinutes >= deimosRiseMinutes) && (phobosRiseMinutes < deimosSetMinutes))
            {
                overlap = Math.Min(phobosSetMinutes, deimosSetMinutes) - Math.Max(phobosRiseMinutes, deimosRiseMinutes);
                if (overlap == 0)
                    overlap = 1;

                return overlap;
            }

            if ((deimosSetMinutes >= phobosRiseMinutes) && (deimosRiseMinutes < phobosSetMinutes))
            {
                overlap = Math.Min(deimosSetMinutes, phobosSetMinutes) - Math.Max(deimosRiseMinutes, phobosRiseMinutes);
                if (overlap == 0)
                    overlap = 1;

                return overlap;
            }

            // check for overlap on previous day:
            phobosRiseMinutes -= MarsTime.maxHour*100;
            phobosSetMinutes -= MarsTime.maxHour*100;


            if ((phobosSetMinutes >= deimosRiseMinutes) && (phobosRiseMinutes < deimosSetMinutes))
            {
                overlap = Math.Min(phobosSetMinutes, deimosSetMinutes) - Math.Max(phobosRiseMinutes, deimosRiseMinutes);
                if (overlap == 0)
                    overlap = 1;

                return overlap;
            }

            if ((deimosSetMinutes >= phobosRiseMinutes) && (deimosRiseMinutes < phobosSetMinutes))
            {
                overlap = Math.Min(deimosSetMinutes, phobosSetMinutes) - Math.Max(deimosRiseMinutes, phobosRiseMinutes);
                if (overlap == 0)
                    overlap = 1;

                return overlap;
            }

            return 0;
        }
    }
}