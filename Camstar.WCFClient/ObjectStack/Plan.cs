// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Plan
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PlanDisposition))]
  [Serializable]
  public class Plan : ProcessObject
  {
    [DataMember(EmitDefaultValue = false, Name = "Plan_AssigneeRole")]
    protected new NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "Plan_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Plan_OwnerRole")]
    protected new NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "Plan_ESigHistoryDetails")]
    protected new SubentityRef[] _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "Plan_ReassignmentComments")]
    protected new Primitive<string> _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Attachments")]
    protected new DocAttachments _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "Plan_AssigneeOption")]
    protected new Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Stage")]
    protected new Enumeration<StageEnum, int> _Stage;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Details")]
    protected new ProcessObject[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "Plan_onStartRules")]
    protected BusinessRuleData[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Organization")]
    protected new NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "Plan_CompleteWithinUOM")]
    protected Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "Plan_LastStage")]
    protected new Enumeration<StageEnum, int> _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "Plan_OutstandingDetailStatus")]
    protected new Enumeration<ProcObjectOutstandingDtlEnum, int> _OutstandingDetailStatus;
    [DataMember(EmitDefaultValue = false, Name = "Plan_LastApprovalRouted")]
    protected NamedSubentityRef _LastApprovalRouted;
    [DataMember(EmitDefaultValue = false, Name = "Plan_ApprovalSheets")]
    protected ApprovalSheet[] _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "Plan_DataPointCollection")]
    protected new DataPointCollection _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "Plan_onCompleteRules")]
    protected BusinessRuleData[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Checklist")]
    protected new Checklist _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Prerequisites")]
    protected Plan[] _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "Plan_AllowReassignment")]
    protected new Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "Plan_AutoStart")]
    protected new Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "Plan_CompleteWithinQty")]
    protected Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "Plan_LastCompletedOn")]
    protected new Primitive<DateTime> _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "Plan_LastCompletedOnGMT")]
    protected new Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Sequence")]
    protected new Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "Plan_LastDesignatedOnGMT")]
    protected new Primitive<DateTime> _LastDesignatedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "Plan_AutoComplete")]
    protected new Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "Plan_LastDesignatedOn")]
    protected new Primitive<DateTime> _LastDesignatedOn;
    [DataMember(EmitDefaultValue = false, Name = "Plan_AutoCompleteFailure")]
    protected new Primitive<bool> _AutoCompleteFailure;
    [DataMember(EmitDefaultValue = false, Name = "Plan_CompleteBy")]
    protected Primitive<DateTime> _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "Plan_DefaultAssigneeInfo")]
    protected new Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "Plan_FirstRoutedOnGMT")]
    protected new Primitive<DateTime> _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "Plan_FirstRoutedOn")]
    protected new Primitive<DateTime> _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "Plan_CompleteByGMT")]
    protected Primitive<DateTime> _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "Plan_IsRequired")]
    protected new Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "Plan_LastCompletedBy")]
    protected new NamedObjectRef _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "Plan_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Plan_CompleteWithin")]
    protected Primitive<double> _CompleteWithin;
    [DataMember(EmitDefaultValue = false, Name = "Plan_CompletionComments")]
    protected new Primitive<string> _CompletionComments;
    [DataMember(EmitDefaultValue = false, Name = "Plan_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Plan_DocumentSet")]
    protected new NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Assignee")]
    protected new NamedObjectRef _Assignee;

    public override bool Equals(object obj)
    {
      return obj is Plan && object.Equals((object) this._AssigneeRole, (object) ((Plan) obj)._AssigneeRole) && (object.Equals((object) this._Description, (object) ((Plan) obj)._Description) && object.Equals((object) this._ExportImportKey, (object) ((Plan) obj)._ExportImportKey)) && (object.Equals((object) this._OwnerRole, (object) ((Plan) obj)._OwnerRole) && this.CompareArrays((Array) this._ESigHistoryDetails, (Array) ((Plan) obj)._ESigHistoryDetails) && (object.Equals((object) this._ReassignmentComments, (object) ((Plan) obj)._ReassignmentComments) && object.Equals((object) this._Attachments, (object) ((Plan) obj)._Attachments))) && (object.Equals((object) this._AssigneeOption, (object) ((Plan) obj)._AssigneeOption) && object.Equals((object) this._Stage, (object) ((Plan) obj)._Stage) && (this.CompareArrays((Array) this._Details, (Array) ((Plan) obj)._Details) && this.CompareArrays((Array) this._onStartRules, (Array) ((Plan) obj)._onStartRules)) && (object.Equals((object) this._Organization, (object) ((Plan) obj)._Organization) && object.Equals((object) this._CompleteWithinUOM, (object) ((Plan) obj)._CompleteWithinUOM) && (object.Equals((object) this._LastStage, (object) ((Plan) obj)._LastStage) && object.Equals((object) this._OutstandingDetailStatus, (object) ((Plan) obj)._OutstandingDetailStatus)))) && (object.Equals((object) this._LastApprovalRouted, (object) ((Plan) obj)._LastApprovalRouted) && this.CompareArrays((Array) this._ApprovalSheets, (Array) ((Plan) obj)._ApprovalSheets) && (object.Equals((object) this._DataPointCollection, (object) ((Plan) obj)._DataPointCollection) && this.CompareArrays((Array) this._onCompleteRules, (Array) ((Plan) obj)._onCompleteRules)) && (object.Equals((object) this._Checklist, (object) ((Plan) obj)._Checklist) && this.CompareArrays((Array) this._Prerequisites, (Array) ((Plan) obj)._Prerequisites) && (object.Equals((object) this._AllowReassignment, (object) ((Plan) obj)._AllowReassignment) && object.Equals((object) this._AutoStart, (object) ((Plan) obj)._AutoStart))) && (object.Equals((object) this._CompleteWithinQty, (object) ((Plan) obj)._CompleteWithinQty) && object.Equals((object) this._LastCompletedOn, (object) ((Plan) obj)._LastCompletedOn) && (object.Equals((object) this._LastCompletedOnGMT, (object) ((Plan) obj)._LastCompletedOnGMT) && object.Equals((object) this._Sequence, (object) ((Plan) obj)._Sequence)) && (object.Equals((object) this._LastDesignatedOnGMT, (object) ((Plan) obj)._LastDesignatedOnGMT) && object.Equals((object) this._AutoComplete, (object) ((Plan) obj)._AutoComplete) && (object.Equals((object) this._LastDesignatedOn, (object) ((Plan) obj)._LastDesignatedOn) && object.Equals((object) this._AutoCompleteFailure, (object) ((Plan) obj)._AutoCompleteFailure))))) && (object.Equals((object) this._CompleteBy, (object) ((Plan) obj)._CompleteBy) && object.Equals((object) this._DefaultAssigneeInfo, (object) ((Plan) obj)._DefaultAssigneeInfo) && (object.Equals((object) this._FirstRoutedOnGMT, (object) ((Plan) obj)._FirstRoutedOnGMT) && object.Equals((object) this._FirstRoutedOn, (object) ((Plan) obj)._FirstRoutedOn)) && (object.Equals((object) this._CompleteByGMT, (object) ((Plan) obj)._CompleteByGMT) && object.Equals((object) this._IsRequired, (object) ((Plan) obj)._IsRequired) && (object.Equals((object) this._LastCompletedBy, (object) ((Plan) obj)._LastCompletedBy) && object.Equals((object) this._ChangeHistory, (object) ((Plan) obj)._ChangeHistory))) && (object.Equals((object) this._Notes, (object) ((Plan) obj)._Notes) && object.Equals((object) this._CompleteWithin, (object) ((Plan) obj)._CompleteWithin) && (object.Equals((object) this._CompletionComments, (object) ((Plan) obj)._CompletionComments) && object.Equals((object) this._IsFrozen, (object) ((Plan) obj)._IsFrozen)) && (object.Equals((object) this._DocumentSet, (object) ((Plan) obj)._DocumentSet) && object.Equals((object) this._Owner, (object) ((Plan) obj)._Owner) && (object.Equals((object) this._Name, (object) ((Plan) obj)._Name) && object.Equals((object) this._Assignee, (object) ((Plan) obj)._Assignee))))) && base.Equals(obj);
    }

    public new NamedObjectRef AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new NamedObjectRef OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public new SubentityRef[] ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public new Primitive<string> ReassignmentComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReassignmentComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReassignmentComments));
      }
    }

    public new DocAttachments Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments) this.PropertyGet(nameof (Attachments));
      }
    }

    public new Enumeration<AssigneeOptionEnum, int> AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Enumeration<AssigneeOptionEnum, int>) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public new Enumeration<StageEnum, int> Stage
    {
      [param: In] set
      {
        this.PropertySet(nameof (Stage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (Stage));
      }
    }

    public new ProcessObject[] Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObject[]) this.PropertyGet(nameof (Details));
      }
    }

    public BusinessRuleData[] onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleData[]) this.PropertyGet(nameof (onStartRules));
      }
    }

    public new NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public Enumeration<DurationUOMEnum, string> CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Enumeration<DurationUOMEnum, string>) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public new Enumeration<StageEnum, int> LastStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (LastStage));
      }
    }

    public new Enumeration<ProcObjectOutstandingDtlEnum, int> OutstandingDetailStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutstandingDetailStatus), (object) value);
      }
      get
      {
        return (Enumeration<ProcObjectOutstandingDtlEnum, int>) this.PropertyGet(nameof (OutstandingDetailStatus));
      }
    }

    public NamedSubentityRef LastApprovalRouted
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalRouted), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (LastApprovalRouted));
      }
    }

    public ApprovalSheet[] ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheet[]) this.PropertyGet(nameof (ApprovalSheets));
      }
    }

    public new DataPointCollection DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (DataPointCollection) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public BusinessRuleData[] onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleData[]) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public new Checklist Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Checklist) this.PropertyGet(nameof (Checklist));
      }
    }

    public Plan[] Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (Plan[]) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public new Enumeration<ReassignmentRestrictionEnum, int> AllowReassignment
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReassignment), (object) value);
      }
      get
      {
        return (Enumeration<ReassignmentRestrictionEnum, int>) this.PropertyGet(nameof (AllowReassignment));
      }
    }

    public new Primitive<bool> AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Primitive<int> CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public new Primitive<DateTime> LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public new Primitive<DateTime> LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletedOnGMT));
      }
    }

    public new Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public new Primitive<DateTime> LastDesignatedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDesignatedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDesignatedOnGMT));
      }
    }

    public new Primitive<bool> AutoComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoComplete));
      }
    }

    public new Primitive<DateTime> LastDesignatedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDesignatedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastDesignatedOn));
      }
    }

    public new Primitive<bool> AutoCompleteFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoCompleteFailure), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoCompleteFailure));
      }
    }

    public Primitive<DateTime> CompleteBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteBy), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompleteBy));
      }
    }

    public new Primitive<bool> DefaultAssigneeInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultAssigneeInfo), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DefaultAssigneeInfo));
      }
    }

    public new Primitive<DateTime> FirstRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FirstRoutedOnGMT));
      }
    }

    public new Primitive<DateTime> FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (FirstRoutedOn));
      }
    }

    public Primitive<DateTime> CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public new Primitive<bool> IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRequired));
      }
    }

    public new NamedObjectRef LastCompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LastCompletedBy));
      }
    }

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public Primitive<double> CompleteWithin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithin), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (CompleteWithin));
      }
    }

    public new Primitive<string> CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CompletionComments));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new NamedObjectRef Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Assignee));
      }
    }
  }
}
