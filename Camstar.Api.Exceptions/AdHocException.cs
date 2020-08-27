// Decompiled with JetBrains decompiler
// Type: Camstar.Exceptions.AdHocException
// Assembly: Camstar.Exceptions, Version=7.8.7004.31019, Culture=neutral, PublicKeyToken=null
// MVID: DCD1F3EE-20E6-4307-A2E0-3C6DF5B436BE
// Assembly location: E:\WCFServicesGenerator\Camstar.Exceptions.dll

namespace Camstar.Api.Exceptions
{
  public class AdHocException : CamstarException
  {
    private string mMessage = string.Empty;
    private string mId = string.Empty;
    private string mKey = string.Empty;

    public AdHocException(string id, string message)
    {
      this.mId = id;
      this.mMessage = message;
      this.mKey = this.GetType().Name;
    }

    public AdHocException(string id, string key, string message)
    {
      this.mId = id;
      this.mMessage = message;
      this.mKey = key;
    }

    public override string Message
    {
      get
      {
        return this.mMessage;
      }
    }

    public override string Id
    {
      get
      {
        return this.mId;
      }
    }

    public override string Key
    {
      get
      {
        return this.mKey;
      }
    }
  }
}
