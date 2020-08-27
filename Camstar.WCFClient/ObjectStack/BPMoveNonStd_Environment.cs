// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPMoveNonStd_Environment
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
  public class BPMoveNonStd_Environment : BPMoveTxn_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 16777408, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_Comments")]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_Path")]
    [Metadata("ReworkPath", "ReworkPath", false, false, false, "NamedSubentityRef", 1049030, false, false, true, null)]
    protected new Environment _Path;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, false, "NamedSubentityRef", 16777459, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_ToStep")]
    protected new Environment _ToStep;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, false, "RevisionedObjectRef", 1049622, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_ToWorkflow")]
    protected new Environment _ToWorkflow;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components.", "BusinessProcessSpec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_Spec")]
    protected new Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_Step")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, false, "NamedSubentityRef", 1049032, false, false, true, null)]
    protected new Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_WorkflowStack")]
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow.", "BPSubWorkflowStep", false, false, false, "NamedSubentityRef", 1049067, false, true, true, null)]
    protected new Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_ToWorkflowStack")]
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow.", "BPSubWorkflowStep", false, false, false, "NamedSubentityRef", 1049818, false, true, true, null)]
    protected new Environment _ToWorkflowStack;
    [Metadata("A CDO with the intention of being subclassed for usage in a business process which includes possibly a workflow.", "TrackableObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, false, "NamedSubentityRef", 1049817, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPMoveNonStd_Environment_ToSpecStep")]
    protected new Environment _ToSpecStep;

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

    public new Environment Path
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

    public new Environment ToStep
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

    public new Environment ToWorkflow
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

    public new Environment Spec
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

    public new Environment Step
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

    public new Environment WorkflowStack
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

    public new Environment ToWorkflowStack
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

    public new Environment ToSpecStep
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
  }
}
