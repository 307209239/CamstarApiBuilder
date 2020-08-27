// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordSPCViolation_Environment
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
  public class RecordSPCViolation_Environment : SPCTxn_Environment
  {
    [Metadata("The detail of a chart where violations have been identified.", "RecordSPCViolationDetail", false, false, false, "RecordSPCViolationDetail", 1052996, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolation_Environment_ServiceDetails")]
    protected RecordSPCViolationDetail_Environment _ServiceDetails;

    public RecordSPCViolationDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (RecordSPCViolationDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
