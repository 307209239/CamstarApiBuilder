// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VoidCPStatus
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
  public class VoidCPStatus : ChangeStatusTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "VoidCPStatus_Status")]
    protected Enumeration<PackageStatusEnum, int> _Status;

    public override bool Equals(object obj)
    {
      return obj is VoidCPStatus && object.Equals((object) this._Status, (object) ((VoidCPStatus) obj)._Status) && base.Equals(obj);
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
  }
}
