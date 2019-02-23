using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedLists
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

    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public static void display(Node head)
        {
            Node start = head;

            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
                return head = new Node(data);
            else
            {
                var current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = new Node(data);
            }
            return head;
        }


    }
}
