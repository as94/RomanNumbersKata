using RomanNumbers.Core;
using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class FromTenToNinetyTests
    {
        [Fact]
        public void ForTenNumber_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "10";
            var outputNumber = converter.FromArabic(inputNumber);

            Assert.Equal("X", outputNumber);
        }
        
        [Fact]
        public void ForTwenty_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "20";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XX", outputNumber);
        }

        [Fact]
        public void ForThirty_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "30";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XXX", outputNumber);
        }

        [Fact]
        public void ForForty_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "40";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XL", outputNumber);
        }

        [Fact]
        public void ForFifty_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "50";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("L", outputNumber);
        }

        [Fact]
        public void ForSixty_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "60";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("LX", outputNumber);
        }

        [Fact]
        public void ForSeventy_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "70";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("LXX", outputNumber);
        }

        [Fact]
        public void ForEighty_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "80";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("LXXX", outputNumber);
        }

        [Fact]
        public void ForNinety_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "90";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XC", outputNumber);
        }

        [Fact]
        public void ForEleven_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "11";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XI", outputNumber);
        }

        [Fact]
        public void ForTwentyThree_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "23";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XXIII", outputNumber);
        }

        [Fact]
        public void ForFortyNine_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "49";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XLIX", outputNumber);
        }

        [Fact]
        public void ForNinetySeven_ShouldConvertCorrectly()
        {
            var converter = new RomanNumbersConverter(new RomanTable(RomanTableOptions.GetDefault));

            var inputNumber = "97";
            var outputNumber = converter.FromArabic(inputNumber);
            Assert.Equal("XCVII", outputNumber);
        }
    }
}