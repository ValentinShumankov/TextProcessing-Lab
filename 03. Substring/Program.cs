using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string [ ] args)
        {
            string filter = Console.ReadLine().ToLower();
            string rowInputText = Console.ReadLine();

            while ( rowInputText.IndexOf( filter ) != -1 )
            {
                rowInputText = rowInputText.Remove( rowInputText.IndexOf( filter ), filter.Length );
            }
            Console.WriteLine( rowInputText );

        }
    }
}
