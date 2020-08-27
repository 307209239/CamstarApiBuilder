// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Info
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Info : WCFObjectBase
  {
    [DataMember(EmitDefaultValue = false, Name = "RequestValue")]
    public bool RequestValue { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "RequestSelectionValues")]
    public bool RequestSelectionValues { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "RequestSelectionValuesInfo")]
    public SelectionValuesInfo RequestSelectionValuesInfo { get; set; }

    public override bool IsEmpty
    {
      get
      {
        return base.IsEmpty && !this.RequestValue && !this.RequestSelectionValues;
      }
    }

    public Info()
    {
    }

    public Info(bool requestValue)
    {
      this.RequestValue = requestValue;
    }

    public Info(bool requestValue, bool requestSelectionValues)
      : this(requestValue)
    {
      this.RequestSelectionValues = requestSelectionValues;
    }
  }
}
