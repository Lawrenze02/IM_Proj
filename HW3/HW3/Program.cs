using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
 

    internal class Program
    {

        public static Dictionary<string, Dictionary<char, int>> GetCharacterFrequency(string input)
        {
            var wordFrequencies = new Dictionary<string, Dictionary<char, int>>();

            char[] delimiters = new char[] { ' ', ',' };

            var words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

           
            foreach (string word in words)
            {
               
                var letterFrequency = new Dictionary<char, int>();

              
                foreach (char c in word)
                {
                    
                    if (char.IsLetter(c))
                    {
                        
                        char lowerChar = char.ToLower(c);

                      
                        if (letterFrequency.ContainsKey(lowerChar))
                        {
                            letterFrequency[lowerChar]++;
                        }
                        else
                        {
                            letterFrequency.Add(lowerChar, 1);
                        }
                    }
                }

                
                if (letterFrequency.Count > 0) 
                {
                    wordFrequencies.Add(word, letterFrequency);
                }
            }

            return wordFrequencies;
        }
        public static void PrintCharacterFrequencies(Dictionary<string, Dictionary<char, int>> wordFrequencies)
        {
           
            foreach (var kvpWord in wordFrequencies)
            {
                string word = kvpWord.Key;
                Dictionary<char, int> letterFrequency = kvpWord.Value;

                Console.WriteLine($"\nWord: {word}");

               
                var frequencyStrings = new List<string>();

               
                foreach (var kvpChar in letterFrequency)
                {
                    char character = char.ToUpper(kvpChar.Key); 
                    int count = kvpChar.Value;
                    frequencyStrings.Add($"{character} = {count}");
                }

                
                Console.WriteLine($"\t{string.Join(", ", frequencyStrings)}");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("--- Character Frequency Counter ---");

            Console.Write("Enter string: ");
            string input = Console.ReadLine();


            Console.WriteLine("\n--- Resulting Frequencies ---");


            var result = GetCharacterFrequency(input);

           
            PrintCharacterFrequencies(result);

           
            Console.ReadKey();





        }
    }
}
