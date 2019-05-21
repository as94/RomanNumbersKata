using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public sealed class RomanTable : INumericalDigitTable
    {
        private readonly Func<int, char[]> _getOptions;

        public RomanTable(Func<int, char[]> getOptions)
        {
            _getOptions = getOptions ?? throw new ArgumentNullException(nameof(getOptions));
        }
    
        public IDictionary<int, string> Build(int digitNumber)
        {
            var digitNumberParams = _getOptions(digitNumber);
            
            var result = new Dictionary<int, string>();

            var values = GetValue(
                digitNumberParams[0],
                digitNumberParams[1],
                digitNumberParams[2]);

            var idx = 1;
            var pow = (int)Math.Pow(10, digitNumber - 1);
            foreach (var value in values)
            {
                var key = idx * pow;
                result.Add(key, value);
                idx++;
            }

            return result;
        }

        private static IEnumerable<string> GetValue(char oneSymbol, char fiveSymbol, char tenSymbol)
        {
            for (var i = 1; i < 10; i++)
            {
                if (i >= 1 && i <= 3)
                {
                    var repeatCount = i;
                    
                    yield return new string(oneSymbol, repeatCount);
                }
                else if (i == 4)
                {
                    yield return new string(new[] { oneSymbol, fiveSymbol });
                }
                else if (i == 5)
                {
                    yield return fiveSymbol.ToString();
                }
                else if (i >= 6 && i <= 8)
                {
                    var repeatCount = i - 5;
                    
                    yield return fiveSymbol + new string(oneSymbol, repeatCount);
                }
                else
                {
                    yield return new string(new[] { oneSymbol, tenSymbol });
                }
            }
        }
    }
}