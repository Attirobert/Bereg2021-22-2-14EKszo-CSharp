using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string vartEredm = "Hello World!";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloVilag.Program.Main();
            }
        }
    }
}
