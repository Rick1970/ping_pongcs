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
    public static bool Calculate()
    {
      return false;
    }
  }
}
