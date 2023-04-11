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
            int n = random.Next(3,10);
            int m = random.Next(3,10);
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


        public static int[,] FillMatrix() { 
           int[,] initialMatrix = BuildMatrix();
           DisplayMatrix(initialMatrix);

            int[,] zeroOne = new int[initialMatrix.GetLength(0), initialMatrix.GetLength(1)];

            for (int i = 0; i < initialMatrix.GetLength(0); i++) { 
                for (int j = 0;j < initialMatrix.GetLength(1);j++)
                {
                    if (i == j)
                    {
                        zeroOne[i, j] = initialMatrix[i, j];
                    }
                    else if (i < j)
                    {
                        zeroOne[i, j] = 1;

                    }
                    else if (i > j) {

                        zeroOne[i,j] = 0; //this if is not that necessary because by default the matrix has 0 as values in the initialization,
                                          //so doing the ones part is enough.
                    }

                }           
            }


            Console.WriteLine("-----------------------------------------------------");

            DisplayMatrix(zeroOne);
            return zeroOne;            
        
        }
        


    }
}
