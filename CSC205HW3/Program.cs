using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array of words to be tested
            string[] words = {"abdest", "acknow", "acorsy", "adempt", "adipsy", "agnosy",
                          "best", "behint", "beknow", "bijoux", "biopsy", "cestuy",
                          "chintz", "deflux", "dehors", "dehort", "deinos", "diluvy", "dimpsy",
                          "apple", "zebra", "happy"};

            // Loop through each word and test if it is abecedarian
            // using both iterative and recursive methods
            foreach (string word in words)
            {
                Console.WriteLine($"{word}: {IsAbecedarian_Iterative(word)}");
                Console.WriteLine($"{word}: {IsAbecedarian_Recursive(word)}");
            }
        }

        // 2. Implement your process in a method called IsAbecedarian.
        // Method to check if a word is abecedarian using an iterative approach
        public static bool IsAbecedarian_Iterative(string word)
        {
            // Iterate through the word
            for (int i = 0; i < word.Length - 1; i++)
            {
                // Compare each character with the next one
                if (word[i] > word[i + 1])
                {
                    // If any character is greater than the next, the word is not abecedarian
                    return false;
                }
            }

            // If all characters are in order, the word is abecedarian
            return true;
        }

        // Method to check if a word is abecedarian using a recursive approach
        public static bool IsAbecedarian_Recursive(string word)
        {
            // Base case: if the word length is 1 or less, it is abecedarian
            if (word.Length <= 1)
            {
                return true;
            }

            // Compare the first character with the second
            if (word[0] > word[1])
            {
                // If the first character is greater than the second, the word is not abecedarian
                return false;
            }

            // Recursively check the rest of the word
            return IsAbecedarian_Recursive(word.Substring(1));
        }
    }
}

//1.Process for Checking if a Word is Abecedarian
//To determine if a word is abecedarian,
//we need to check if the letters in the word appear
//in alphabetical order. Here is a step-by-step process:

//Iterative Approach
//Initialize: Start by assuming the word is abecedarian.
//Loop through the word: Compare each letter with the letter that follows it.
//Comparison: If any letter is greater than the next letter, the word is not abecedarian.
//Return Result: If all letters are in order, return true; otherwise, return false.

//Recursive Approach
//Base Case: If the word has one or zero letters, it is abecedarian.
//Recursive Step: Compare the first letter with the second letter.
//If the first letter is greater, the word is not abecedarian.
//Continue Recursively: If the first two letters are in order,
//check the rest of the word using the same process.
//Return Result: If all letters are in order, return true; otherwise, return false.