using MyExtensions;
using System;
using System.Text;


namespace Extension_Methods_Delegates_Lambda_LINKQ.Tests
{
    public static class StringBuilderTest
    {
        public static void Test()
        {
            var testSB = new StringBuilder("Some testing text for the stringbuilder extensions");
            Console.WriteLine("--- Testing StringBuilder Extennsions ---");
            Console.WriteLine(testSB.Substring(0,12));
            Console.WriteLine(testSB.Substring(12));
        }
    }
}
