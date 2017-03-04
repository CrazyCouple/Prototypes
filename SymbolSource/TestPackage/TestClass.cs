using System;

namespace TestPackage
{
    public class TestClass
    {
        public void TestMethod(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                TestMethodPrivate("The string is empty!!!");
            }
            else
            {
                TestMethodPrivate(input);
            }
        }

        private static void TestMethodPrivate(string input)
        {
            Console.WriteLine(input);
        }
    }
}
