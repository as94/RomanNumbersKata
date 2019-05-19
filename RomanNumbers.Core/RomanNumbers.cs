using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public static class RomanNumbers
    {
        private static readonly Dictionary<int, string> RomanNumbersTable = new Dictionary<int, string>()
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
                return RomanNumbersTable[number];
            }
            
            return string.Empty;
        }
    }
}