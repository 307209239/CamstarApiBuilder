// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemoteReceive
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
  public class RemoteReceive : CompoundTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_CurrentStatus")]
    protected CurrentStatus _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_ShipmentDestination")]
    protected NamedObjectRef _ShipmentDestination;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_MfgProcessOverrides")]
    protected new RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_ContainerStatus")]
    protected Enumeration<ContainerStatusEnum, int> _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Container")]
    protected Container _Container;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Close")]
    protected Primitive<bool> _Close;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is RemoteReceive && object.Equals((object) this._CurrentStatus, (object) ((RemoteReceive) obj)._CurrentStatus) && (object.Equals((object) this._ShipmentDestination, (object) ((RemoteReceive) obj)._ShipmentDestination) && object.Equals((object) this._MfgProcessOverrides, (object) ((RemoteReceive) obj)._MfgProcessOverrides)) && (object.Equals((object) this._ContainerStatus, (object) ((RemoteReceive) obj)._ContainerStatus) && object.Equals((object) this._Container, (object) ((RemoteReceive) obj)._Container) && (object.Equals((object) this._Close, (object) ((RemoteReceive) obj)._Close) && object.Equals((object) this._Factory, (object) ((RemoteReceive) obj)._Factory))) && base.Equals(obj);
    }

    public CurrentStatus CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (CurrentStatus) this.PropertyGet(nameof (CurrentStatus));
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

    public new RevisionedObjectRef MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MfgProcessOverrides));
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

    public Container Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Container) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<bool> Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Close));
      }
    }

    public new NamedObjectRef Factory
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
  }
}
