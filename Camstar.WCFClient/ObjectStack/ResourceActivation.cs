// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceActivation
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
  public class ResourceActivation : MaintenanceReqTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivation_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivation_ServiceDetails")]
    protected ResourceActivationDetails[] _ServiceDetails;

    public override bool Equals(object obj)
    {
      return obj is ResourceActivation && object.Equals((object) this._ResourceGroup, (object) ((ResourceActivation) obj)._ResourceGroup) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ResourceActivation) obj)._ServiceDetails) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public ResourceActivationDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ResourceActivationDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
