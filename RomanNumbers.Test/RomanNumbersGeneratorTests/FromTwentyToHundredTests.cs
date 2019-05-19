using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class FromTwentyToHundredTests
    {
        [Fact]
        public void ForTwenty_ShouldConvertCorrectly()
        {
            var inputNumber = "20";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XX", outputNumber);
        }

        [Fact]
        public void ForThirty_ShouldConvertCorrectly()
        {
            var inputNumber = "30";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XXX", outputNumber);
        }

        [Fact]
        public void ForForty_ShouldConvertCorrectly()
        {
            var inputNumber = "40";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XL", outputNumber);
        }

        [Fact]
        public void ForFifty_ShouldConvertCorrectly()
        {
            var inputNumber = "50";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("L", outputNumber);
        }

        [Fact]
        public void ForSixty_ShouldConvertCorrectly()
        {
            var inputNumber = "60";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("LX", outputNumber);
        }

        [Fact]
        public void ForSeventy_ShouldConvertCorrectly()
        {
            var inputNumber = "70";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("LXX", outputNumber);
        }

        [Fact]
        public void ForEighty_ShouldConvertCorrectly()
        {
            var inputNumber = "80";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("LXXX", outputNumber);
        }

        [Fact]
        public void ForNinety_ShouldConvertCorrectly()
        {
            var inputNumber = "90";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XC", outputNumber);
        }

        [Fact]
        public void ForOneHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "100";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("C", outputNumber);
        }
    }
}