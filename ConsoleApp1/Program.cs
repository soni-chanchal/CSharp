using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter A string: ");
        string input = Console.ReadLine();
        string result = ReverseString(input);
        Console.WriteLine($"Reverse of {input} is {result}.");

        // reverse array
        int[] array = { 1, 2, 3, 4, 5 };
        int[] revArray = ReverseArray(array);
        TraverseArray(revArray);

        // factorial of a number
        int number = Factorial(5);
        Console.WriteLine(number);

        // Search Element in array
        int[] numbers = {1, 2, 3, 4, 5};
        int numIndex = SearchElementInArray(numbers, 4);
        Console.WriteLine(numIndex);

        // check number is even or odd
        EvenOdd(5);

        // Check number is prime or not.
        CheckPrimeNumber(-34);
        CheckPrimeNumber(1);
        CheckPrimeNumber(2);
        CheckPrimeNumber(17);
        CheckPrimeNumber(12);

        //swap number

        SwapNumber(2, 4);

        // fabonacii series
        Fabonacii(8);
        

    }

    public static string ReverseString(string str)
    {
        string revString = "";
        for (int index = str.Length - 1; index >= 0; index--)
        {
            revString = revString + str[index];
        }
        return revString;
    }

    public static void TraverseArray(int[] array)
    {
        for(int index  = 0; index < array.Length; index++)
        {
            Console.WriteLine(array[index]);
        }
    }

    public static int[] CopyArray(int[] arr)
    {
        int[] temp = new int[arr.Length];
        for (int index = arr.Length - 1; index >= 0; index--)
        {
            temp[index] = arr[index];
        }
        return temp;
    }

    public static int[] ReverseArray(int[] arr)
    {
        int[] tempArray = new int[arr.Length];
        int tempIndex = 0;
        for(int index = arr.Length - 1; index >= 0; index--)
        {
            tempArray[tempIndex] = arr[index];
            tempIndex++;
        }
        return tempArray;
    }

    public static int Factorial(int num)
    {
        int fact = 1;
        for( int i = 1; i <= num; i++ ) 
        {
            fact = fact * i;
        }
        return fact;
    }

    public static int SearchElementInArray(int[] array, int element)
    {
        int foundIndex = -1;
        for(int index = 0 ; index < array.Length; index++)
        {
            if(array[index] == element)
            {
                foundIndex = index;
                break;
            }                       
        }
        return foundIndex;
    }

    public static void EvenOdd(int num)
    {
        if(num % 2 == 0)
        {
            Console.WriteLine("This is a even number");
        }
        else 
        {
            Console.WriteLine("This is a odd number");
        }
    }

    public static void CheckPrimeNumber(int num)
    {
        if(num < 1)
        {
            Console.WriteLine("Enter a valid number.");
        }
        else if(num == 1)
        {
            Console.WriteLine($"{num} neither prime nor composite");
        }
        else if (num == 2)
        {
            Console.WriteLine($"{num} is only even prime nmber");
        }
        else
        {
           for(int i = 2; i < num; i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine($"{num} is not a prime number");
                    return;
                }
            }
            Console.WriteLine($"{num} is a prime number");

        }
    }

    public static void SwapNumber(int num1, int num2)
    {
        Console.WriteLine($"old num1->{num1}  num2 -> {num2}");
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"new num1->{num1} num2 -> {num2}");
    }

    public static void Fabonacii(int num)
    {
        int a = 0;
        int b = 1;
        if(num<1)
        {
            Console.WriteLine("invalid number");
        }
        else if(num == 1)
        {
            Console.WriteLine(a);
        }
        else if(num ==2)
        {
            Console.WriteLine($"{a},{b}");
        }
        else
        {
            Console.WriteLine(a);
            for (int i = 1; i <= num; i++)
            {
                b = a + b;
                Console.WriteLine($"{b}");
                int temp = a;
                a = b;
                b = temp;
            }
           
        }

    }
}