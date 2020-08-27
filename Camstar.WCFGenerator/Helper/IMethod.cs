// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.IMethod
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

namespace Camstar.WCF.Generator.Helper
{
  public interface IMethod
  {
    ExposedMethodStateType ExposedState { get; set; }

    string Description { get; }

    string Name { get; }

    bool IsInherited { get; }
  }
}
