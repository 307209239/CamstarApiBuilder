// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerLabelMapChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerLabelMapChanges : LabelTxnMapChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerLabelMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLabelMapChanges_TxnType")]
    protected new Primitive<int> _TxnType;

    public override bool Equals(object obj)
    {
      return obj is ContainerLabelMapChanges && object.Equals((object) this._ObjectToChange, (object) ((ContainerLabelMapChanges) obj)._ObjectToChange) && object.Equals((object) this._TxnType, (object) ((ContainerLabelMapChanges) obj)._TxnType) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<int> TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnType));
      }
    }
  }
}
