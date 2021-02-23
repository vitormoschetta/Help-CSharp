using System.Collections.Generic;

namespace Yield
{
    public class Repository
    {
        private int[] list = new int[200];
        public Repository()
        {
            for (int i = 0; i < 200; i++)
            {
                list[i] = i;
            }
        }

        public int Count()
        {
            return list.Length;
        }


        // neste método preenchemos a lista e retornamos ela de uma só vez
        public IEnumerable<int> Get01()
        {
            int[] list = new int[200];

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i;                                
            }

            return list;            
        }    


        // neste método retornamos a lista gradualmente, linha por linha
        public IEnumerable<int> Get02()
        {            
            for (int i = 0; i < list.Length; i++)
            {                
                yield return list[i];
            }                    
        }    



    }
}