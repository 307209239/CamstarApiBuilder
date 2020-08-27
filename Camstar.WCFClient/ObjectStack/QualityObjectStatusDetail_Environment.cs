// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectStatusDetail_Environment
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
  public class QualityObjectStatusDetail_Environment : ServiceData_Environment
  {
    [Metadata("Document Attachments", "DocAttachments", false, false, true, "DocAttachments", 1051144, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Attachments")]
    protected DocAttachments_Environment _Attachments;
    [Metadata("Enumeration for the Quality Status:\r\n1 = Active\r\n2 = Pending\r\n3 = Escalated\r\n5 = Closed\r\n6 = Deleted\r\n7 = Initiated\r\n8 = InReview", "QualityStatusEnum", false, false, false, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Role")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050342, false, false, false, null)]
    protected Environment _Role;
    [Metadata("Document Attachments", "DocAttachments", false, false, true, "SubentityRef", 1053021, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_AttachmentsID")]
    protected Environment _AttachmentsID;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051491, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CrossReferenceItems")]
    protected Environment _CrossReferenceItems;
    [Metadata("LabelName", "", false, false, true, "String", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_StatusName")]
    protected Environment _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CARResolutionActionName")]
    [Metadata("LabelName", "", false, false, true, "String", 1051675, false, false, false, null)]
    protected Environment _CARResolutionActionName;
    [Metadata("LabelName", "", false, false, true, "String", 1051146, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_SubclassificationName")]
    protected Environment _SubclassificationName;
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, false, "Integer", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Category")]
    protected Environment _Category;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, true, "NamedObjectRef", 1051051, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_PriorityLevel")]
    protected Environment _PriorityLevel;
    [Metadata("LabelName", "", false, false, true, "String", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CategoryName")]
    protected Environment _CategoryName;
    [Metadata("LabelName", "", false, false, false, "String", 1051541, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ProcessModelStageName")]
    protected Environment _ProcessModelStageName;
    [Metadata("LabelName", "", false, false, true, "String", 1051055, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ClassificationName")]
    protected Environment _ClassificationName;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051054, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ReporterOrganization")]
    protected Environment _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_InitiatorOrganization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051049, false, false, false, null)]
    protected Environment _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_EntryForApproval")]
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, true, "SubentityRef", 1053038, false, false, false, null)]
    protected Environment _EntryForApproval;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Organization")]
    protected Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CompletionApprovalSheet")]
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, false, "NamedSubentityRef", 1051677, false, false, false, null)]
    protected Environment _CompletionApprovalSheet;
    [Metadata("Identifies the valid resolution codes for closing an Event or CAPA.", "QualityResolutionCode", false, false, true, "NamedObjectRef", 1051676, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_QualityResolutionCode")]
    protected Environment _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CmpltRoutingResolutionAction")]
    [Metadata("Enumeration for the Resolution Action:\r\n1 = Close", "ResolutionActionEnum", false, false, true, "Integer", 1051675, false, false, true, null)]
    protected Environment _CmpltRoutingResolutionAction;
    [Metadata("Information needed to determine the risk score for a Quality object.", "RiskAssessment", false, false, true, "RiskAssessment", 1052467, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_RiskAssessment")]
    protected RiskAssessment_Environment _RiskAssessment;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CompletionRoutingInfo")]
    [Metadata("Information stored for Approvals as part of the Routing.", "ApprovalRoutingInfo", false, false, false, "SubentityRef", 1051678, false, false, false, null)]
    protected Environment _CompletionRoutingInfo;
    [Metadata("A process object progresses through several stages during its processing.", "StageEnum", false, false, true, "Integer", 1051356, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ProcessModelStage")]
    protected Environment _ProcessModelStage;
    [Metadata("These statuses define the life cycle of approval sheets and approval sheet entries.", "ApprovalStatusEnum", false, false, true, "Integer", 1048671, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CompletionApprovalStatus")]
    protected Environment _CompletionApprovalStatus;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_SubClassification")]
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, false, "NamedObjectRef", 1052104, false, false, false, null)]
    protected Environment _SubClassification;
    [Metadata("Brief Description", "", false, false, true, "String", 1051299, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_BriefDescription")]
    protected Environment _BriefDescription;
    [Metadata("Used to classify QualityObjects", "Classification", false, false, false, "NamedObjectRef", 1051055, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Classification")]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CARResolutionAction")]
    [Metadata("Enumeration for the CAR Resolution Action:\r\n1 = Close\r\n2 = AttachToCAPA\r\n3 = CreateCAPA", "CARResolutionActionEnum", false, false, true, "Integer", 1051675, false, false, false, null)]
    protected Environment _CARResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ProcessModel")]
    [Metadata("A process model describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModel", false, false, true, "NamedSubentityRef", 1051357, false, false, false, null)]
    protected Environment _ProcessModel;
    [Metadata("Identifies the valid resolution codes for closing an Event or CAPA.", "QualityResolutionCode", false, false, true, "NamedObjectRef", 1051676, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CmpltRoutingResolutionCode")]
    protected Environment _CmpltRoutingResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ChecklistAssigned")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053050, false, false, false, "0")]
    protected Environment _ChecklistAssigned;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ChecklistSaved")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053062, false, false, false, "0")]
    protected Environment _ChecklistSaved;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051445, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_IsCARRequiredToClose")]
    protected Environment _IsCARRequiredToClose;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_OccurrenceDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051344, false, false, false, null)]
    protected Environment _OccurrenceDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051455, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ClosureDateGMT")]
    protected Environment _ClosureDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ClosureDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051699, false, false, false, null)]
    protected Environment _ClosureDate;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_UserHasRole")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052007, false, false, false, "0")]
    protected Environment _UserHasRole;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052008, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_UserIsOwner")]
    protected Environment _UserIsOwner;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_IsApprovalRequired")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052934, false, false, false, "0")]
    protected Environment _IsApprovalRequired;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051655, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_TriageComplete")]
    protected Environment _TriageComplete;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ReportedDateGMT")]
    protected Environment _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CloseDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051674, false, false, false, null)]
    protected Environment _CloseDescription;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_DiscoveryArea")]
    protected Environment _DiscoveryArea;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052282, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Reporter")]
    protected Environment _Reporter;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051674, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_CmpltRoutingCloseDescription")]
    protected Environment _CmpltRoutingCloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_ClosedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051710, false, false, false, null)]
    protected Environment _ClosedBy;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Owner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectStatusDetail_Environment_Initiator")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052281, false, false, false, null)]
    protected Environment _Initiator;

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

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment AttachmentsID
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentsID));
      }
    }

    public Environment CrossReferenceItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (CrossReferenceItems), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CrossReferenceItems));
      }
    }

    public Environment StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusName));
      }
    }

    public Environment CARResolutionActionName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionActionName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CARResolutionActionName));
      }
    }

    public Environment SubclassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubclassificationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubclassificationName));
      }
    }

    public Environment Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Category));
      }
    }

    public Environment PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Environment CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryName));
      }
    }

    public Environment ProcessModelStageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelStageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessModelStageName));
      }
    }

    public Environment ClassificationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassificationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClassificationName));
      }
    }

    public Environment ReporterOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrganization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReporterOrganization));
      }
    }

    public Environment InitiatorOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrganization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitiatorOrganization));
      }
    }

    public Environment EntryForApproval
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryForApproval), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EntryForApproval));
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

    public Environment CompletionApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionApprovalSheet));
      }
    }

    public Environment QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public Environment CmpltRoutingResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingResolutionAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CmpltRoutingResolutionAction));
      }
    }

    public RiskAssessment_Environment RiskAssessment
    {
      [param: In] set
      {
        this.PropertySet(nameof (RiskAssessment), (object) value);
      }
      get
      {
        return (RiskAssessment_Environment) this.PropertyGet(nameof (RiskAssessment));
      }
    }

    public Environment CompletionRoutingInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionRoutingInfo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionRoutingInfo));
      }
    }

    public Environment ProcessModelStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModelStage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessModelStage));
      }
    }

    public Environment CompletionApprovalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionApprovalStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionApprovalStatus));
      }
    }

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Environment BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public Environment CARResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CARResolutionAction));
      }
    }

    public Environment ProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessModel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessModel));
      }
    }

    public Environment CmpltRoutingResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CmpltRoutingResolutionCode));
      }
    }

    public Environment ChecklistAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistAssigned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistAssigned));
      }
    }

    public Environment ChecklistSaved
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistSaved), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChecklistSaved));
      }
    }

    public Environment IsCARRequiredToClose
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCARRequiredToClose), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsCARRequiredToClose));
      }
    }

    public Environment OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccurrenceDateGMT));
      }
    }

    public Environment ClosureDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosureDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClosureDateGMT));
      }
    }

    public Environment ClosureDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosureDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClosureDate));
      }
    }

    public Environment UserHasRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserHasRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserHasRole));
      }
    }

    public Environment UserIsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserIsOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserIsOwner));
      }
    }

    public Environment IsApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsApprovalRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsApprovalRequired));
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

    public Environment ReportedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportedDateGMT));
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

    public Environment CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDescription));
      }
    }

    public Environment DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DiscoveryArea));
      }
    }

    public Environment Reporter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reporter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Reporter));
      }
    }

    public Environment CmpltRoutingCloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CmpltRoutingCloseDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CmpltRoutingCloseDescription));
      }
    }

    public Environment ClosedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClosedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClosedBy));
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

    public Environment Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Initiator));
      }
    }
  }
}
