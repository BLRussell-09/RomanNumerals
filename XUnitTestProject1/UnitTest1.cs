using RomanNumerics.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,"I")]
        public void A_1_should_return_a_I(int num, string romanNumeral)
        {
            // Arrange
            var converter = new Converter();
            
            //Act
             string result =  converter.conRom(num);
            //Assert
            Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(5,"V")]
        public void A_5_should_return_a_V(int num, string romanNumeral)
        {
            // Arrange
            var converter = new Converter();
            
            //Act
             string result =  converter.conRom(num);
            //Assert
            Assert.Equal(romanNumeral, result);
        }
    }
}
