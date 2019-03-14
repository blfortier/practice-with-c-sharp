using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class ListNode<T>
        {
            public T value { get; set; }
            public ListNode<T> next { get; set; }
        }

        public ListNode<int> removeKFromList(ListNode<int> l, int k)
        {

            if (l == null)
                return l;

            l.next = removeKFromList(l.next, k);

            if (l.value == k)
                return l.next;

            return l;
        }
    }

    

}
