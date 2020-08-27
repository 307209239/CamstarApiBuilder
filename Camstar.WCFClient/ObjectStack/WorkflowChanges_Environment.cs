// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkflowChanges_Environment
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
  public class WorkflowChanges_Environment : BusinessProcessWorkflowChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_Gates")]
    [Metadata("Changes CDO for Gate.", "GateChanges", false, false, false, "GateChanges", 1049328, false, true, false, null)]
    protected GateChanges_Environment _Gates;
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "NamedSubentityRef", 1048931, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_FirstStep")]
    protected new Environment _FirstStep;
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a mirror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRoute", false, false, false, "RevisionedObjectRef", 1049919, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_ERPRoute")]
    protected Environment _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_Steps")]
    [Metadata("This CDO contains all the fields for a Spec Step and a Subworkflow Step.  This CDO will not be instanciated directly however.  The SpecStepChanges and SubworkflowStepChanges will be used.  The only difference is that the ObjectToChange Field type have been overridden.", "StepChanges", false, false, false, "StepChanges", 1048932, false, true, false, null)]
    protected new StepChanges_Environment _Steps;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_Image")]
    [Metadata("URL", "", false, false, false, "String", 1050307, false, false, false, null)]
    protected Environment _Image;
    [Metadata("Percentage", "", false, false, false, "Fixed", 1048719, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_TotalYield")]
    protected Environment _TotalYield;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_ObjectToChange")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_IsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "1")]
    protected new Environment _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050233, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_Base")]
    [Metadata("The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.  WorkflowBase is the specific type of RevisionBase used for a workflow, which defines the route and processing details required for a manufacturing process.", "WorkflowBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1048718, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WorkflowChanges_Environment_TotalCycleTime")]
    protected Environment _TotalCycleTime;

    public GateChanges_Environment Gates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gates), (object) value);
      }
      get
      {
        return (GateChanges_Environment) this.PropertyGet(nameof (Gates));
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

    public Environment ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPRoute));
      }
    }

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

    public Environment Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Image));
      }
    }

    public Environment TotalYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalYield), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalYield));
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

    public Environment TotalCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalCycleTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalCycleTime));
      }
    }
  }
}
