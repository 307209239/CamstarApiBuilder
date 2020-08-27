// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.MethodElementCollection
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Configuration;

namespace Camstar.WCF.Generator.Helper
{
  public class MethodElementCollection : ConfigurationElementCollection
  {
    public void Add(MethodElement myElement)
    {
      this.BaseAdd((ConfigurationElement) myElement);
    }

    public MethodElement Get(string name)
    {
      return this.BaseGet((object) name) as MethodElement;
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return (ConfigurationElement) new MethodElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return (object) (element as MethodElement).Name;
    }
  }
}
