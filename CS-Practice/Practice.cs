namespace CS_Practice
{
    public class Practice
    {
        public static void Main(String[] arg)
        {
            //Program.AddNum(12, 23);

            //array
            //string

            // declare empty array
            int[] arr = new int[12];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;

            // declare and initialize array
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int index=0;index<numbers.Length;index++)
            {
                Console.WriteLine(numbers[index]);
            }
            int[] MyArray = { 647, 43, 54, 2, 34, 43, 345 };
            ReverseArray(MyArray);

            string word = "my name is cheeku";
            for(int index = 0; index<word.Length;index++)
            {
                Console.WriteLine(word[index]);
            }


        }

        public static void ReverseArray(int[] array)
        {
            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.WriteLine(array[index]);
            }
               
        }

    }
}
