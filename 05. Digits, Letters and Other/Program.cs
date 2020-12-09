using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string [ ] args)
        {
            string text = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder other = new StringBuilder();
            for ( int i = 0; i < text.Length; i++ )
            {
                if ( char.IsDigit( text [ i ] ) )
                {
                    digits.Append( text [ i ] );

                }
                else if ( char.IsLetter( text [ i ] ) )
                {
                    letters.Append( text [ i ] );
                }
                else
                {
                    other.Append( text [ i ] );
                }
            }
            Console.WriteLine( digits );
            Console.WriteLine( letters );
            Console.WriteLine( other );
        }
    }
}
 