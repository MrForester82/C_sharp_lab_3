using System;

namespace arrayTest
{
    public class Arrs
    {
        private static Random md = new Random();

        public static void createOneDimAr(int[] mas)
        { 
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = md.Next(1, 20);
            }
        }

        public static void createMatrix(int[,] matr)
        {
            for(int i=0; i<matr.GetLength(0); i++)
            {
                for(int j=0; j<matr.GetLength(1); j++)
                {
                    matr[i,j] = md.Next(1, 20);
                }
            }
        }

        public static void createArr3(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = md.Next(1, 20);
                }
            }
        }

        public static void printArr1(string name, int[] mas)
        {
            int count = 0;
            count = mas.GetLength(count); //(_) - арность массива
            Console.Write("{0}:\t", name);
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}\t", mas[i]);
            }
            Console.WriteLine();
        }

        public static void printMatrix(string name, int[,] matr)
        {
            Console.WriteLine("{0}:\t", name);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matr[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void printArr3(string name,  int[][] array)
        {
            Console.WriteLine("{0}:\t", name);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0}\t", array[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static void sum(int[] left, int[] right, int[] result)
        {
            if(left.Length == right.Length && (result.Length >= left.Length && result.Length >= right.Length))
            {
                for (int i = 0; i < left.Length; i++)
                {
                    result[i] = left[i] + right[i];
                }
            }
            else
            {
                Console.WriteLine("Различное количество элементов суммируемых массивов!");
            }
        }

        public static int[,] multipleMatrix(int[,] matr1, int[,] matr2)
        {
            
            if(matr1.GetLength(1) == matr2.GetLength(0))
            {
                int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
                for (int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        for (int q = 0; q < matr2.GetLength(0); q++)
                        {
                            result[i, j] += matr1[i, q] * matr2[q, j];
                        }
                    }
                }
                return result;
            }
            else
            {
                Console.WriteLine("Невозможно перемножить данные матрицы!");
                int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
                return result;
            }
        }

    }
}
