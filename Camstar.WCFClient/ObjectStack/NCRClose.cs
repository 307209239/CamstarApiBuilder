// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRClose
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
  public class NCRClose : NCRUpdate
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRClose_ServiceDetail")]
    protected NCRCloseDetail _ServiceDetail;

    public override bool Equals(object obj)
    {
      return obj is NCRClose && object.Equals((object) this._ServiceDetail, (object) ((NCRClose) obj)._ServiceDetail) && base.Equals(obj);
    }

    public NCRCloseDetail ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (NCRCloseDetail) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
