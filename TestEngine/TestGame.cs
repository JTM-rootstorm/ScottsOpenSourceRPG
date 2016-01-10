using Microsoft.VisualStudio.TestTools.UnitTesting;

using Engine;

namespace TestEngine
{
    [TestClass]
    public class TestGame
    {
        [TestMethod]
        public void TestNewGame()
        {
            Game game = new Game("MyGame", "Scott's Open Source C# RPG", "https://github.com/ScottLilly/ScottsOpenSourceRPG", 1, 2, "Scott Lilly", 1999);

            Assert.AreEqual("MyGame", game.Name);
            Assert.AreEqual("1.2", game.CurrentVersion.ToString());
        }
    }
}
