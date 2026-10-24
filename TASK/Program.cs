namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    Console.WriteLine("Database connected successfully!");

                    Console.WriteLine("Books count: " + context.Books.Count());

                    Console.WriteLine("Authors count: " + context.Authors.Count());
                }

                Console.ReadKey();
            }
        }
    }
}
