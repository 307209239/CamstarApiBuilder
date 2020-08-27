// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModel_Info
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
  public class ProcessModel_Info : ProcessObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_ESigHistoryDetails")]
    protected new Info _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_OwnerRole")]
    protected new Info _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Attachments")]
    protected new DocAttachments_Info _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_AssigneeRole")]
    protected new Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_ReassignmentComments")]
    protected new Info _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_AssigneeOption")]
    protected new Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_LastStage")]
    protected new Info _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_OutstandingDetailStatus")]
    protected new Info _OutstandingDetailStatus;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_DataPointCollection")]
    protected new DataPointCollection_Info _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_AllowReassignment")]
    protected new Info _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Organization")]
    protected new Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Checklist")]
    protected new Checklist_Info _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Stage")]
    protected new Info _Stage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_onStartRules")]
    protected BusinessRuleData_Info _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Details")]
    protected new ProcessObject_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_onCompleteRules")]
    protected BusinessRuleData_Info _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Sequence")]
    protected new Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_LastDesignatedOnGMT")]
    protected new Info _LastDesignatedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_FirstRoutedOn")]
    protected new Info _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_AutoComplete")]
    protected new Info _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_LastCompletedOn")]
    protected new Info _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_DefaultAssigneeInfo")]
    protected new Info _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_AutoStart")]
    protected new Info _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_LastCompletedOnGMT")]
    protected new Info _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_IsRequired")]
    protected new Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_FirstRoutedOnGMT")]
    protected new Info _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_LastDesignatedOn")]
    protected new Info _LastDesignatedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_AutoCompleteFailure")]
    protected new Info _AutoCompleteFailure;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_DocumentSet")]
    protected new Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_CompletionComments")]
    protected new Info _CompletionComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Owner")]
    protected new Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Assignee")]
    protected new Info _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_Notes")]
    protected new Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModel_Info_LastCompletedBy")]
    protected new Info _LastCompletedBy;

    public new Info ESigHistoryDetails
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

    public new Info Description
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

    public new Info OwnerRole
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

    public new DocAttachments_Info Attachments
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

    public new Info AssigneeRole
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

    public new Info ReassignmentComments
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

    public new Info AssigneeOption
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

    public new Info LastStage
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

    public new Info OutstandingDetailStatus
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

    public new DataPointCollection_Info DataPointCollection
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

    public new Info AllowReassignment
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

    public new Info Organization
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

    public new Checklist_Info Checklist
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

    public new Info Stage
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

    public BusinessRuleData_Info onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Info) this.PropertyGet(nameof (onStartRules));
      }
    }

    public new ProcessObject_Info Details
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

    public BusinessRuleData_Info onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Info) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public new Info Sequence
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

    public new Info LastDesignatedOnGMT
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

    public new Info FirstRoutedOn
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

    public new Info AutoComplete
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

    public new Info LastCompletedOn
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

    public new Info DefaultAssigneeInfo
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

    public new Info AutoStart
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

    public new Info LastCompletedOnGMT
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

    public new Info IsRequired
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

    public new Info FirstRoutedOnGMT
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

    public new Info LastDesignatedOn
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

    public new Info AutoCompleteFailure
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

    public new ChangeHistory_Info ChangeHistory
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

    public new Info DocumentSet
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

    public new Info CompletionComments
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

    public new Info Owner
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

    public new Info Assignee
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

    public new Info Notes
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

    public new Info LastCompletedBy
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
  }
}
