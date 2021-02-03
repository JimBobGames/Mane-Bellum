using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManeBellum.Core.Data;
using ManeBellum.Core.Engines;
using ManeBellum.Core.Persistence;

namespace ManeBellum.Test
{
    [TestClass]
    public class TurnResolutionTest
    {
        [TestMethod]
        public void TestSingleTurnResolution()
        {
            ManeBellumGame game = GameLoader.CreateGame();
            TurnResolutionEngine turnEngine = new TurnResolutionEngine
            {
                Game = game
            };

            // run one turn 
            turnEngine.ResolveTurn();

            game.GameEventLog.DisplayEvents(game);
        }
    }
}
