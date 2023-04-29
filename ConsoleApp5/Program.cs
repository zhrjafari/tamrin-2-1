using System;

class middle
{
    static void Main(string[] args)
    {
        int[] array = new int[50];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        int middle = GetMiddle(array);

        Console.WriteLine("The middle  is: " + middle);
    }

    static int GetMiddle(int[] array)
    {
        int middleIndex = array.Length / 2;
        int middle = array[middleIndex];
        return middle;
    }
}