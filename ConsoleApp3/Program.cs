public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        int[] array = { 1, 2, 3 };  
        // search element in array
        int res = SearchElementInArray(array,3);
        Console.WriteLine(res);

        //sum of array
        int sum = SumOfArray(array);
        Console.WriteLine(sum);

        // factorial
        Factorial(5);

        //  reverse a string
        string str = ReverseString("hello");
        Console.WriteLine(str);

        // check prime number
        CheckPrime(0);
        CheckPrime(1);
        CheckPrime(2);
        CheckPrime(6);
        CheckPrime(13);

        // Fibonacci
        Fibonacci(6);

    }


    public static int SearchElementInArray(int[] array, int num)
    {
        int temp = -1;
        for(int index = 0; index < array.Length; index++)
        {
            if (array[index] == num)
            {
                temp = index;
                break;
            }
               
        }
        return temp;
    }

    public static int SumOfArray(int[] array)
    {
        int sum = 0;
        for(int index =0; index < array.Length; ++index)
        {
            sum = sum + array[index];
           
        }
        return sum;
    }

    public static void Factorial(int num)
    {
        int fact = 1;
        for(int index = 1; index <= num; ++index)
        {
            fact = fact * index;
            

        }
        Console.WriteLine(fact);
    }

    public static string ReverseString(string str)
    {
        string empty = "";
        for(int i = str.Length - 1; i >= 0; --i)
        {
            empty = empty + str[i];
        }
        return empty;
    }

    public static void CheckPrime(int num)
    {
        if(num == 0)
        {
            Console.WriteLine("Enter a valid number.");
        }
        else if(num == 1)
        {
            Console.WriteLine("One is a universal number.");
        }
        else if(num == 2)
        {
            Console.WriteLine("Two is only a even prime number.");
        }
        else
        {
            for(int i = 3; i< num; i++)
            {
                if(num% i == 0)
                {
                    Console.WriteLine("This is not a prime number.");
                    return;
                }
            }
            Console.WriteLine("This is a prime number.");
        }
    }

    public static void Fibonacci(int num)
    {
        int a = 0;
        int b = 1;
        if(num == 1)
        {
            Console.WriteLine(a);
        }
        else if(num == 2)
        {
            Console.WriteLine($"{a} {b}");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{a}");
            for(int i = 2; i<=num; i++)
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
