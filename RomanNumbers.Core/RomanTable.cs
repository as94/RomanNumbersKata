using System;
using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public static class RomanTable
    {
        public static Dictionary<int, string> Get(int digitNumber)
        {
            var digitNumberParams = GetOptions(digitNumber);
            if (digitNumberParams != Array.Empty<char>())
            {
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

            if (digitNumber == 4)
            {
                return new Dictionary<int, string>
                {
                    {1000, "M"},
                    {2000, "MM"},
                    {3000, "MMM"},
                };
            }

            throw new NotImplementedException();
        }

        private static char[] GetOptions(int digitNumber)
        {
            var digitNumberParams = Array.Empty<char>();

            switch (digitNumber)
            {
                case 1:
                    digitNumberParams = new[] {'I', 'V', 'X'};
                    break;
                case 2:
                    digitNumberParams = new[] {'X', 'L', 'C'};
                    break;
                case 3:
                    digitNumberParams = new[] {'C', 'D', 'M'};
                    break;
            }

            return digitNumberParams;
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