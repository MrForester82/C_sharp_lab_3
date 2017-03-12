using System;

namespace arrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //одномерные массивы//////////////////////////////////////////////////
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
           
            Arrs.createOneDimAr(A);
            Arrs.printArr1("A", A);
            Arrs.createOneDimAr(B);
            Arrs.printArr1("B", B);

            Arrs.sum(A, B, C);
            Arrs.printArr1("C", C);

            int[] X = { 5, 5, 6, 6, 7, 7 };
            int[] U, V;
            U = new int[3];
            for(int i=0; i<3; i++)
            {
                U[i] = i + 1;
            }

            V = new int[3];
            V = U;
            Arrs.printArr1("U", U);
            V[0] = 9;
            Arrs.printArr1("V", V);

            int size = 0;
            Console.Write("Введите размерность массива: ");
            size = int.Parse(Console.ReadLine());
            int[] D = new int[size];
            Arrs.createOneDimAr(D);
            Arrs.printArr1("D", D);
            //одномерные массивы//////////////////////////////////////////////////

            //матрицы//////////////////////////////////////////////////
            int[,] matr1 = new int[3, 3];
            int[,] matr2 = new int[3, 3];

            Arrs.createMatrix(matr1);
            Arrs.printMatrix("matr1", matr1);
            Arrs.createMatrix(matr2);
            Arrs.printMatrix("matr2", matr2);

            Arrs.printMatrix("matr1 * matr2", Arrs.multipleMatrix(matr1, matr2));
            //матрицы//////////////////////////////////////////////////

            //массивы массивов//////////////////////////////////////////////////
            int[][] arrr = new int[10][];
            for(int i = 0;  i < arrr.Length; i++)
            {
                arrr[i] = new int[i + 1];
            }
            Arrs.createArr3(arrr);
            Arrs.printArr3("arrr", arrr);
            //массивы массивов//////////////////////////////////////////////////

        }
    }    
}