// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRClose_Environment
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
  public class NCRClose_Environment : NCRUpdate_Environment
  {
    [Metadata("This ServiceDetails object contains customizations specifice to closing a Nonconformance.", "NCRCloseDetail", false, false, false, "NCRCloseDetail", 1050454, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRClose_Environment_ServiceDetail")]
    protected NCRCloseDetail_Environment _ServiceDetail;

    public NCRCloseDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (NCRCloseDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
