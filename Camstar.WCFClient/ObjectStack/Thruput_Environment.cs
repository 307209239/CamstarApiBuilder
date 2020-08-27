// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Thruput_Environment
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
  public class Thruput_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1052596, false, false, false, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049574, false, false, false, null)]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_ServiceDetails")]
    [Metadata("Thruput detail.", "ThruputDetail", false, false, false, "ThruputDetail", 1049645, false, true, false, null)]
    protected ThruputDetail_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_SummaryThruput")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048987, false, false, false, "0")]
    protected Environment _SummaryThruput;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_ThruputAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049283, false, false, false, "0")]
    protected Environment _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_UnitCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048852, false, false, false, null)]
    protected Environment _UnitCount;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048770, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_ChildCount")]
    protected Environment _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_ThruputReportingLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, true, "NamedObjectRef", 1048988, false, false, true, null)]
    protected Environment _ThruputReportingLevel;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1052595, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_QtyRemaining")]
    protected Environment _QtyRemaining;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_ContainerLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, true, "NamedObjectRef", 1049278, false, false, true, null)]
    protected Environment _ContainerLevel;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_Operation")]
    protected new Environment _Operation;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1052594, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Environment_QtyProcessed")]
    protected Environment _QtyProcessed;

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public ThruputDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ThruputDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment SummaryThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryThruput), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SummaryThruput));
      }
    }

    public Environment ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputAllQty));
      }
    }

    public Environment UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Environment ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public Environment ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }

    public Environment QtyRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemaining), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyRemaining));
      }
    }

    public Environment ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public new Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment QtyProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyProcessed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyProcessed));
      }
    }
  }
}
