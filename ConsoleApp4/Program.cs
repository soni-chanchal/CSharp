public class Program
{
    public static void Main(string[] args)
    {
        Create1DArray();
    }


    public static void Create1DArray()
    {
        // 1-D Array
        Console.WriteLine("Enter the size of array: ");
        string len = Console.ReadLine();
        int length = int.Parse(len);
        int[] arr = new int[length];

        // pushing element in array
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter the element: ");
            string ele = Console.ReadLine();
            arr[i] = int.Parse(ele);
        }

        // traverse and print element of array
        Console.WriteLine();
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"element at {i} index = {arr[i]} ");
        }

    }
}