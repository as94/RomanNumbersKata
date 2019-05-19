using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class TensTests
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

        [Fact]
        public void ForSevenNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "7";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("VII", outputNumber);
        }

        [Fact]
        public void ForEightNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "8";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("VIII", outputNumber);
        }

        [Fact]
        public void ForNineNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "9";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("IX", outputNumber);
        }

        [Fact]
        public void ForTenNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "10";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("X", outputNumber);
        }
    }
}