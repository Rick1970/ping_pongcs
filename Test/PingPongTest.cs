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
    public void Calculate_ReturnOneAfterInputOne_true()
    {

      Ping testPing = new Ping("1");
      Assert.Equal(true, testPing.Calculate());
    }
  }
}
