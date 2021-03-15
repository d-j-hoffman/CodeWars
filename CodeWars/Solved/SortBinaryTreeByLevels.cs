using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Solved
{
    class SortBinaryTreeByLevels
    {
        public class Node
        {
            public Node Left;
            public Node Right;
            public int Value;

            public Node(Node l, Node r, int v)
            {
                Left = l;
                Right = r;
                Value = v;
            }
        }
        public static List<int> TreeByLevels(Node node)
        {
            List<int> returnList = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            if (node != null)
                queue.Enqueue(node);
            while (queue.Count != 0)
            {
                Node front = queue.Dequeue();
                returnList.Add(front.Value);
                if (front.Left != null)
                    queue.Enqueue(front.Left);
                if (front.Right != null)
                    queue.Enqueue(front.Right);
            }

            return returnList;
        }
    }
}
