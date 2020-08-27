// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPMoveTxn_Environment
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
  public class BPMoveTxn_Environment : BusinessProcessTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_WorkflowNavigator")]
    [Metadata("Navigate through a workflow, including subworkflows and rework information.", "WorkflowNavigator", false, false, true, "SubentityRef", 1049790, false, false, false, null)]
    protected Environment _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_NavigationMode")]
    [Metadata("Workflow navigation mode determines whether to use a regular Path or a ReworkPath during Move transactions.\r\nPossible navigational modes are:\r\nStandard = 1\r\nRework = 2", "WorkflowNavigationModeEnum", false, false, false, "Integer", 1050305, false, false, false, null)]
    protected Environment _NavigationMode;
    [Metadata("Comments", "", false, false, false, "String", 16777408, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_Comments")]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_Path")]
    [Metadata("A Path defines an allowable (Standard) move from one Step to another within a Workflow. Each Step contains zero or more (outbound) Paths. Only one of the Paths is the default Path, all others are alternate paths. If a Step contains any Paths, one must be the default. The default Route for a Workflow is determined by traversing through the Steps, starting at the first Step (defined in the workflow), using the default Path for each.\r\n\r\nPaths are referenced by name or by Id. Path names are unique within the context of their Step.", "Path", false, false, false, "NamedSubentityRef", 1049030, false, false, true, null)]
    protected Environment _Path;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_ToSpecStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, false, "NamedSubentityRef", 1049817, false, false, true, null)]
    protected Environment _ToSpecStep;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow.", "BPSubWorkflowStep", false, false, false, "NamedSubentityRef", 1049067, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_WorkflowStack")]
    protected Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_Step")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, false, "NamedSubentityRef", 1049032, false, false, true, null)]
    protected Environment _Step;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow.", "BPSubWorkflowStep", false, false, false, "NamedSubentityRef", 1049818, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_ToWorkflowStack")]
    protected Environment _ToWorkflowStack;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components.", "BusinessProcessSpec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_ToWorkflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflow", false, false, false, "RevisionedObjectRef", 1049622, false, false, true, null)]
    protected Environment _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_TrackableObject")]
    [Metadata("BaseObject", "BaseObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    protected new Environment _TrackableObject;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049437, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_ClearToWorkflowStack")]
    protected Environment _ClearToWorkflowStack;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1048927, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_FromStep")]
    protected Environment _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveTxn_Environment_ToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048929, false, false, true, null)]
    protected Environment _ToStep;

    public Environment WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public Environment NavigationMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NavigationMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NavigationMode));
      }
    }

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Path));
      }
    }

    public Environment ToSpecStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToSpecStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToSpecStep));
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

    public Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }

    public Environment ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToWorkflowStack));
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

    public Environment ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Environment ClearToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearToWorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClearToWorkflowStack));
      }
    }

    public Environment FromStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStep));
      }
    }

    public Environment ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStep));
      }
    }
  }
}
