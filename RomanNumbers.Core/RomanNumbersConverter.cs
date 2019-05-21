using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public sealed class RomanNumbersConverter
    {
        private readonly IDictionary<int, IDictionary<int, string>> _numbersByDigitsTable =
            new Dictionary<int, IDictionary<int, string>>();

        public RomanNumbersConverter(INumericalDigitTable numericalDigitTable)
        {
            if (numericalDigitTable == null)
            {
                throw new ArgumentNullException(nameof(numericalDigitTable));
            }

            for (var digit = 1; digit <= 4; digit++)
            {
                var key = digit;
                var value = numericalDigitTable.Build(digit);
                
                _numbersByDigitsTable.Add(key, value);
            }
        }

        public string FromArabic(string inputNumber)
        {
            if (string.IsNullOrWhiteSpace(inputNumber))
            {
                throw new ArgumentNullException();
            }

            if (!int.TryParse(inputNumber, out var number))
            {
                throw new InvalidOperationException($"Input number format in incorrect: {inputNumber}");
            }

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException($"Input number shouldn't be negative: {inputNumber}");
            }

            if (number == 0)
            {
                return string.Empty;
            }

            var fromOneToTenTable = _numbersByDigitsTable[1];
            if (number < 10)
            {
                return fromOneToTenTable[number];
            }

            var fromTwentyToNinetyTable = _numbersByDigitsTable[2];
            if (number >= 10 && number < 100)
            {
                var secondDigitNumber = number / 10;
                var firstDigitNumber = number % 10;

                return fromTwentyToNinetyTable[secondDigitNumber * 10] +
                       (firstDigitNumber == 0 ? string.Empty : fromOneToTenTable[firstDigitNumber]);
            }

            var fromOneHundredToNineHundredTable = _numbersByDigitsTable[3];
            if (number >= 100 && number < 1000)
            {
                var thirdDigitNumber = number / 100;
                var remainder = number - thirdDigitNumber * 100;

                var secondDigitNumber = remainder / 10;
                var firstDigitNumber = remainder % 10;

                return fromOneHundredToNineHundredTable[thirdDigitNumber * 100] +
                       (secondDigitNumber == 0 ? string.Empty : fromTwentyToNinetyTable[secondDigitNumber * 10]) +
                       (firstDigitNumber == 0 ? string.Empty : fromOneToTenTable[firstDigitNumber]);
            }

            if (number >= 1000 && number <= 9000)
            {
                var fourDigitNumber = number / 1000;
                var remainder = number - fourDigitNumber * 1000;

                var thirdDigitNumber = remainder / 100;
                remainder = remainder - thirdDigitNumber * 100;

                var secondDigitNumber = remainder / 10;
                var firstDigitNumber = remainder % 10;

                return _numbersByDigitsTable[4][fourDigitNumber * 1000] +
                       (thirdDigitNumber == 0
                           ? string.Empty
                           : fromOneHundredToNineHundredTable[thirdDigitNumber * 100]) +
                       (secondDigitNumber == 0 ? string.Empty : fromTwentyToNinetyTable[secondDigitNumber * 10]) +
                       (firstDigitNumber == 0 ? string.Empty : fromOneToTenTable[firstDigitNumber]);
            }

            throw new NotImplementedException();
        }
    }
}