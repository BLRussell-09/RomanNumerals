using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerics.Models
{
    public class Converter
    {
        public void conRom(int numbers)
        {
            var numberList = new List<int>{0,0,0,0};
            var romanNumeral = new List<string>{"","","",""};
            var numString = numbers.ToString();

            switch (numString.Length)
            {
                case 1:
                  numberList[3] = int.Parse(numString);
                  break;
                case 2:
                  numberList[2] = int.Parse(numString[0].ToString());
                  numberList[3] = int.Parse(numString[1].ToString());
                  break;
                case 3:
                  numberList[1] = int.Parse(numString[0].ToString());
                  numberList[2] = int.Parse(numString[1].ToString());
                  numberList[3] = int.Parse(numString[2].ToString());
                  break;
                case 4:
                  numberList[0] = int.Parse(numString[0].ToString()); 
                  numberList[1] = int.Parse(numString[1].ToString());
                  numberList[2] = int.Parse(numString[2].ToString());
                  numberList[3] = int.Parse(numString[3].ToString());
                  break;
            }

            var ones = numberList[3];
            var tens = numberList[2];
            var huns = numberList[1];
            var thou = numberList[0];

            //Thousands
            if (thou < 4 && thou > 0)
            {
                string cCount = new String('M', thou);
                romanNumeral[0] = cCount;
            }
           
            //Hundreds
            if (huns < 4 && huns > 0)
            {
                string cCount = new String('C', huns);
                romanNumeral[1] = cCount;
            }
            else if (huns == 4)
            {
                romanNumeral[1] = "CD";
            }
            else if(huns == 5)
            {
                romanNumeral[1] = "D";
            }
            else if (huns < 9 && huns > 5)
            {
                string cCount = "D" + new String('C', huns - 5);
                romanNumeral[1] = cCount;
            }
            else if (huns == 9)
            {
                romanNumeral[1] = "CM";
            }

            // Value in the tens position
            if (tens < 4 && tens > 0)
            {
                string xCount = new String('X', tens);
                romanNumeral[2] = xCount;
            }
            else if (tens == 4)
            {
                romanNumeral[2] = "XL";
            }
            else if(tens == 5)
            {
                romanNumeral[2] = "L";
            }
            else if (tens < 9 && tens > 5)
            {
                string xCount = "L" + new String('X', tens - 5);
                romanNumeral[2] = xCount;
            }
            else if (tens == 9)
            {
                romanNumeral[2] = "XC";
            }

            // Value in the ones position
            if (ones < 4 && ones > 0)
            {
                string iCount = new String('I', ones);
                romanNumeral[3] = iCount;
            }
            else if (ones == 4)
            {
                string iCount = new String("IV");
                romanNumeral[3] = iCount;
            }
            else if (ones == 5)
            {
                string iCount = new String("V");
                romanNumeral[3] = iCount;
            }
            else if (ones < 9 && ones > 5)
            {
                string iCount = "V" + new String('I', ones - 5);
                romanNumeral[3] = iCount;
            }
            else if (ones == 9)
            {
                romanNumeral[3] = "IX";
            }

            Console.WriteLine(String.Join(", ", romanNumeral.ToArray()).Replace(" ", "").Replace("," , ""));
        }

        
    }
}
