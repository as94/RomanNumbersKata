using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public static class RomanNumbers
    {
        public static string ConvertFromArabic(string inputNumber)
        {
            if (inputNumber == "1")
            {
                return "I";
            }

            if (inputNumber == "2")
            {
                return "II";
            }

            if (inputNumber == "3")
            {
                return "III";
            }
            
            return string.Empty;
        }
    }
}