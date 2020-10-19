﻿using System;

namespace List_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matriz bidimensional de 3 linhas e 3 colunas
            int[,] array2D = new int[3, 3] {
                                        { 11, 2, 4  },
                                        {  4, 5, 6  },
                                        { 10, 8, -12 },
                                    };


            System.Console.WriteLine(array2D[0, 0]); // <-- print 11
            System.Console.WriteLine(array2D[1, 1]); // <-- print 5
            System.Console.WriteLine(array2D[2, 2]); // <-- print -12

            foreach (var item in array2D)
            {
                System.Console.WriteLine(item); // <-- print all
            }
        }

    }
}
