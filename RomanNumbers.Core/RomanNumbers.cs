using System;
using System.Linq;

namespace RomanNumbers.Core
{
    public static class RomanNumbers
    {
        private static int[] StartRange = Enumerable.Range(1, 3).ToArray();
        
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
            
            foreach (var supposedNumber in StartRange)
            {
                if (number == supposedNumber)
                {
                    return new string('I', supposedNumber);
                }
            }

            if (inputNumber == "4")
            {
                return "IV";
            }
            
            return string.Empty;
        }
    }
}