using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string [ ] args)
        {
            List<string> inputText = Console.ReadLine().Split().ToList();
            for ( int i = 0; i < inputText.Count; i++ )
            {
                foreach ( char item in inputText[i] )
                {
                    Console.Write( inputText [ i ] );
                }
            }
        }
    }
}
