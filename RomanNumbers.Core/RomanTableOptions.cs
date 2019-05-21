using System;

namespace RomanNumbers.Core
{
    public static class RomanTableOptions
    {
        public static char[] GetDefault(int digitNumber)
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
                
                case 4:
                    digitNumberParams = new[] {'M', 'V', 'X'};
                    break;
                
                default:
                    throw new NotImplementedException();
            }

            return digitNumberParams;
        }
    }
}