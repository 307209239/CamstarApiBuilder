// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCloseQuality_Environment
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
  public class NCRCloseQuality_Environment : NCRClose_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCloseQuality_Environment_ServiceDetail")]
    [Metadata("This ServiceDetails object contains customizations specifice to closing a Nonconformance escalated to Quality.", "NCRCloseQualityDetail", false, false, false, "NCRCloseQualityDetail", 1050454, true, false, false, null)]
    protected NCRCloseQualityDetail_Environment _ServiceDetail;

    public NCRCloseQualityDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (NCRCloseQualityDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
