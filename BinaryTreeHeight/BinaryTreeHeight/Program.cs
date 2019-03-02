using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeHeight
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
        static int getHeight(Node root)
        {
            if (root == null)
                return -1;

            int leftBranch = getHeight(root.left) + 1;
            int rightBranch = getHeight(root.right) + 1;

            return Math.Max(leftBranch, rightBranch);
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Node root = null;

                Console.Write("How many nodes in your tree? ");
                int T = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter an integer to be added to the tree on each of the subsequent lines: ");
                while (T-- > 0)
                {
                    var data = Console.ReadLine();
                    int number;
                    if (String.IsNullOrEmpty(data))
                    {
                        Console.Write("Please enter a number: ");
                        number = Int32.Parse(data);
                        root = insert(root, number);
                    }
                    else
                    {
                        number = Int32.Parse(data);
                    }

                    root = insert(root, number);
                }
                int height = getHeight(root);
                Console.WriteLine();
                Console.WriteLine("The height of the binary tree is {0}", height);
                }
            }
    }}
