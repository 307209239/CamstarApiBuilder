// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.IService
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Collections.Generic;

namespace Camstar.WCF.Generator.Helper
{
  public interface IService
  {
    ExposedServiceStateType ExposedState { get; set; }

    List<IService> Children { get; }

    IService FindChild(string name);

    List<IMethod> Methods { get; }

    string Name { get; }

    string Description { get; }

    bool IsParent { get; }
  }
}
