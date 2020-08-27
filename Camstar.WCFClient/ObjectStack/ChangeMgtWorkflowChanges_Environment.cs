// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeMgtWorkflowChanges_Environment
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
  public class ChangeMgtWorkflowChanges_Environment : BusinessProcessWorkflowChanges_Environment
  {
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "StepChanges", 1048932, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Environment_Steps")]
    protected new StepChanges_Environment _Steps;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Environment_FirstStep")]
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "NamedSubentityRef", 1048931, false, false, false, null)]
    protected new Environment _FirstStep;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Environment_Base")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflowBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16777290, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeMgtWorkflowChanges_Environment_Name")]
    protected new Environment _Name;

    public new StepChanges_Environment Steps
    {
      [param: In] set
      {
        this.PropertySet(nameof (Steps), (object) value);
      }
      get
      {
        return (StepChanges_Environment) this.PropertyGet(nameof (Steps));
      }
    }

    public new Environment FirstStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FirstStep));
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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
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
