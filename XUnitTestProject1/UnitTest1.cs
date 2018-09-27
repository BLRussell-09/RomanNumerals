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

        [Theory]
        [InlineData(9, "IX")]
        public void A_9_should_return_an_IX(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(12, "XII")]
        public void A_12_should_return_an_XII(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(16, "XVI")]
        public void A_16_should_return_an_XVI(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(29, "XXIX")]
        public void A_29_should_return_an_XXIX(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(44, "XLIV")]
        public void A_44_should_return_an_XLIV(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(45, "XLV")]
        public void A_45_should_return_an_XLV(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }

        [Theory]
        [InlineData(68, "LXVIII")]
        public void A_68_should_return_an_LXVIII(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(83, "LXXXIII")]
        public void An_83_should_return_an_lxXXIII(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(97, "XCVII")]
        public void A_97_should_return_an_XCVII(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(99, "XCIX")]
        public void A_99_should_return_an_XCIX(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(500, "D")]
        public void A_500_should_return_an_D(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(501, "DI")]
        public void A_501_should_return_an_DI(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(649, "DCXLIX")]
        public void A_649_should_return_an_DCXLIX(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(798, "DCCXCVIII")]
        public void A_798_should_return_an_DCCXCVIII(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(891, "DCCCXCI")]
        public void A_1_should_return_an_DCCCXCI(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(1000, "M")]
        public void A_1000_should_return_an_M(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(1004, "MIV")]
        public void A_1004should_return_an_MIV(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(1006, "MVI")]
        public void A_1006_should_return_an_MVI(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(1023, "MXXIII")]
        public void A_1023_should_return_an_MXXIII(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(2014, "MMXIV")]
        public void A_2014_should_return_an_MMXIV(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
        [Theory]
        [InlineData(3999, "MMMCMXCIX")]
        public void A_3999_should_return_an_MMmCMXCIX(int num, string romanNumeral)
        {
          // Arrange
          var converter = new Converter();

          //Act
          string result = converter.conRom(num);
          //Assert
          Assert.Equal(romanNumeral, result);
        }
  }
}
