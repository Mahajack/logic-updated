using System;

class BinarySort
{

    public static void Main()
    {
        int[] arr = {37, 23, 0, 17, 12, 72, 31, 
							46, 100, 88, 54 };

        sort(arr);

        for (int input = 0; input < arr.Length; input++)
            Console.Write(arr[input] + " ");
    }

    public static void sort(int[] array)
    {
        for (int input = 1; input < array.Length; input++)
        {
            int key = array[input];

            // Find location to insert using 
            // binary search 
            int insert = Math.Abs(Array.BinarySearch(
                            array, 0, input, key) + 1);

            // Shifting array to one location right 
            System.Array.Copy(array, insert, array,
                                        insert + 1, input - insert);

            // Placing element at its correct 
            // location 
            array[insert] = key;
        }
    }
}


