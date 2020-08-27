// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldStatusTxn
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
  public class HoldStatusTxn : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxn_HoldReason")]
    protected NamedObjectRef _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxn_CurrentHoldCount")]
    protected Primitive<int> _CurrentHoldCount;

    public override bool Equals(object obj)
    {
      return obj is HoldStatusTxn && object.Equals((object) this._HoldReason, (object) ((HoldStatusTxn) obj)._HoldReason) && object.Equals((object) this._CurrentHoldCount, (object) ((HoldStatusTxn) obj)._CurrentHoldCount) && base.Equals(obj);
    }

    public NamedObjectRef HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Primitive<int> CurrentHoldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentHoldCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentHoldCount));
      }
    }
  }
}
