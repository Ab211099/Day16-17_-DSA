using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17_DSA
{
    internal class BinarySearch
    {

        public static void SearchWord()        {
            string[] words = new String[10];

            words[0] = "bike";
            words[1] = "cars";
            words[2] = "aeroplane";
            words[3] = "motorcycle";
            words[4] = "cycle";
            words[5] = "boat";
            words[6] = "ship";
            words[7] = "rocket";
            words[8] = "submarine";
            words[9] = "racing bike";


            
            Console.WriteLine ("enter your input : ");
            String charKey = Console.ReadLine();
            Array.Sort(words);
            Console.WriteLine (charKey + " found at index = " + Array.IndexOf(words, charKey));
            Console.WriteLine();
        }
    }
}
