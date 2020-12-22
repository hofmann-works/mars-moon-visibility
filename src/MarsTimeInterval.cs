using System;

namespace MarsMoonVisibility
{
    public class MarsTimeInterval
    {
        public MarsTime Start { get; }
        public MarsTime End { get; }
        public bool DaysDiffer { get; }

        public MarsTimeInterval(MarsTime Start, MarsTime End)
        {
            this.Start = Start;
            this.End = End;
            if (Start.ToMinutes() > End.ToMinutes())
                this.DaysDiffer = true;
        }

        public int getRelativeStartMinutes()
        {
            if (DaysDiffer)
                return Start.ToMinutes() - MarsTime.maxHour * (MarsTime.maxMinute + 1);

            return Start.ToMinutes();
        }

        public int getRelativeEndMinutes()
        {
            return End.ToMinutes();
        }
        public int getRelativeStartMinutesPreviousDay()
        {
            return (Start.Hour - MarsTime.maxHour) * (MarsTime.maxMinute + 1) + Start.Minute;
        }

        public int getRelativeEndMinutesPreviousDay()
        {
            return (End.Hour - MarsTime.maxHour) * (MarsTime.maxMinute + 1) + End.Minute;

        }

    }
}
