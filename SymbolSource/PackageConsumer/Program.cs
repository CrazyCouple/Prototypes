using TestPackage;

namespace PackageConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestClass();

            test.TestMethod("Hello");
        }
    }
}
