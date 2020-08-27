// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeProcess
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
  public class ChangeProcess : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_AuditTrail")]
    protected SubentityRef _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_RuleList")]
    protected Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ProcessModelDetails")]
    protected ProcessModel _ProcessModelDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ProcessObjectDetails")]
    protected new Camstar.WCF.ObjectStack.ProcessObject _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ProcessObjectMaint")]
    protected ProcessObjectMaint _ProcessObjectMaint;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_PhaseTemplate")]
    protected NamedObjectRef _PhaseTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ActivityTemplate")]
    protected NamedObjectRef _ActivityTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ProcessModelTemplate")]
    protected RevisionedObjectRef _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ObjectChanges")]
    protected ProcessObjectChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ExecuteChecklist")]
    protected ExecuteChecklist _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_CollectDataPoints")]
    protected CollectDataPoints _CollectDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_PlanTemplate")]
    protected NamedObjectRef _PlanTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_BusinessRule")]
    protected NamedObjectRef _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ActivityInvestigation")]
    protected NamedSubentityRef _ActivityInvestigation;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ProcessModel")]
    protected ProcessModel _ProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Plan")]
    protected NamedSubentityRef _Plan;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Phase")]
    protected NamedSubentityRef _Phase;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Activity")]
    protected NamedSubentityRef _Activity;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ParentDataObject")]
    protected BaseObjectRef _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_TriageComplete")]
    protected Primitive<bool> _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Template")]
    protected BaseObjectRef _Template;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_ActivityType")]
    protected Primitive<string> _ActivityType;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_MaintenanceType")]
    protected Primitive<string> _MaintenanceType;

    public override bool Equals(object obj)
    {
      return obj is ChangeProcess && object.Equals((object) this._QualityObject, (object) ((ChangeProcess) obj)._QualityObject) && (object.Equals((object) this._AuditTrail, (object) ((ChangeProcess) obj)._AuditTrail) && object.Equals((object) this._RuleList, (object) ((ChangeProcess) obj)._RuleList)) && (object.Equals((object) this._ProcessModelDetails, (object) ((ChangeProcess) obj)._ProcessModelDetails) && object.Equals((object) this._ProcessObjectDetails, (object) ((ChangeProcess) obj)._ProcessObjectDetails) && (object.Equals((object) this._ProcessObjectMaint, (object) ((ChangeProcess) obj)._ProcessObjectMaint) && object.Equals((object) this._PhaseTemplate, (object) ((ChangeProcess) obj)._PhaseTemplate))) && (object.Equals((object) this._ActivityTemplate, (object) ((ChangeProcess) obj)._ActivityTemplate) && object.Equals((object) this._ProcessModelTemplate, (object) ((ChangeProcess) obj)._ProcessModelTemplate) && (object.Equals((object) this._ObjectChanges, (object) ((ChangeProcess) obj)._ObjectChanges) && object.Equals((object) this._ExecuteChecklist, (object) ((ChangeProcess) obj)._ExecuteChecklist)) && (object.Equals((object) this._CollectDataPoints, (object) ((ChangeProcess) obj)._CollectDataPoints) && object.Equals((object) this._ProcessObject, (object) ((ChangeProcess) obj)._ProcessObject) && (object.Equals((object) this._PlanTemplate, (object) ((ChangeProcess) obj)._PlanTemplate) && object.Equals((object) this._ChecklistTemplate, (object) ((ChangeProcess) obj)._ChecklistTemplate)))) && (object.Equals((object) this._BusinessRule, (object) ((ChangeProcess) obj)._BusinessRule) && object.Equals((object) this._ActivityInvestigation, (object) ((ChangeProcess) obj)._ActivityInvestigation) && (object.Equals((object) this._ApprovalSheetTemplate, (object) ((ChangeProcess) obj)._ApprovalSheetTemplate) && object.Equals((object) this._ObjectToChange, (object) ((ChangeProcess) obj)._ObjectToChange)) && (object.Equals((object) this._ProcessModel, (object) ((ChangeProcess) obj)._ProcessModel) && object.Equals((object) this._Plan, (object) ((ChangeProcess) obj)._Plan) && (object.Equals((object) this._Phase, (object) ((ChangeProcess) obj)._Phase) && object.Equals((object) this._Activity, (object) ((ChangeProcess) obj)._Activity))) && (object.Equals((object) this._ParentDataObject, (object) ((ChangeProcess) obj)._ParentDataObject) && object.Equals((object) this._ProcessESignatures, (object) ((ChangeProcess) obj)._ProcessESignatures) && (object.Equals((object) this._TriageComplete, (object) ((ChangeProcess) obj)._TriageComplete) && object.Equals((object) this._Template, (object) ((ChangeProcess) obj)._Template)) && (object.Equals((object) this._ActivityType, (object) ((ChangeProcess) obj)._ActivityType) && object.Equals((object) this._MaintenanceType, (object) ((ChangeProcess) obj)._MaintenanceType)))) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public SubentityRef AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Primitive<string> RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RuleList));
      }
    }

    public ProcessModel ProcessModelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelDetails), (object) value);
      }
      get
      {
        return (ProcessModel) this.PropertyGet(nameof (ProcessModelDetails));
      }
    }

    public new Camstar.WCF.ObjectStack.ProcessObject ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ProcessObject) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public ProcessObjectMaint ProcessObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectMaint), (object) value);
      }
      get
      {
        return (ProcessObjectMaint) this.PropertyGet(nameof (ProcessObjectMaint));
      }
    }

    public NamedObjectRef PhaseTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhaseTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PhaseTemplate));
      }
    }

    public NamedObjectRef ActivityTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActivityTemplate));
      }
    }

    public RevisionedObjectRef ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public ProcessObjectChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ExecuteChecklist ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public CollectDataPoints CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public new NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public NamedObjectRef PlanTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PlanTemplate));
      }
    }

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public NamedObjectRef BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public NamedSubentityRef ActivityInvestigation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityInvestigation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ActivityInvestigation));
      }
    }

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ProcessModel ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (ProcessModel) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public NamedSubentityRef Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Plan));
      }
    }

    public NamedSubentityRef Phase
    {
      [param: In] set
      {
        this.PropertySet(nameof (Phase), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Phase));
      }
    }

    public NamedSubentityRef Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Activity));
      }
    }

    public BaseObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Primitive<bool> TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public BaseObjectRef Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Template));
      }
    }

    public Primitive<string> ActivityType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ActivityType));
      }
    }

    public Primitive<string> MaintenanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceType));
      }
    }
  }
}
