// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeDetails_Environment
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
  public class SerializeDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Start Details required for creating Serialized Containers.", "SerializedStartDetails", false, false, false, "SerializedStartDetails", 1049886, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Environment_StartDetails")]
    protected SerializedStartDetails_Environment _StartDetails;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049878, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Environment_ActualChildCount")]
    protected Environment _ActualChildCount;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Environment_ChildContainerLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, true, false, "NamedObjectRef", 1049884, false, false, true, null)]
    protected Environment _ChildContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _Product;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049885, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Environment_ContainerNames")]
    protected Environment _ContainerNames;

    public SerializedStartDetails_Environment StartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDetails), (object) value);
      }
      get
      {
        return (SerializedStartDetails_Environment) this.PropertyGet(nameof (StartDetails));
      }
    }

    public Environment ActualChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualChildCount));
      }
    }

    public Environment ChildContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainerLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildContainerLevel));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }

    public Environment ContainerNames
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNames), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerNames));
      }
    }
  }
}
