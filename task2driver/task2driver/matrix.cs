using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2driver
{
    public class Matrix
    {

        public static void DisplayMatrix(int[,] matrix) {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static int[,] BuildMatrix()
        {

            Random random = new Random();
            int n = random.Next(10);
            int m = random.Next(10);
            int[,] matrix = new int[n, m];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = random.Next(10);
                }
            }

            return matrix;

        }


        public static void FillMatrix() { 
           int[,] initialMatrix = BuildMatrix();
           DisplayMatrix(initialMatrix);

            int[,] zerone = new int[initialMatrix.GetLength(0), initialMatrix.GetLength(1)];


        
        }


    }
}
