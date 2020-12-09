using System;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string [ ] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            while (inputText != "end" )
            {
                for ( int i = inputText.Length - 1; i >= 0; i-- )
                {
                    reversed.Append( inputText [ i ] );
                }
                Console.WriteLine(inputText + " = " + reversed);
                reversed.Clear( );
                inputText = Console.ReadLine( );
            }
        }
    }
}
