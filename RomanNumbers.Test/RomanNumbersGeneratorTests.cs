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
    }
}