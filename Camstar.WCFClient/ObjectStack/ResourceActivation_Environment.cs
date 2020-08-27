// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceActivation_Environment
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
  public class ResourceActivation_Environment : MaintenanceReqTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivation_Environment_ResourceGroup")]
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    protected Environment _ResourceGroup;
    [Metadata("Used to activate the Resource to the parent Maintenance Requirement", "ResourceActivationDetails", false, false, false, "ResourceActivationDetails", 1049843, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivation_Environment_ServiceDetails")]
    protected ResourceActivationDetails_Environment _ServiceDetails;

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public ResourceActivationDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ResourceActivationDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
