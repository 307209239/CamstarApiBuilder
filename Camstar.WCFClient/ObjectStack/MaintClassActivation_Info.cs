// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintClassActivation_Info
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
  public class MaintClassActivation_Info : MaintenanceReqTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintClassActivation_Info_ServiceDetails")]
    protected MaintClassActivationDetails_Info _ServiceDetails;

    public MaintClassActivationDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (MaintClassActivationDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
