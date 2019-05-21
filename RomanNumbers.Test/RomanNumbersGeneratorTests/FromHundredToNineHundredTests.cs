using Xunit;

namespace RomanNumbers.Test.RomanNumbersGeneratorTests
{
    public class FromHundredToNineHundredTests
    {
        [Fact]
        public void ForOneHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "100";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("C", outputNumber);
        }

        [Fact]
        public void ForTwoHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "200";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("CC", outputNumber);
        }

        [Fact]
        public void ForThreeHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "300";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("CCC", outputNumber);
        }

        [Fact]
        public void ForFourHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "400";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("CD", outputNumber);
        }

        [Fact]
        public void ForFiveHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "500";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("D", outputNumber);
        }

        [Fact]
        public void ForSixHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "600";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("DC", outputNumber);
        }

        [Fact]
        public void ForSevenHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "700";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("DCC", outputNumber);
        }

        [Fact]
        public void ForEightHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "800";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("DCCC", outputNumber);
        }

        [Fact]
        public void ForNineHundred_ShouldConvertCorrectly()
        {
            var inputNumber = "900";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("CM", outputNumber);
        }

        [Fact]
        public void ForNineHundredSeventyFive_ShouldConvertCorrectly()
        {
            var inputNumber = "975";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("CMLXXV", outputNumber);
        }

        [Fact]
        public void ForEightHundredFortySix_ShouldConvertCorrectly()
        {
            var inputNumber = "846";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("DCCCXLVI", outputNumber);
        }

        [Fact]
        public void ForThreeHundredTwelve_ShouldConvertCorrectly()
        {
            var inputNumber = "312";
            var outputNumber = Core.RomanNumbers.ConvertFromArabic(inputNumber);
            Assert.Equal("CCCXII", outputNumber);
        }
    }
}