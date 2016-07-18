using Xunit;
namespace PingPong
{
  public class PingPongTest
  {

  }
  public class PongTest : IDisposable
  {
    public void Dispose()
    {
      Task.DeleteAll();
    }
  }
}
