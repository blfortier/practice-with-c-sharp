using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveDuplicateNodes
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    class Solution
    {
        public static Node RemoveDuplicates(Node head)
        {
            var current = head;
            var ahead = head.next;

            while (ahead != null)
            {
                if (current.data == ahead.data)
                {
                    current.next = ahead.next;
                    ahead = current.next;
                }
                else
                {
                    current = current.next;
                    ahead = ahead.next;
                }
            }

            return head;
        }

        public static Node Insert(Node head, int data)
        {
            var p = new Node(data);

            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }

            return head;
        }

        public static void Display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }

            Console.WriteLine();
        }

        class Program
        {
            static void Main(string[] args)
            {
                Node head = null;
                int T = Int32.Parse(Console.ReadLine());
                while (T-- > 0)
                {
                    int data = Int32.Parse(Console.ReadLine());
                    head = Insert(head, data);
                }
                head = RemoveDuplicates(head);
                Display(head);
            }
        }
    }
}
