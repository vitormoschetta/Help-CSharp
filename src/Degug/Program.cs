﻿using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Degug
{  
    class Program
    {
        static void Main(string[] args)
        {
            var flow = new FileStream("EmissaoDare.pdf", FileMode.Open);
            var buffer = new byte[1024]; // 1kb
            var readBytes = -1; 

            while (readBytes != 0)
            {
                readBytes = flow.Read(buffer, 0, 10);
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
