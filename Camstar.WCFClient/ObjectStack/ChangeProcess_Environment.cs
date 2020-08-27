// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeProcess_Environment
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
  public class ChangeProcess_Environment : ProcessObjectTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected new Environment _QualityObject;
    [Metadata("Modeling Audit Trail Header encapsulates the header information captured during every modeling data object maintenance", "ModelingAuditTrailHeader", false, false, false, "SubentityRef", 1050782, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_AuditTrail")]
    protected Environment _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_RuleList")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051394, false, false, false, null)]
    protected Environment _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ProcessModelDetails")]
    [Metadata("A process model describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModel", false, false, true, "ProcessModel", 1051357, false, false, false, null)]
    protected ProcessModel_Environment _ProcessModelDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ProcessObjectDetails")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, false, "ProcessObject", 1051538, false, false, false, null)]
    protected new ProcessObject_Environment _ProcessObjectDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ProcessObjectMaint")]
    [Metadata("Used to maintain process object subentities", "ProcessObjectMaint", false, false, false, "ProcessObjectMaint", 1051401, false, false, false, null)]
    protected ProcessObjectMaint_Environment _ProcessObjectMaint;
    [Metadata("A template of a Phase.  A phase describes different stages of the process, e.g. Triage, Investigation, Implementation, Review.", "PhaseTemplate", false, false, false, "NamedObjectRef", 1051398, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_PhaseTemplate")]
    protected Environment _PhaseTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ActivityTemplate")]
    [Metadata("A template of an Activity, which is the basic unit of work used to process a Quality object.", "ActivityTemplate", false, false, false, "NamedObjectRef", 1051397, false, false, true, null)]
    protected Environment _ActivityTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ProcessModelTemplate")]
    [Metadata("A template of the Process object that describes the processing needed for a Quality Object", "ProcessModelTemplate", false, false, false, "RevisionedObjectRef", 1052177, false, false, true, null)]
    protected Environment _ProcessModelTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ObjectChanges")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObjectChanges", false, false, false, "ProcessObjectChanges", 1048873, false, false, false, null)]
    protected ProcessObjectChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ExecuteChecklist")]
    [Metadata("Execute Checklist transaction is used to complete assigned checklist.", "ExecuteChecklist", false, false, false, "ExecuteChecklist", 1052417, true, false, false, null)]
    protected ExecuteChecklist_Environment _ExecuteChecklist;
    [Metadata("The Collect Data Points transaction is used to collect data points for a trackable object.  It requires that the trackable object have a DataPointCollection assigned to it.", "CollectDataPoints", false, false, false, "CollectDataPoints", 1052463, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_CollectDataPoints")]
    protected CollectDataPoints_Environment _CollectDataPoints;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, false, "NamedSubentityRef", 1051396, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ProcessObject")]
    protected new Environment _ProcessObject;
    [Metadata("A template of Plan, which is a list of acivities used to process the Quality object.", "PlanTemplate", false, false, false, "NamedObjectRef", 1051399, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_PlanTemplate")]
    protected Environment _PlanTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ChecklistTemplate")]
    [Metadata("The Checklist Template object allows the user to configure checklist items/questions and associate each item with the appropriate Response Set.", "ChecklistTemplate", false, false, false, "RevisionedObjectRef", 1052389, false, false, true, null)]
    protected Environment _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_BusinessRule")]
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1048810, false, false, false, null)]
    protected Environment _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ActivityInvestigation")]
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigation", false, false, false, "NamedSubentityRef", 1052180, false, false, false, null)]
    protected Environment _ActivityInvestigation;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ApprovalSheetTemplate")]
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051618, false, false, true, null)]
    protected Environment _ApprovalSheetTemplate;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ObjectToChange")]
    protected Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ProcessModel")]
    [Metadata("A process model describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModel", false, false, false, "ProcessModel", 1051357, false, false, false, null)]
    protected ProcessModel_Environment _ProcessModel;
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, false, "NamedSubentityRef", 1051188, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_Plan")]
    protected Environment _Plan;
    [Metadata("A phase describes the general stages that a Quality object goes through during processing.", "Phase", false, false, false, "NamedSubentityRef", 1051187, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_Phase")]
    protected Environment _Phase;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_Activity")]
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, false, false, "NamedSubentityRef", 1050968, false, false, false, null)]
    protected Environment _Activity;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1050488, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ParentDataObject")]
    protected Environment _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ProcessESignatures")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    protected new Environment _ProcessESignatures;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051655, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_TriageComplete")]
    protected Environment _TriageComplete;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_Template")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051395, false, false, false, null)]
    protected Environment _Template;
    [Metadata("Generic String", "", false, false, false, "String", 1051602, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_ActivityType")]
    protected Environment _ActivityType;
    [DataMember(EmitDefaultValue = false, Name = "ChangeProcess_Environment_MaintenanceType")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1050764, false, false, false, null)]
    protected Environment _MaintenanceType;

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Environment AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Environment RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RuleList));
      }
    }

    public ProcessModel_Environment ProcessModelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelDetails), (object) value);
      }
      get
      {
        return (ProcessModel_Environment) this.PropertyGet(nameof (ProcessModelDetails));
      }
    }

    public new ProcessObject_Environment ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ProcessObject_Environment) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }

    public ProcessObjectMaint_Environment ProcessObjectMaint
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectMaint), (object) value);
      }
      get
      {
        return (ProcessObjectMaint_Environment) this.PropertyGet(nameof (ProcessObjectMaint));
      }
    }

    public Environment PhaseTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhaseTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhaseTemplate));
      }
    }

    public Environment ActivityTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActivityTemplate));
      }
    }

    public Environment ProcessModelTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessModelTemplate));
      }
    }

    public ProcessObjectChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ExecuteChecklist_Environment ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Environment) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public CollectDataPoints_Environment CollectDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectDataPoints), (object) value);
      }
      get
      {
        return (CollectDataPoints_Environment) this.PropertyGet(nameof (CollectDataPoints));
      }
    }

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public Environment PlanTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlanTemplate));
      }
    }

    public Environment ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public Environment BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public Environment ActivityInvestigation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityInvestigation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActivityInvestigation));
      }
    }

    public Environment ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public Environment ObjectToChange
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

    public ProcessModel_Environment ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (ProcessModel_Environment) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public Environment Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Plan));
      }
    }

    public Environment Phase
    {
      [param: In] set
      {
        this.PropertySet(nameof (Phase), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Phase));
      }
    }

    public Environment Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Activity));
      }
    }

    public Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Environment TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageComplete));
      }
    }

    public Environment Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Template));
      }
    }

    public Environment ActivityType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActivityType));
      }
    }

    public Environment MaintenanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceType));
      }
    }
  }
}
