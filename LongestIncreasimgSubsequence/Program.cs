using System;

namespace LongestIncreasimgSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Increasing Subsequence in an array!");
            Console.WriteLine("--------------------------------------------");

            try
            {
                Console.WriteLine("Enter the number of elements!");
                int noOfElements = int.Parse(Console.ReadLine());
                int[] array = new int[noOfElements];
                Console.WriteLine("Enter the elements separated by space");
                string elementsString = Console.ReadLine();

                string[] elements = elementsString.Split(' ');
                for (int i = 0; i < elements.Length; i++)
                {
                    array[i] = int.Parse(elements[i]);
                }

                int longestIncresingSubsequence = GetLIS(array);

                Console.WriteLine("----------------Result--------------");
                Console.WriteLine("The longest increasing subsequence is " + longestIncresingSubsequence);
                Console.ReadKey();


            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }
            
        }

        private static int GetLIS(int[] array) {
            int[] lis = new int[array.Length];

            for (int i = 0; i < array.Length; i++) {
                lis[i] = 1;
            }

            for (int i = 1; i < array.Length; i++) {
                for (int j = 0; j < i; j++) {
                    if (array[i] > array[j] && lis[i] < lis[j] +1) {
                        lis[i] = lis[j] + 1;
                    }
                }
            }

            int max = int.MinValue;
            for (int i = 0; i < lis.Length; i++) {
                if (max < lis[i]) {
                    max = lis[i];
                }
            }
            return max;
        }
    }
}
