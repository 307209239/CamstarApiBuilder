// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObject_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (Activity_Environment))]
  [KnownType(typeof (Phase_Environment))]
  [KnownType(typeof (Plan_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ProcessModel_Environment))]
  [Serializable]
  public class ProcessObject_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_AssigneeRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1051574, false, false, false, null)]
    protected Environment _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_ReassignmentComments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Description")]
    [Metadata("Instruction", "", false, false, true, "String", 1051642, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Attachments")]
    [Metadata("Document Attachments", "DocAttachments", false, false, true, "DocAttachments", 1051144, true, false, false, null)]
    protected DocAttachments_Environment _Attachments;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [Metadata("This subentity will maintain the data for the esignatures associated with the last update to its parent object.", "ModelingESigHistoryDetail", false, false, true, "SubentityRef", 1050926, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_ESigHistoryDetails")]
    protected Environment _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_OwnerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1051580, false, false, false, null)]
    protected Environment _OwnerRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_OutstandingDetailStatus")]
    [Metadata("Identifies the Outstanding details of process objects.\r\n0 = NoneOutstanding\r\n1 = ProcessObjectsOutstanding\r\n2 = LotsOutstanding", "ProcObjectOutstandingDtlEnum", false, false, true, "Integer", 1052338, false, false, false, null)]
    protected Environment _OutstandingDetailStatus;
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollection", false, false, true, "DataPointCollection", 1052416, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_DataPointCollection")]
    protected DataPointCollection_Environment _DataPointCollection;
    [Metadata("Non-persistent subentity is populated by EndCollaborationHistory and DesignateProcessObjectHistory records.", "CollaborationLogDetail", false, false, true, "CollaborationLogDetail", 1052064, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_ProcessLog")]
    protected CollaborationLogDetail_Environment _ProcessLog;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "ProcessObject", 1051405, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Prerequisites")]
    protected ProcessObject_Environment _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_AssigneeOption")]
    [Metadata("Enumeration for the Assignee Option:\r\n1 = Assignee\r\n2 = Owner\r\n3 = Collaborator", "AssigneeOptionEnum", false, false, true, "Integer", 1052123, false, false, false, null)]
    protected Environment _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Details")]
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "ProcessObject", 1049090, false, true, false, null)]
    protected ProcessObject_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Stage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1051356, false, false, false, "20")]
    protected Environment _Stage;
    [Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, true, "Integer", 1052113, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_AllowReassignment")]
    protected Environment _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_LastStage")]
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1052085, false, false, false, "0")]
    protected Environment _LastStage;
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "Checklist", false, false, true, "Checklist", 1052398, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Checklist")]
    protected Checklist_Environment _Checklist;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Organization")]
    protected Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_LastCompletedOn")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052121, false, false, false, null)]
    protected Environment _LastCompletedOn;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_OnHold")]
    protected Environment _OnHold;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051785, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_AutoComplete")]
    protected Environment _AutoComplete;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052021, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_DefaultAssigneeInfo")]
    protected Environment _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_AutoStart")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051697, false, false, false, "0")]
    protected Environment _AutoStart;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052210, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_FirstRoutedOnGMT")]
    protected Environment _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_LastDesignatedOn")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052161, false, false, false, null)]
    protected Environment _LastDesignatedOn;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_LastCompletedOnGMT")]
    protected Environment _LastCompletedOnGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049018, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_IsRequired")]
    protected Environment _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_LastDesignatedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052240, false, false, false, null)]
    protected Environment _LastDesignatedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Sequence")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052294, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_AutoCompleteFailure")]
    protected Environment _AutoCompleteFailure;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049313, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_FirstRoutedOn")]
    protected Environment _FirstRoutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Owner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_LastCompletedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051683, false, false, false, null)]
    protected Environment _LastCompletedBy;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Notes")]
    protected Environment _Notes;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_ChangeHistory")]
    protected ChangeHistory_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_Assignee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051372, false, false, false, null)]
    protected Environment _Assignee;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1052111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObject_Environment_CompletionComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1052106, false, false, false, null)]
    protected Environment _CompletionComments;

    public Environment AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Environment ReassignmentComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReassignmentComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReassignmentComments));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public DocAttachments_Environment Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (DocAttachments_Environment) this.PropertyGet(nameof (Attachments));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Environment ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public Environment OwnerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerRole));
      }
    }

    public Environment OutstandingDetailStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutstandingDetailStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OutstandingDetailStatus));
      }
    }

    public DataPointCollection_Environment DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (DataPointCollection_Environment) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public CollaborationLogDetail_Environment ProcessLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessLog), (object) value);
      }
      get
      {
        return (CollaborationLogDetail_Environment) this.PropertyGet(nameof (ProcessLog));
      }
    }

    public ProcessObject_Environment Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (ProcessObject_Environment) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public Environment AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public ProcessObject_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObject_Environment) this.PropertyGet(nameof (Details));
      }
    }

    public Environment Stage
    {
      [param: In] set
      {
        this.PropertySet(nameof (Stage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Stage));
      }
    }

    public Environment AllowReassignment
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReassignment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowReassignment));
      }
    }

    public Environment LastStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastStage));
      }
    }

    public Checklist_Environment Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Checklist_Environment) this.PropertyGet(nameof (Checklist));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public Environment LastCompletedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedOn));
      }
    }

    public Environment OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnHold));
      }
    }

    public Environment AutoComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoComplete));
      }
    }

    public Environment DefaultAssigneeInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultAssigneeInfo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultAssigneeInfo));
      }
    }

    public Environment AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Environment FirstRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FirstRoutedOnGMT));
      }
    }

    public Environment LastDesignatedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDesignatedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDesignatedOn));
      }
    }

    public Environment LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedOnGMT));
      }
    }

    public Environment IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRequired));
      }
    }

    public Environment LastDesignatedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastDesignatedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastDesignatedOnGMT));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment AutoCompleteFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoCompleteFailure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoCompleteFailure));
      }
    }

    public Environment FirstRoutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (FirstRoutedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FirstRoutedOn));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
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

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }

    public Environment LastCompletedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletedBy));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }

    public ChangeHistory_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public Environment Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Assignee));
      }
    }

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Environment CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionComments));
      }
    }
  }
}
