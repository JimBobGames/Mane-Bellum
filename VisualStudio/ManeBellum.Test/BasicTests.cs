using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManeBellum.Core;
using SACD = ManeBellum.Core.Data;
using SACP = ManeBellum.Core.Persistence;
using ManeBellum.Core.Util;

namespace ManeBellum.Test
{
    [TestClass]
    public class BasicTests
    {
        private SACD.ManeBellumGame game = null;

        [TestMethod]
        public void TestUnityDll()
        {
            Console.WriteLine(MyUtilities.GenerateRandom(0, 100));
        }

        [TestInitialize()]
        public void Initialize()
        {
            game = SACP.GameLoader.CreateGame(); //new MBCD.MariBellumGame();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            game = null;
        }

        [TestMethod]
        public void TestReferenceDataLoading()
        {
            Assert.IsNotNull(game, "Test Game is null");
            Assert.IsTrue(game.GunData.Count > 0, "No gun reference data loaded");
        }
    }
}
