﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Plan_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (PlanDisposition_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Plan_Environment : ProcessObject_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1051574, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_AssigneeRole")]
    protected new Environment _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Description")]
    [Metadata("Instruction", "", false, false, true, "String", 1051642, false, false, false, null)]
    protected new Environment _Description;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_OwnerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1051580, false, false, false, null)]
    protected new Environment _OwnerRole;
    [Metadata("This subentity will maintain the data for the esignatures associated with the last update to its parent object.", "ModelingESigHistoryDetail", false, false, true, "SubentityRef", 1050926, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_ESigHistoryDetails")]
    protected new Environment _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_ReassignmentComments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected new Environment _ReassignmentComments;
    [Metadata("Document Attachments", "DocAttachments", false, false, true, "DocAttachments", 1051144, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Attachments")]
    protected new DocAttachments_Environment _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_AssigneeOption")]
    [Metadata("Enumeration for the Assignee Option:\r\n1 = Assignee\r\n2 = Owner\r\n3 = Collaborator", "AssigneeOptionEnum", false, false, true, "Integer", 1052123, false, false, false, null)]
    protected new Environment _AssigneeOption;
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1051356, false, false, false, "20")]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Stage")]
    protected new Environment _Stage;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, false, true, "ProcessObject", 1052212, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Details")]
    protected new ProcessObject_Environment _Details;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_onStartRules")]
    [Metadata("Business Rule Data", "BusinessRuleData", false, false, true, "BusinessRuleData", 1052120, false, true, false, null)]
    protected BusinessRuleData_Environment _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, false, false, null)]
    protected new Environment _Organization;
    [Metadata("Describes the different measurements used for a duration\r\n1=Hour(s)\r\n24=Day(s)\r\n168=Week(s)", "DurationUOMEnum", false, false, true, "String", 1051692, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_CompleteWithinUOM")]
    protected Environment _CompleteWithinUOM;
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1052085, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_LastStage")]
    protected new Environment _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_OutstandingDetailStatus")]
    [Metadata("Identifies the Outstanding details of process objects.\r\n0 = NoneOutstanding\r\n1 = ProcessObjectsOutstanding\r\n2 = LotsOutstanding", "ProcObjectOutstandingDtlEnum", false, false, true, "Integer", 1052338, false, false, false, null)]
    protected new Environment _OutstandingDetailStatus;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_LastApprovalRouted")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, true, "NamedSubentityRef", 1052295, false, false, false, null)]
    protected Environment _LastApprovalRouted;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_ApprovalSheets")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, true, "ApprovalSheet", 1052012, false, true, false, null)]
    protected ApprovalSheet_Environment _ApprovalSheets;
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollection", false, false, true, "DataPointCollection", 1052416, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_DataPointCollection")]
    protected new DataPointCollection_Environment _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_onCompleteRules")]
    [Metadata("Business Rule Data", "BusinessRuleData", false, false, true, "BusinessRuleData", 1052119, false, true, false, null)]
    protected BusinessRuleData_Environment _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Checklist")]
    [Metadata("Checklists are connected to process objects or templates and contain entries copied from Checklist Template.", "Checklist", false, false, true, "Checklist", 1052398, false, false, false, null)]
    protected new Checklist_Environment _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Prerequisites")]
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, true, "Plan", 1051405, false, true, false, null)]
    protected Plan_Environment _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_AllowReassignment")]
    [Metadata("1 = To a user within the specified Role(s)\r\n2 = To any user\r\n3 = Reassignment not allowed", "ReassignmentRestrictionEnum", false, false, true, "Integer", 1052113, false, false, false, null)]
    protected new Environment _AllowReassignment;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051697, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_AutoStart")]
    protected new Environment _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_CompleteWithinQty")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051407, false, false, false, null)]
    protected Environment _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_LastCompletedOn")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052121, false, false, false, null)]
    protected new Environment _LastCompletedOn;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_LastCompletedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051796, false, false, false, null)]
    protected new Environment _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Sequence")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected new Environment _Sequence;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052240, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_LastDesignatedOnGMT")]
    protected new Environment _LastDesignatedOnGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051785, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_AutoComplete")]
    protected new Environment _AutoComplete;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052161, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_LastDesignatedOn")]
    protected new Environment _LastDesignatedOn;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052294, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_AutoCompleteFailure")]
    protected new Environment _AutoCompleteFailure;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_CompleteBy")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    protected Environment _CompleteBy;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_DefaultAssigneeInfo")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052021, false, false, false, "0")]
    protected new Environment _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_FirstRoutedOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052210, false, false, false, null)]
    protected new Environment _FirstRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_FirstRoutedOn")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049313, false, false, false, null)]
    protected new Environment _FirstRoutedOn;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052086, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_CompleteByGMT")]
    protected Environment _CompleteByGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049018, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_IsRequired")]
    protected new Environment _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_LastCompletedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051683, false, false, false, null)]
    protected new Environment _LastCompletedBy;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_ChangeHistory")]
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    protected new ChangeHistory_Environment _ChangeHistory;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Notes")]
    protected new Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_CompleteWithin")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1051409, false, false, false, null)]
    protected Environment _CompleteWithin;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1052106, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_CompletionComments")]
    protected new Environment _CompletionComments;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "NamedObjectRef", 1052111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_DocumentSet")]
    protected new Environment _DocumentSet;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Owner")]
    protected new Environment _Owner;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "Plan_Environment_Assignee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051372, false, false, false, null)]
    protected new Environment _Assignee;

    public new Environment AssigneeRole
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

    public new Environment Description
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

    public new Environment OwnerRole
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

    public new Environment ESigHistoryDetails
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

    public new Environment ReassignmentComments
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

    public new DocAttachments_Environment Attachments
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

    public new Environment AssigneeOption
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

    public new Environment Stage
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

    public new ProcessObject_Environment Details
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

    public BusinessRuleData_Environment onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Environment) this.PropertyGet(nameof (onStartRules));
      }
    }

    public new Environment Organization
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

    public Environment CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public new Environment LastStage
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

    public new Environment OutstandingDetailStatus
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

    public Environment LastApprovalRouted
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastApprovalRouted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastApprovalRouted));
      }
    }

    public ApprovalSheet_Environment ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheet_Environment) this.PropertyGet(nameof (ApprovalSheets));
      }
    }

    public new DataPointCollection_Environment DataPointCollection
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

    public BusinessRuleData_Environment onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleData_Environment) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public new Checklist_Environment Checklist
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

    public Plan_Environment Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (Plan_Environment) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public new Environment AllowReassignment
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

    public new Environment AutoStart
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

    public Environment CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public new Environment LastCompletedOn
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

    public new Environment LastCompletedOnGMT
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

    public new Environment Sequence
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

    public new Environment LastDesignatedOnGMT
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

    public new Environment AutoComplete
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

    public new Environment LastDesignatedOn
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

    public new Environment AutoCompleteFailure
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

    public Environment CompleteBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteBy));
      }
    }

    public new Environment DefaultAssigneeInfo
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

    public new Environment FirstRoutedOnGMT
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

    public new Environment FirstRoutedOn
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

    public Environment CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public new Environment IsRequired
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

    public new Environment LastCompletedBy
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

    public new ChangeHistory_Environment ChangeHistory
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

    public new Environment Notes
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

    public Environment CompleteWithin
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithin), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteWithin));
      }
    }

    public new Environment CompletionComments
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

    public new Environment DocumentSet
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

    public new Environment Owner
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

    public new Environment Assignee
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
  }
}
