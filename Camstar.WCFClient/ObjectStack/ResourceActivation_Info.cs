// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceActivation_Info
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
  public class ResourceActivation_Info : MaintenanceReqTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivation_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivation_Info_ServiceDetails")]
    protected ResourceActivationDetails_Info _ServiceDetails;

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public ResourceActivationDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ResourceActivationDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
