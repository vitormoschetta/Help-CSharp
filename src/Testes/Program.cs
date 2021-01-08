using System;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(1,5);
            var pointB = new Point(1,5);   
            
            Console.WriteLine(Equals(point, point));
            Console.WriteLine(Equals(point, pointB));

            // Equal retorna true na comparação de dois objetos caso a instância seja a mesma

            Console.WriteLine(point.Igual(pointB));
        }
    }

    class Point
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        protected int x, y;

        public bool Igual(Point other)
        {
            if (x == other.x && y == other.y)
                return true;
            
            return false;
        }

    }
}
