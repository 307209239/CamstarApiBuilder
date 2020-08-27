// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Step_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (SubWorkflowStep_Environment))]
  [Serializable]
  public class Step_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_WIPMsgLabel")]
    [Metadata("Identifier for relating a WIP Message to one or more Steps. WIP Messages defined for all Modeling Entities except a Step or Operation can be qualified with a WIP Message Label. This allows the same message to be associated with multiple Steps.", "", false, false, true, "String", 1050049, false, false, false, null)]
    protected Environment _WIPMsgLabel;
    [Metadata("Path selectors are used to select a Path based on the value of specific data within a transaction. Each Path selector includes an expression to evaluate and a Path to select. The expression must be a Boolean expression, and is defined using the standard InSite expression syntax.\r\n\r\nA MovePathSelector is the path selector used for a normal path between steps, MovePathSelectors are evaluated by all Move-type transactions other than Rework and TransferRework.  ReworkPathSelectors are evaluated by the  Rework and TransferRework transactions. ", "ReworkPathSelector", false, false, true, "ReworkPathSelector", 1050301, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_ReworkPathSelectors")]
    protected ReworkPathSelector_Environment _ReworkPathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_ReworkPaths")]
    [Metadata("ReworkPath", "ReworkPath", false, false, true, "ReworkPath", 1050300, false, true, false, null)]
    protected ReworkPath_Environment _ReworkPaths;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_PathSelectors")]
    [Metadata("Path selectors are used to select a Path based on the value of specific data within a transaction. Each Path selector includes an expression to evaluate and a Path to select. The expression must be a Boolean expression, and is defined using the standard InSite expression syntax.\r\n\r\nA MovePathSelector is the path selector used for a normal path between steps, MovePathSelectors are evaluated by all Move-type transactions other than Rework and TransferRework.  ReworkPathSelectors are evaluated by the  Rework and TransferRework transactions. ", "MovePathSelector", false, false, true, "MovePathSelector", 1048915, false, true, false, null)]
    protected MovePathSelector_Environment _PathSelectors;
    [Metadata("X-Y axis coordinate for drawing a Workflow Step", "", false, false, true, "Integer", 1048919, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Xlocation")]
    protected Environment _Xlocation;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("An Operation uses an instance of Scheduling Details to define scheduling information at the most generic level. Each value in the scheduling details can be overridden by a Spec. The values in the Spec can in turn be overridden by a Step. The Maintenance function must provide security for access to Scheduling Details. \r\n\r\nThe calculation for cycle time is:\r\n\r\n( ( (RunTime + SetupTime) / Utilitzation ) + MoveTime + [Fast/Normal]QueueTime ) [/ HoursPerDay]\r\n\r\nThe hierarchy built-in to the application model is that Scheduling details specified at the Operation level can be overridden by a Spec. In turn the values in the Spec can be overridden by each Step that references that Spec. It is also assumed that Scheduling Details will be overridden at the Product or Product Family level. Further, the assumption is that this will be for a few Steps (if any) and that adding user-defined fields to the Product or Product Family definition (and then updating the field overrides) will address it.", "StepSchedulingDetail", false, false, true, "StepSchedulingDetail", 1048916, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_SchedulingDetail")]
    protected StepSchedulingDetail_Environment _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Ylocation")]
    [Metadata("X-Y axis coordinate for drawing a Workflow Step", "", false, false, true, "Integer", 1048920, false, false, false, null)]
    protected Environment _Ylocation;
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nBins are used to define one or more options for distributing (Moving-out) the content of a Container as part of a single transaction. Each Step can contain zero or more Bins. Each Bin identifies a Path, Transaction Details (Move, Combine, etc.), and Product change information. Bins are Product Specific (see Product Changes below).\r\n\r\nBins are referenced by name or by Id. Bin names are unique within the context of their Step.\r\n\r\nProduct Changes\r\n\r\nProduct-in refers to a Containers’ Product at the time it arrives at the Step. A Resource is Set-up to run a specific Product. If optioning is being used then this is the Option-to Product (“what am I trying to make”). Bins are used to provide a list of possible outcomes based on the processing at a Step. This is the list of Bin-to Products (“what did I actually make”). The list of available Bins is based on the “starting” Product, which is Product-in, or the Option-to Product if optioning is being used.", "Bin", false, false, true, "Bin", 1048910, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Bins")]
    protected Bin_Environment _Bins;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_RouteStep")]
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, true, "NamedSubentityRef", 1049917, false, false, false, null)]
    protected Environment _RouteStep;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052989, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_IsLastStep")]
    protected Environment _IsLastStep;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048913, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_OnDefaultRoute")]
    protected Environment _OnDefaultRoute;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050279, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_IsFirstStep")]
    protected Environment _IsFirstStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, true, "NamedObjectRef", 1048815, false, false, false, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_StepType")]
    [Metadata("Numeric Option", "", false, false, true, "Integer", 1048918, false, false, false, null)]
    protected Environment _StepType;
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, true, "MovePath", 1048914, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Paths")]
    protected MovePath_Environment _Paths;
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, true, "NamedSubentityRef", 1048911, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_DefaultPath")]
    protected Environment _DefaultPath;
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nGates are used to group one or more Steps for a specific purpose. There are three types of Gates: Cycle-time, Processing, and Collection. Each Gate has an Entry Point and an Exit Point. An Entry or Exit Point is a transaction at a Step. For use in defining Entry and Exit Points, transactions are grouped as Begin Work, or Complete Work.  Begin Work is any transaction that changes the \"Work started\" status attribute of a Container to True. Complete Work is any transaction that changes the location of a Container.\r\n\r\nGates are referenced by name or by Id. Gates names are unique within the context of their Workflow.", "Gate", false, false, true, "NamedSubentityRef", 1048912, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Gates")]
    protected Environment _Gates;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Workflow")]
    protected Environment _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_FirstSpecStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1049430, false, false, false, null)]
    protected Environment _FirstSpecStep;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_IconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    protected Environment _IconId;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Notes")]
    protected Environment _Notes;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049579, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_ToSteps")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049829, false, true, false, null)]
    protected Environment _ToSteps;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Step_Environment_Description")]
    protected Environment _Description;

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment WIPMsgLabel
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgLabel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgLabel));
      }
    }

    public ReworkPathSelector_Environment ReworkPathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPathSelectors), (object) value);
      }
      get
      {
        return (ReworkPathSelector_Environment) this.PropertyGet(nameof (ReworkPathSelectors));
      }
    }

    public ReworkPath_Environment ReworkPaths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkPaths), (object) value);
      }
      get
      {
        return (ReworkPath_Environment) this.PropertyGet(nameof (ReworkPaths));
      }
    }

    public MovePathSelector_Environment PathSelectors
    {
      [param: In] set
      {
        this.PropertySet(nameof (PathSelectors), (object) value);
      }
      get
      {
        return (MovePathSelector_Environment) this.PropertyGet(nameof (PathSelectors));
      }
    }

    public Environment Xlocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Xlocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Xlocation));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public StepSchedulingDetail_Environment SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (StepSchedulingDetail_Environment) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Environment Ylocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Ylocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Ylocation));
      }
    }

    public Bin_Environment Bins
    {
      [param: In] set
      {
        this.PropertySet(nameof (Bins), (object) value);
      }
      get
      {
        return (Bin_Environment) this.PropertyGet(nameof (Bins));
      }
    }

    public Environment RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteStep));
      }
    }

    public Environment IsLastStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLastStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLastStep));
      }
    }

    public Environment OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public Environment IsFirstStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFirstStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFirstStep));
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

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment StepType
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StepType));
      }
    }

    public MovePath_Environment Paths
    {
      [param: In] set
      {
        this.PropertySet(nameof (Paths), (object) value);
      }
      get
      {
        return (MovePath_Environment) this.PropertyGet(nameof (Paths));
      }
    }

    public Environment DefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultPath));
      }
    }

    public Environment Gates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gates), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Gates));
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

    public Environment FirstSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstSpecStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FirstSpecStep));
      }
    }

    public Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
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

    public Environment ToSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSteps), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToSteps));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
