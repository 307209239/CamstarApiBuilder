// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ToDoListDetail_Environment
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
  public class ToDoListDetail_Environment : ServiceData_Environment
  {
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, true, "Integer", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Category")]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_SubclassificationName")]
    [Metadata("LabelName", "", false, false, true, "String", 1051146, false, false, false, null)]
    protected Environment _SubclassificationName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Role")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, false, null)]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ApprovalEntryRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, false, null)]
    protected Environment _ApprovalEntryRole;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, true, "NamedObjectRef", 1051051, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_PriorityLevel")]
    protected Environment _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ClassificationName")]
    [Metadata("LabelName", "", false, false, true, "String", 1051055, false, false, false, null)]
    protected Environment _ClassificationName;
    [Metadata("LabelName", "", false, false, true, "String", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_CategoryName")]
    protected Environment _CategoryName;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, true, "NamedObjectRef", 1051298, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_QualityObject")]
    protected Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_MessageCategoryName")]
    [Metadata("Label Value.", "", false, false, true, "String", 1052301, false, false, false, null)]
    protected Environment _MessageCategoryName;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051060, false, false, false, null)]
    protected Environment _Organization;
    [Metadata("A process model describes what needs to be done to resolve the issue reported as a Quality Object", "ProcessModel", false, false, true, "NamedSubentityRef", 1051357, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ProcessModel")]
    protected Environment _ProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Plan")]
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, true, "NamedSubentityRef", 1051188, false, false, false, null)]
    protected Environment _Plan;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, true, "NamedObjectRef", 1052104, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_SubClassification")]
    protected Environment _SubClassification;
    [Metadata("Enumeration for the Concierge Page Mapping:\r\nEventRecordView\r\nCAPARecordView\r\nEventCreatePageflow\r\nCAPACreatePageflow\r\nActivityExecution\r\nActivityDispExecution\r\nActivityInvestExecution\r\nProcessModelOwnership\r\nPhaseOwnership\r\nPlanOwnership\r\nApprovalPlanEntry\r\nApprovalPhaseEntry\r\nApprovalQualityObjectEntry\r\nApprovalQualityObjectComplete", "ConciergePageMappingEnum", false, false, true, "String", 1051779, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ToDoListItemType")]
    protected Environment _ToDoListItemType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_PriorityStatus")]
    [Metadata("Indicates PriorityStatus", "PriorityStatusEnum", false, false, true, "Integer", 1053054, false, false, false, null)]
    protected Environment _PriorityStatus;
    [Metadata("The type of actions that will cause an EMail to be sent.", "NotificationTypeEnum", false, false, true, "Integer", 1051759, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_NotificationType")]
    protected Environment _NotificationType;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_MessageCategory")]
    [Metadata("Manages Categories available for use in PortalNotification.", "MessageCategoryLabel", false, false, false, "NamedObjectRef", 1052301, false, false, false, null)]
    protected Environment _MessageCategory;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ApprovalSheetEntry")]
    [Metadata("An entry in an approval sheet specifies the details for a single approver.", "ApprovalSheetEntry", false, false, true, "SubentityRef", 1051640, false, false, false, null)]
    protected Environment _ApprovalSheetEntry;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Classification")]
    [Metadata("Used to classify QualityObjects", "Classification", false, false, true, "NamedObjectRef", 1051055, false, false, false, null)]
    protected Environment _Classification;
    [Metadata("Generic String", "", false, false, true, "String", 1051940, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Type")]
    protected Environment _Type;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_AssignedDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052310, false, false, false, null)]
    protected Environment _AssignedDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052324, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_AssignedDateGMT")]
    protected Environment _AssignedDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_DueDate")]
    protected Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_IdentifierType")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052236, false, false, false, null)]
    protected Environment _IdentifierType;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ReportingDate")]
    protected Environment _ReportingDate;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ReportingDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052323, false, false, false, null)]
    protected Environment _ReportingDateGMT;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1051057, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Identifier")]
    protected Environment _Identifier;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Status")]
    [Metadata("Generic String", "", false, false, true, "String", 1048671, false, false, false, null)]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_DueDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048792, false, false, false, null)]
    protected Environment _DueDateGMT;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051672, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_ApprovalSheetParent")]
    protected Environment _ApprovalSheetParent;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051655, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_TriageComplete")]
    protected Environment _TriageComplete;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049982, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_IdentifierCDOType")]
    protected Environment _IdentifierCDOType;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051603, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_DataCollectionDefined")]
    protected Environment _DataCollectionDefined;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_OwnerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048824, false, false, false, null)]
    protected Environment _OwnerName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050342, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_RoleName")]
    protected Environment _RoleName;
    [Metadata("Message text.", "", false, false, true, "String", 1051161, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_DisplayMessage")]
    protected Environment _DisplayMessage;
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Owner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1051372, false, false, false, null)]
    protected Environment _Owner;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ToDoListDetail_Environment_Name")]
    protected Environment _Name;

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

    public Environment ApprovalEntryRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntryRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalEntryRole));
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

    public Environment QualityObject
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

    public Environment MessageCategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategoryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MessageCategoryName));
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

    public Environment ToDoListItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToDoListItemType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToDoListItemType));
      }
    }

    public Environment PriorityStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityStatus));
      }
    }

    public Environment NotificationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NotificationType));
      }
    }

    public Environment MessageCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (MessageCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MessageCategory));
      }
    }

    public Environment ApprovalSheetEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetEntry));
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

    public Environment Type
    {
      [param: In] set
      {
        this.PropertySet(nameof (Type), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Type));
      }
    }

    public Environment AssignedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedDate));
      }
    }

    public Environment AssignedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedDateGMT));
      }
    }

    public Environment DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDate));
      }
    }

    public Environment IdentifierType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IdentifierType));
      }
    }

    public Environment ReportingDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportingDate));
      }
    }

    public Environment ReportingDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportingDateGMT));
      }
    }

    public Environment Identifier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Identifier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Identifier));
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

    public Environment DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Environment ApprovalSheetParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetParent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetParent));
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

    public Environment IdentifierCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IdentifierCDOType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IdentifierCDOType));
      }
    }

    public Environment DataCollectionDefined
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDefined), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDefined));
      }
    }

    public Environment OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerName));
      }
    }

    public Environment RoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RoleName));
      }
    }

    public Environment DisplayMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayMessage));
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

    public Environment Name
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
  }
}
