namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            var createUser = user.Run();

            Console.WriteLine(createUser.Age);

        }
    }
}
