// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.Helper.MethodComparer
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using System.Collections.Generic;

namespace Camstar.WCF.Generator.Helper
{
  internal class MethodComparer : Comparer<IMethod>
  {
    public override int Compare(IMethod x, IMethod y)
    {
      return string.Compare(x.Name, y.Name);
    }
  }
}
