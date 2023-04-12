using System.Text;


namespace task2driver
{
    public class TaskDriver
    {
        public static void Main(string[] args)
        {

            int choice;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Palindrome");
                Console.WriteLine("2. Swap Values");
                Console.WriteLine("3. Matrix Upper-Lower");
                Console.WriteLine("4. Game of Life");
                Console.WriteLine("5. Exit");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You selected Palindrome");
                        Palindrome.DisplayPalindrome();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("You selected Swap Values");
                        Swap.SwapValues();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("You selected Matrix Upper-Lower");
                        Matrix.FillMatrix();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("You selected Game of Life");
                        GameofLife.Game();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 5);

            /*Console.WriteLine("------------Palindrome----------- \n");
            Palindrome.DisplayPalindrome();

            Console.WriteLine(" \n -----------SwapArray------------ \n");
            Swap.SwapValues();

            Console.WriteLine("\n ---------FillMatrix---------- \n");
            Matrix.FillMatrix();*/

            /*GameofLife.Game();*/



            
        }
                       
     }
}