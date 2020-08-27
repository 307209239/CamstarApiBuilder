// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.ConnectionStringElementCollection
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class ConnectionStringElementCollection : ConfigurationElementCollection
  {
    public void Add(ConnectionStringElement myElement)
    {
      this.BaseAdd((ConfigurationElement) myElement);
    }

    public ConnectionStringElement Get(string name)
    {
      return this.BaseGet((object) name) as ConnectionStringElement;
    }

    public void Remove(string name)
    {
      this.BaseRemove((object) name);
    }

    public void Clear()
    {
      this.BaseClear();
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return (ConfigurationElement) new ConnectionStringElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return (object) (element as ConnectionStringElement).Name;
    }
  }
}
