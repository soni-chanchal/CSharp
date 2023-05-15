public class Program
{
    public static void Main(string[] args)
    {   // string reverse
        string str = StringReverse("hello");
        Console.WriteLine(str);

        //string comparision
        StringCompare("hello", "helloo");
        StringCompare("halo", "helloo");
        StringCompare("Hello", "hello");
        StringCompare("hello", "hello");

        // max and min in aaray
        int[] array = { 11, 2, 33, 44 };
        MaxMin(array);

        //find element in array
        int res = FindElement(array, 22);
        Console.WriteLine(res);
    }

    public static string StringReverse(string str)
    {
        string temp = "";
        for(int i = str.Length-1; i>=0; i--)
        {
            temp = temp + str[i];
        
        }
        return temp;
    }

    public static void StringCompare(string str1, string str2)
    {
        if(str1.Length != str2.Length) 
        {
            Console.WriteLine("Strings are not same");
        }
        else
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            for(int i = 0 ; i < str1.Length; i++)
            {
                if (str1[i] != str2[i]) 
                {
                    Console.WriteLine("Strings are not same.");
                    return;
                }
            }
            Console.WriteLine("Strings are equal");
        }
    }


    public static void MaxMin(int[] array)
    {
        if(array.Length <=0) 
        {
            Console.WriteLine("array is empty");
            return;
        }
        int max = array[0];
        int min = array[0];
        for(int i = 0 ; i<array.Length; i++)
        {
            if(max < array[i])
            {
                max = array[i];
            }
            if(min > array[i])
            {
                min = array[i];
            }
        }
        Console.WriteLine($"max value is {max} and min value is {min}");
    }

    public static int FindElement(int[] arr, int num)
    {
        int temp = -1;
        for(int i =0 ; i<arr.Length; i++)
        {
            if (arr[i] == num)
            {
                temp = i;
                break;
            }

        }
        return temp;
    }
}