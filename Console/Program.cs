using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Extensions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string displayFormat = "Original word: {0}\r\nPascal word: {1} \r\n";

            string text1 = "hello";
            Console.WriteLine(String.Format(displayFormat, text1, text1.ToPascal()));

            string text2 = "hello world";
            Console.WriteLine(String.Format(displayFormat, text2, text2.ToPascal()));

            string text3 = " world";
            Console.WriteLine(String.Format(displayFormat, text3, text3.ToPascal()));

            Console.ReadLine();
        }
    }
}
