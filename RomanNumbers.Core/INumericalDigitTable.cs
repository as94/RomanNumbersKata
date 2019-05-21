using System.Collections.Generic;

namespace RomanNumbers.Core
{
    public interface INumericalDigitTable
    {
        IDictionary<int, string> Build(int digitNumber);
    }
}