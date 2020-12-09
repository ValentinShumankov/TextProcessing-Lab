using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string [ ] args)
        {
            List<string> filsterList = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string textInput = Console.ReadLine();
          
            foreach ( var item in filsterList )
            {
                textInput = textInput.Replace( item, new string ('*',item.Length));
            }
           
            Console.WriteLine( textInput );
        }
    }
}
