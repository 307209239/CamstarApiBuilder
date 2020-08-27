// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryMainline_Environment
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
  public class HistoryMainline_Environment : BaseObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_LabelDetails")]
    [Metadata("History Detail information for every label printed.  One History Detail record will be created for every printed label.", "LabelHistoryDetail", false, false, true, "LabelHistoryDetail", 1050623, false, true, false, null)]
    protected LabelHistoryDetail_Environment _LabelDetails;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050417, false, false, false, null)]
    protected Environment _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_WIPMsgHistoryDetails")]
    [Metadata("Records the WIP Messages that were displayed as part of the transaction.", "WIPMsgHistoryDetail", false, false, true, "WIPMsgHistoryDetail", 1051150, false, true, false, null)]
    protected WIPMsgHistoryDetail_Environment _WIPMsgHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_MfgProcessOverrides")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, true, "RevisionedObjectRef", 1050936, false, false, false, null)]
    protected Environment _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ESigDetails")]
    [Metadata("The detail history for the collection of ESignatures.", "ESigHistoryDetail", false, false, true, "ESigHistoryDetail", 1050355, false, true, false, null)]
    protected ESigHistoryDetail_Environment _ESigDetails;
    [Metadata("The summary history for the collection of ESignatures.", "ESigHistorySummary", false, false, true, "SubentityRef", 1050356, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ESigSummaries")]
    protected Environment _ESigSummaries;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_MassUpdates")]
    [Metadata("LongString", "", false, false, true, "String", 16779378, false, true, false, null)]
    protected Environment _MassUpdates;
    [Metadata("History of the Computation", "ComputationHistory", false, false, true, "ComputationHistory", 1051025, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ComputationHistory")]
    protected ComputationHistory_Environment _ComputationHistory;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_LabelSummaries")]
    [Metadata("History Summary information for every label printed.  One History Summary record will be created for every printed label.", "LabelHistorySummary", false, false, true, "SubentityRef", 1050622, false, true, false, null)]
    protected Environment _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_DisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    protected Environment _DisplayName;
    [Metadata("History of the parametric data such as measurements that were collected during a specific transaction.", "ParametricDetail", false, false, true, "ParametricDetail", 1049103, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ParametricDetail")]
    protected ParametricDetail_Environment _ParametricDetail;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_HistoryDetails")]
    [Metadata("Describes history details.", "HistoryDetails", false, false, true, "HistoryDetails", 1049096, false, true, false, null)]
    protected HistoryDetails_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_AdditionalESigReqs")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1051894, false, true, false, null)]
    protected Environment _AdditionalESigReqs;
    [Metadata("The primary feature of the Manufacturing Calendar.  The Manufacturing Calendar contains a collection (list) of \"calendar shifts\".  Each calendar shift starts and ends at a particular calendar date/time, and includes information on which shift, mfg date, etc. to use for this time period.", "CalendarShift", false, false, true, "SubentityRef", 1049106, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_CalendarShift")]
    protected Environment _CalendarShift;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_WorkflowStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1048855, false, false, false, null)]
    protected Environment _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_AttachmentsDetails")]
    [Metadata("Document Attachments History Details", "DocAttachmentsHistoryDetails", false, false, true, "DocAttachmentsHistoryDetails", 1051126, false, true, false, null)]
    protected DocAttachmentsHistoryDetails_Environment _AttachmentsDetails;
    [Metadata("Name/Value pairs to be added as user attributes to the started containers", "StartContAttrHistoryDetail", false, false, true, "SubentityRef", 1051938, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_AttributeDetails")]
    protected Environment _AttributeDetails;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Batch")]
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, true, "ContainerRef", 1051854, false, false, false, null)]
    protected Environment _Batch;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_BaseTxnType")]
    [Metadata("Definition for the Transaction Type Id.", "ServiceNameEnum", false, false, true, "Integer", 1048867, false, false, false, null)]
    protected Environment _BaseTxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_TxnType")]
    [Metadata("Definition for the Transaction Type Id.", "ServiceNameEnum", false, false, true, "Integer", 1048909, false, false, false, null)]
    protected Environment _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, true, "NamedObjectRef", 1051807, false, false, false, null)]
    protected Environment _Carrier;
    [Metadata("Keeps track of all the Documents attached and detached form NDOs, RDOs and Containers", "AttachDocumentHistory", false, false, true, "SubentityRef", 16778477, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_AttachDocumentHistories")]
    protected Environment _AttachDocumentHistories;
    [Metadata("Definition for the Transaction Type Id.", "ServiceNameEnum", false, false, true, "Integer", 1049601, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_CompoundTxnType")]
    protected Environment _CompoundTxnType;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_BizRuleHistory")]
    [Metadata("Business Rule Execution History", "BusinessRuleExecutionHistory", false, false, true, "SubentityRef", 1051414, false, true, false, null)]
    protected Environment _BizRuleHistory;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049105, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Server")]
    protected Environment _Server;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_LocalReworkIncluded")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049099, false, false, false, "0")]
    protected Environment _LocalReworkIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ReversalStatus")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049111, false, false, false, "1")]
    protected Environment _ReversalStatus;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_BonusIncluded")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049093, false, false, false, "0")]
    protected Environment _BonusIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_StepPass")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052229, false, false, false, null)]
    protected Environment _StepPass;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_DefectIncluded")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049095, false, false, false, "0")]
    protected Environment _DefectIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_LossIncluded")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049100, false, false, false, "0")]
    protected Environment _LossIncluded;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Container")]
    protected Environment _Container;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049637, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_InRework")]
    protected Environment _InRework;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_SystemDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049108, false, false, false, null)]
    protected Environment _SystemDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_TxnDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049109, false, false, false, null)]
    protected Environment _TxnDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_BinningIncluded")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049092, false, false, false, "0")]
    protected Environment _BinningIncluded;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Implicit")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049098, false, false, false, "0")]
    protected Environment _Implicit;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048863, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_TxnDate")]
    protected Environment _TxnDate;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048876, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Client")]
    protected Environment _Client;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049101, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_MfgDate")]
    protected Environment _MfgDate;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Application")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048875, false, false, false, null)]
    protected Environment _Application;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051665, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_QualityESigConfirmed")]
    protected Environment _QualityESigConfirmed;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_SystemDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049107, false, false, false, null)]
    protected Environment _SystemDate;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049947, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ShiftName")]
    protected Environment _ShiftName;
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, true, "NamedObjectRef", 1049247, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ResourceStatusCode")]
    protected Environment _ResourceStatusCode;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Authorizations")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1049091, false, true, false, null)]
    protected Environment _Authorizations;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Resource")]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Status")]
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, true, "Integer", 1048671, false, false, false, "1")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, true, "NamedObjectRef", 1048815, false, false, false, null)]
    protected Environment _Operation;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, true, "NamedObjectRef", 1048659, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Factory")]
    protected Environment _Factory;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_IconId")]
    protected Environment _IconId;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048864, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_User")]
    protected Environment _User;
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, false, true, "Integer", 1049962, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ResourceAvailability")]
    protected Environment _ResourceAvailability;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Owner")]
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, true, "NamedObjectRef", 1049249, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_ResourceStatusReason")]
    protected Environment _ResourceStatusReason;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050517, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Workstation")]
    protected Environment _Workstation;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048880, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Login")]
    protected Environment _Login;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Employee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048861, false, false, false, null)]
    protected Environment _Employee;
    [DataMember(EmitDefaultValue = false, Name = "HistoryMainline_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;

    public LabelHistoryDetail_Environment LabelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelDetails), (object) value);
      }
      get
      {
        return (LabelHistoryDetail_Environment) this.PropertyGet(nameof (LabelDetails));
      }
    }

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public WIPMsgHistoryDetail_Environment WIPMsgHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetails), (object) value);
      }
      get
      {
        return (WIPMsgHistoryDetail_Environment) this.PropertyGet(nameof (WIPMsgHistoryDetails));
      }
    }

    public Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public ESigHistoryDetail_Environment ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigHistoryDetail_Environment) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public Environment ESigSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigSummaries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigSummaries));
      }
    }

    public Environment MassUpdates
    {
      [param: In] set
      {
        this.PropertySet(nameof (MassUpdates), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MassUpdates));
      }
    }

    public ComputationHistory_Environment ComputationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationHistory), (object) value);
      }
      get
      {
        return (ComputationHistory_Environment) this.PropertyGet(nameof (ComputationHistory));
      }
    }

    public Environment LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public Environment DisplayName
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

    public ParametricDetail_Environment ParametricDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDetail), (object) value);
      }
      get
      {
        return (ParametricDetail_Environment) this.PropertyGet(nameof (ParametricDetail));
      }
    }

    public HistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (HistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment AdditionalESigReqs
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdditionalESigReqs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdditionalESigReqs));
      }
    }

    public Environment CalendarShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalendarShift), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CalendarShift));
      }
    }

    public Environment WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStep));
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

    public Environment AttributeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeDetails));
      }
    }

    public Environment Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Batch));
      }
    }

    public Environment BaseTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseTxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseTxnType));
      }
    }

    public Environment TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnType));
      }
    }

    public Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public Environment AttachDocumentHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentHistories), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachDocumentHistories));
      }
    }

    public Environment CompoundTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompoundTxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompoundTxnType));
      }
    }

    public Environment BizRuleHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (BizRuleHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BizRuleHistory));
      }
    }

    public Environment Server
    {
      [param: In] set
      {
        this.PropertySet(nameof (Server), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Server));
      }
    }

    public Environment LocalReworkIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalReworkIncluded), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LocalReworkIncluded));
      }
    }

    public Environment ReversalStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReversalStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReversalStatus));
      }
    }

    public Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment BonusIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (BonusIncluded), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BonusIncluded));
      }
    }

    public Environment StepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StepPass));
      }
    }

    public Environment DefectIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefectIncluded), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefectIncluded));
      }
    }

    public Environment LossIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossIncluded), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LossIncluded));
      }
    }

    public Environment Container
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

    public Environment InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InRework));
      }
    }

    public Environment SystemDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SystemDateGMT));
      }
    }

    public Environment TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public Environment BinningIncluded
    {
      [param: In] set
      {
        this.PropertySet(nameof (BinningIncluded), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BinningIncluded));
      }
    }

    public Environment Implicit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Implicit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Implicit));
      }
    }

    public Environment TxnDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnDate));
      }
    }

    public Environment Client
    {
      [param: In] set
      {
        this.PropertySet(nameof (Client), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Client));
      }
    }

    public Environment MfgDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgDate));
      }
    }

    public Environment Application
    {
      [param: In] set
      {
        this.PropertySet(nameof (Application), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Application));
      }
    }

    public Environment QualityESigConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigConfirmed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityESigConfirmed));
      }
    }

    public Environment SystemDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SystemDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SystemDate));
      }
    }

    public Environment ShiftName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShiftName));
      }
    }

    public Environment ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }

    public Environment Authorizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Authorizations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Authorizations));
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

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

    public Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }

    public Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
      }
    }

    public Environment User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (User));
      }
    }

    public Environment ResourceAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceAvailability), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceAvailability));
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

    public Environment ResourceStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusReason));
      }
    }

    public Environment Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workstation));
      }
    }

    public Environment Login
    {
      [param: In] set
      {
        this.PropertySet(nameof (Login), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Login));
      }
    }

    public Environment Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Employee));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }
  }
}
