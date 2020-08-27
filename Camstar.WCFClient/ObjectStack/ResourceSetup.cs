// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceSetup
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
  public class ResourceSetup : ResourceTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_ResourceStatusDetails")]
    protected new ResourceStatusDetails _ResourceStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_ResourceStatusHistory")]
    protected ResourceStatusHistory _ResourceStatusHistory;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_ResourceState")]
    protected Enumeration<ResourceStateEnum, int> _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Run")]
    protected Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_UpdateLastStatusChangeDate")]
    protected Primitive<int> _UpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Setup")]
    protected RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Availability")]
    protected Enumeration<ResourceAvailabilityEnum, int> _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_ResourceStatusReason")]
    protected NamedObjectRef _ResourceStatusReason;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Resource")]
    protected new NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_ResourceStatusCode")]
    protected NamedObjectRef _ResourceStatusCode;

    public override bool Equals(object obj)
    {
      return obj is ResourceSetup && object.Equals((object) this._ResourceStatusDetails, (object) ((ResourceSetup) obj)._ResourceStatusDetails) && (object.Equals((object) this._ResourceGroup, (object) ((ResourceSetup) obj)._ResourceGroup) && object.Equals((object) this._ResourceStatusHistory, (object) ((ResourceSetup) obj)._ResourceStatusHistory)) && (object.Equals((object) this._ResourceState, (object) ((ResourceSetup) obj)._ResourceState) && object.Equals((object) this._Run, (object) ((ResourceSetup) obj)._Run) && (object.Equals((object) this._UpdateLastStatusChangeDate, (object) ((ResourceSetup) obj)._UpdateLastStatusChangeDate) && object.Equals((object) this._Setup, (object) ((ResourceSetup) obj)._Setup))) && (object.Equals((object) this._Availability, (object) ((ResourceSetup) obj)._Availability) && object.Equals((object) this._ResourceStatusReason, (object) ((ResourceSetup) obj)._ResourceStatusReason) && (object.Equals((object) this._Product, (object) ((ResourceSetup) obj)._Product) && object.Equals((object) this._Resource, (object) ((ResourceSetup) obj)._Resource)) && object.Equals((object) this._ResourceStatusCode, (object) ((ResourceSetup) obj)._ResourceStatusCode)) && base.Equals(obj);
    }

    public new ResourceStatusDetails ResourceStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusDetails), (object) value);
      }
      get
      {
        return (ResourceStatusDetails) this.PropertyGet(nameof (ResourceStatusDetails));
      }
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

    public ResourceStatusHistory ResourceStatusHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusHistory), (object) value);
      }
      get
      {
        return (ResourceStatusHistory) this.PropertyGet(nameof (ResourceStatusHistory));
      }
    }

    public Enumeration<ResourceStateEnum, int> ResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceState), (object) value);
      }
      get
      {
        return (Enumeration<ResourceStateEnum, int>) this.PropertyGet(nameof (ResourceState));
      }
    }

    public Primitive<string> Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Run));
      }
    }

    public Primitive<int> UpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UpdateLastStatusChangeDate));
      }
    }

    public RevisionedObjectRef Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Setup));
      }
    }

    public Enumeration<ResourceAvailabilityEnum, int> Availability
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

    public NamedObjectRef ResourceStatusReason
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

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public new NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedObjectRef ResourceStatusCode
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
  }
}
