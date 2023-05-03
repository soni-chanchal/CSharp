using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello world");
        TraverseArray(numbers);

        ReverseArray(nums);

        // Searching Element in array
        Console.WriteLine("Enter the element you want to search: ");
        int element = Int32.Parse(Console.ReadLine());
        int index = SearchElement(nums, element);
        if (index == -1)
        {
            Console.WriteLine($"{element} is not present in array.");
        }
        else
        {
            Console.WriteLine($"The {nums[index]} is present at {index} index.");
        }

    }

    static int[] nums = { 1, 2, 3, 4, 5, 3, 43, 45, 22, 43, 23 };

    static int[] numbers = new int[10];

    public static void TraverseArray(int[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            Console.WriteLine(arr[index]);
        }
    }


    public static void ReverseArray(int[] arr)
    {
        for (int index = arr.Length - 1; index >= 0; index--)
        {
            Console.WriteLine(arr[index]);
        }

    }

    public static int SearchElement(int[] arr, int element)
    {
        // arr =  [ 11,22,33,44,55]
        // arr[0], arr[1], arr[2]
        // linear search -> returns index of element
        int foundIndex = -1;

        for (int index = 0; index < arr.Length; index++)
        {
            if (arr[index] == element)
            {
                foundIndex = index;
                break;
            }
        }
        return foundIndex;
    }

}