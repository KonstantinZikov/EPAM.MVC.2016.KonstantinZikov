using System;

namespace Models.Infrastructure
{
    public class CustomDateValidator
    {
        public static bool Validate(string date, out DateTime result)
        {
            result = new DateTime();
            var parts = date.Split(':');
            if (parts.Length != 3)
            {
                return false;
            }
            // Validate Year
            int year;
            if (!int.TryParse(parts[2],out year))
            {                
                return false;
            }
            // Validate Month
            int month;
            if (!int.TryParse(parts[1], out month))
            {
                return false;
            }
            // Validate day
            int day;
            if (!int.TryParse(parts[0], out day))
            {
                return false;
            }

            try
            {
                result = new DateTime(year, month, day);
            }
            catch(ArgumentOutOfRangeException)
            {
                return false;
            }
            return true;
        }
    }
}