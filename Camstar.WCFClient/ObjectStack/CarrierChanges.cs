// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CarrierChanges
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
  public class CarrierChanges : ResourceChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_ResourceFamily")]
    protected new NamedObjectRef _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_ChildResources")]
    protected new NamedObjectRef[] _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_ParentResource")]
    protected new NamedObjectRef _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is CarrierChanges && object.Equals((object) this._ResourceFamily, (object) ((CarrierChanges) obj)._ResourceFamily) && (this.CompareArrays((Array) this._ChildResources, (Array) ((CarrierChanges) obj)._ChildResources) && object.Equals((object) this._ParentResource, (object) ((CarrierChanges) obj)._ParentResource)) && (object.Equals((object) this._ObjectToChange, (object) ((CarrierChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((CarrierChanges) obj)._Name)) && base.Equals(obj);
    }

    public new NamedObjectRef ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceFamily));
      }
    }

    public new NamedObjectRef[] ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChildResources));
      }
    }

    public new NamedObjectRef ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentResource));
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
  }
}
