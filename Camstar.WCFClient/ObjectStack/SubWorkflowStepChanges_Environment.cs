// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubWorkflowStepChanges_Environment
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
  public class SubWorkflowStepChanges_Environment : StepChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Environment_ObjectToChange")]
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow. This allows, for example, the re-use of Workflows for Rework processing.\r\n\r\n", "SubWorkflowStep", false, false, false, "NamedSubentityRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Allows maintenance of the scheduling details for a sub-workflow step.", "SubWFStepSchedDetailChanges", false, false, false, "SubWFStepSchedDetailChanges", 1050045, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Environment_SchedulingDetail")]
    protected SubWFStepSchedDetailChanges_Environment _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Environment_SubWorkflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    protected Environment _SubWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Environment_StepType")]
    [Metadata("Numeric Option", "", false, false, false, "Integer", 1048918, false, false, false, "2")]
    protected new Environment _StepType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050260, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubWorkflowStepChanges_Environment_Name")]
    protected new Environment _Name;

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

    public SubWFStepSchedDetailChanges_Environment SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (SubWFStepSchedDetailChanges_Environment) this.PropertyGet(nameof (SchedulingDetail));
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
