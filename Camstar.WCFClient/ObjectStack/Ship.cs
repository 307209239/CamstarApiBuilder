// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Ship
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
  public class Ship : MoveNonStd
  {
    [DataMember(EmitDefaultValue = false, Name = "Ship_RemoteContainerStatus")]
    protected Enumeration<ContainerStatusEnum, int> _RemoteContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "Ship_ContainerStatus")]
    protected Enumeration<ContainerStatusEnum, int> _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "Ship_ShipmentDestination")]
    protected NamedObjectRef _ShipmentDestination;
    [DataMember(EmitDefaultValue = false, Name = "Ship_ToCustomer")]
    protected NamedObjectRef _ToCustomer;
    [DataMember(EmitDefaultValue = false, Name = "Ship_ToFactory")]
    protected new NamedObjectRef _ToFactory;
    [DataMember(EmitDefaultValue = false, Name = "Ship_ToLocation")]
    protected new NamedSubentityRef _ToLocation;

    public override bool Equals(object obj)
    {
      return obj is Ship && object.Equals((object) this._RemoteContainerStatus, (object) ((Ship) obj)._RemoteContainerStatus) && (object.Equals((object) this._ContainerStatus, (object) ((Ship) obj)._ContainerStatus) && object.Equals((object) this._ShipmentDestination, (object) ((Ship) obj)._ShipmentDestination)) && (object.Equals((object) this._ToCustomer, (object) ((Ship) obj)._ToCustomer) && object.Equals((object) this._ToFactory, (object) ((Ship) obj)._ToFactory) && object.Equals((object) this._ToLocation, (object) ((Ship) obj)._ToLocation)) && base.Equals(obj);
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

    public Enumeration<ContainerStatusEnum, int> ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Enumeration<ContainerStatusEnum, int>) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public NamedObjectRef ShipmentDestination
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShipmentDestination), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ShipmentDestination));
      }
    }

    public NamedObjectRef ToCustomer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToCustomer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToCustomer));
      }
    }

    public new NamedObjectRef ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToFactory));
      }
    }

    public new NamedSubentityRef ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToLocation));
      }
    }
  }
}
