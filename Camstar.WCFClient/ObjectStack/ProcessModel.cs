// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModel
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
  public class ProcessModel : ProcessObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_ESigHistoryDetails")]
    protected new SubentityRef[] _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_OwnerRole")]
    protected new NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Attachments")]
    protected new DocAttachments _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_AssigneeRole")]
    protected new NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_ReassignmentComments")]
    protected new Primitive<string> _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_AssigneeOption")]
    protected new Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_LastStage")]
    protected new Enumeration<StageEnum, int> _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_OutstandingDetailStatus")]
    protected new Enumeration<ProcObjectOutstandingDtlEnum, int> _OutstandingDetailStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_DataPointCollection")]
    protected new DataPointCollection _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_AllowReassignment")]
    protected new Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Organization")]
    protected new NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Checklist")]
    protected new Checklist _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Stage")]
    protected new Enumeration<StageEnum, int> _Stage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_onStartRules")]
    protected BusinessRuleData[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Details")]
    protected new ProcessObject[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_onCompleteRules")]
    protected BusinessRuleData[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Sequence")]
    protected new Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_LastDesignatedOnGMT")]
    protected new Primitive<DateTime> _LastDesignatedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_FirstRoutedOn")]
    protected new Primitive<DateTime> _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_AutoComplete")]
    protected new Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_LastCompletedOn")]
    protected new Primitive<DateTime> _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_DefaultAssigneeInfo")]
    protected new Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_AutoStart")]
    protected new Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_LastCompletedOnGMT")]
    protected new Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_IsRequired")]
    protected new Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_FirstRoutedOnGMT")]
    protected new Primitive<DateTime> _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_LastDesignatedOn")]
    protected new Primitive<DateTime> _LastDesignatedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_AutoCompleteFailure")]
    protected new Primitive<bool> _AutoCompleteFailure;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_DocumentSet")]
    protected new NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_CompletionComments")]
    protected new Primitive<string> _CompletionComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Owner")]
    protected new NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Assignee")]
    protected new NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_LastCompletedBy")]
    protected new NamedObjectRef _LastCompletedBy;

    public override bool Equals(object obj)
    {
      return obj is ProcessModel && this.CompareArrays((Array) this._ESigHistoryDetails, (Array) ((ProcessModel) obj)._ESigHistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ProcessModel) obj)._ExportImportKey) && object.Equals((object) this._Description, (object) ((ProcessModel) obj)._Description)) && (object.Equals((object) this._OwnerRole, (object) ((ProcessModel) obj)._OwnerRole) && object.Equals((object) this._Attachments, (object) ((ProcessModel) obj)._Attachments) && (object.Equals((object) this._AssigneeRole, (object) ((ProcessModel) obj)._AssigneeRole) && object.Equals((object) this._ReassignmentComments, (object) ((ProcessModel) obj)._ReassignmentComments))) && (object.Equals((object) this._AssigneeOption, (object) ((ProcessModel) obj)._AssigneeOption) && object.Equals((object) this._LastStage, (object) ((ProcessModel) obj)._LastStage) && (object.Equals((object) this._OutstandingDetailStatus, (object) ((ProcessModel) obj)._OutstandingDetailStatus) && object.Equals((object) this._DataPointCollection, (object) ((ProcessModel) obj)._DataPointCollection)) && (object.Equals((object) this._AllowReassignment, (object) ((ProcessModel) obj)._AllowReassignment) && object.Equals((object) this._Organization, (object) ((ProcessModel) obj)._Organization) && (object.Equals((object) this._Checklist, (object) ((ProcessModel) obj)._Checklist) && object.Equals((object) this._Stage, (object) ((ProcessModel) obj)._Stage)))) && (this.CompareArrays((Array) this._onStartRules, (Array) ((ProcessModel) obj)._onStartRules) && this.CompareArrays((Array) this._Details, (Array) ((ProcessModel) obj)._Details) && (this.CompareArrays((Array) this._onCompleteRules, (Array) ((ProcessModel) obj)._onCompleteRules) && object.Equals((object) this._Sequence, (object) ((ProcessModel) obj)._Sequence)) && (object.Equals((object) this._LastDesignatedOnGMT, (object) ((ProcessModel) obj)._LastDesignatedOnGMT) && object.Equals((object) this._FirstRoutedOn, (object) ((ProcessModel) obj)._FirstRoutedOn) && (object.Equals((object) this._AutoComplete, (object) ((ProcessModel) obj)._AutoComplete) && object.Equals((object) this._LastCompletedOn, (object) ((ProcessModel) obj)._LastCompletedOn))) && (object.Equals((object) this._DefaultAssigneeInfo, (object) ((ProcessModel) obj)._DefaultAssigneeInfo) && object.Equals((object) this._AutoStart, (object) ((ProcessModel) obj)._AutoStart) && (object.Equals((object) this._LastCompletedOnGMT, (object) ((ProcessModel) obj)._LastCompletedOnGMT) && object.Equals((object) this._IsRequired, (object) ((ProcessModel) obj)._IsRequired)) && (object.Equals((object) this._FirstRoutedOnGMT, (object) ((ProcessModel) obj)._FirstRoutedOnGMT) && object.Equals((object) this._LastDesignatedOn, (object) ((ProcessModel) obj)._LastDesignatedOn) && (object.Equals((object) this._AutoCompleteFailure, (object) ((ProcessModel) obj)._AutoCompleteFailure) && object.Equals((object) this._IsFrozen, (object) ((ProcessModel) obj)._IsFrozen))))) && (object.Equals((object) this._ChangeHistory, (object) ((ProcessModel) obj)._ChangeHistory) && object.Equals((object) this._DocumentSet, (object) ((ProcessModel) obj)._DocumentSet) && (object.Equals((object) this._CompletionComments, (object) ((ProcessModel) obj)._CompletionComments) && object.Equals((object) this._Name, (object) ((ProcessModel) obj)._Name)) && (object.Equals((object) this._Owner, (object) ((ProcessModel) obj)._Owner) && object.Equals((object) this._Assignee, (object) ((ProcessModel) obj)._Assignee) && (object.Equals((object) this._Notes, (object) ((ProcessModel) obj)._Notes) && object.Equals((object) this._LastCompletedBy, (object) ((ProcessModel) obj)._LastCompletedBy)))) && base.Equals(obj);
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
  }
}
