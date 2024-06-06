namespace DataStructure.Stacks
{
    public class MinStack
    {
        private string[] input = new string[] { "MinStack", "push", "1", "push", "2", "push", "0", "getMin", "pop", "top", "getMin" };
        private Stack<int> stack { get; set;}
        private Stack<int> minStack { get; set; }

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Execute()
        {
            for (int i = 0; i < input.Length; i++)
            {
                string command = input[i];

                switch (command)
                {
                    case "push":
                        int value = int.Parse(input[++i]);
                        Push(value);
                        break;
                    case "pop":
                        Pop();
                        break;
                    case "getMin":
                        GetMin();
                        break;
                    case "top":
                        Top();
                        break;
                    case "MinStack":
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                }
            }
        }

        public void Push(int val)
        {
            stack.Push(val);

            if ( minStack.Count == 0 || val <= minStack.Peek() )
            {
                minStack.Push(val);
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            
            if (stack.Peek() == minStack.Peek())
            {
                minStack.Pop();
            }
                
            return stack.Pop();
        }

        public int Top()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return stack.Peek();
        }

        public int GetMin()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return minStack.Peek();
        }
    }
}
