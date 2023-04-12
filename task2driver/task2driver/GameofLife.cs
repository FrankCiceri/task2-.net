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
            var cells = new List<string> { "+", "-" };
            int n = random.Next(3, 10);
            int m = random.Next(3, 10);
            string[,] matrix = new string[4, 4];

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
            for (int i = 0; i <= matrix.GetLength(1); i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n----------------------------------------");
        }

        public static void Game()
        {
            string[,] field = //InitializeField(); //use this method if you want to generate a random field
           /* {
                { "-", "+", "+", "+" },
                { "-", "-", "+", "+" },  //This will end when there are only empty cells
                { "-", "+", "-", "-" },
                { "-", "-", "-", "+" }
            };*/

            {
                { "-", "+", "-", "-" },
                { "+", "-", "+", "-" },  // this will never generate, and it will end because of that
                { "-", "+", "-", "-" },
                { "-", "-", "-", "-" }
            };


            string[,] newState = field.Clone() as string[,];
            bool loop = true;
            int t = 0;
            string selectedCell = "";
            while (true)
            {
                DisplayMatrix(field);
              

                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        int neighbors = CalcNeighbors(field, i, j);
                        selectedCell = field[i, j];

                        if (selectedCell == "+")
                        {
                            if (neighbors <= 1)
                            {
                                newState[i, j] = "-";
                            }
                            else if (neighbors >= 4)
                            {
                                newState[i, j] = "-";
                            }
                        }
                        else
                        {
                            if (neighbors == 3)
                            {
                                newState[i, j] = "+";
                            }
                        }
                    }
                }

                if (checkAllEmpty(field, newState) || checkSameState(field, newState))
                {
                    Console.WriteLine("GameOver");
                    break;
                }



                field = newState.Clone() as string[,];

                Console.ReadKey(true);
                Console.WriteLine("------------Next Generation-------------");

              
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
                    neighbors += checkNeighbor(field, x, y, i, j);
                }
            }

            return neighbors;
        }

        public static int checkNeighbor(string[,] field, int x, int y, int i, int j)
        {
            bool restricted = !(
                (x < 0 || y < 0) || (x >= field.GetLength(0) || y >= field.GetLength(1))
            );
            if (restricted)
            {
                if (!(x == i && y == j))
                {
                    //Console.WriteLine("for" + i + "," + j + " on "+ x + "," + y + " it found? "+ (field[x, y] == "+"));
                    if (field[x, y] == "+")
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        public static bool checkSameState(string[,] field, string[,] newState)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] != newState[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool checkAllEmpty(string[,] field, string[,] newState)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (newState[i, j] != "+")
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
