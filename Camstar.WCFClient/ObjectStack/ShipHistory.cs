// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipHistory
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
  public class ShipHistory : MoveHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_ContainerStatus")]
    protected Enumeration<ContainerStatusEnum, int> _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_RemoteContainerStatus")]
    protected Enumeration<ContainerStatusEnum, int> _RemoteContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_ShipmentDestination")]
    protected NamedObjectRef _ShipmentDestination;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_ToCustomer")]
    protected NamedObjectRef _ToCustomer;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_ToFactory")]
    protected NamedObjectRef _ToFactory;

    public override bool Equals(object obj)
    {
      return obj is ShipHistory && object.Equals((object) this._ContainerStatus, (object) ((ShipHistory) obj)._ContainerStatus) && (object.Equals((object) this._RemoteContainerStatus, (object) ((ShipHistory) obj)._RemoteContainerStatus) && object.Equals((object) this._ShipmentDestination, (object) ((ShipHistory) obj)._ShipmentDestination)) && (object.Equals((object) this._ToCustomer, (object) ((ShipHistory) obj)._ToCustomer) && object.Equals((object) this._ToFactory, (object) ((ShipHistory) obj)._ToFactory)) && base.Equals(obj);
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

    public NamedObjectRef ToFactory
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
  }
}
