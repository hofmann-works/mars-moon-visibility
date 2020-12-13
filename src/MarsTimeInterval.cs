using System;

namespace MarsMoonVisibility
{
    public class MarsTimeInterval
    {
        public MarsTime Rise { get; }
        public MarsTime Set { get; }

        public MarsTimeInterval(MarsTime Rise, MarsTime Set)
        {
            this.Rise = Rise;
            this.Set = Set;
        }

        public int getRelativeRiseMinutes()
        {
            if (Rise.ToMinutes() > Set.ToMinutes())
                return Rise.ToMinutes() - MarsTime.maxHour*(MarsTime.maxMinute+1);

            return Rise.ToMinutes();
        }

        public int getRelativeSetMinutes()
        {
            return Set.ToMinutes();
        }

        public void ToPreviousDay()
        {
            Rise.ToPreviousDay();
            Set.ToPreviousDay();
        }

    }
}
