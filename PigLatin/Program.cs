using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please input an English word.");
                string myWord = Console.ReadLine().ToUpper();   //I thought this would save space in the vowels array and in conversion later
                string way = "WAY";
                string ay = "AY";

                char firstLetter = myWord[0];
                char secondLetter = myWord[1];

                char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
                string firsttwoletters = myWord.Substring(0, 2);
                string second = myWord.Substring(2);    //only named this because I came up with it second
                string third = myWord.Substring(1);

                string firstLetterString = firstLetter.ToString();

                if (firstLetter == 'Q' && secondLetter == 'U')
                { Console.WriteLine(second + firsttwoletters + ay); }

                else if (!vowels.Contains(firstLetter) && (vowels.Contains(secondLetter)))
                { Console.WriteLine(third + firstLetter + ay); }


                else if (!firsttwoletters.Contains('A') && !firsttwoletters.Contains('E') && !firsttwoletters.Contains('I') && !firsttwoletters.Contains('O') && !firsttwoletters.Contains('U'))
                    Console.WriteLine(second + firsttwoletters +ay);

                else
                { Console.WriteLine(myWord + way); }
                }
            }
        }
}
 

        
