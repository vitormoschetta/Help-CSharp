using System;
using System.Collections.Generic;

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


            Console.WriteLine(array2D[0, 0]); // <-- print 11
            Console.WriteLine(array2D[1, 1]); // <-- print 5
            Console.WriteLine(array2D[2, 2]); // <-- print -12

            foreach (var item in array2D)
            {
                Console.WriteLine(item); // <-- print all
            }

            Console.WriteLine(array2D.Length); //<-- print the number of element



            // Matriz de coleção de lista:
            List<List<int>> arr = new List<List<int>>(){
                                            new List<int>() { 11, 2,  4  },
                                            new List<int>() {  4, 5,  6  },
                                            new List<int>() { 10, 8, -12 },
                                        };

            // Duas formas de iterar:

            foreach (var item in arr)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.WriteLine(item[i]);
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
        }

    }
}
