using System;
using System.Collections.Concurrent;


namespace Camstar.Api.Utility
{
  public class ServerConnectionPool
  {
    private readonly ConcurrentStack<ServerConnection> _ConnCache = new ConcurrentStack<ServerConnection>();

    public ServerConnectionPool()
    {
      
    }

  

    public ServerConnection GetServerConnection(out bool fromCache)
    {
      ServerConnection result = (ServerConnection) null;
      fromCache = this._ConnCache.TryPop(out result);
      if (!fromCache)
        result = new ServerConnection();
      return result;
    }

    public void ReleaseServerConnection(ServerConnection conn)
    {
      this._ConnCache.Push(conn);
    }
  }
}
