using RomanNumbers.Core;
using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class FromOneToNineTests
    {
        [Fact]
        public void ForOneNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "1";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("I", outputNumber);
        }

        [Fact]
        public void ForTwoNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "2";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("II", outputNumber);
        }

        [Fact]
        public void ForThreeNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "3";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("III", outputNumber);
        }

        [Fact]
        public void ForFourNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "4";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("IV", outputNumber);
        }

        [Fact]
        public void ForFiveNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "5";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("V", outputNumber);
        }

        [Fact]
        public void ForSixNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "6";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("VI", outputNumber);
        }

        [Fact]
        public void ForSevenNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "7";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("VII", outputNumber);
        }

        [Fact]
        public void ForEightNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "8";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("VIII", outputNumber);
        }

        [Fact]
        public void ForNineNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "9";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("IX", outputNumber);
        }
    }
}