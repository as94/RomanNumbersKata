using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public static class RomanNumbers
    {
        private static readonly Dictionary<int, string> FromOneToTenTable = RomanTable.Get(1);
        private static readonly Dictionary<int, string> FromTwentyToNinetyTable = RomanTable.Get(2);
        private static readonly Dictionary<int, string> FromOneHundredToNineHundredTable = RomanTable.Get(3);
        private static readonly Dictionary<int, string> FromOneThousandToThreeThousandTable = RomanTable.Get(4);

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

            if (number >= 100 && number < 1000)
            {
                var thirdDigitNumber = number / 100;
                var remainder = number - thirdDigitNumber * 100;

                var secondDigitNumber = remainder / 10;
                var firstDigitNumber = remainder % 10;

                return FromOneHundredToNineHundredTable[thirdDigitNumber * 100] +
                       (secondDigitNumber == 0 ? string.Empty : FromTwentyToNinetyTable[secondDigitNumber * 10]) +
                       (firstDigitNumber == 0 ? string.Empty : FromOneToTenTable[firstDigitNumber]);
            }

            if (number >= 1000 && number < 4000)
            {
                var fourDigitNumber = number / 1000;
                var remainder = number - fourDigitNumber * 1000;

                var thirdDigitNumber = remainder / 100;
                remainder = remainder - thirdDigitNumber * 100;

                var secondDigitNumber = remainder / 10;
                var firstDigitNumber = remainder % 10;

                return FromOneThousandToThreeThousandTable[fourDigitNumber * 1000] +
                       (thirdDigitNumber == 0
                           ? string.Empty
                           : FromOneHundredToNineHundredTable[thirdDigitNumber * 100]) +
                       (secondDigitNumber == 0 ? string.Empty : FromTwentyToNinetyTable[secondDigitNumber * 10]) +
                       (firstDigitNumber == 0 ? string.Empty : FromOneToTenTable[firstDigitNumber]);
            }

            throw new NotImplementedException();
        }
    }
}