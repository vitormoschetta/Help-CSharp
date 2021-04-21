namespace _Equal
{   
    public class Objeto
    {
        public Objeto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        protected int x, y;

        public bool Igual(Objeto other)
        {
            if (x == other.x && y == other.y)
                return true;

            return false;
        }

    }
}