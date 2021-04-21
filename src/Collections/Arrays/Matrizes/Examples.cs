namespace List_Array.Matrizes
{
    public class Examples
    {
        public void ex()
        {
            // Matriz bidimensional de 4 linhas e 2 colunas
            int[,] array2Da = new int[4, 2];
            array2Da = new int[4, 2] {
                                        { 1, 2 },
                                        { 3, 4 },
                                        { 5, 6 },
                                        { 7, 8 }
                                    };

            // Matriz bidimensional de linhas e colunas n
            int[,] array2Db = new int[,] {
                                            { 1, 2 },
                                            { 3, 4 },
                                            { 5, 6 },
                                            { 7, 8 }
                                        };

            // Matriz bidimensional de string
            string[,] array2Dc = new string[3, 2] {
                                                    { "one", "two" },
                                                    { "three", "four" },
                                                    { "five", "six" }
                                                };


            // Matriz tridimensional de n
            int[,,] array3D = new int[,,] {
                                            {
                                                { 1, 2, 3 },
                                                { 4, 5, 6 } },
                                            {
                                                { 7, 8, 9 },
                                                { 10, 11, 12 }
                                            }
                                        };


            // Matriz tridimensional com 
            int[,,] array3Da = new int[2, 2, 3] {
                                                    {
                                                        { 1, 2, 3 },
                                                        { 4, 5, 6 }
                                                    },
                                                    {
                                                        { 7, 8, 9 },
                                                        { 10, 11, 12 }
                                                    }
                                                };
        }
    }
}