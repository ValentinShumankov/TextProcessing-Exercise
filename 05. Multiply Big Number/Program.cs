using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string [ ] args)
        {
            string bigNum = Console.ReadLine().TrimStart('0');
            int mulptiplier = int.Parse(Console.ReadLine());
            StringBuilder number = new StringBuilder();
            int remainder = 0;
           
            if ( mulptiplier == 0 )
            {
                Console.WriteLine( 0 );
                return;
            }
            for ( int i = bigNum.Length - 1; i >= 0; i-- )
            {
               int result = int.Parse(bigNum [ i ].ToString( )) * mulptiplier + remainder ;
                remainder = 0;
                if ( result > 9 )
                {
                    remainder = result / 10;
                    result = result % 10;
                }
                number.Append( result );
            }
            if ( remainder != 0  )
            {
                number.Append( remainder );
            }
            StringBuilder finalNum = new StringBuilder();
            for ( int i = number.Length - 1; i >= 0; i-- )
            {
                finalNum.Append( number [ i ] );
            }
            Console.WriteLine(finalNum);
        }
    }
}
