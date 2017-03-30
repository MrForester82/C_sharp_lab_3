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

            /*
             * LAB 4444444444444444444444444444444444444444444
            */

            Console.WriteLine();
            Arrs.printAnyArray("A", A);
            Console.WriteLine();
            Arrs.printAnyArray("matr1", matr1);
            Console.WriteLine();
            Arrs.printAnyArray("arrr", arrr);

            //задание 2
            Array ACopy = Array.CreateInstance(typeof(string), 6);
            Array Aexample = Array.CreateInstance(typeof(string), 3);
            Aexample.SetValue("zero", 0);
            Aexample.SetValue("four", 1);
            Aexample.SetValue("five", 2);
            Aexample.CopyTo(ACopy, 2);
            Console.WriteLine();
            Arrs.printAnyArray("ACopy", ACopy);
            string str1 = ACopy.GetValue(2).ToString();
            Console.WriteLine("\n'r' at position {0}",str1.IndexOf('r'));
            string str2 = "initialise";
            Console.WriteLine("the last posotion if'i' is {0}", str2.LastIndexOf('i'));
            Console.WriteLine();
            Arrs.printAnyArray("A", A);
            Console.WriteLine();
            Array.Reverse(A);
            Arrs.printAnyArray("reverse A", A);
            Console.WriteLine();
            Array.Sort(A);
            Arrs.printAnyArrayObj("sorted A", A);


            //Students
            Student[] st = new Student[3];
            Student.InitAr(st);
            st[0].SetValue("Орджоникидзе");
            st[1].SetValue("Лепсеридзе");
            st[2].SetValue("Газгаридзе");
            Console.WriteLine("\n");
            for (int i = 0; i < st.GetLength(0); i++)
            {
                Console.WriteLine(st[i].ToString());
            }
            Console.WriteLine();

        }
    }    
}