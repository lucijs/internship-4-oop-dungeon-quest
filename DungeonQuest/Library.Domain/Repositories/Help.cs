namespace Library.Domain.Repositories
{
    public static class Help
    {
        public static double RandomNumber(int scale)
        {
            var randomNumberGenerator = new Random();
            return randomNumberGenerator.NextDouble()*scale;
        }

        public static int RandomNumber()
        {
            var randomNumberGenerator = new Random();
            return randomNumberGenerator.Next(1,101);
        }

       
    }
}
