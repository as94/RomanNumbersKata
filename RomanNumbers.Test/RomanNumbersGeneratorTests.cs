using Xunit;

namespace RomanNumbers.Test
{
    public class RomanNumbersGeneratorTests
    {
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
    }
}