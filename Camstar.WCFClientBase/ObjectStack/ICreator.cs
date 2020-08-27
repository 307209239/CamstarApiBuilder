// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ICreator
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

namespace Camstar.WCF.ObjectStack
{
  public interface ICreator
  {
    void SetValue(string fieldPath, object value);

    void ReplaceValue(string fieldPath, object value);

    object GetValue(string fieldPath);
  }
}
