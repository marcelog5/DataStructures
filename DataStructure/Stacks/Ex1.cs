namespace DataStructure.Stacks
{
    public static class Ex1
    {
        private static string Input = "[";

        public static void Execute()
        {
            IsValid(Input);
        }

        private static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };

            foreach (char c in s)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != bracketPairs[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

    }
}
