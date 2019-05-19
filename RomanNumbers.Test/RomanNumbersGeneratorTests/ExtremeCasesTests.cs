using System;
using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class ExtremeCasesTests
    {
        [Fact]
        public void ThrowArgumentNullEx_WhenInputNull()
        {
            Assert.Throws<ArgumentNullException>(() => Core.RomanNumbers.ConvertFromArabic(null));
        }
        
        [Fact]
        public void ThrowInvalidOperationEx_WhenBadInputNumberFormat()
        {
            var input = "abc123";

            Assert.Throws<InvalidOperationException>(() => Core.RomanNumbers.ConvertFromArabic(input));
        }
    }
}