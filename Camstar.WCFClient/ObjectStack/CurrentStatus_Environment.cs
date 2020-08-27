// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentStatus_Environment
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
  public class CurrentStatus_Environment : BaseObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_ContainerCompletedTasks")]
    [Metadata("Used to build the list of completed Tasks for the Container at its current step.  The list is cleared when the Container leaves the step.", "ContainerCompletedTask", false, false, true, "ContainerCompletedTask", 1050554, false, true, false, null)]
    protected ContainerCompletedTask_Environment _ContainerCompletedTasks;
    [Metadata("A instance of a Rework Status is used to keep track of rework processing details for a Container. This includes the current status and the information required to complete the rework and return to normal processing. Rework, and therefore Rework Status entries, can be recursive.", "ReworkStatus", false, false, true, "ReworkStatus", 1048842, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_ReworkStatus")]
    protected ReworkStatus_Environment _ReworkStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_WorkflowStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1048855, false, false, false, null)]
    protected Environment _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_WorkflowStack")]
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow. This allows, for example, the re-use of Workflows for Rework processing.\r\n\r\n", "SubWorkflowStep", false, false, true, "SubWorkflowStep", 1049067, false, true, false, null)]
    protected SubWorkflowStep_Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_StepPassCounts")]
    [Metadata("This is a CurrentStatus SubEntity which is used to keep track of the number of times a Step is passed during the \r\nlife time of a container.", "StepPassCount", false, false, true, "StepPassCount", 1052228, false, true, false, null)]
    protected StepPassCount_Environment _StepPassCounts;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Timers")]
    [Metadata("Timer", "Timer", false, false, true, "Timer", 16778633, false, true, false, null)]
    protected Timer_Environment _Timers;
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, false, true, "RevisionedObjectRef", 1052252, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_InitialRecipeList")]
    protected Environment _InitialRecipeList;
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1050555, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_LastCompletedTask")]
    protected Environment _LastCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_CurrentStepPass")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052225, false, false, false, "1")]
    protected Environment _CurrentStepPass;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049674, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_ReworkTotalCount")]
    protected Environment _ReworkTotalCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_LastMoveDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048808, false, false, false, null)]
    protected Environment _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_InProcess")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048801, false, false, false, "0")]
    protected Environment _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_TimersCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16778634, false, false, false, "0")]
    protected Environment _TimersCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_InRework")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049637, false, false, false, "0")]
    protected Environment _InRework;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_LastMoveDate")]
    protected Environment _LastMoveDate;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050887, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_ClearanceWorkstations")]
    protected Environment _ClearanceWorkstations;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050517, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Workstation")]
    protected Environment _Workstation;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, true, "NamedObjectRef", 1048659, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Factory")]
    protected Environment _Factory;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, true, "NamedSubentityRef", 1048660, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Location")]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, true, "NamedObjectRef", 1048815, false, false, false, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, false, null)]
    protected Environment _Workflow;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Environment_Resource")]
    protected Environment _Resource;

    public ContainerCompletedTask_Environment ContainerCompletedTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerCompletedTasks), (object) value);
      }
      get
      {
        return (ContainerCompletedTask_Environment) this.PropertyGet(nameof (ContainerCompletedTasks));
      }
    }

    public ReworkStatus_Environment ReworkStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkStatus), (object) value);
      }
      get
      {
        return (ReworkStatus_Environment) this.PropertyGet(nameof (ReworkStatus));
      }
    }

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
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

    public SubWorkflowStep_Environment WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (SubWorkflowStep_Environment) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public StepPassCount_Environment StepPassCounts
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPassCounts), (object) value);
      }
      get
      {
        return (StepPassCount_Environment) this.PropertyGet(nameof (StepPassCounts));
      }
    }

    public Timer_Environment Timers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timers), (object) value);
      }
      get
      {
        return (Timer_Environment) this.PropertyGet(nameof (Timers));
      }
    }

    public Environment InitialRecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitialRecipeList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitialRecipeList));
      }
    }

    public Environment LastCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedTask));
      }
    }

    public Environment CurrentStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStepPass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentStepPass));
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

    public Environment LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDateGMT));
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

    public Environment TimersCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimersCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimersCount));
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

    public Environment LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Environment ClearanceWorkstations
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearanceWorkstations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClearanceWorkstations));
      }
    }

    public Environment Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workstation));
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

    public Environment Operation
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
  }
}
