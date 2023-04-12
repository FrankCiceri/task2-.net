using System;
using System.Text;

namespace task2driver
{
    public class Swap
    {
        public static string[] BuildArray() {
            Console.Write("Enter your array= ");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            sb.Replace(",", "");
            sb.Replace("(", "");
            sb.Replace(")", "");  
            return sb.ToString().Split();

        }



        public static void SwapValues()
        {
            string[] numArray = BuildArray();
           
            int front = 0;
            int back = numArray.Length - 1;
            string temporal;
            while (back - front >= 0)
            {

                temporal = numArray[back];
                numArray[back] = numArray[front];
                numArray[front] = temporal;

                front++;
                back--;

            }
            string outputString = string.Join(", ", numArray);
            outputString = outputString.Insert(0, "(").Insert(outputString.Length+1, ")");
            Console.Write( " => "+outputString);


        }


    }
}
