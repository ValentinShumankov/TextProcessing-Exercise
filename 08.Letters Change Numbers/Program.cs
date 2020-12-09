using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int lowerPosition = 96;
            int upperPosition = 64;
            double finalSum = 0;
            List<string> combos = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach ( var item in combos )
            {
                double mainNum = 0;
                mainNum = double.Parse( item.Substring(1,item.Length-1) );
                
                for ( int i = 0; i < item.Length; i++ )
                {
                    if ( i == 0 )
                    {
                        if ( char.IsUpper( item [ i ] ) )
                        {
                            mainNum /=  (item [ i ] - upperPosition);
                        }
                        else
                        {
                            mainNum *=  (item [ i ] - lowerPosition);
                        }
                    }
                    else if ( i == item.Length - 1 )
                    {
                        if ( char.IsUpper( item [ i ] ) )
                        {
                            mainNum -= (item [ i ] - upperPosition);
                        }
                        else
                        {
                           mainNum += (item [ i ] - lowerPosition);
                        }
                    }
                }//for Cycle
                finalSum += mainNum;
            }//foreach
            Console.WriteLine( $"{finalSum:f2}" );
        }// Main
    }// Class Program
}// Namespace
