// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveStdChangePkg_Environment
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
  public class MoveStdChangePkg_Environment : BPMoveStd_Environment
  {
    [Metadata("Navigate through a workflow, including subworkflows and rework information.", "WorkflowNavigator", false, false, true, "SubentityRef", 1049790, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_WorkflowNavigator")]
    protected new Environment _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_Step")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "ChangeMgtSpecStep", false, false, false, "NamedSubentityRef", 1049032, false, false, true, null)]
    protected new Environment _Step;
    [Metadata("ChangeMgtSubWorkflowStep", "ChangeMgtSubWorkflowStep", false, false, false, "NamedSubentityRef", 1049067, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_WorkflowStack")]
    protected new Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_ToSpecStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "ChangeMgtSpecStep", false, false, false, "NamedSubentityRef", 1049817, false, false, true, null)]
    protected new Environment _ToSpecStep;
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_Spec")]
    protected new Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_ToWorkflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, false, "RevisionedObjectRef", 1049622, false, false, true, null)]
    protected new Environment _ToWorkflow;
    [Metadata("ChangeMgtSubWorkflowStep", "ChangeMgtSubWorkflowStep", false, false, false, "NamedSubentityRef", 1049818, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_ToWorkflowStack")]
    protected new Environment _ToWorkflowStack;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1051446, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "MoveStdChangePkg_Environment_ChangePackageHeader")]
    [Metadata("Detail information about a change package.", "ChangePackageHeader", false, false, false, "ChangePackageHeader", 1053248, false, false, false, null)]
    protected ChangePackageHeader_Environment _ChangePackageHeader;

    public new Environment WorkflowNavigator
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

    public ChangePackageHeader_Environment ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Environment) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }
  }
}
