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
    }
}
