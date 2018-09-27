using RomanNumerics.Models;
using System;

namespace RomanNumerics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var doConvert = new Converter();
            doConvert.conRom(68);   
            Console.Read();
        }
      }
}
