// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Container_Environment
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
  public class Container_Environment : BaseObject_Environment
  {
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, true, "RevisionedObjectRef", 1050936, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_BillOfProcess")]
    protected Environment _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ProjectedQty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048835, false, false, false, null)]
    protected Environment _ProjectedQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Customer")]
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, true, "NamedObjectRef", 1048612, false, false, false, null)]
    protected Environment _Customer;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Qty2")]
    protected Environment _Qty2;
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Status")]
    protected Environment _Status;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048850, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ThruputAdjustmentQty2")]
    protected Environment _ThruputAdjustmentQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OriginalQty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048819, false, false, false, null)]
    protected Environment _OriginalQty2;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, true, "NamedObjectRef", 1048800, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_HoldReason")]
    protected Environment _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048853, false, false, false, null)]
    protected Environment _UOM;
    [Metadata("The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.", "Bill", false, false, true, "RevisionedObjectRef", 1049438, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_BOM")]
    protected Environment _BOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OriginalUOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048823, false, false, false, null)]
    protected Environment _OriginalUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_FactoryStartQty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048796, false, false, false, null)]
    protected Environment _FactoryStartQty2;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048828, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_PlannedQty2")]
    protected Environment _PlannedQty2;
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050437, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OpenNonconformanceReports")]
    protected Environment _OpenNonconformanceReports;
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, true, "NamedObjectRef", 1053010, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OpenEvents")]
    protected Environment _OpenEvents;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, true, "NamedSubentityRef", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_VendorItem")]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_GateStatus")]
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nA Gate Status is used to manage the status of a Container with the boundaries of a Gate. This includes track completed Steps (when applicable), determining if it is valid the Container to exit the Gate and any associated actions required (i.e., create a History Entry when exiting a cycle-time Gate.", "GateStatus", false, false, true, "GateStatus", 1048799, false, true, false, null)]
    protected GateStatus_Environment _GateStatus;
    [Metadata("A detail object of the container CDO.  The intent is that the end user extends the detail object instead of extending the container object itself.", "ContainerDetail", false, false, true, "ContainerDetail", 1049951, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Detail")]
    protected ContainerDetail_Environment _Detail;
    [Metadata("This is not implemented in the current version of InSite.\r\n\r\nA Spec Status is used to manage the status of a Container for the duration of processing against its current Spec. This includes tracking completed Transactions (when applicable), and determining if it is valid for the Container to Move to another Step (processing is completed for the current Spec).", "SpecStatus", false, false, true, "SpecStatus", 1048844, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_SpecStatus")]
    protected SpecStatus_Environment _SpecStatus;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OriginalUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048822, false, false, false, null)]
    protected Environment _OriginalUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_FactoryStartUOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048798, false, false, false, null)]
    protected Environment _FactoryStartUOM2;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048830, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_PlannedQtyUOM2")]
    protected Environment _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_CurrentThruputQty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048788, false, false, false, null)]
    protected Environment _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_NonconformanceReports")]
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050602, false, true, false, null)]
    protected Environment _NonconformanceReports;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048829, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_PlannedQtyUOM")]
    protected Environment _PlannedQtyUOM;
    [Metadata("Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).", "StartReason", false, false, true, "NamedObjectRef", 1048846, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_StartReason")]
    protected Environment _StartReason;
    [Metadata("Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.  This particular type of material list item is used on Containers, and was created so that Container component lists could be stored in a separate table from BOM or MfgOrder component lists.", "ContainerMaterialListItem", false, false, true, "ContainerMaterialListItem", 1049923, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ContainerMaterialList")]
    protected ContainerMaterialListItem_Environment _ContainerMaterialList;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_FactoryStartUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048797, false, false, false, null)]
    protected Environment _FactoryStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048854, false, false, false, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_RelativePriority")]
    [Metadata("This is a numeric value that is used to sequence Containers for Dispatching (\"What do I work on next?\"). There are multiple algorithms that can be resolved to a single numeric value. This (use of a field) is a simple approach to dividing the algorithm from the Dispatching.", "", false, false, true, "Integer", 1048705, false, false, false, null)]
    protected Environment _RelativePriority;
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollection", false, false, true, "NamedSubentityRef", 1052938, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_DataPointCollections")]
    protected Environment _DataPointCollections;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, false, null)]
    protected Environment _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ContainerSampleData")]
    [Metadata("Used to  record all sampling plan data for a container.  The sampling plan data is stored in this objects in order to keep updates from a user to the SamplingPlan from changing once the container has started its sampling plan tested.  This is also used to provide selection data for the user on the Collect Sampling transaction.  The next container will pick up the new changes.", "ContainerSampleData", false, false, true, "ContainerSampleData", 1053102, false, true, false, null)]
    protected ContainerSampleData_Environment _ContainerSampleData;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Attributes")]
    [Metadata("A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.", "UserAttribute", false, false, true, "UserAttribute", 1051932, false, true, false, null)]
    protected UserAttribute_Environment _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_AttachDocumentDetails")]
    [Metadata("The details used to display the attached documents.", "AttachDocumentDetails", false, false, true, "AttachDocumentDetails", 16777527, false, true, false, null)]
    protected AttachDocumentDetails_Environment _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_SamplingLot")]
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, true, "NamedObjectRef", 16777719, false, false, false, null)]
    protected Environment _SamplingLot;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048820, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OriginalStartDate")]
    protected Environment _OriginalStartDate;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16779198, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_InQualityControl")]
    protected Environment _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_LastMoveDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048808, false, false, false, null)]
    protected Environment _LastMoveDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048793, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_FactoryStartDate")]
    protected Environment _FactoryStartDate;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053103, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_SamplingPassed")]
    protected Environment _SamplingPassed;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050318, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_PlannedStartDate")]
    protected Environment _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_CurrentHoldCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049783, false, false, false, null)]
    protected Environment _CurrentHoldCount;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048806, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_LastCompletionDateGMT")]
    protected Environment _LastCompletionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Parent")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1048825, false, false, false, null)]
    protected Environment _Parent;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_UnitCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048852, false, false, false, null)]
    protected Environment _UnitCount;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049788, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ThruputAdjustmentChildCount")]
    protected Environment _ThruputAdjustmentChildCount;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048794, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_FactoryStartDateGMT")]
    protected Environment _FactoryStartDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048803, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_LastActivityDate")]
    protected Environment _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ThisContainerLost")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048848, false, false, false, "0")]
    protected Environment _ThisContainerLost;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053104, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_SamplingRequired")]
    protected Environment _SamplingRequired;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ExpirationDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050479, false, false, false, null)]
    protected Environment _ExpirationDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_CurrentThruputUnitCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049434, false, false, false, null)]
    protected Environment _CurrentThruputUnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_LastCompletionDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048805, false, false, false, null)]
    protected Environment _LastCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_DueDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    protected Environment _DueDate;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049786, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_IssuedToContainer")]
    protected Environment _IssuedToContainer;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049787, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OnHoldDate")]
    protected Environment _OnHoldDate;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ThruputAdjustmentUnitCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049789, false, false, false, null)]
    protected Environment _ThruputAdjustmentUnitCount;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048833, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ProjectedDateGMT")]
    protected Environment _ProjectedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_RollupUnitCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052226, false, false, false, null)]
    protected Environment _RollupUnitCount;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049435, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_CurrentThruputChildCount")]
    protected Environment _CurrentThruputChildCount;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048821, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OriginalStartDateGMT")]
    protected Environment _OriginalStartDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051257, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ExpirationDateGMT")]
    protected Environment _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_RequestDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048838, false, false, false, null)]
    protected Environment _RequestDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048804, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_LastActivityDateGMT")]
    protected Environment _LastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ChildContainers")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "Container", 1048769, false, true, false, null)]
    protected Container_Environment _ChildContainers;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048832, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ProjectedDate")]
    protected Environment _ProjectedDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051453, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_PlannedStartDateGMT")]
    protected Environment _PlannedStartDateGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777528, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_IsContainer")]
    protected Environment _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_IsNDO")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777529, false, false, false, "0")]
    protected Environment _IsNDO;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048839, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_RequestDateGMT")]
    protected Environment _RequestDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_IsRDO")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777530, false, false, false, "0")]
    protected Environment _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_CurrentStepPass")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052225, false, false, false, null)]
    protected Environment _CurrentStepPass;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_LastMoveDate")]
    protected Environment _LastMoveDate;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048770, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ChildCount")]
    protected Environment _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_DueDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048792, false, false, false, null)]
    protected Environment _DueDateGMT;
    [Metadata("Attached to an instance of a modeling entity, this contains the messages that apply to the entity.  When asked to supply its WIP Messages, a modeling entity will ask its WIPMsgDefMgr to supply a list of WIP Messages that have been filtered to include only the messages that apply to the current circumstances (step, operation and label).\r\nThe WIPMsgDefMgr will check the AllKey WIPMsgKey (which contains a message that applies to all steps) if specified, and run through the entries in the OperationKeys and LabelKeys lists and filter each message found.", "WIPMsgDefMgr", false, false, true, "WIPMsgDefMgr", 1048768, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_WIPMsgDefMgr")]
    protected WIPMsgDefMgr_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_SalesOrder")]
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, true, "NamedObjectRef", 1048843, false, false, false, null)]
    protected Environment _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OriginalQty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048818, false, false, false, null)]
    protected Environment _OriginalQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Priority")]
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, true, "NamedObjectRef", 1049086, false, false, false, null)]
    protected Environment _Priority;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049088, false, false, false, null)]
    protected Environment _Name;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Qty")]
    protected Environment _Qty;
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, true, "NamedObjectRef", 1048809, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Level")]
    protected Environment _Level;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ThruputAdjustmentQty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048849, false, false, false, null)]
    protected Environment _ThruputAdjustmentQty;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, true, "NamedObjectRef", 1048817, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_OriginalFactory")]
    protected Environment _OriginalFactory;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_FactoryStartQty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048795, false, false, false, null)]
    protected Environment _FactoryStartQty;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048834, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ProjectedQty")]
    protected Environment _ProjectedQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_PlannedQty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048827, false, false, false, null)]
    protected Environment _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_MfgOrder")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, true, "NamedObjectRef", 1048810, false, false, false, null)]
    protected Environment _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_CurrentThruputQty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048787, false, false, false, null)]
    protected Environment _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_ContainerComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048771, false, false, false, null)]
    protected Environment _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_PlannedProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048826, false, false, false, null)]
    protected Environment _PlannedProduct;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Owner")]
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050517, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Container_Environment_Workstation")]
    protected Environment _Workstation;

    public Environment BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public Environment ProjectedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProjectedQty2));
      }
    }

    public Environment Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Customer));
      }
    }

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
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

    public Environment ThruputAdjustmentQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputAdjustmentQty2));
      }
    }

    public Environment OriginalQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalQty2));
      }
    }

    public Environment HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReason));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment BOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BOM));
      }
    }

    public Environment OriginalUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalUOM2));
      }
    }

    public Environment FactoryStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryStartQty2));
      }
    }

    public Environment PlannedQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedQty2));
      }
    }

    public Environment OpenNonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenNonconformanceReports), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OpenNonconformanceReports));
      }
    }

    public Environment OpenEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenEvents), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OpenEvents));
      }
    }

    public Environment VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorItem));
      }
    }

    public GateStatus_Environment GateStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (GateStatus), (object) value);
      }
      get
      {
        return (GateStatus_Environment) this.PropertyGet(nameof (GateStatus));
      }
    }

    public ContainerDetail_Environment Detail
    {
      [param: In] set
      {
        this.PropertySet(nameof (Detail), (object) value);
      }
      get
      {
        return (ContainerDetail_Environment) this.PropertyGet(nameof (Detail));
      }
    }

    public SpecStatus_Environment SpecStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStatus), (object) value);
      }
      get
      {
        return (SpecStatus_Environment) this.PropertyGet(nameof (SpecStatus));
      }
    }

    public Environment OriginalUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalUOM));
      }
    }

    public Environment FactoryStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryStartUOM2));
      }
    }

    public Environment PlannedQtyUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedQtyUOM2));
      }
    }

    public Environment CurrentThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentThruputQty2));
      }
    }

    public Environment NonconformanceReports
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceReports), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NonconformanceReports));
      }
    }

    public Environment PlannedQtyUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQtyUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedQtyUOM));
      }
    }

    public Environment StartReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartReason));
      }
    }

    public ContainerMaterialListItem_Environment ContainerMaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerMaterialList), (object) value);
      }
      get
      {
        return (ContainerMaterialListItem_Environment) this.PropertyGet(nameof (ContainerMaterialList));
      }
    }

    public Environment FactoryStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryStartUOM));
      }
    }

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

    public Environment RelativePriority
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelativePriority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RelativePriority));
      }
    }

    public Environment DataPointCollections
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollections), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointCollections));
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

    public ContainerSampleData_Environment ContainerSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleData), (object) value);
      }
      get
      {
        return (ContainerSampleData_Environment) this.PropertyGet(nameof (ContainerSampleData));
      }
    }

    public UserAttribute_Environment Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttribute_Environment) this.PropertyGet(nameof (Attributes));
      }
    }

    public AttachDocumentDetails_Environment AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (AttachDocumentDetails_Environment) this.PropertyGet(nameof (AttachDocumentDetails));
      }
    }

    public Environment SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Environment OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Environment InQualityControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (InQualityControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InQualityControl));
      }
    }

    public Environment LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Environment FactoryStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryStartDate));
      }
    }

    public Environment SamplingPassed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPassed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPassed));
      }
    }

    public Environment PlannedStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedStartDate));
      }
    }

    public Environment CurrentHoldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentHoldCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentHoldCount));
      }
    }

    public Environment LastCompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletionDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletionDateGMT));
      }
    }

    public Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Environment ThruputAdjustmentChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputAdjustmentChildCount));
      }
    }

    public Environment FactoryStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryStartDateGMT));
      }
    }

    public Environment LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Environment ThisContainerLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerLost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThisContainerLost));
      }
    }

    public Environment SamplingRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingRequired));
      }
    }

    public Environment ExpirationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExpirationDate));
      }
    }

    public Environment CurrentThruputUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputUnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentThruputUnitCount));
      }
    }

    public Environment LastCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletionDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastCompletionDate));
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

    public Environment IssuedToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedToContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuedToContainer));
      }
    }

    public Environment OnHoldDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnHoldDate));
      }
    }

    public Environment ThruputAdjustmentUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentUnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputAdjustmentUnitCount));
      }
    }

    public Environment ProjectedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProjectedDateGMT));
      }
    }

    public Environment RollupUnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupUnitCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RollupUnitCount));
      }
    }

    public Environment CurrentThruputChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentThruputChildCount));
      }
    }

    public Environment OriginalStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalStartDateGMT));
      }
    }

    public Environment ExpirationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExpirationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExpirationDateGMT));
      }
    }

    public Environment RequestDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequestDate));
      }
    }

    public Environment LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Container_Environment ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Container_Environment) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public Environment ProjectedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProjectedDate));
      }
    }

    public Environment PlannedStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedStartDateGMT));
      }
    }

    public Environment IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Environment IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsNDO));
      }
    }

    public Environment RequestDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequestDateGMT));
      }
    }

    public Environment IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Environment CurrentStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStepPass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentStepPass));
      }
    }

    public Environment LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Environment ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildCount));
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

    public WIPMsgDefMgr_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Environment SalesOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SalesOrder));
      }
    }

    public Environment OriginalQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalQty));
      }
    }

    public Environment Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Priority));
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

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public Environment Level
    {
      [param: In] set
      {
        this.PropertySet(nameof (Level), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Level));
      }
    }

    public Environment ThruputAdjustmentQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAdjustmentQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputAdjustmentQty));
      }
    }

    public Environment OriginalFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalFactory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalFactory));
      }
    }

    public Environment FactoryStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryStartQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryStartQty));
      }
    }

    public Environment ProjectedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProjectedQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProjectedQty));
      }
    }

    public Environment PlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedQty));
      }
    }

    public Environment MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public Environment CurrentThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentThruputQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentThruputQty));
      }
    }

    public Environment ContainerComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerComments));
      }
    }

    public Environment PlannedProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedProduct));
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
  }
}
