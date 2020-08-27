// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeProcess_Info
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
  public class ChangeProcess_Info : ProcessObjectTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_AuditTrail")]
    protected Info _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_RuleList")]
    protected Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ProcessModelDetails")]
    protected ProcessModel_Info _ProcessModelDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ProcessObjectDetails")]
    protected new ProcessObject_Info _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ProcessObjectMaint")]
    protected ProcessObjectMaint_Info _ProcessObjectMaint;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_PhaseTemplate")]
    protected Info _PhaseTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ActivityTemplate")]
    protected Info _ActivityTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ProcessModelTemplate")]
    protected Info _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ObjectChanges")]
    protected ProcessObjectChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ExecuteChecklist")]
    protected ExecuteChecklist_Info _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_CollectDataPoints")]
    protected CollectDataPoints_Info _CollectDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ProcessObject")]
    protected new Info _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_PlanTemplate")]
    protected Info _PlanTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_BusinessRule")]
    protected Info _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ActivityInvestigation")]
    protected Info _ActivityInvestigation;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ObjectToChange")]
    protected Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ProcessModel")]
    protected ProcessModel_Info _ProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_Plan")]
    protected Info _Plan;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_Phase")]
    protected Info _Phase;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_Activity")]
    protected Info _Activity;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ParentDataObject")]
    protected Info _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ProcessESignatures")]
    protected new Info _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_TriageComplete")]
    protected Info _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_Template")]
    protected Info _Template;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_ActivityType")]
    protected Info _ActivityType;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Info_MaintenanceType")]
    protected Info _MaintenanceType;

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Info AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Info RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RuleList));
      }
    }

    public ProcessModel_Info ProcessModelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelDetails), (object) value);
      }
      get
      {
        return (ProcessModel_Info) this.PropertyGet(nameof (ProcessModelDetails));
      }
    }

    public new ProcessObject_Info ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Info) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public ProcessObjectMaint_Info ProcessObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectMaint), (object) value);
      }
      get
      {
        return (ProcessObjectMaint_Info) this.PropertyGet(nameof (ProcessObjectMaint));
      }
    }

    public Info PhaseTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhaseTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhaseTemplate));
      }
    }

    public Info ActivityTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActivityTemplate));
      }
    }

    public Info ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public ProcessObjectChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ExecuteChecklist_Info ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Info) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public CollectDataPoints_Info CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints_Info) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public new Info ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Info PlanTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlanTemplate));
      }
    }

    public Info ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public Info BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public Info ActivityInvestigation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityInvestigation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActivityInvestigation));
      }
    }

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ProcessModel_Info ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (ProcessModel_Info) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public Info Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Plan));
      }
    }

    public Info Phase
    {
      [param: In] set
      {
        this.PropertySet(nameof (Phase), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Phase));
      }
    }

    public Info Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Activity));
      }
    }

    public Info ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public new Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Info Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Template));
      }
    }

    public Info ActivityType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActivityType));
      }
    }

    public Info MaintenanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceType));
      }
    }
  }
}
