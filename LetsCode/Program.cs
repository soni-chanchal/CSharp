public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lets Code Baby");

        // Finding a factorial
        Console.WriteLine("Enter a number: ");
        int num = Int32.Parse(Console.ReadLine());
        int res = Factorial(num);
        Console.WriteLine($"Factorial of {num} is {res}.");

        // Reverse a string 
        Console.WriteLine("Enter a word to reverse: ");
        string str = Console.ReadLine();
        string result = ReverseString(str);
        Console.WriteLine($"Reverse string for {str} is {result}.");

        // Reverse Array
        int[] array = { 2, 5, 6, 8, 12, 5, 4, 3, 2, 1, };
        ReverseArray(array);

        //
        int[] array2 = ReturnRevereArray(array);
        TraverseArray(array2);


    }

    public static int Factorial(int num)
    {
         int fact = 1;
        for(int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    public static string ReverseString(string str)
    {
        string reverseStr = "";
        for(int index = str.Length-1; index >= 0; index--)
        {
            reverseStr = reverseStr + str[index];
        }
        return reverseStr;
    }

    public static void ReverseArray(int[] arr)
    {
        for(int index =  arr.Length-1;index >= 0; index--)
        {
            Console.WriteLine(arr[index]);
        }
    }

    public static int[] ReturnRevereArray(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int i = 0;
        
        for( int index = arr.Length-1; --index >= 0;)
        {
            temp[9] = arr[9];
            i++;
        }
        return temp;
    }

    public static void TraverseArray(int[] arr)
    {
        for(int index = 0; index < arr.Length; index++)
        {
            Console.Write($"{ arr[index]}  -> ");
        }
    }
}


