// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipmentDestinationChanges_Environment
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
  public class ShipmentDestinationChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("A ShipmentDestination is the factory or customer to which the container is shipped. ShipmentDestinaiton also contains routing information used by the RemoteProcessingInfo object when the Ship transaction is sending remote transactions to a destination site.", "ShipmentDestination", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1049895, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_LocalContainerStatus")]
    protected Environment _LocalContainerStatus;
    [Metadata("A site is defined as an independent InSite entity within a manufacturing organization. While a factory is a physical facilities concept, a site is a self contained IT structure based on a single transaction processing database, along with the associated InSite servers that provide the capability to generate transactions in the database. A factory could have one or more sites; and a site could run one or more factories.", "Site", false, false, false, "NamedObjectRef", 1049707, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_RemoteSite")]
    protected Environment _RemoteSite;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_RemoteContainerStatus")]
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1049676, false, false, true, null)]
    protected Environment _RemoteContainerStatus;
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1048612, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_Customer")]
    protected Environment _Customer;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_Location")]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050090, false, false, false, null)]
    protected new Environment _Name;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment LocalContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalContainerStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LocalContainerStatus));
      }
    }

    public Environment RemoteSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteSite), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemoteSite));
      }
    }

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

    public Environment Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Customer));
      }
    }

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }

    public Environment Factory
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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
