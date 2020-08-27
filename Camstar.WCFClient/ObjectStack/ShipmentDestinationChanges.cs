// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipmentDestinationChanges
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
  public class ShipmentDestinationChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_LocalContainerStatus")]
    protected Enumeration<ContainerStatusEnum, int> _LocalContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_RemoteSite")]
    protected NamedObjectRef _RemoteSite;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_RemoteContainerStatus")]
    protected Enumeration<ContainerStatusEnum, int> _RemoteContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Customer")]
    protected NamedObjectRef _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ShipmentDestinationChanges && object.Equals((object) this._ObjectToChange, (object) ((ShipmentDestinationChanges) obj)._ObjectToChange) && (object.Equals((object) this._LocalContainerStatus, (object) ((ShipmentDestinationChanges) obj)._LocalContainerStatus) && object.Equals((object) this._RemoteSite, (object) ((ShipmentDestinationChanges) obj)._RemoteSite)) && (object.Equals((object) this._RemoteContainerStatus, (object) ((ShipmentDestinationChanges) obj)._RemoteContainerStatus) && object.Equals((object) this._Customer, (object) ((ShipmentDestinationChanges) obj)._Customer) && (object.Equals((object) this._Location, (object) ((ShipmentDestinationChanges) obj)._Location) && object.Equals((object) this._Factory, (object) ((ShipmentDestinationChanges) obj)._Factory))) && object.Equals((object) this._Name, (object) ((ShipmentDestinationChanges) obj)._Name) && base.Equals(obj);
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

    public Enumeration<ContainerStatusEnum, int> LocalContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalContainerStatus), (object) value);
      }
      get
      {
        return (Enumeration<ContainerStatusEnum, int>) this.PropertyGet(nameof (LocalContainerStatus));
      }
    }

    public NamedObjectRef RemoteSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteSite), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RemoteSite));
      }
    }

    public Enumeration<ContainerStatusEnum, int> RemoteContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteContainerStatus), (object) value);
      }
      get
      {
        return (Enumeration<ContainerStatusEnum, int>) this.PropertyGet(nameof (RemoteContainerStatus));
      }
    }

    public NamedObjectRef Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Customer));
      }
    }

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
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
