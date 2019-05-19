using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class FromTenToNinetyTests
    {
        [Fact]
        public void ForTenNumber_ShouldConvertCorrectly()
        {
            var inputNumber = "10";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);

            Assert.Equal("X", outputNumber);
        }
        
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
        public void ForEleven_ShouldConvertCorrectly()
        {
            var inputNumber = "11";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XI", outputNumber);
        }

        [Fact]
        public void ForTwentyThree_ShouldConvertCorrectly()
        {
            var inputNumber = "23";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XXIII", outputNumber);
        }

        [Fact]
        public void ForFortyNine_ShouldConvertCorrectly()
        {
            var inputNumber = "49";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XLIX", outputNumber);
        }

        [Fact]
        public void ForNinetySeven_ShouldConvertCorrectly()
        {
            var inputNumber = "97";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("XCVII", outputNumber);
        }
    }
}