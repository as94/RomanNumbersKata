using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class FromOneThousandToThreeThousandTests
    {
        [Fact]
        public void ForOneThousand_ShouldConvertCorrectly()
        {
            var inputNumber = "1000";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("M", outputNumber);
        }
        
        [Fact]
        public void ForNineteenNinetyNine_ShouldConvertCorrectly()
        {
            var inputNumber = "1999";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("MCMXCIX", outputNumber);
        }

        [Fact]
        public void ForTwoThousandEight_ShouldConvertCorrectly()
        {
            var inputNumber = "2008";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("MMVIII", outputNumber);
        }

        [Fact]
        public void ForThirtySevenTwentyOne_ShouldConvertCorrectly()
        {
            var inputNumber = "3721";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("MMMDCCXXI", outputNumber);
        }
    }
}