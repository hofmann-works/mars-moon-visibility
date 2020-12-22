using System;

namespace MarsMoonVisibility
{
    public class MarsTime
    {
        public const int minHour = 0;
        public const int maxHour = 25;
        public const int minMinute = 0;
        public const int maxMinute = 99;
        public int Hour { get; }
        public int Minute { get; }
        public MarsTime(int hour, int minute)
        {
            if (hour <= maxHour && hour >= minHour)
                this.Hour = hour;
            else
                throw new ArgumentException(hour + " is not a valid mars hour.");
            if (minute <= maxMinute && minute >= minMinute)
                this.Minute = minute;
            else
                throw new ArgumentException(minute + " is not a valid mars minute.");
        }

        public int ToMinutes()
        {
            return Hour * 100 + Minute;
        }

    }
}
