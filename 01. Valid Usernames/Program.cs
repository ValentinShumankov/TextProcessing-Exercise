using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string [ ] args)
        {
            List<string> nickNames = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> validWord = new List<string>();
            for ( int word = 0; word < nickNames.Count; word++ )
            {
                var currentWord = nickNames[word];
                if ( nickNames [ word ].Length >= 3 && nickNames [ word ].Length <= 16 )
                {
                    bool isValid = true;
                    for ( int i = 0; i < nickNames[word].Length; i++ )
                    {
                        if (!(char.IsLetterOrDigit( currentWord[i]) 
                            || currentWord[i] == '-' 
                            || currentWord[i] == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }  
                    if ( isValid == true )
                    {
                        validWord.Add( nickNames [ word ] );
                    }
                }
            }

            Console.WriteLine( string.Join( Environment.NewLine, validWord ) );

        }
    }
}
