// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackableObjectCurrentStatus_Environment
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
  public class TrackableObjectCurrentStatus_Environment : BaseObject_Environment
  {
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "BusinessProcessSpecStep", false, false, true, "NamedSubentityRef", 1048855, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Environment_WorkflowStep")]
    protected Environment _WorkflowStep;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow.", "BPSubWorkflowStep", false, false, true, "NamedSubentityRef", 1049067, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Environment_WorkflowStack")]
    protected Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, false, null)]
    protected Environment _Workflow;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Environment_LastMoveDate")]
    protected Environment _LastMoveDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048808, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrackableObjectCurrentStatus_Environment_LastMoveDateGMT")]
    protected Environment _LastMoveDateGMT;

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
  }
}
