// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Ship_Environment
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
  public class Ship_Environment : MoveNonStd_Environment
  {
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1049676, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Ship_Environment_RemoteContainerStatus")]
    protected Environment _RemoteContainerStatus;
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1049675, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Ship_Environment_ContainerStatus")]
    protected Environment _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "Ship_Environment_ShipmentDestination")]
    [Metadata("A ShipmentDestination is the factory or customer to which the container is shipped. ShipmentDestinaiton also contains routing information used by the RemoteProcessingInfo object when the Ship transaction is sending remote transactions to a destination site.", "ShipmentDestination", false, true, false, "NamedObjectRef", 1049682, false, false, true, null)]
    protected Environment _ShipmentDestination;
    [DataMember(EmitDefaultValue = false, Name = "Ship_Environment_ToCustomer")]
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1049681, false, false, true, null)]
    protected Environment _ToCustomer;
    [DataMember(EmitDefaultValue = false, Name = "Ship_Environment_ToFactory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1049677, false, false, true, null)]
    protected new Environment _ToFactory;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Ship_Environment_ToLocation")]
    protected new Environment _ToLocation;

    public Environment RemoteContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteContainerStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemoteContainerStatus));
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

    public Environment ToCustomer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToCustomer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToCustomer));
      }
    }

    public new Environment ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToFactory));
      }
    }

    public new Environment ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToLocation));
      }
    }
  }
}
