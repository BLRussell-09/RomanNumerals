using RomanNumerics.Models;
using System;

namespace RomanNumerics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var doConvert = new Converter();

            doConvert.convertToRoman(30);


            Console.Read();
        }
      }
}
