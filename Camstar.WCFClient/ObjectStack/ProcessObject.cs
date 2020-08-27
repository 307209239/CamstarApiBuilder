// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObject
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (Phase))]
  [KnownType(typeof (ProcessModel))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (Activity))]
  [KnownType(typeof (Plan))]
  [Serializable]
  public class ProcessObject : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_ReassignmentComments")]
    protected Primitive<string> _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Attachments")]
    protected DocAttachments _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_ESigHistoryDetails")]
    protected SubentityRef[] _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_OwnerRole")]
    protected NamedObjectRef _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_OutstandingDetailStatus")]
    protected Enumeration<ProcObjectOutstandingDtlEnum, int> _OutstandingDetailStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_DataPointCollection")]
    protected DataPointCollection _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_ProcessLog")]
    protected CollaborationLogDetail[] _ProcessLog;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Prerequisites")]
    protected ProcessObject[] _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_AssigneeOption")]
    protected Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Details")]
    protected ProcessObject[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Stage")]
    protected Enumeration<StageEnum, int> _Stage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_AllowReassignment")]
    protected Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_LastStage")]
    protected Enumeration<StageEnum, int> _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Checklist")]
    protected Checklist _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_LastCompletedOn")]
    protected Primitive<DateTime> _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_OnHold")]
    protected Primitive<bool> _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_AutoComplete")]
    protected Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_DefaultAssigneeInfo")]
    protected Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_AutoStart")]
    protected Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_FirstRoutedOnGMT")]
    protected Primitive<DateTime> _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_LastDesignatedOn")]
    protected Primitive<DateTime> _LastDesignatedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_LastCompletedOnGMT")]
    protected Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_LastDesignatedOnGMT")]
    protected Primitive<DateTime> _LastDesignatedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_AutoCompleteFailure")]
    protected Primitive<bool> _AutoCompleteFailure;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_FirstRoutedOn")]
    protected Primitive<DateTime> _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_LastCompletedBy")]
    protected NamedObjectRef _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_ChangeHistory")]
    protected ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Assignee")]
    protected NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_CompletionComments")]
    protected Primitive<string> _CompletionComments;

    public override bool Equals(object obj)
    {
      return obj is ProcessObject && object.Equals((object) this._AssigneeRole, (object) ((ProcessObject) obj)._AssigneeRole) && (object.Equals((object) this._ReassignmentComments, (object) ((ProcessObject) obj)._ReassignmentComments) && object.Equals((object) this._ExportImportKey, (object) ((ProcessObject) obj)._ExportImportKey)) && (object.Equals((object) this._Description, (object) ((ProcessObject) obj)._Description) && object.Equals((object) this._Attachments, (object) ((ProcessObject) obj)._Attachments) && (object.Equals((object) this._DisplayName, (object) ((ProcessObject) obj)._DisplayName) && this.CompareArrays((Array) this._ESigHistoryDetails, (Array) ((ProcessObject) obj)._ESigHistoryDetails))) && (object.Equals((object) this._OwnerRole, (object) ((ProcessObject) obj)._OwnerRole) && object.Equals((object) this._OutstandingDetailStatus, (object) ((ProcessObject) obj)._OutstandingDetailStatus) && (object.Equals((object) this._DataPointCollection, (object) ((ProcessObject) obj)._DataPointCollection) && this.CompareArrays((Array) this._ProcessLog, (Array) ((ProcessObject) obj)._ProcessLog)) && (this.CompareArrays((Array) this._Prerequisites, (Array) ((ProcessObject) obj)._Prerequisites) && object.Equals((object) this._AssigneeOption, (object) ((ProcessObject) obj)._AssigneeOption) && (this.CompareArrays((Array) this._Details, (Array) ((ProcessObject) obj)._Details) && object.Equals((object) this._Stage, (object) ((ProcessObject) obj)._Stage)))) && (object.Equals((object) this._AllowReassignment, (object) ((ProcessObject) obj)._AllowReassignment) && object.Equals((object) this._LastStage, (object) ((ProcessObject) obj)._LastStage) && (object.Equals((object) this._Checklist, (object) ((ProcessObject) obj)._Checklist) && object.Equals((object) this._Organization, (object) ((ProcessObject) obj)._Organization)) && (object.Equals((object) this._LastCompletedOn, (object) ((ProcessObject) obj)._LastCompletedOn) && object.Equals((object) this._OnHold, (object) ((ProcessObject) obj)._OnHold) && (object.Equals((object) this._AutoComplete, (object) ((ProcessObject) obj)._AutoComplete) && object.Equals((object) this._DefaultAssigneeInfo, (object) ((ProcessObject) obj)._DefaultAssigneeInfo))) && (object.Equals((object) this._AutoStart, (object) ((ProcessObject) obj)._AutoStart) && object.Equals((object) this._FirstRoutedOnGMT, (object) ((ProcessObject) obj)._FirstRoutedOnGMT) && (object.Equals((object) this._LastDesignatedOn, (object) ((ProcessObject) obj)._LastDesignatedOn) && object.Equals((object) this._LastCompletedOnGMT, (object) ((ProcessObject) obj)._LastCompletedOnGMT)) && (object.Equals((object) this._IsRequired, (object) ((ProcessObject) obj)._IsRequired) && object.Equals((object) this._LastDesignatedOnGMT, (object) ((ProcessObject) obj)._LastDesignatedOnGMT) && (object.Equals((object) this._Sequence, (object) ((ProcessObject) obj)._Sequence) && object.Equals((object) this._AutoCompleteFailure, (object) ((ProcessObject) obj)._AutoCompleteFailure))))) && (object.Equals((object) this._FirstRoutedOn, (object) ((ProcessObject) obj)._FirstRoutedOn) && object.Equals((object) this._IsFrozen, (object) ((ProcessObject) obj)._IsFrozen) && (object.Equals((object) this._Name, (object) ((ProcessObject) obj)._Name) && object.Equals((object) this._Owner, (object) ((ProcessObject) obj)._Owner)) && (object.Equals((object) this._LastCompletedBy, (object) ((ProcessObject) obj)._LastCompletedBy) && object.Equals((object) this._Notes, (object) ((ProcessObject) obj)._Notes) && (object.Equals((object) this._ChangeHistory, (object) ((ProcessObject) obj)._ChangeHistory) && object.Equals((object) this._Assignee, (object) ((ProcessObject) obj)._Assignee))) && (object.Equals((object) this._DocumentSet, (object) ((ProcessObject) obj)._DocumentSet) && object.Equals((object) this._CompletionComments, (object) ((ProcessObject) obj)._CompletionComments))) && base.Equals(obj);
    }

    public NamedObjectRef AssigneeRole
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

    public Primitive<string> ReassignmentComments
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

    public Primitive<string> Description
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

    public DocAttachments Attachments
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

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public SubentityRef[] ESigHistoryDetails
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

    public NamedObjectRef OwnerRole
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

    public Enumeration<ProcObjectOutstandingDtlEnum, int> OutstandingDetailStatus
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

    public DataPointCollection DataPointCollection
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

    public CollaborationLogDetail[] ProcessLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessLog), (object) value);
      }
      get
      {
        return (CollaborationLogDetail[]) this.PropertyGet(nameof (ProcessLog));
      }
    }

    public ProcessObject[] Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (ProcessObject[]) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public Enumeration<AssigneeOptionEnum, int> AssigneeOption
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

    public ProcessObject[] Details
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

    public Enumeration<StageEnum, int> Stage
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

    public Enumeration<ReassignmentRestrictionEnum, int> AllowReassignment
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

    public Enumeration<StageEnum, int> LastStage
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

    public Checklist Checklist
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

    public NamedObjectRef Organization
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

    public Primitive<DateTime> LastCompletedOn
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

    public Primitive<bool> OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OnHold));
      }
    }

    public Primitive<bool> AutoComplete
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

    public Primitive<bool> DefaultAssigneeInfo
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

    public Primitive<bool> AutoStart
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

    public Primitive<DateTime> FirstRoutedOnGMT
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

    public Primitive<DateTime> LastDesignatedOn
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

    public Primitive<DateTime> LastCompletedOnGMT
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

    public Primitive<bool> IsRequired
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

    public Primitive<DateTime> LastDesignatedOnGMT
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

    public Primitive<int> Sequence
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

    public Primitive<bool> AutoCompleteFailure
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

    public Primitive<DateTime> FirstRoutedOn
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

    public NamedObjectRef Owner
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

    public NamedObjectRef LastCompletedBy
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

    public Primitive<string> Notes
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

    public ChangeHistory ChangeHistory
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

    public NamedObjectRef Assignee
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

    public NamedObjectRef DocumentSet
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

    public Primitive<string> CompletionComments
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
  }
}
