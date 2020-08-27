// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LocationChanges
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
  public class LocationChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_ChangeStatus")]
    protected SubentityRef _ChangeStatus;
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_IconId")]
    protected Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "LocationChanges_Status")]
    protected Enumeration<StatusEnum, int> _Status;

    public override bool Equals(object obj)
    {
      return obj is LocationChanges && object.Equals((object) this._ChangeStatus, (object) ((LocationChanges) obj)._ChangeStatus) && (object.Equals((object) this._ListItemToChange, (object) ((LocationChanges) obj)._ListItemToChange) && object.Equals((object) this._Name, (object) ((LocationChanges) obj)._Name)) && (object.Equals((object) this._Description, (object) ((LocationChanges) obj)._Description) && object.Equals((object) this._Factory, (object) ((LocationChanges) obj)._Factory) && (object.Equals((object) this._ObjectToChange, (object) ((LocationChanges) obj)._ObjectToChange) && object.Equals((object) this._IconId, (object) ((LocationChanges) obj)._IconId))) && object.Equals((object) this._Status, (object) ((LocationChanges) obj)._Status) && base.Equals(obj);
    }

    public SubentityRef ChangeStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeStatus), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ChangeStatus));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
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

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }
  }
}
