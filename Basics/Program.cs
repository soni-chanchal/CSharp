public class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Hello World");
        int res = Factorial(5);
        Console.WriteLine(res);

        int sum = AddTwoNum(22, 22);
        Console.WriteLine(sum);

        string concat = ConcatenateString("Cheeku", "Guddu");
        Console.WriteLine(concat);
    }

    public static int AddTwoNum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static string ConcatenateString(string str1, string str2)
    {
        return str1 + str2;
    }
    
    
    public static int Factorial(int num)
    {
        int fact = 1;
        for(int i = 1; i<=num; i ++)
        {
            fact = fact * i;
        }
        return fact;

    }

}


