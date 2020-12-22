using System;

namespace MarsMoonVisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Todo: naming calculator -> no moon
            // MarsTimeInterval to struct -> copy instead of reference
            MarsTime deimosRise = new MarsTime(12, 32);
            MarsTime deimosSet = new MarsTime(17, 06);
            MarsTime phobosRise = new MarsTime(17, 06);
            MarsTime phobosSet = new MarsTime(19, 78);
            MarsTimeInterval deimos = new MarsTimeInterval(deimosRise, deimosSet);
            MarsTimeInterval phobos = new MarsTimeInterval(phobosRise, phobosSet);
            int overlapMinutes = MoonVisibilityCalculator.CalculateOverlaps(deimos,phobos);

            Console.WriteLine("Deimos and Phobos are both visible for "+overlapMinutes+" minutes.");
        }
    }
}
