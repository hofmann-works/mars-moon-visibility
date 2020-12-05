using System;

namespace MarsMoonVisibility
{
    public class MarsTime
    {
        public int Hour { get; }
        public int Minute { get; }
        public MarsTime(int hour, int minute)
        {
            if (hour <= 25 && hour >= 0)
                this.Hour = hour;
            else
                throw new ArgumentException(hour + " is not a valid mars hour.");
            if (minute <= 99 && minute >= 0)
                this.Minute = minute;
            else
                throw new ArgumentException(minute + " is not a valid mars minute.");
        }

    }
}
