using System;
using System.Numerics;


namespace task2driver
{
    public class GameofLife
    {


        public static string[,] InitializeField()
        {
            Console.WriteLine("Matrix Generated....");
            Random random = new Random();
            var cells = new List<string> {"+","-"};
            int n = random.Next(3, 10);
            int m = random.Next(3, 10);
            string[,] matrix = new string[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int index = random.Next(cells.Count);
                    matrix[i, j] = cells[index];
                }
            }
            return matrix;

        }


        public static void DisplayMatrix(string[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write((matrix.GetLength(0) - i) + " ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                                       
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
            for (int i = 0; i <= matrix.GetLength(1); i++) {
                Console.Write(i + " ");
            }
            
            Console.WriteLine("\n--------------------------");

        }



        public static void Game()
        {

            string[,] field = InitializeField();
            bool loop = true;
            int t = 0, neighbors = 0;
            
            while (t < 5)
            {

                DisplayMatrix(field);
                

                for (int i = 0; i < field.GetLength(0); i++) {

                    for (int j = 0; j < field.GetLength(1); j++) {

                        neighbors = CalcNeighbors(field, i, j);
                        
                    }
                
                }

                t++;





            }


        }

        public static int CalcNeighbors(string[,] field, int i, int j)
        {
            int neighbors = 0;
            int x;
            int y;
            bool restricted = false;

        for (x = i - 1; x <= i + 1; x++)
            {
                for (y = j - 1; y <= j + 1; y++)
                {
                    if (x != i || y != j)
                    {
                        neighbors += checkNeighbor(field, x, y);


                    }

                }
            }
                    return neighbors;


        }


        public static int checkNeighbor(string[,] field, int x, int y) {
             bool restricted = x >= 0 && y >= 0 && x < field.GetLength(0) && y < field.GetLength(1);
             if (restricted)
             {
                 if (field[x, y] == "+")
                 {
                     return 1;
                 }

             }
            return 0;
        }
             








    }
}
