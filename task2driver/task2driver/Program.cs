using System.Text;


namespace task2driver
{
    public class TaskDriver
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("------------Palindrome----------- \n");
            Palindrome.DisplayPalindrome();

            Console.WriteLine(" \n -----------SwapArray------------ \n");
            Swap.SwapValues();

            Console.WriteLine("\n ---------FillMatrix---------- \n");
            Matrix.FillMatrix();
        }
                       
     }
}