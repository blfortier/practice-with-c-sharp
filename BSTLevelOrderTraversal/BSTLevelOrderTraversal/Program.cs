using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSTLevelOrderTraversal
{
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Solution
    {

        static void LevelOrder(Node root)
        {
            //Write your code here

            if (root == null)
                return;

            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count != 0)
            {
                var currentNode = nodeQueue.Dequeue();
                Console.Write(currentNode.data + " ");

                if (currentNode.left != null)
                    nodeQueue.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    nodeQueue.Enqueue(currentNode.right);
            }
        }
        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node curr;
                if (data <= root.data)
                {
                    curr = Insert(root.left, data);
                    root.left = curr;
                }
                else
                {
                    curr = Insert(root.right, data);
                    root.right = curr;
                }
                return root;
            }
        }

        class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = Insert(root, data);
            }
            LevelOrder(root);

        }
        }
    }
}
