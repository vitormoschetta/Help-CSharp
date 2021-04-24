using System;
using System.Collections.Generic;

namespace _Queue
{
    public class QueuesBackup
    {
        private Queue<string> queueOne;
        private Queue<string> queueTwo;
        private static Queue<string> queuesBackup;
        public QueuesBackup()
        {
            queueOne = new Queue<string>();
            queueTwo = new Queue<string>();
            queuesBackup = new Queue<string>();
        }

        public void Execute()
        {
            SetQueueOne();
            SetQueueTwo();
            SetQueuesBackup();
        }

        public Queue<string> GetQueueBackup()
        {
            return queuesBackup;
        }

        public string DequeueBackupGetValue()
        {
            return queuesBackup.Dequeue();
        }

        private void SetQueueOne()
        {
            queueOne.Enqueue("one");
            queueOne.Enqueue("two");
            queueOne.Enqueue("three");
            queueOne.Enqueue("four");
            queueOne.Enqueue("five");
        }

        private void SetQueueTwo()
        {
            queueTwo.Enqueue("six");
            queueTwo.Enqueue("seven");
            queueTwo.Enqueue("eight");
            queueTwo.Enqueue("nine");
            queueTwo.Enqueue("ten");
        }

        private void SetQueuesBackup()
        {
            string[] array = new string[10];
            queueOne.CopyTo(array, 0);
            queueTwo.CopyTo(array, 5);

            queuesBackup = new Queue<string>(array);
        }


    }
}