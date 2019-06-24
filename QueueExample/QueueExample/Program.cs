using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Attendee attendee1 = new Attendee()
            {
                Id = 1,
                Name = "John Doe"
            };

            Attendee attendee2 = new Attendee()
            {
                Id = 2,
                Name = "Sally Smith"
            };

            Attendee attendee3 = new Attendee()
            {
                Id = 3,
                Name = "Marshall Taylor"
            };

            List<Attendee> attendeeList = new List<Attendee>()
            {
                attendee1,
                attendee2,
                attendee3
            };

            foreach (var item in AddAttendeesToQueue(attendeeList))
            {
                Console.WriteLine("queue item: {0}", item.Id);
            }

            Queue<Attendee> queue = AddAttendeesToQueue(attendeeList);
            Console.WriteLine("Queue count: {0}", queue.Count);

            Attendee test = queue.Dequeue();
            Console.WriteLine("test name: {0}", test.Name);

            int itemsAfterDequeue = queue.Count;
            Console.WriteLine("Queue count after dequeue: {0}", itemsAfterDequeue);

        }

        public static Queue<Attendee> AddAttendeesToQueue(List<Attendee> attendees)
        {
            Queue<Attendee> attendeeQueue = new Queue<Attendee>();

            foreach (Attendee attendee in attendees)
            {
                attendeeQueue.Enqueue(attendee);
            }

            return attendeeQueue;
        }
    }
}
