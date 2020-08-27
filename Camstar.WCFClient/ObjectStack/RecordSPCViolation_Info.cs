// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordSPCViolation_Info
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
  public class RecordSPCViolation_Info : SPCTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolation_Info_ServiceDetails")]
    protected RecordSPCViolationDetail_Info _ServiceDetails;

    public RecordSPCViolationDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (RecordSPCViolationDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
