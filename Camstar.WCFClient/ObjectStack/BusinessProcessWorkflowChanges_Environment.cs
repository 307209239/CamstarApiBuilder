// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessWorkflowChanges_Environment
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
  public class BusinessProcessWorkflowChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "NamedSubentityRef", 1048931, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Environment_FirstStep")]
    protected Environment _FirstStep;
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "StepChanges", 1048932, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Environment_Steps")]
    protected StepChanges_Environment _Steps;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflow", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "BusinessProcessWorkflowBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Environment_Base")]
    protected new Environment _Base;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Environment_IsRevOfRcd")]
    protected new Environment _IsRevOfRcd;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053250, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessWorkflowChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment FirstStep
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

    public StepChanges_Environment Steps
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

    public new Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
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
