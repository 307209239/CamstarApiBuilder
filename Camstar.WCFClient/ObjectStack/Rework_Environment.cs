// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Rework_Environment
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
  public class Rework_Environment : MoveTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_ReEntryStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1049469, false, false, true, null)]
    protected Environment _ReEntryStep;
    [Metadata("ReworkPath", "ReworkPath", false, false, false, "NamedSubentityRef", 1049030, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_Path")]
    protected new Environment _Path;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_NavigationMode")]
    [Metadata("Workflow navigation mode determines whether to use a regular Path or a ReworkPath during Move transactions.\r\nPossible navigational modes are:\r\nStandard = 1\r\nRework = 2", "WorkflowNavigationModeEnum", false, false, false, "Integer", 1050305, false, false, false, null)]
    protected new Environment _NavigationMode;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow. This allows, for example, the re-use of Workflows for Rework processing.\r\n\r\n", "SubWorkflowStep", false, false, false, "NamedSubentityRef", 1049824, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_ReEntryWorkflowStack")]
    protected Environment _ReEntryWorkflowStack;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050018, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_UseReEntryWorkflowStack")]
    protected Environment _UseReEntryWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_UseDispatch")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050386, false, false, false, "1")]
    protected new Environment _UseDispatch;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1049629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_ReEntryWorkflow")]
    protected Environment _ReEntryWorkflow;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049627, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_EndReworkStep")]
    protected Environment _EndReworkStep;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1049628, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_EndReworkWorkflow")]
    protected Environment _EndReworkWorkflow;
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, true, false, "NamedObjectRef", 1048740, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_ReworkReason")]
    protected Environment _ReworkReason;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048929, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Rework_Environment_ToStep")]
    protected new Environment _ToStep;

    public Environment ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReEntryStep));
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

    public new Environment NavigationMode
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

    public Environment ReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReEntryWorkflowStack));
      }
    }

    public Environment UseReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseReEntryWorkflowStack));
      }
    }

    public new Environment UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Environment ReEntryWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReEntryWorkflow));
      }
    }

    public Environment EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndReworkStep));
      }
    }

    public Environment EndReworkWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndReworkWorkflow));
      }
    }

    public Environment ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReworkReason));
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
  }
}
