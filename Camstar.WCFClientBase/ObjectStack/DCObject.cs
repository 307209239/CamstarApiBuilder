// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DCObject
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public abstract class DCObject : WCFObjectBase
  {
    [DataMember(EmitDefaultValue = false, Name = "FieldAction")]
    public Action? FieldAction { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "IgnoreTypeDifference")]
    public bool? IgnoreTypeDifference { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ListItemAction")]
    public Camstar.WCF.ObjectStack.ListItemAction? ListItemAction { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ListItemIndex")]
    public int? ListItemIndex { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Key")]
    public NamedObjectRef Key { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "CDOTypeName")]
    public string CDOTypeName { get; set; }

    public override bool Equals(object obj)
    {
      return true;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
