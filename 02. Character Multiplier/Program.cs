using System;
using System.Buffers;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string [ ] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Console.WriteLine( CharMultiplier( input [ 0 ], input [ 1 ] ) );
        }

        public static int CharMultiplier(string one,string two)
        {
            int largest = Math.Max(one.Length,two.Length);
            int smallest = Math.Min(one.Length,two.Length);
            int sum = 0;
            for ( int i = 0; i < largest; i++ )
            {
                if ( i <= smallest - 1 )
                {
                    sum += one [ i ] * two [ i ];
                }
                else
                {
                    if ( one.Length > two.Length )
                    {
                        sum += one [ i ];
                    }
                    else
                    {
                        sum += two [ i ];
                    }
                }
            }
            return sum;
        }
    }
}
