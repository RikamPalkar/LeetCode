namespace Solution
{
    public class Program
    {
        static public void Main()
        {
            // Brute force: Time Complexity: O(n^2), Space complexity: O(1) 
            // ({ 2, 7, 11, 15 }, 9);
            // ({ 3, 2, 4 }, 6);
            // ({ 3, 3 }, 6);
            int[] resultOfBruteForce = TwoSumBruteForce(new int[] { 0, 4, 3, 0 }, 0);
            Console.WriteLine("------------------ BruteForce Solution ------------------");
            Console.WriteLine("--------- Time Complexity: O(n^2), Space complexity: O(1)  ---------");
            Console.WriteLine(string.Join(" ", resultOfBruteForce));

            Console.WriteLine();

            // Using a Dictionary: Time Complexity: O(n), Space complexity: O(n) 
            // ({ 2, 7, 11, 15 }, 9);
            // ({ 3, 2, 4 }, 6);
            // ({ 3, 3 }, 6);
            int[] resultOfOptimized = TwoSumOptimized(new int[] { 1, 1, 2, 1, 1, 2 }, 4);
            Console.WriteLine("------------------ Optimized Solution ------------------");
            Console.WriteLine("--------- Time Complexity: O(n), Space complexity: O(n)   ---------");
            Console.WriteLine(string.Join(" ", resultOfOptimized));
        }

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n) 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns>
        private static int[] TwoSumOptimized(int[] nums, int target)
        {
            //Declarations
            int arrayLength = nums.Length;
            Dictionary<int, int> resultDictionary = new();

            //Validations
            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }

            //Logic
            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] { index, i };
                }

                //resultDictionary.Add(firstNumber, i);
                resultDictionary[firstNumber] = i;
            }

            return Array.Empty<int>(); ;
        }


        /// <summary>
        /// Brute force: Time Complexity: O(n^2), Space complexity: O(1) 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns>
        private static int[] TwoSumBruteForce(int[] nums, int target)
        {
            //Declarations
            int arrayLength = nums.Length;

            //Validations
            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }

            //Logic
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return Array.Empty<int>();
        }
    }
}