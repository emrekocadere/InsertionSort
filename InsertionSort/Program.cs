using System;
class InsertionSort
{

    void sort(int[] array)
    {
        int length = array.Length;
        for (int i = 1; i < length; ++i)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    static void PrintArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length; ++i)
            Console.Write(array[i] + " ");
            Console.WriteLine();
    }

    public static void Main()
    {
        int[] array = {5,9,8,2,3,1};
        InsertionSort sorting = new InsertionSort();
        sorting.sort(array);
        PrintArray(array);
    }
}