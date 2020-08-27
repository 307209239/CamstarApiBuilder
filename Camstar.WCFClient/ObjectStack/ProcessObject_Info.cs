// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObject_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (Phase_Info))]
  [KnownType(typeof (Plan_Info))]
  [KnownType(typeof (Activity_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ProcessModel_Info))]
  [Serializable]
  public class ProcessObject_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_AssigneeRole")]
    protected Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_ReassignmentComments")]
    protected Info _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Attachments")]
    protected DocAttachments_Info _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_ESigHistoryDetails")]
    protected Info _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_OwnerRole")]
    protected Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_OutstandingDetailStatus")]
    protected Info _OutstandingDetailStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_DataPointCollection")]
    protected DataPointCollection_Info _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_ProcessLog")]
    protected CollaborationLogDetail_Info _ProcessLog;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Prerequisites")]
    protected ProcessObject_Info _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_AssigneeOption")]
    protected Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Details")]
    protected ProcessObject_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Stage")]
    protected Info _Stage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_AllowReassignment")]
    protected Info _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_LastStage")]
    protected Info _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Checklist")]
    protected Checklist_Info _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_LastCompletedOn")]
    protected Info _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_OnHold")]
    protected Info _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_AutoComplete")]
    protected Info _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_DefaultAssigneeInfo")]
    protected Info _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_AutoStart")]
    protected Info _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_FirstRoutedOnGMT")]
    protected Info _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_LastDesignatedOn")]
    protected Info _LastDesignatedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_LastCompletedOnGMT")]
    protected Info _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_IsRequired")]
    protected Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_LastDesignatedOnGMT")]
    protected Info _LastDesignatedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_AutoCompleteFailure")]
    protected Info _AutoCompleteFailure;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_FirstRoutedOn")]
    protected Info _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_LastCompletedBy")]
    protected Info _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_ChangeHistory")]
    protected ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_Assignee")]
    protected Info _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Info_CompletionComments")]
    protected Info _CompletionComments;

    public Info AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Info ReassignmentComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReassignmentComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReassignmentComments));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public DocAttachments_Info Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments_Info) this.PropertyGet(nameof (Attachments));
      }
    }

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Info ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public Info OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Info OutstandingDetailStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutstandingDetailStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OutstandingDetailStatus));
      }
    }

    public DataPointCollection_Info DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (DataPointCollection_Info) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public CollaborationLogDetail_Info ProcessLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessLog), (object) value);
      }
      get
      {
        return (CollaborationLogDetail_Info) this.PropertyGet(nameof (ProcessLog));
      }
    }

    public ProcessObject_Info Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (ProcessObject_Info) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public Info AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public ProcessObject_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObject_Info) this.PropertyGet(nameof (Details));
      }
    }

    public Info Stage
    {
      [param: In] set
      {
        this.PropertySet(nameof (Stage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Stage));
      }
    }

    public Info AllowReassignment
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReassignment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowReassignment));
      }
    }

    public Info LastStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastStage));
      }
    }

    public Checklist_Info Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Checklist_Info) this.PropertyGet(nameof (Checklist));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Info OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnHold));
      }
    }

    public Info AutoComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoComplete));
      }
    }

    public Info DefaultAssigneeInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultAssigneeInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultAssigneeInfo));
      }
    }

    public Info AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Info FirstRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FirstRoutedOnGMT));
      }
    }

    public Info LastDesignatedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDesignatedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDesignatedOn));
      }
    }

    public Info LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedOnGMT));
      }
    }

    public Info IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRequired));
      }
    }

    public Info LastDesignatedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDesignatedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastDesignatedOnGMT));
      }
    }

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info AutoCompleteFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoCompleteFailure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoCompleteFailure));
      }
    }

    public Info FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FirstRoutedOn));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info LastCompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedBy));
      }
    }

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public ChangeHistory_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public Info Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Assignee));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Info CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionComments));
      }
    }
  }
}
