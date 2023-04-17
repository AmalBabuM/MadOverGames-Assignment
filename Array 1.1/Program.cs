namespace Practice2
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            int[] arr = { -7, -5, 4, 5, 6 };
            int[] arr2 = { -7, -3, 4, 6, 10, 15 };
            Program.SumFind(arr);
        }

        static void SumFind(int[] arr) //Time complexity => O(n^2)
        {
            bool found = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == 0)
                    {
                        found = true;
                        Console.WriteLine("True: There are numbers whose sum is 0");
                        break;
                    }
                }

            }
            if (!found)
            {
                Console.WriteLine("False: There are No such numbers whose sum is 0");
            }
        }
    }

}