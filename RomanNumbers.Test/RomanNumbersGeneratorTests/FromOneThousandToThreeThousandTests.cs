using RomanNumbers.Core;
using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class FromOneThousandToThreeThousandTests
    {
        [Fact]
        public void ForOneThousand_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "1000";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("M", outputNumber);
        }
        
        [Fact]
        public void ForNineteenNinetyNine_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "1999";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("MCMXCIX", outputNumber);
        }

        [Fact]
        public void ForTwoThousandEight_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "2008";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("MMVIII", outputNumber);
        }

        [Fact]
        public void ForThirtySevenTwentyOne_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "3721";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("MMMDCCXXI", outputNumber);
        }
    }
}