public class Program
{
    public static void Main(string[] arg)
    {
        //swap numbers
        Swap(3,6);

        // factorial
        int result = Factorial(5);
        Console.WriteLine(result);

        // reverse a string

        string str = ReverseString("chanchal");
        Console.WriteLine(str);

        // traverse a array
        int[] array = {1,2,3,4,5};
        TraverseArray(array);

        // reverse array
        int[] revArr = ReverseArray(array);
        TraverseArray(revArr);

        // prime number
        CheckPrime(0);
        CheckPrime(1);
        CheckPrime(2);
        CheckPrime(4);
        CheckPrime(13);

        // Fibonacci series
        Fabonacci(10);
        
    }

    public static void Swap(int a, int b)
    {
        Console.WriteLine($"{a},{b}");
        int t = a;
        a =  b;
        b = t;
        Console.WriteLine($"new {a},{b}");

    }

    public static int Factorial(int num)
    {
        int fact = 1;
        for(int index = 1; index <= num; index++)
        {
            fact = fact * index;
           
        }
        return fact;
    }

    public static string ReverseString(string s)
    {
        string empty = "";
        for(int index = s.Length - 1; index >= 0; index--)
        {
            empty = empty + s[index];
        }
        return empty;
    }

    public static void TraverseArray(int[] arr)
    {
        for(int index = 0; index < arr.Length; index++)
        {
            Console.WriteLine(arr[index]);
        }
    }

    public static int[] ReverseArray(int[] arr)
    {
        int[] empty = new int[arr.Length];
        int emptyIndex = 0;
        for(int index = arr.Length-1; index >= 0; index--)
        {
            empty[emptyIndex] = arr[index];
            emptyIndex++;
        }
        return empty;
    }

    public static void CheckPrime(int n)
    {
        if (n <= 0)
        {
            Console.WriteLine("Enter a valid number");
        }
        else if (n == 1)
        {
            Console.WriteLine("One is Universal number");
        }
        else if(n == 2)
        {
            Console.WriteLine("Two is only even prime number");
        }
        else
        {
            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} is not a prime number");
                    return;
                }

            }
            Console.WriteLine($"{n} is a prime number");
        }
        
    }

    public static void Fabonacci(int n) 
    {
        // 0 1 1 2 3 5 8 13 21
        int a = 0;
        int b = 1;
        if (n < 1)
        {
            Console.WriteLine("Enter a valid number");
        }
        else if (n == 1)
        {
            Console.WriteLine($"{a}");
        }
        else if (n == 2)
        {
            Console.WriteLine($"{a} {b}");
        }
        else 
        {
            Console.WriteLine($"{a}");
            for(int i = 3; i <= n; i++)
            {
                b = a + b;
                Console.WriteLine(b);
                int t = a;
                a = b;
                b = t;
            }
        }
    
    }
}