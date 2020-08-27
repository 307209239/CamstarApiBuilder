// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OpenCPStatus
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
  public class OpenCPStatus : ChangeStatusTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "OpenCPStatus_Status")]
    protected Enumeration<PackageStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "OpenCPStatus_LockInstances")]
    protected new Primitive<bool> _LockInstances;

    public override bool Equals(object obj)
    {
      return obj is OpenCPStatus && object.Equals((object) this._Status, (object) ((OpenCPStatus) obj)._Status) && object.Equals((object) this._LockInstances, (object) ((OpenCPStatus) obj)._LockInstances) && base.Equals(obj);
    }

    public Enumeration<PackageStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<PackageStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public new Primitive<bool> LockInstances
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
  }
}
