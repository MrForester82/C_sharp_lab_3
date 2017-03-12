using System;

namespace arrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }    
}