// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusCodeChanges
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
  public class ResourceStatusCodeChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_ResourceStatusReasons")]
    protected NamedObjectRef _ResourceStatusReasons;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_ResourceState")]
    protected Enumeration<ResourceStateEnum, int> _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_NextTxnType")]
    protected Primitive<int> _NextTxnType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_StatusReasons")]
    protected NamedObjectRef[] _StatusReasons;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Availability")]
    protected Enumeration<ResourceAvailabilityEnum, int> _Availability;

    public override bool Equals(object obj)
    {
      return obj is ResourceStatusCodeChanges && object.Equals((object) this._ResourceStatusReasons, (object) ((ResourceStatusCodeChanges) obj)._ResourceStatusReasons) && (object.Equals((object) this._ResourceState, (object) ((ResourceStatusCodeChanges) obj)._ResourceState) && object.Equals((object) this._NextTxnType, (object) ((ResourceStatusCodeChanges) obj)._NextTxnType)) && (this.CompareArrays((Array) this._StatusReasons, (Array) ((ResourceStatusCodeChanges) obj)._StatusReasons) && object.Equals((object) this._Name, (object) ((ResourceStatusCodeChanges) obj)._Name) && (object.Equals((object) this._ObjectToChange, (object) ((ResourceStatusCodeChanges) obj)._ObjectToChange) && object.Equals((object) this._Availability, (object) ((ResourceStatusCodeChanges) obj)._Availability))) && base.Equals(obj);
    }

    public NamedObjectRef ResourceStatusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusReasons));
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

    public Primitive<int> NextTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextTxnType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NextTxnType));
      }
    }

    public NamedObjectRef[] StatusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (StatusReasons));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
