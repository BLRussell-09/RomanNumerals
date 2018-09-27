using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerics.Models
{
    public class Converter
    {
        
        public void convertToRoman(int number)
        {
            var twoDigit = number.ToString().Length == 2 && number < 40 && number % 1 == 0;

            if (number > 0 && number < 5)
            {

                string counter = new String('I', number);
                Console.WriteLine(counter);
            }
            else if (twoDigit)
            {
                var newNumber = number.ToString();
                var tensPlace = newNumber[0];
                switch (tensPlace)
                {
                    case '1':
                      Console.WriteLine("X");
                      break;
                    case '2':
                      Console.WriteLine("XX");
                      break;
                    case '3':
                      Console.WriteLine("XXX");
                      break;
                }
            }

        }
    }
}
