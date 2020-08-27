// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Defect_Environment
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
  public class Defect_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_Qty2Inspected")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049483, false, false, false, null)]
    protected Environment _Qty2Inspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_ServiceDetails")]
    [Metadata("Defect transaction detail.", "DefectDetail", false, true, false, "DefectDetail", 1049639, false, true, false, null)]
    protected DefectDetail_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_IssueActualsHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "IssueActualsHistory", 1049663, false, true, false, null)]
    protected IssueActualsHistory_Environment _IssueActualsHistory;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049340, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_ContainersInspected")]
    protected Environment _ContainersInspected;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_Resource")]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_QtyInspected")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049335, false, false, false, null)]
    protected Environment _QtyInspected;
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_ChargeToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    protected Environment _ChargeToStep;
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1049341, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Defect_Environment_ContainerLevelInspected")]
    protected Environment _ContainerLevelInspected;

    public Environment Qty2Inspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Inspected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Inspected));
      }
    }

    public DefectDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DefectDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public IssueActualsHistory_Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Environment ContainersInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersInspected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainersInspected));
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

    public Environment QtyInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyInspected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyInspected));
      }
    }

    public Environment ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public Environment ContainerLevelInspected
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelInspected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerLevelInspected));
      }
    }
  }
}
