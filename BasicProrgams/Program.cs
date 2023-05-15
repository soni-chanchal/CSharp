public class Program
{
    public static void Main(string[] args)
    {
        // Check even odd number
        IsEven(5);
        IsEven(6);

        // check for prime number
        IsPrimeNumber(0);
        IsPrimeNumber(1);
        IsPrimeNumber(2);
        IsPrimeNumber(3);
        IsPrimeNumber(8);

        // factorial
        int fact = Factorial(5);
        Console.WriteLine(fact);

        // swap two numbers
        SwapNum(2, 4);

        // fibonacci
        Fibonacci(6);

        //reverse string
        string str = ReverseString("hello");
        Console.WriteLine(str);

    }

    public static void IsEven(int num)
    {
        if(num%2 == 0)
        {
            Console.WriteLine($"{num} is a even number");
        }
        else
        {
            Console.WriteLine($"{num} is odd number");
        }
    }

    public static void IsPrimeNumber(int num) 
    { 
        if(num <=0)
        {
            Console.WriteLine($"entered number is {num}, enter a valid number");
        }
        else if(num == 1)
        {
            Console.WriteLine($"{num} is universal number");
        }
        else if (num == 2)
        {
            Console.WriteLine($"{num} is only a even prime number");
        }
        else
        {
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine($"{num} is not a prime number");
                    return;
                }
            }
            Console.WriteLine($"{num} is a prime number");
        }
    }

    public static int Factorial(int num)
    {
        int fact = 1;
        for(int i =1; i <= num; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    public static void SwapNum(int x, int y)
    {
        Console.WriteLine($"old value of x {x} old value of y {y}");
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"new value of x {x} and new value of y {y}");
    }
    
    public static void Fibonacci(int num)
    {
        int a = 0;
        int b = 1;
        if(num <= 0)
        {
            Console.WriteLine("Enter a valid number");
        }
        else if(num == 1)
        {
            Console.WriteLine(a);
        }
        else if(num == 2)
        {
            Console.WriteLine($"{a} {b}");
        }
        else
        {
            Console.WriteLine(a);
            for(int i = 2 ; i <= num; i++)
            {
                b = a + b;
                Console.WriteLine(b);
                int temp = b;
                b = a;
                a = temp;
                
            }
            
        }
    }

    public static string ReverseString(string str)
    {
        string empty = "";
        for(int i =str.Length-1; i>=0; i--)
        {
            empty = empty + str[i];
        }
        return empty;
    }
}