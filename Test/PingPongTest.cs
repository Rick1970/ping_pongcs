using Xunit;
using System;

namespace PingPong.Objects
{
  public class PingPongGenerator
  {

  }
  public class PingTest : IDisposable
  {
    public void Dispose()
    {
      Ping.DeleteAll();
    }
    [Fact]
    public void Calculate_ReturnPingForThree_true()
    {
      Ping testPing = new Ping(3);
      Assert.Equal("ping", testPing.Calculate());
    }
    [Fact]
    public void Calculate_ReturnPongForFive_true()
    {
      Ping testPing = new Ping(5);
      Assert.Equal("pong", testPing.Calculate());
    }
    [Fact]
    public void Calculate_ReturnPingPongForFifteen_true()
    {
      Ping testPing = new Ping(15);
      Assert.Equal("ping-pong", testPing.Calculate());
    }
  }
}
