using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string input)
        {
            string[] readFile = System.IO.File.ReadAllLines(input);

            //Initialise all the values in the list to '0'
            List<int> values = new List<int>();

            //List of integers to hold the first five measurements:

            //1. Number of sentences

            int sentenceCount = 0;
            //loop repeats until all sentences have been counted
            for (int length = 0; length < readFile.Length; length = +1)
            {
                string character = readFile[length];
                if (character == ".")
                {
                    sentenceCount = +1;
                }
            }

            Console.WriteLine(values);
            values.Add(sentenceCount);
            Console.WriteLine(values);

            //2. Number of vowels

            int vowelCount = 0;
            for (int length = 0; length < readFile.Length; length =+ 1)
            {
                string character = readFile[length];
                if (character == "a" || character == "e" || character == "i" || character == "o" || character == "u")
                {
                    vowelCount = +1;
                }
            }

            values.Add(vowelCount);
            Console.WriteLine(values);

            //3. Number of consonants

            int consonantsCount = 0;
            for (int length = 0; length < readFile.Length; length =+ 1)
            {
                string character = readFile[length];
                if (character == "b" || character == "c" || character == "d" || character == "f" || character == "g" || character == "h" || character == "j" || character == "k" || character == "l" || character == "m" || character == "n" || character == "p" || character == "q" || character == "r" || character == "s" || character == "t" || character == "v" || character == "w" || character == "x" || character == "y" || character == "z")
                {
                    consonantsCount = +1;
                }
            }

            values.Add(consonantsCount);
            Console.WriteLine(values);

            //4. Number of upper case letters

            int upperCaseCount = 0;
            for (int length = 0; length < readFile.Length; length =+ 1)
            {
                string currentWord = readFile[length];
                char[] character = currentWord.ToCharArray();
                for (int x = 0; x < character.Length; x =+ 1)
                {
                    if (char.IsUpper(character[x]) == true)
                    {
                        upperCaseCount = +1;
                    }
                }
            }

            values.Add(upperCaseCount);
            Console.WriteLine(values);

            //5. Number of lower case letters

            int lowerCaseCount = 0;
            for (int length = 0; length < readFile.Length; length = +1)
            {
                string currentWord = readFile[length];
                char[] character = currentWord.ToCharArray();
                for (int x = 0; x < character.Length; x = +1)
                {
                    if (char.IsLower(character[x]) == true)
                    {
                        lowerCaseCount = +1;
                    }
                }
            }
            values.Add(lowerCaseCount);

            Console.WriteLine(values);
            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }


            return values;
        }
    }
}
