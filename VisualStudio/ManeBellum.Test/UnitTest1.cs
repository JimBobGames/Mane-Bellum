using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManeBellum.Core;

namespace ManeBellum.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUnityDll()
        {
            Console.WriteLine(MyUtilities.GenerateRandom(0, 100));
        }
    }
}
