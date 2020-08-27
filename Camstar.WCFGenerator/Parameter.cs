// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Parameter
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

namespace Camstar.WCF.Generator
{
  internal class Parameter
  {
    protected string name;

    public Parameter(string name)
    {
      this.name = name;
    }

    public string Name
    {
      get
      {
        return this.name;
      }
    }
  }
}
