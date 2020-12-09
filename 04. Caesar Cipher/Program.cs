using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string [ ] args)
        {
            StringBuilder text =  new StringBuilder();
            string input = Console.ReadLine();
            for ( int i = 0; i < input.Length; i++ )
            {
                text.Append((char)(input [ i ] + 3));
            }
            Console.WriteLine(text);
        }
    }
}
