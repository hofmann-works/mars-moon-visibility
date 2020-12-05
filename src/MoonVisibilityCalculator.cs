

using System;

namespace MarsMoonVisibility
{
    public class MoonVisibilityCalculator
    {
        //deimosRiseMinute
        //public MoonVisibilityCalculator(MarsTime deimosRise, MarsTime deimosSet, MarsTime phobosRise, MarsTime phobosSet){
        //}
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
                Console.WriteLine("New deimosRiseMinutes: "+deimosRiseMinutes);
            }

            if (phobosRiseMinutes > phobosSetMinutes)
            {
                phobosRiseMinutes -= MarsTime.maxHour*100;
                Console.WriteLine("New phobosRiseMinutes: "+phobosRiseMinutes);
            }


            if ((deimosRiseMinutes > phobosRiseMinutes) && (deimosRiseMinutes < phobosSetMinutes))
            {
                Console.WriteLine("deimosRise in Phobos visible time");
                return Math.Min(deimosSetMinutes, phobosSetMinutes) - deimosRiseMinutes;
            }

            if ((deimosSetMinutes >= phobosRiseMinutes))
            {
                overlap = Math.Min(deimosSetMinutes,phobosSetMinutes) - Math.Max(deimosRiseMinutes, phobosRiseMinutes);
                if (overlap == 0)
                    overlap = 1;

                return overlap;
            }
            return 0;
        }
    }
}