// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintClassActivation_Environment
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
  public class MaintClassActivation_Environment : MaintenanceReqTxn_Environment
  {
    [Metadata("Used to activate the Maintenance Class to the parent Maintenance Requirement", "MaintClassActivationDetails", false, false, false, "MaintClassActivationDetails", 1049843, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintClassActivation_Environment_ServiceDetails")]
    protected MaintClassActivationDetails_Environment _ServiceDetails;

    public MaintClassActivationDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (MaintClassActivationDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
