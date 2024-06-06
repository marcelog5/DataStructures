namespace DataStructure.Trees
{
    public class Tree
    {
        public Node _root { get; set; }

        public Tree
        (
            Node root
        )
        {
            _root = root;
        }

        public void Initiate(int[] values)
        {
            _root = Insert(_root, values[0]);
            Node node = _root;

            foreach (var value in values.Skip(1))
            {
                node = Insert(node, value);
            }
        }

        private Node Insert(Node node, int value)
        {
            if (node == null)
            {
                node = new Node();
                node.value = value;

                return node;
            }

            if (node.value >= value)
            {
                node.left = Insert(node.left, value);
            }
            else
            {
                node.right = Insert(node.right, value);
            }

            return node;
        }

        public Node Revert(Node node)
        {
            if (node == null)
            {
                return node;
            }

            Node temp = node.left;
            node.left = node.right;
            node.right = temp;

            Revert(node.left);
            Revert(node.right);

            return node;
        }

        public int GetDepth()
        {
            return GetDepthWithDFSRecursion(_root);
        }

        private int GetDepthWithDFSRecursion(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetDepthWithDFSRecursion(root.left), GetDepthWithDFSRecursion(root.right));
        }

        private int GetDepthWithBFSIterative(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            int depth = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                depth++;
            }

            return depth;
        }

        private int GetDepthWithDFSIterative(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            Stack<Tuple<Node, int>> stack = new Stack<Tuple<Node, int>>();
            stack.Push(new Tuple<Node, int>(root, 1));
            int res = 1;

            while (stack.Count > 0)
            {
                Tuple<Node, int> nodePair = stack.Pop();

                if (nodePair.Item1 != null)
                {
                    res = Math.Max(nodePair.Item2, res);
                    stack.Append(new Tuple<Node, int>(root.left, nodePair.Item2 + 1));
                    stack.Append(new Tuple<Node, int>(root.right, nodePair.Item2 + 1));
                }
            }

            return res;
        }
    }
}
