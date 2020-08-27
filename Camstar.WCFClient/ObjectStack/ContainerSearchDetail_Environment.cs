// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerSearchDetail_Environment
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
  public class ContainerSearchDetail_Environment : ContainerStatusDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected new Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_HoldReason")]
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048800, false, false, true, null)]
    protected new Environment _HoldReason;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Spec")]
    protected new Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Customer")]
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1048612, false, false, true, null)]
    protected new Environment _Customer;
    [Metadata("Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).", "StartReason", false, false, false, "NamedObjectRef", 1048846, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_StartReason")]
    protected new Environment _StartReason;
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1048671, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Status")]
    protected new Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_SpecHistory")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    protected Environment _SpecHistory;
    [Metadata("Qty Operator:\r\n10 = Equal\r\n20 = GreaterThan\r\n30 = GreaterThanOrEqual\r\n40 = LessThan\r\n50 = LessThanOrEqual", "QtyOperatorEnum", false, false, false, "Integer", 1052703, false, false, true, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_QtyOperator")]
    protected new Environment _QtyOperator;
    [Metadata("Enumeration for the ContainerSearchFilter:\r\n-1 = Don't Filter\r\n 0 = Omit \r\n 1 = Include", "ContainerSearchFilterEnum", false, false, false, "Integer", 1048801, false, false, true, "-1")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_InProcessFilter")]
    protected Environment _InProcessFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_OnHoldFilter")]
    [Metadata("Enumeration for the ContainerSearchFilter:\r\n-1 = Don't Filter\r\n 0 = Omit \r\n 1 = Include", "ContainerSearchFilterEnum", false, false, false, "Integer", 1051239, false, false, true, "-1")]
    protected Environment _OnHoldFilter;
    [Metadata("Enumeration for the ContainerSearchFilter:\r\n-1 = Don't Filter\r\n 0 = Omit \r\n 1 = Include", "ContainerSearchFilterEnum", false, false, false, "Integer", 1049637, false, false, true, "-1")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_InReworkFilter")]
    protected Environment _InReworkFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_DueDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    protected new Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_InQualityControl")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779198, false, false, false, "0")]
    protected Environment _InQualityControl;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_TxnFromDate")]
    protected Environment _TxnFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_TxnToDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052918, false, false, false, null)]
    protected Environment _TxnToDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_OpenNonConformances")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052704, false, false, false, "0")]
    protected Environment _OpenNonConformances;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048801, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_InProcess")]
    protected new Environment _InProcess;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_OnHold")]
    protected Environment _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ApplyLineAssignmentHistory")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778990, false, false, false, "0")]
    protected Environment _ApplyLineAssignmentHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_FromIssuedStockPoint")]
    [Metadata("Generic String", "", false, false, false, "String", 1052914, false, false, false, null)]
    protected Environment _FromIssuedStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_FromIssuedLot")]
    [Metadata("Generic String", "", false, false, false, "String", 1052913, false, false, false, null)]
    protected Environment _FromIssuedLot;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_InRework")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049637, false, false, false, "0")]
    protected Environment _InRework;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778990, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ApplyLineAssignmentCurrentStatus")]
    protected Environment _ApplyLineAssignmentCurrentStatus;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Container")]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_IssuedComponentProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1052915, false, false, true, null)]
    protected Environment _IssuedComponentProduct;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Operation")]
    protected new Environment _Operation;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_OperationHistory")]
    protected Environment _OperationHistory;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1049578, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_SpecRevision")]
    protected new Environment _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Owner")]
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    protected new Environment _Owner;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1050517, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Workstation")]
    protected Environment _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_SalesOrder")]
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, false, "NamedObjectRef", 1048843, false, false, true, null)]
    protected new Environment _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Step")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049032, false, false, true, null)]
    protected new Environment _Step;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_LAResource")]
    protected Environment _LAResource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_LAWorkstation")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 16778989, false, false, false, null)]
    protected Environment _LAWorkstation;
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_MfgOrder")]
    protected new Environment _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ResourceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049575, false, false, false, null)]
    protected new Environment _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected new Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_IssuedContainer")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052916, false, false, false, null)]
    protected Environment _IssuedContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ProductRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1049573, false, false, false, null)]
    protected new Environment _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_OperationName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049568, false, false, false, null)]
    protected new Environment _OperationName;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Qty")]
    protected new Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    protected new Environment _Workflow;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ContainerName")]
    protected new Environment _ContainerName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Specification")]
    protected new Environment _Specification;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ReworkReason")]
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, false, "NamedObjectRef", 1048740, false, false, true, null)]
    protected new Environment _ReworkReason;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_LAOperation")]
    protected Environment _LAOperation;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_WorkCenter")]
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, false, null)]
    protected Environment _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_HistoryEmployeeHistory")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048861, false, false, true, null)]
    protected Environment _HistoryEmployeeHistory;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Resource")]
    protected new Environment _Resource;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049278, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ContainerLevelName")]
    protected new Environment _ContainerLevelName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ResourceHistory")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _ResourceHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_StepName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049579, false, false, false, null)]
    protected new Environment _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ContainerLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1049278, false, false, true, null)]
    protected new Environment _ContainerLevel;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Product")]
    protected new Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_LAWorkCenter")]
    [Metadata("A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.\r\n\r\nThe work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.\r\n\r\n", "WorkCenter", false, false, false, "NamedObjectRef", 1048644, false, false, false, null)]
    protected Environment _LAWorkCenter;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_ProductName")]
    protected new Environment _ProductName;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_Location")]
    protected new Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_PriorityCode")]
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, false, "NamedObjectRef", 1049086, false, false, true, null)]
    protected new Environment _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerSearchDetail_Environment_WorkflowRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1049581, false, false, false, null)]
    protected new Environment _WorkflowRev;

    public new Environment UOM
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

    public new Environment HoldReason
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

    public new Environment Spec
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

    public new Environment Customer
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

    public new Environment StartReason
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

    public new Environment Status
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

    public Environment SpecHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecHistory));
      }
    }

    public new Environment QtyOperator
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyOperator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyOperator));
      }
    }

    public Environment InProcessFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcessFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InProcessFilter));
      }
    }

    public Environment OnHoldFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHoldFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnHoldFilter));
      }
    }

    public Environment InReworkFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (InReworkFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InReworkFilter));
      }
    }

    public new Environment DueDate
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

    public Environment TxnFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnFromDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnFromDate));
      }
    }

    public Environment TxnToDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnToDate));
      }
    }

    public Environment OpenNonConformances
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenNonConformances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OpenNonConformances));
      }
    }

    public new Environment InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InProcess));
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

    public Environment ApplyLineAssignmentHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyLineAssignmentHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApplyLineAssignmentHistory));
      }
    }

    public Environment FromIssuedStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromIssuedStockPoint));
      }
    }

    public Environment FromIssuedLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromIssuedLot));
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

    public Environment ApplyLineAssignmentCurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyLineAssignmentCurrentStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApplyLineAssignmentCurrentStatus));
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

    public Environment IssuedComponentProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedComponentProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuedComponentProduct));
      }
    }

    public new Environment Operation
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

    public Environment OperationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationHistory));
      }
    }

    public new Environment SpecRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecRevision));
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

    public new Environment SalesOrder
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

    public new Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }

    public Environment LAResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAResource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LAResource));
      }
    }

    public Environment LAWorkstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAWorkstation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LAWorkstation));
      }
    }

    public new Environment MfgOrder
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

    public new Environment ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceName));
      }
    }

    public new Environment Factory
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

    public Environment IssuedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuedContainer));
      }
    }

    public new Environment ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductRev));
      }
    }

    public new Environment OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationName));
      }
    }

    public new Environment Qty
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

    public new Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public new Environment ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerName));
      }
    }

    public new Environment Specification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Specification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Specification));
      }
    }

    public new Environment ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public Environment LAOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAOperation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LAOperation));
      }
    }

    public Environment WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenter));
      }
    }

    public Environment HistoryEmployeeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryEmployeeHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryEmployeeHistory));
      }
    }

    public new Environment Resource
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

    public new Environment ContainerLevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerLevelName));
      }
    }

    public Environment ResourceHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceHistory));
      }
    }

    public new Environment StepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StepName));
      }
    }

    public new Environment ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public new Environment Product
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

    public Environment LAWorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LAWorkCenter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LAWorkCenter));
      }
    }

    public new Environment ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductName));
      }
    }

    public new Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }

    public new Environment PriorityCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityCode));
      }
    }

    public new Environment WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowRev));
      }
    }
  }
}
