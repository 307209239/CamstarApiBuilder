// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PELabelMapChanges
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
  public class PELabelMapChanges : LabelTxnMapChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PELabelMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PELabelMapChanges_TxnType")]
    protected new Primitive<int> _TxnType;

    public override bool Equals(object obj)
    {
      return obj is PELabelMapChanges && object.Equals((object) this._ObjectToChange, (object) ((PELabelMapChanges) obj)._ObjectToChange) && object.Equals((object) this._TxnType, (object) ((PELabelMapChanges) obj)._TxnType) && base.Equals(obj);
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
