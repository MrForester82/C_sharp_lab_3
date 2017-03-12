using System;

public class Arrs
{
    private static Random md;

	public Arrs()
	{
        mn = new Random();
	}

    public static void createOneDimAr(int[] mas)
    {
        int cout = GetLength(mas);
        for(int i=0; i<count; i++)
        {
            mas[i] = md.Next(1, 20);
        }
    }

    public static void printArr1(int[] mas)
    {
        int cout = GetLength(mas);
        for (int i = 0; i < count; i++)
        {
            System.Write("{0}\t", mas[i]);
        }
    }
}
