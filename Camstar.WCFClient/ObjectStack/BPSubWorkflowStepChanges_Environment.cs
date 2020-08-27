// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPSubWorkflowStepChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChangeMgtSubWFStepChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class BPSubWorkflowStepChanges_Environment : StepChanges_Environment
  {
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflow", false, false, false, "RevisionedObjectRef", 16777326, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_Environment_SubWorkflow")]
    protected Environment _SubWorkflow;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow.", "BPSubWorkflowStep", false, false, false, "NamedSubentityRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Numeric Option", "", false, false, false, "Integer", 1048918, false, false, false, "2")]
    [DataMember(EmitDefaultValue = false, Name = "BPSubWorkflowStepChanges_Environment_StepType")]
    protected new Environment _StepType;

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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
