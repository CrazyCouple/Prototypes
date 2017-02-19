namespace ClassicConsole
{
    class Program
    {
        static void Main()
        {
            var lib = new CoreLib.Lib();

            System.Console.WriteLine(lib.Hello("Mr. Noris"));
            System.Console.ReadKey();
        }
    }
}
