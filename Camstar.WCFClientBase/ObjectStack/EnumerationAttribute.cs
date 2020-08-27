// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EnumerationAttribute
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;

namespace Camstar.WCF.ObjectStack
{
  [AttributeUsage(AttributeTargets.Field)]
  [Serializable]
  public class EnumerationAttribute : Attribute
  {
    public string _DefaultValue;

    public string DefaultValue
    {
      get
      {
        return this._DefaultValue;
      }
    }

    public EnumerationAttribute(string value)
    {
      this._DefaultValue = value;
    }
  }
}
