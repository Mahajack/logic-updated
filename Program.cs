using System;

class InsertionSort
{
    // Function to sort array 
    // using insertion sort 
    void sort(int[] arr)
    {
        int input = arr.Length;
        for (int input_array = 1; input_array < input; ++input_array)
        {
            int key = arr[input_array];
            int j = input_array - 1;

            // Move elements of arr[0..i-1], 
            // that are greater than key, 
            // to one position ahead of 
            // their current position 
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

   
    static void printArray(int[] arr)
    {
        int input = arr.Length;
        for (int input_array = 0; input_array < input; ++input_array)
            Console.Write(arr[input_array] + " ");

        Console.Write("\n");
    }

    //main method
    public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 };
        InsertionSort obj = new InsertionSort();
        obj.sort(arr);
        printArray(arr);
    }
}


