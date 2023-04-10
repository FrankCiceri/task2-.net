using System.Text;

namespace task2driver
{
    public class TaskDriver
    {
        public static void Main(string[] args)
        {
            palindrome();

        }

        public static void palindrome()
        {
            string input = Console.ReadLine();
            int specialcharCount = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) || input[i].Equals('-'))
                {
                    if(specialcharCount > 0)
                    {
                        sb.Append(" ");
                        specialcharCount = 0;
                    }
                    sb.Append(input[i]);
                }
                else {
                    specialcharCount++;
                }

            }

            String[] words = sb.ToString().Split();
            
         

            for (int i=0;i<words.Length;i++) 
            {   
                string word = words[i].Replace("-",string.Empty);
                bool isPalindrome = true;
                int front = 0;
                int back = word.Length - 1;
                bool different;
                char c1;
                char c2;
                while (word.Length > 0 && back - front > 0 ) {
                    c1 = Char.ToLower(word[front]);
                    c2 = Char.ToLower(word[back]);
                  
                    different = (c1 != c2);
                    if (different) { 
                        
                        isPalindrome = false;
                        break;
                    }
                    front++;
                    back--;                
                
                }
               
                if(word.Length > 0 ){
                    Console.WriteLine(words[i] + " – " + (isPalindrome ? "" : "not") + " palindrome");
                }

            }
         








        }

    }





}