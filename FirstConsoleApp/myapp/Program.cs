using System; //console class is in System Library.

namespace myapp //myapp is the name of the package/project
{
    class Program
    {
        public static string title = "Hello, This is Winston Lim.";
        private static int whichPart;
        static void Main(string[] args)
        {
            whichPart = 2;
            var message = string.Format("Welcome to {0} Part {1}-{3}!",title,whichPart);
            Console.WriteLine("Hello World!");
            Console.WriteLine(title);
            Console.WriteLine(message);
        }
    }
}
