using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public static class RomanNumbers
    {
        private static readonly Dictionary<int, string> FromOneToTenTable = new Dictionary<int, string>()
        {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 4, "IV" },
            { 5, "V" },
            { 6, "VI" },
            { 7, "VII" },
            { 8, "VIII" },
            { 9, "IX" },
            { 10, "X" }
        };

        private static readonly Dictionary<int, string> FromTwentyToHundredTable = new Dictionary<int, string>()
        {
            { 20, "XX" },
            { 30, "XXX" },
            { 40, "XL" },
            { 50, "L" },
            { 60, "LX" },
            { 70, "LXX" },
            { 80, "LXXX" },
            { 90, "XC" },
            { 100, "C" }
        };
        
        public static string ConvertFromArabic(string inputNumber)
        {
            if (string.IsNullOrWhiteSpace(inputNumber))
            {
                throw new ArgumentNullException();
            }
            
            if (!int.TryParse(inputNumber, out var number))
            {
                throw new InvalidOperationException($"Input number format in incorrect: {inputNumber}");
            }

            if (number <= 10)
            {
                return FromOneToTenTable[number];
            }

            if (number > 10 && number % 10 == 0)
            {
                return FromTwentyToHundredTable[number];
            }
            
            return string.Empty;
        }
    }
}