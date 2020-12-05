using System;

namespace MarsMoonVisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsTime deimosRise = new MarsTime(13,91);
            MarsTime deimosSet = new MarsTime(23,05);
            MarsTime phobosRise = new MarsTime(22,05);
            MarsTime phobosSet = new MarsTime(24,45);
            int overlapMinutes = MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet);

            Console.WriteLine("Deimos and Phobos are both visible for "+overlapMinutes+" minutes.");

        }
    }
}
