using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {  
        static void Main(string[] args)
        { string  Continue;
            do
            {
                Console.WriteLine("Welcome to the Pig Latin Translator.");
                Console.Write("Enter a line to be translated: "); //Console.Write makes it so the user input will come up next to this sentence. 
                string sentence = Console.ReadLine().ToLower(); // Stores the user's sentence. Adds to string builder and it will add the strings togther. 

                string[] words = sentence.Split(' '); // This line makes an array of each indivisual word through the string. 
                char[] vowelArray = { 'a', 'e', 'i', 'o', 'u' };



                for (int i = 0; i < words.Length; i++)
                {
                    string beginningLetter = words[i].Substring(0, 1); // takes the first letter of the word you are currently looking at.
                    string restOfWord = words[i].Substring(1, words[i].Length - 1);
                    string vowels = "aeiou";


                    if (vowels.Contains(beginningLetter))
                    {
                        words[i] = words[i] + "way";

                    }
                    else
                    {
                        while (!vowels.Contains(beginningLetter))
                        {
                            words[i] = restOfWord + beginningLetter;
                            beginningLetter = words[i].Substring(0, 1);
                            restOfWord = words[i].Substring(1, words[i].Length - 1);


                        }

                        words[i] += "ay";
                    }


                }

                Console.WriteLine(string.Join(" ", words));





                Console.Write("Translate another line? (y/n): ");
                Continue = Console.ReadLine().ToLower();

            } while (Continue == "y" || Continue == "yes");


            Console.WriteLine(" Thanks, bye! ");
           
        }
        
        



    }
}

