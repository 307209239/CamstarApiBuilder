// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgAuditTrailInquiry_Environment
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
  public class MfgAuditTrailInquiry_Environment : ContainerHistoryInquiry_Environment
  {
    [Metadata("History Summary object for a Container or Resource Update Service.  One ServiceHistorySummary will be created for every Container or Resource update transaction. The ServiceHistorySummary object and its associated HistoryDetails subentity lists (if necessary) will contain all the history information needed for the service that is not already contained in the HistoryMainline object.", "ServiceHistorySummary", false, false, true, "SubentityRef", 1049593, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_HistorySummary")]
    protected Environment _HistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_WIPMsgHistoryDetails")]
    [Metadata("Records the WIP Messages that were displayed as part of the transaction.", "WIPMsgHistoryDetail", false, false, false, "SubentityRef", 1053015, false, true, true, null)]
    protected Environment _WIPMsgHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_NextLevelHistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, true, "SubentityRef", 1052884, false, true, true, null)]
    protected Environment _NextLevelHistoryDetails;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, true, "SubentityRef", 1049096, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_HistoryDetails")]
    protected Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_SelectedHistoryMainline")]
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, false, "BaseObjectRef", 1050628, false, false, true, null)]
    protected Environment _SelectedHistoryMainline;
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, true, "BaseObjectRef", 1049583, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_Histories")]
    protected Environment _Histories;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_AttachmentsDetails")]
    [Metadata("Document Attachments History Details", "DocAttachmentsHistoryDetails", false, false, false, "DocAttachmentsHistoryDetails", 1051126, false, true, false, null)]
    protected DocAttachmentsHistoryDetails_Environment _AttachmentsDetails;
    [Metadata("The History View object is used to store a user configured view of the History objects.  This object is used by the Live Manufacturing Audit Trail application.", "HistoryView", true, true, false, "NamedObjectRef", 1050028, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_HistoryView")]
    protected Environment _HistoryView;
    [Metadata("Document Attachments", "DocAttachments", false, false, true, "SubentityRef", 1053021, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_Attachments")]
    protected Environment _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_UIPreference")]
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", true, false, false, "UIPreference", 1050029, false, false, true, null)]
    protected new UIPreference_Environment _UIPreference;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051298, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_QualityObject")]
    protected Environment _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_EventLog")]
    [Metadata("Identifies a Log for an Event.", "EventLog", false, false, false, "EventLog", 1052956, false, true, false, null)]
    protected EventLog_Environment _EventLog;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_DetailsRequested")]
    [Metadata("Type for the History Details Requested through the Mfg Audit trail Inquiry service", "DetailsRequestTypeEnum", false, false, false, "Integer", 1052883, false, false, true, null)]
    protected Environment _DetailsRequested;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_AvailableHistoryDetails")]
    [Metadata("Mask for the types of History Details available for the selected History Mainline object", "AvailableHistDetailsMaskEnum", false, false, true, "Integer", 1052881, false, false, true, null)]
    protected Environment _AvailableHistoryDetails;
    [Metadata("Enumeration for the History Record Type:\r\n1 = Event\r\n2 = CAR\r\n3 = CAPA\r\n4 = Container\r\n5 = ContainerInCarrier", "HistoryRecordTypeEnum", false, false, false, "Integer", 1051578, false, false, true, "4")]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_RecordType")]
    protected new Environment _RecordType;
    [Metadata("Keeps track of all the Documents attached and detached form NDOs, RDOs and Containers", "AttachDocumentHistory", false, false, false, "AttachDocumentHistory", 16778477, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_AttachDocumentHistories")]
    protected AttachDocumentHistory_Environment _AttachDocumentHistories;
    [Metadata("A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.", "UserAttribute", false, false, true, "UserAttribute", 1052882, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ContainerAttributes")]
    protected UserAttribute_Environment _ContainerAttributes;
    [Metadata("MfgAuditTrailType", "MfgAuditTrailTypeEnum", false, false, false, "Integer", 16778917, false, false, true, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_TransactionFilter")]
    protected Environment _TransactionFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_NextReversibleHMIndex")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052937, false, false, false, null)]
    protected Environment _NextReversibleHMIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_SelectedHistoryMainlineIndex")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052886, false, false, false, "-1")]
    protected Environment _SelectedHistoryMainlineIndex;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049589, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ShowFullHistory")]
    protected new Environment _ShowFullHistory;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ShowAllAvailable")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052887, false, false, false, "0")]
    protected Environment _ShowAllAvailable;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ResultsetSizeLimit")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050019, false, false, false, "-1")]
    protected new Environment _ResultsetSizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ShowAllTxnTypes")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049588, false, false, false, "1")]
    protected new Environment _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ResultsetStartRow")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050020, false, false, false, "1")]
    protected new Environment _ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_SelectedHistorySummaryIndex")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053046, false, false, false, "0")]
    protected Environment _SelectedHistorySummaryIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_EndDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049310, false, false, false, null)]
    protected new Environment _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_DateTimeFormat")]
    [Metadata("Generic String", "", false, false, false, "String", 16779315, false, false, false, null)]
    protected Environment _DateTimeFormat;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049675, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ContainerStatus")]
    protected Environment _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_SelectCurrentOperation")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053045, false, false, false, "0")]
    protected Environment _SelectCurrentOperation;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_Status")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1048671, false, false, true, null)]
    protected Environment _Status;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052885, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_SelectedHistoryDetailsIndex")]
    protected Environment _SelectedHistoryDetailsIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_SortAscending")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049312, false, false, false, "0")]
    protected new Environment _SortAscending;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_StartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049313, false, false, false, null)]
    protected new Environment _StartDate;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049590, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ShowReversalInfo")]
    protected new Environment _ShowReversalInfo;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049310, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_EndDateLastSec")]
    protected Environment _EndDateLastSec;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_OperationFilter")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    protected Environment _OperationFilter;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_Resource")]
    protected Environment _Resource;
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, true, "NamedObjectRef", 1049249, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ResourceStatusReasonFilter")]
    protected Environment _ResourceStatusReasonFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ResourceStatusCodeFilter")]
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, true, "NamedObjectRef", 1049247, false, false, true, null)]
    protected Environment _ResourceStatusCodeFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ResourceFilter")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _ResourceFilter;
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, false, true, "Integer", 1048655, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_AvailabilityFilter")]
    protected Environment _AvailabilityFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_ShowTxnTypes")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049591, false, true, true, null)]
    protected new Environment _ShowTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Environment_EmployeeFilter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048861, false, false, true, null)]
    protected Environment _EmployeeFilter;

    public Environment HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public Environment WIPMsgHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgHistoryDetails));
      }
    }

    public Environment NextLevelHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextLevelHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextLevelHistoryDetails));
      }
    }

    public Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment SelectedHistoryMainline
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainline), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHistoryMainline));
      }
    }

    public Environment Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Histories));
      }
    }

    public DocAttachmentsHistoryDetails_Environment AttachmentsDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails_Environment) this.PropertyGet(nameof (AttachmentsDetails));
      }
    }

    public Environment HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryView));
      }
    }

    public Environment Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Attachments));
      }
    }

    public new UIPreference_Environment UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference_Environment) this.PropertyGet(nameof (UIPreference));
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

    public EventLog_Environment EventLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLog), (object) value);
      }
      get
      {
        return (EventLog_Environment) this.PropertyGet(nameof (EventLog));
      }
    }

    public Environment DetailsRequested
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetailsRequested), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DetailsRequested));
      }
    }

    public Environment AvailableHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AvailableHistoryDetails));
      }
    }

    public new Environment RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordType));
      }
    }

    public AttachDocumentHistory_Environment AttachDocumentHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentHistories), (object) value);
      }
      get
      {
        return (AttachDocumentHistory_Environment) this.PropertyGet(nameof (AttachDocumentHistories));
      }
    }

    public UserAttribute_Environment ContainerAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerAttributes), (object) value);
      }
      get
      {
        return (UserAttribute_Environment) this.PropertyGet(nameof (ContainerAttributes));
      }
    }

    public Environment TransactionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransactionFilter));
      }
    }

    public Environment NextReversibleHMIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextReversibleHMIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextReversibleHMIndex));
      }
    }

    public Environment SelectedHistoryMainlineIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainlineIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHistoryMainlineIndex));
      }
    }

    public new Environment ShowFullHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowFullHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowFullHistory));
      }
    }

    public Environment ShowAllAvailable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllAvailable), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowAllAvailable));
      }
    }

    public new Environment ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultsetSizeLimit));
      }
    }

    public new Environment ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public new Environment ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetStartRow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResultsetStartRow));
      }
    }

    public Environment SelectedHistorySummaryIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistorySummaryIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHistorySummaryIndex));
      }
    }

    public new Environment EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDate));
      }
    }

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment DateTimeFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateTimeFormat), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DateTimeFormat));
      }
    }

    public Environment ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public Environment SelectCurrentOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectCurrentOperation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectCurrentOperation));
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

    public Environment SelectedHistoryDetailsIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryDetailsIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHistoryDetailsIndex));
      }
    }

    public new Environment SortAscending
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortAscending), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SortAscending));
      }
    }

    public new Environment StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartDate));
      }
    }

    public new Environment ShowReversalInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowReversalInfo), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowReversalInfo));
      }
    }

    public Environment EndDateLastSec
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateLastSec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDateLastSec));
      }
    }

    public Environment OperationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationFilter));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public Environment ResourceStatusReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusReasonFilter));
      }
    }

    public Environment ResourceStatusCodeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusCodeFilter));
      }
    }

    public Environment ResourceFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceFilter));
      }
    }

    public Environment AvailabilityFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailabilityFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AvailabilityFilter));
      }
    }

    public new Environment ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowTxnTypes));
      }
    }

    public Environment EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EmployeeFilter));
      }
    }
  }
}
