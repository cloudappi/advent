namespace advent.Core
{
    public class Util
    {
        public static int random(int total)
        {
            Random rnd = new Random();
            return rnd.Next(0, total);
        }

    }
}
