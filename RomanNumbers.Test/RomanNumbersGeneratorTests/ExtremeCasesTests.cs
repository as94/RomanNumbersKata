using System;
using RomanNumbers.Core;
using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class ExtremeCasesTests
    {
        [Fact]
        public void ThrowArgumentNullEx_WhenInputNull()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));
            
            Assert.Throws<ArgumentNullException>(() => converter.FromArabic(null));
        }
        
        [Fact]
        public void ThrowInvalidOperationEx_WhenBadInputNumberFormat()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var input = "abc123";

            Assert.Throws<InvalidOperationException>(() => converter.FromArabic(input));
        }

        [Fact]
        public void ThrowArgumentOutOfRangeEx_WhenNegativeInputNumber()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));
            
            var input = "-1";

            Assert.Throws<ArgumentOutOfRangeException>(() => converter.FromArabic(input));
        }

        [Fact]
        public void ThrowNotImplEx_WhenInputTenThousandAndMore()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var input = "10000";
            
            Assert.Throws<NotImplementedException>(() => converter.FromArabic(input));
        }
    }
}