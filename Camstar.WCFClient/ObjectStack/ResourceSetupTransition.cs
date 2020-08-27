// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceSetupTransition
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
  public class ResourceSetupTransition : ResourceSetup
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetupTransition_ResourceStatusCode")]
    protected new NamedObjectRef _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetupTransition_ResourceStatusReason")]
    protected new NamedObjectRef _ResourceStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetupTransition_Availability")]
    protected new Enumeration<ResourceAvailabilityEnum, int> _Availability;

    public override bool Equals(object obj)
    {
      return obj is ResourceSetupTransition && object.Equals((object) this._ResourceStatusCode, (object) ((ResourceSetupTransition) obj)._ResourceStatusCode) && (object.Equals((object) this._ResourceStatusReason, (object) ((ResourceSetupTransition) obj)._ResourceStatusReason) && object.Equals((object) this._Availability, (object) ((ResourceSetupTransition) obj)._Availability)) && base.Equals(obj);
    }

    public new NamedObjectRef ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public new NamedObjectRef ResourceStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusReason));
      }
    }

    public new Enumeration<ResourceAvailabilityEnum, int> Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAvailabilityEnum, int>) this.PropertyGet(nameof (Availability));
      }
    }
  }
}
