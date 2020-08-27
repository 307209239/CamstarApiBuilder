// Decompiled with JetBrains decompiler
// Type: Camstar.Utility.ServerConnectionPool
// Assembly: Camstar.Utility, Version=7.8.7004.31020, Culture=neutral, PublicKeyToken=null
// MVID: AF6B540D-12F7-4E34-9655-933F6DAB67E3
// Assembly location: E:\WCFServicesGenerator\Camstar.Utility.dll

using System;
using System.Collections.Concurrent;

namespace Camstar.Utility
{
  public class ServerConnectionPool
  {
    private readonly ConcurrentStack<ServerConnection> _ConnCache = new ConcurrentStack<ServerConnection>();

    public ServerConnectionPool()
    {
      ServerConnectionSettings.ConfigFileChanged += new EventHandler(this.OnConfigFileChanged);
    }

    private void OnConfigFileChanged(object sender, EventArgs e)
    {
      this._ConnCache.Clear();
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
      if (ServerConnectionSettings.CurrentChangeNumber != conn.Settings.ChangeNumber)
        return;
      this._ConnCache.Push(conn);
    }
  }
}
