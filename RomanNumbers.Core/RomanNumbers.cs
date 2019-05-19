using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public static class RomanNumbers
    {
        private static readonly Dictionary<int, string> FromOneToTenTable = new Dictionary<int, string>
        {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" },
            { 4, "IV" },
            { 5, "V" },
            { 6, "VI" },
            { 7, "VII" },
            { 8, "VIII" },
            { 9, "IX" }
        };

        private static readonly Dictionary<int, string> FromTwentyToNinetyTable = new Dictionary<int, string>
        {
            { 10, "X" },
            { 20, "XX" },
            { 30, "XXX" },
            { 40, "XL" },
            { 50, "L" },
            { 60, "LX" },
            { 70, "LXX" },
            { 80, "LXXX" },
            { 90, "XC" }
        };

        private static readonly Dictionary<int, string> FromHundredToThousandTable = new Dictionary<int, string>
        {
            { 100, "C" },
            { 200, "CC" },
            { 300, "CCC" },
            { 400, "CD" },
            { 500, "D" },
            { 600, "DC" },
            { 700, "DCC" },
            { 800, "DCCC" },
            { 900, "CM" },
            { 1000, "M" },
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

            if (number < 10)
            {
                return FromOneToTenTable[number];
            }

            if (number >= 10 && number < 100)
            {
                var secondDigitNumber = number / 10;
                var firstDigitNumber = number % 10;
                
                return FromTwentyToNinetyTable[secondDigitNumber * 10] +
                       (firstDigitNumber == 0 ? string.Empty : FromOneToTenTable[firstDigitNumber]);
            }

            if (number >= 100 && number <= 1000)
            {
                var thirdDigitNumber = number / 100;
                var remainder = number - thirdDigitNumber * 100;
                var secondDigitNumber = remainder / 10;
                var firstDigitNumber = remainder % 10;
                
                return FromHundredToThousandTable[thirdDigitNumber * 100] + 
                       (secondDigitNumber == 0 ? string.Empty : FromTwentyToNinetyTable[secondDigitNumber * 10]) +
                       (firstDigitNumber == 0 ? string.Empty : FromOneToTenTable[firstDigitNumber]);
            }
            
            return string.Empty;
        }
    }
}