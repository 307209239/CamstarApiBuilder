// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemoteReceive_Environment
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
  public class RemoteReceive_Environment : CompoundTxn_Environment
  {
    [Metadata("The Current Container Status contains the current location information for one or more containers.  Every container associated in a multilevel container structure will have a reference to a single Current Container Status CDO.", "CurrentStatus", false, false, false, "CurrentStatus", 1048786, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Environment_CurrentStatus")]
    protected CurrentStatus_Environment _CurrentStatus;
    [Metadata("A ShipmentDestination is the factory or customer to which the container is shipped. ShipmentDestinaiton also contains routing information used by the RemoteProcessingInfo object when the Ship transaction is sending remote transactions to a destination site.", "ShipmentDestination", false, false, false, "NamedObjectRef", 1049682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Environment_ShipmentDestination")]
    protected Environment _ShipmentDestination;
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Environment_MfgProcessOverrides")]
    protected new Environment _MfgProcessOverrides;
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, true, false, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Environment_ContainerStatus")]
    protected Environment _ContainerStatus;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "Container", 1049902, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Environment_Container")]
    protected Container_Environment _Container;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049202, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Environment_Close")]
    protected Environment _Close;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Environment_Factory")]
    protected new Environment _Factory;

    public CurrentStatus_Environment CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (CurrentStatus_Environment) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public Environment ShipmentDestination
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShipmentDestination), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShipmentDestination));
      }
    }

    public new Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public Environment ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public Container_Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Container_Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Close));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
