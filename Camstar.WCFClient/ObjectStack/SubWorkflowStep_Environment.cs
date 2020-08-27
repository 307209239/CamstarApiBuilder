// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubWorkflowStep_Environment
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
  public class SubWorkflowStep_Environment : Step_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_Xlocation")]
    [Metadata("X-Y axis coordinate for drawing a Workflow Step", "", false, false, true, "Integer", 1048919, false, false, false, null)]
    protected new Environment _Xlocation;
    [Metadata("Path selectors are used to select a Path based on the value of specific data within a transaction. Each Path selector includes an expression to evaluate and a Path to select. The expression must be a Boolean expression, and is defined using the standard InSite expression syntax.\r\n\r\nA MovePathSelector is the path selector used for a normal path between steps, MovePathSelectors are evaluated by all Move-type transactions other than Rework and TransferRework.  ReworkPathSelectors are evaluated by the  Rework and TransferRework transactions. ", "MovePathSelector", false, false, true, "MovePathSelector", 1048915, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_PathSelectors")]
    protected new MovePathSelector_Environment _PathSelectors;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_FirstSpecStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1049430, false, false, false, null)]
    protected new Environment _FirstSpecStep;
    [Metadata("An Operation uses an instance of Scheduling Details to define scheduling information at the most generic level. Each value in the scheduling details can be overridden by a Spec. In a Sub-Workflow Step, the individual values are passed through from the first Step of the sub-workflow.\r\n\r\nThe calculation for cycle time is:\r\n\r\n( ( (RunTime + SetupTime) / Utilitzation ) + MoveTime + [Fast/Normal]QueueTime ) [/ HoursPerDay]\r\n\r\nThe hierarchy built-in to the application model is that Scheduling details specified at the Operation level can be overridden by a Spec. In turn the values in the Spec can be overridden by each Step that references that Spec. It is also assumed that Scheduling Details will be overridden at the Product or Product Family level. Further, the assumption is that this will be for a few Steps (if any) and that adding user-defined fields to the Product or Product Family definition (and then updating the field overrides) will address it.", "SubWorkflowStepSchedulingDetail", false, false, true, "SubWorkflowStepSchedulingDetail", 1048916, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_SchedulingDetail")]
    protected SubWorkflowStepSchedulingDetail_Environment _SchedulingDetail;
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_Sequence")]
    protected new Environment _Sequence;
    [Metadata("X-Y axis coordinate for drawing a Workflow Step", "", false, false, true, "Integer", 1048920, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_Ylocation")]
    protected new Environment _Ylocation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_OnDefaultRoute")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048913, false, false, false, "0")]
    protected new Environment _OnDefaultRoute;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_IconId")]
    protected new Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_DefaultPath")]
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "MovePath", false, false, true, "NamedSubentityRef", 1048911, false, false, false, null)]
    protected new Environment _DefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, true, "NamedObjectRef", 1048815, false, false, false, null)]
    protected new Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected new Environment _Notes;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_Description")]
    protected new Environment _Description;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, true, "RevisionedObjectRef", 1049035, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_SubWorkflow")]
    protected Environment _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_StepType")]
    [Metadata("Numeric Option", "", false, false, true, "Integer", 1048918, false, false, false, null)]
    protected new Environment _StepType;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStep_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050260, false, false, false, null)]
    protected new Environment _Name;

    public new Environment Xlocation
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

    public new MovePathSelector_Environment PathSelectors
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

    public new Environment FirstSpecStep
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

    public SubWorkflowStepSchedulingDetail_Environment SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SubWorkflowStepSchedulingDetail_Environment) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public new Environment Sequence
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

    public new Environment Ylocation
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

    public new Environment OnDefaultRoute
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

    public new Environment IconId
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

    public new Environment DefaultPath
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

    public new Environment Notes
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

    public new Environment Description
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

    public Environment SubWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubWorkflow));
      }
    }

    public new Environment StepType
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
