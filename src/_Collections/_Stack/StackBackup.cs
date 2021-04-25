using System.Collections.Generic;

namespace _Stack
{
    public class StackBackup
    {
        private Stack<string> stackOne;
        private Stack<string> stackTwo;
        private static Stack<string> stackBackup;
        public StackBackup()
        {
            stackOne = new Stack<string>();
            stackTwo = new Stack<string>();
            stackBackup = new Stack<string>();
        }

        public void Execute()
        {
            SetstackOne();
            SetstackTwo();
            SetstackBackup();
        }

        public Stack<string> GetQueueBackup()
        {
            return stackBackup;
        }

        public string DequeueBackupGetValue()
        {
            return stackBackup.Pop();
        }

        private void SetstackOne()
        {
            stackOne.Push("one");
            stackOne.Push("two");
            stackOne.Push("three");
            stackOne.Push("four");
            stackOne.Push("five");
        }

        private void SetstackTwo()
        {
            stackTwo.Push("six");
            stackTwo.Push("seven");
            stackTwo.Push("eight");
            stackTwo.Push("nine");
            stackTwo.Push("ten");
        }

        private void SetstackBackup()
        {
            string[] array = new string[10];
            stackOne.CopyTo(array, 0);
            stackTwo.CopyTo(array, 5);

            stackBackup = new Stack<string>(array);
        }
    }
}