using System;

namespace IdSrv3.Extensions
{
    public static class IntegerExtensions
    {
        public static int GetIterationsFromYear(this int year)
        {
            int StartYear = 2000;
            int StartCount = 1000;

            if(year > StartYear)
            {
                var diff = (year - StartYear) / 2;
                var mul = (int)Math.Pow(2, diff);
                int count = StartCount * mul;
                // if we go negative, then we wrapped (expected in year ~2044).
                // Int32.Max is best we can do at this point
                if(count < 0) count = Int32.MaxValue;
                return count;
            }
            return StartCount;
        }
    }
}