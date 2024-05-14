using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = CleanString(UserInput());
            Console.WriteLine(word);
            Console.WriteLine(isPalindrome(word) ? "That is a palindrome" : "That was not a palindrome");
            Console.ReadLine();
        }
        static bool isPalindrome(string s)
        {

            if (s.Length <= 1)
                return true;
            else
                if (s[0] == s[s.Length - 1])
                return isPalindrome(s.Substring(1, s.Length - 2));
            else
                return false;
        }

        static string UserInput()
        {
            Console.WriteLine("Please enter a word/sentence and I will check if it is a Palindrome.");
            string s = Console.ReadLine();
            return s;
        }

        static string CleanString(string s)
        {
            string cleansed = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleansed += char.ToLower(c);
                }
            }
            
            return cleansed;
        }
    }
}