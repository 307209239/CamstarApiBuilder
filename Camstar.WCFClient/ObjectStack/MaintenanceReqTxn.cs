// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintenanceReqTxn
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
  public class MaintenanceReqTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqTxn_MaintenanceReq")]
    protected RevisionedObjectRef _MaintenanceReq;

    public override bool Equals(object obj)
    {
      return obj is MaintenanceReqTxn && object.Equals((object) this._MaintenanceReq, (object) ((MaintenanceReqTxn) obj)._MaintenanceReq) && base.Equals(obj);
    }

    public RevisionedObjectRef MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MaintenanceReq));
      }
    }
  }
}
