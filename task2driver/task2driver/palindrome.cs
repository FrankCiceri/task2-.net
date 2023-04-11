using System;


namespace task2driver
{
    public class Palindrome
    {

        public static string[] BuildList() {
            string input = Console.ReadLine();
            string[] words = input.Replace(",", string.Empty).Split();
           
            return words;

        }



        public static void DisplayPalindrome()
        {
            
            string[] words = BuildList();
            bool isLast = false;
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].Replace("-", string.Empty);
                bool isPalindrome = true;
                int front = 0;
                int back = word.Length - 1;
                bool different;
                char c1;
                char c2;
                while (word.Length > 0 && back - front > 0)
                {
                    c1 = Char.ToLower(word[front]);
                    c2 = Char.ToLower(word[back]);

                    different = (c1 != c2);
                    if (different)
                    {

                        isPalindrome = false;
                        break;
                    }
                    front++;
                    back--;

                }

                if (word.Length > 0)
                {
                    if (i == words.Length - 1)
                    {
                        isLast = true;
                    }
                    Console.Write(words[i] + " – " + (isPalindrome ? "" : "not") + " palindrome" + (isLast ? ".":", "));
                }



            }
        }

    }
}
