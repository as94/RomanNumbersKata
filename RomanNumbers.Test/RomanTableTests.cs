using System;
using System.Collections.Generic;
using RomanNumbers.Core;
using Xunit;

namespace RomanNumbers.Test
{
    public class RomanTableTests
    {
        [Fact]
        public void ForFirstDigitNumber_ShouldBeCorrect()
        {
            var romanTable = new RomanTable(RomanTableOptions.GetDefault);
            
            var expected = new Dictionary<int, string>
            {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
                {7, "VII"},
                {8, "VIII"},
                {9, "IX"}
            };

            var actual = romanTable.Build(1);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForSecondDigitNumber_ShouldBeCorrect()
        {
            var romanTable = new RomanTable(RomanTableOptions.GetDefault);
            
            var expected = new Dictionary<int, string>
            {
                {10, "X"},
                {20, "XX"},
                {30, "XXX"},
                {40, "XL"},
                {50, "L"},
                {60, "LX"},
                {70, "LXX"},
                {80, "LXXX"},
                {90, "XC"}
            };

            var actual = romanTable.Build(2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForThirdDigitNumber_ShouldBeCorrect()
        {
            var romanTable = new RomanTable(RomanTableOptions.GetDefault);
            
            var expected = new Dictionary<int, string>
            {
                {100, "C"},
                {200, "CC"},
                {300, "CCC"},
                {400, "CD"},
                {500, "D"},
                {600, "DC"},
                {700, "DCC"},
                {800, "DCCC"},
                {900, "CM"},
            };

            var actual = romanTable.Build(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForFourDigitNumber_ShouldBeCorrect_OnlyForOneTwoThree()
        {
            var romanTable = new RomanTable(RomanTableOptions.GetDefault);
            
            var expected = new Dictionary<int, string>
            {
                {1000, "M"},
                {2000, "MM"},
                {3000, "MMM"},
                {4000, "MV"},
                {5000, "V"},
                {6000, "VM"},
                {7000, "VMM"},
                {8000, "VMMM"},
                {9000, "MX"},
            };

            var actual = romanTable.Build(4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForFiveDigitNumberAndMore_ShouldBeNotImplemented()
        {
            var romanTable = new RomanTable(RomanTableOptions.GetDefault);
            
            Assert.Throws<NotImplementedException>(() => romanTable.Build(5));
            Assert.Throws<NotImplementedException>(() => romanTable.Build(6));
            Assert.Throws<NotImplementedException>(() => romanTable.Build(100500));
        }
        
    }
}