// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentStatusStartDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (V3_CurrentStatusStartDetails_Environment))]
  [KnownType(typeof (MatlContainerCurrentStartDtls_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class CurrentStatusStartDetails_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_ReworkStatusStartDetails")]
    [Metadata("StartDetails related to the Rework Status of a Container will go here", "ReworkStatusStartDetails", false, false, false, "ReworkStatusStartDetails", 1049865, false, true, false, null)]
    protected ReworkStatusStartDetails_Environment _ReworkStatusStartDetails;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    protected Environment _Carrier;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049674, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_ReworkTotalCount")]
    protected Environment _ReworkTotalCount;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049637, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_InRework")]
    protected Environment _InRework;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048801, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_InProcess")]
    protected Environment _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    protected Environment _Workflow;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_Resource")]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_WorkflowStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048855, false, false, true, null)]
    protected Environment _WorkflowStep;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049067, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_WorkflowStack")]
    protected Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatusStartDetails_Environment_Location")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    protected Environment _Location;

    public ReworkStatusStartDetails_Environment ReworkStatusStartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkStatusStartDetails), (object) value);
      }
      get
      {
        return (ReworkStatusStartDetails_Environment) this.PropertyGet(nameof (ReworkStatusStartDetails));
      }
    }

    public Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public Environment ReworkTotalCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkTotalCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReworkTotalCount));
      }
    }

    public Environment InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InRework));
      }
    }

    public Environment InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InProcess));
      }
    }

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
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

    public Environment WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public Environment WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStack));
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
  }
}
