using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public sealed class RomanNumbersConverter
    {
        private readonly IDictionary<int, string> _fromOneToTenTable;
        private readonly IDictionary<int, string> _fromTwentyToNinetyTable;
        private readonly IDictionary<int, string> _fromOneHundredToNineHundredTable;
        private readonly IDictionary<int, string> _fromOneThousandToThreeThousandTable;

        public RomanNumbersConverter(INumericalDigitTable numericalDigitTable)
        {
            if (numericalDigitTable == null)
            {
                throw new ArgumentNullException(nameof(numericalDigitTable));
            }

            _fromOneToTenTable = numericalDigitTable.Build(1);
            _fromTwentyToNinetyTable = numericalDigitTable.Build(2);
            _fromOneHundredToNineHundredTable = numericalDigitTable.Build(3);
            _fromOneThousandToThreeThousandTable = numericalDigitTable.Build(4);
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

            if (number < 10)
            {
                return _fromOneToTenTable[number];
            }

            if (number >= 10 && number < 100)
            {
                var secondDigitNumber = number / 10;
                var firstDigitNumber = number % 10;

                return _fromTwentyToNinetyTable[secondDigitNumber * 10] +
                       (firstDigitNumber == 0 ? string.Empty : _fromOneToTenTable[firstDigitNumber]);
            }

            if (number >= 100 && number < 1000)
            {
                var thirdDigitNumber = number / 100;
                var remainder = number - thirdDigitNumber * 100;

                var secondDigitNumber = remainder / 10;
                var firstDigitNumber = remainder % 10;

                return _fromOneHundredToNineHundredTable[thirdDigitNumber * 100] +
                       (secondDigitNumber == 0 ? string.Empty : _fromTwentyToNinetyTable[secondDigitNumber * 10]) +
                       (firstDigitNumber == 0 ? string.Empty : _fromOneToTenTable[firstDigitNumber]);
            }

            if (number >= 1000 && number <= 9000)
            {
                var fourDigitNumber = number / 1000;
                var remainder = number - fourDigitNumber * 1000;

                var thirdDigitNumber = remainder / 100;
                remainder = remainder - thirdDigitNumber * 100;

                var secondDigitNumber = remainder / 10;
                var firstDigitNumber = remainder % 10;

                return _fromOneThousandToThreeThousandTable[fourDigitNumber * 1000] +
                       (thirdDigitNumber == 0
                           ? string.Empty
                           : _fromOneHundredToNineHundredTable[thirdDigitNumber * 100]) +
                       (secondDigitNumber == 0 ? string.Empty : _fromTwentyToNinetyTable[secondDigitNumber * 10]) +
                       (firstDigitNumber == 0 ? string.Empty : _fromOneToTenTable[firstDigitNumber]);
            }

            throw new NotImplementedException();
        }
    }
}