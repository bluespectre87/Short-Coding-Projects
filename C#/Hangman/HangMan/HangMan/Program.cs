using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variable Definition
            string knownletters = "";
            string line = "";
            int counter = 0;
            int c2 = 0;
            List<char> lettersFromKnownWord = new List<char>();
            List<string> narrowedDownWords = new List<string>();
            List<string> acceptableStrings = new List<string>();
            List<char> temp = new List<char>();
            StreamReader reader = new StreamReader("words.TXT");

            //reading in and seperating out words from file
            line = reader.ReadLine();
            List<string> words = new List<string>();
            words = line.Split(',').ToList();

            //getting known inputs
            Console.WriteLine("Enter known letters in the word, use spaces for any unkonwn letters");
            knownletters = Console.ReadLine();

            foreach (var letter in knownletters) //seperates letters in known input
            {
                lettersFromKnownWord.Add(letter);
            }

            foreach (var item in lettersFromKnownWord)
            {
                if (item != ' ')
                {
                    counter += 1;
                }
            }


            //removing words from array that do not match the length of the full known input
            foreach (var word in words)
            {
                if (word.Length == knownletters.Length)
                {
                    narrowedDownWords.Add(word);
                }
            }


            foreach (var word in narrowedDownWords)
            {
                foreach (var letter in word)
                {
                    temp.Add(letter);
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i] == lettersFromKnownWord[i])
                    {
                        c2 += 1;
                    }
                }

                if (c2 == counter)
                {
                    acceptableStrings.Add(word);
                }

                temp.Clear();
                c2 = 0;
            }

            if (acceptableStrings.Count() == 0)
            {
                Console.WriteLine("No words matching this pattern were found in our database to suggest - are you sure it is spelt correctly");
            }
            else
            {
                Console.WriteLine("Possible words that this could be include: ");
                foreach (var l in acceptableStrings)
                {
                    Console.WriteLine(l);
                }
            }
           
            Console.Read();
        }
    }
}
