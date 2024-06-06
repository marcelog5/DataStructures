namespace DataStructure.Hashs
{
    public static class TwoSum
    {
        private static int[] input = new int[] { 3, 4, 5, 6 };
        private static int target = 9;

        public static void Execute() 
        { 
            int[] output = TwoSumSolution(input, target);
        }

        private static int[] TwoSumSolution(int[] nums, int target) 
        {
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numToIndex.ContainsKey(complement))
                {
                    return new int[] { numToIndex[complement], i };
                }
                if (!numToIndex.ContainsKey(nums[i]))
                {
                    numToIndex.Add(nums[i], i);
                }
            }

            return new int[0];
        }
    }
}
