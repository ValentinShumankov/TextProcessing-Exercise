using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string [ ] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine()) ;
            string sample = input[0].ToString();
            StringBuilder sb= new StringBuilder(sample);
            for ( int i = 0; i < input.Length; i++ )
            {
                if ( input[i].ToString() != sample )
                {
                    sb.Append( input [ i ].ToString( ) );
                    sample = input [ i ].ToString( );
                }
            }
            Console.WriteLine(sb);
        }
    }
}
