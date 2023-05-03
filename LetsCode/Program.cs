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
}
