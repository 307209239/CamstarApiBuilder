// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.ConnectionStringItem
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using System.ComponentModel;

namespace Camstar.WCF.Builder
{
  [DefaultProperty("Name")]
  public class ConnectionStringItem
  {
    private string mName = string.Empty;
    private string mValue = string.Empty;

    [Category("Connection String")]
    [Description("Connection String name.")]
    public string Name
    {
      get
      {
        return this.mName;
      }
      set
      {
        this.mName = value;
      }
    }

    [Category("Connection String")]
    [Description("Connection String value.")]
    public string Value
    {
      get
      {
        return this.mValue;
      }
      set
      {
        this.mValue = value;
      }
    }

    public ConnectionStringItem()
    {
    }

    public ConnectionStringItem(string name, string value)
    {
      this.mName = name;
      this.mValue = value;
    }
  }
}
