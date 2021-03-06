﻿using System;

namespace MarsMoonVisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsTime deimosRise = new MarsTime(12, 32);
            MarsTime deimosSet = new MarsTime(17, 06);
            MarsTime phobosRise = new MarsTime(17, 06);
            MarsTime phobosSet = new MarsTime(19, 78);
            MarsTimeInterval deimos = new MarsTimeInterval(deimosRise, deimosSet);
            MarsTimeInterval phobos = new MarsTimeInterval(phobosRise, phobosSet);
            int overlapMinutes = MoonVisibilityCalculator.GetOverlapMinutes(deimos,phobos);

            Console.WriteLine("Deimos and Phobos are both visible for "+overlapMinutes+" minutes.");
        }
    }
}
