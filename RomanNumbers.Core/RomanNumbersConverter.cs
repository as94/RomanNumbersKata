using System;
using System.Collections.Generic;
using System.Text;

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

            if (!int.TryParse(inputNumber, out var arabicNumber))
            {
                throw new InvalidOperationException($"Input number format in incorrect: {inputNumber}");
            }

            return GetRomanNumber(arabicNumber);
        }

        private string GetRomanNumber(int arabicNumber)
        {
            if (arabicNumber < 0)
            {
                throw new ArgumentOutOfRangeException($"Input number shouldn't be negative: {arabicNumber}");
            }

            if (arabicNumber == 0)
            {
                return string.Empty;
            }
            
            var sb = new StringBuilder();
            var digitRank = 1;
            var currentNumber = arabicNumber;
            do
            {
                if (digitRank >= 5)
                {
                    throw new NotImplementedException();
                }
                
                var remainder = currentNumber % 10;

                var pow = (int)Math.Pow(10, digitRank - 1);
                var currentRomanNumber = remainder != 0
                    ? _numbersByDigitsTable[digitRank][remainder * pow]
                    : string.Empty;
                
                sb.Insert(0, currentRomanNumber);

                digitRank++;
                currentNumber /= 10;
            }
            while (currentNumber > 0);

            return sb.ToString();
        }
    }
}