using System;
using System.Collections.Generic;

namespace _Queue
{
    class Program
    {
        static Queue<string> queueOne = new Queue<string>();
        static Queue<string> queueTwo = new Queue<string>();
        static Queue<string> queuesBackup;
        static void Main(string[] args)
        {
            SetQueueOne();
            SetQueueTwo();
            SetQueuesBackup();
        
            Console.WriteLine("\nqueueCopy.Count = " + queuesBackup.Count);

            queuesBackup.Clear();
        }

        static void SetQueueOne()
        {
            queueOne.Enqueue("one");
            queueOne.Enqueue("two");
            queueOne.Enqueue("three");
            queueOne.Enqueue("four");
            queueOne.Enqueue("five");
        }

        static void SetQueueTwo()
        {
            queueTwo.Enqueue("six");
            queueTwo.Enqueue("seven");
            queueTwo.Enqueue("eight");
            queueTwo.Enqueue("nine");
            queueTwo.Enqueue("ten");
        }

        static void SetQueuesBackup()
        {
            string[] array = new string[10];
            queueOne.CopyTo(array, 0);
            queueTwo.CopyTo(array, 5);

            queuesBackup = new Queue<string>(array);            
        }
    }
}
