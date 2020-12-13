using System;

namespace MarsMoonVisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsTimeInterval deimos = new MarsTimeInterval(new MarsTime(13,91), new MarsTime(23,05));
            MarsTimeInterval phobos = new MarsTimeInterval(new MarsTime(22,05), new MarsTime(24,45));
            int overlapMinutes = MoonVisibilityCalculator.CalculateOverlaps(deimos,phobos);

            Console.WriteLine("Deimos and Phobos are both visible for "+overlapMinutes+" minutes.");

        }
    }
}
