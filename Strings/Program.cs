public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Helloooo");

        TraverseString("Cheeku");

        string result = ReverseString("Cheeku");
        Console.WriteLine(result);

        bool comp = CompareString("Cheeku", "cheeku");
        Console.WriteLine(comp);
    }


    public static string ReverseString(string str)
    {
        // hello -> olleh
        string reversedStr = "";

        for(int index = str.Length-1; index>=0; index--)
        {
            reversedStr = reversedStr + str[index];
        }

        return reversedStr;


    }

    public static bool CompareString(string str1, string str2)
    {
        str1 = str1.ToLower();
        str2 = str2.ToLower();
        // hello==hello -> true
        // str1 len == str2 len -> proceed further
        // assume string is equal -> isEqual = true
        // str1[0] == str2[0]
        // str1[1] == str2[1] -> isEqual=false if not matched break
        // return isEqual

        if( str1.Length == str2.Length)
        {
            bool isEqual = true;
            for (int index = 0; index <= str1.Length; index++)
            {
                if (str1[index] != str2[index])
                {
                    isEqual = false;
                    break;
                }
            }
            return isEqual;

        }
        else
        {
            return false;
        }
    }

    public static bool CheckSubstring(string source, string str)
    {

        // "hello world", "llo" -> true
        return true;
    }


    public static void TraverseString(string str)
    {
        // string = array of char
        // char[] name = { 'c', 'h', 'e', 'k', 'u' };
        // string naam = "cheeku";
        // name[2] -> e
        // naam[0] -> c

        for(int index = 0; index <str.Length; index++)
        {
            Console.WriteLine(str[index]);
        }


    }

}

// case comparision