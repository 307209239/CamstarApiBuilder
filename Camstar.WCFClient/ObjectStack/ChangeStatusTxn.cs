// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeStatusTxn
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
  public class ChangeStatusTxn : ChangeMgtTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_ChangePackage")]
    protected new NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_LockInstances")]
    protected Primitive<bool> _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_Status")]
    protected Primitive<int> _Status;

    public override bool Equals(object obj)
    {
      return obj is ChangeStatusTxn && object.Equals((object) this._ChangePackage, (object) ((ChangeStatusTxn) obj)._ChangePackage) && (object.Equals((object) this._LockInstances, (object) ((ChangeStatusTxn) obj)._LockInstances) && object.Equals((object) this._Status, (object) ((ChangeStatusTxn) obj)._Status)) && base.Equals(obj);
    }

    public new NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Primitive<bool> LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Primitive<int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Status));
      }
    }
  }
}
