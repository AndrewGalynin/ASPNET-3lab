namespace Lab3
{
    public class CalcService
    {
        public int Add(int x, int y) 
        { 
            return x + y; 
        }
        public int Substraction(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new Exception("Divisior cannot be zero!");
            }
        }
    }
}
