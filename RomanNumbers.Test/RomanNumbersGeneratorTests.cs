using System;
using Xunit;

namespace RomanNumbers.Test
{
    public class RomanNumbersGeneratorTests
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
        
        [Fact]
        public void ForOneNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "1";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("I", outputNumber);
        }

        [Fact]
        public void ForTwoNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "2";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("II", outputNumber);
        }

        [Fact]
        public void ForThreeNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "3";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("III", outputNumber);
        }

        [Fact]
        public void ForFourNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "4";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("IV", outputNumber);
        }

        [Fact]
        public void ForFiveNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "5";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("V", outputNumber);
        }

        [Fact]
        public void ForSixNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "6";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("VI", outputNumber);
        }
    }
}