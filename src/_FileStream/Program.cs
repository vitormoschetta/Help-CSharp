using System;
using System.IO;

namespace _FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            var flow = new FileStream("contas.txt", FileMode.Open);
            var buffer = new byte[1024]; // 1kb
            var readBytes = -1; 

            while (readBytes != 0)
            {
                readBytes = flow.Read(buffer, 0, 1024);
                WriteBuffer(buffer);
            }

        }

        static void WriteBuffer(byte[] buffer)
        {
            foreach (var item in buffer)
            {
                Console.Write(item + " ");
            }
        }
    }
}
