using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void replaceNumbersWithPingPong()
    {
      Game testGame = new Game();
      Assert.AreEqual("ping-pong", testGame.replaceNumbersWithPingPong(15));
    }
    [TestMethod]
    public void replaceNumbersWithPingPong_3()
    {
      Game testGame = new Game();
      Assert.AreEqual("pong", testGame.replaceNumbersWithPingPong(5));
    }
    [TestMethod]
    public void replaceNumbersWithPingPong_2()
    {
      Game testGame = new Game();
      Assert.AreEqual("ping", testGame.replaceNumbersWithPingPong(3));
    }
    [TestMethod]
    public void replaceNumbersWithPingPong_4()
    {
      Game testGame = new Game();
      Assert.AreEqual("2",testGame.replaceNumbersWithPingPong(2));
    }
  }
}
