// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainerAsParent_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CurrentContainerStatus_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ViewContainerAsParent_Environment : ContainerStatusDetails_Environment
  {
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1049570, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_PlannedUOM")]
    protected new Environment _PlannedUOM;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_UOM")]
    protected new Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Customer")]
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, true, "NamedObjectRef", 1048612, false, false, true, null)]
    protected new Environment _Customer;
    [Metadata("Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).", "StartReason", false, false, true, "NamedObjectRef", 1048846, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_StartReason")]
    protected new Environment _StartReason;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1049571, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_PlannedUOM2")]
    protected new Environment _PlannedUOM2;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048828, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_PlannedQty2")]
    protected new Environment _PlannedQty2;
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, true, "Integer", 1048671, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Status")]
    protected new Environment _Status;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, true, "NamedObjectRef", 1048800, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_HoldReason")]
    protected new Environment _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_CurrentThruputQty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048788, false, false, false, null)]
    protected new Environment _CurrentThruputQty2;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048837, false, false, false, null)]
    protected new Environment _Qty2;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, true, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Spec")]
    protected new Environment _Spec;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_UOM2")]
    protected new Environment _UOM2;
    [Metadata("Current status of the Container.\r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\n5 = OnHold", "ContainerStatusExtEnum", false, false, true, "Integer", 1049675, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ContainerStatus")]
    protected Environment _ContainerStatus;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048820, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_OriginalStartDate")]
    protected new Environment _OriginalStartDate;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_LastMoveDate")]
    protected new Environment _LastMoveDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048803, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_LastActivityDate")]
    protected new Environment _LastActivityDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048832, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ProjectedDate")]
    protected new Environment _ProjectedDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_DueDate")]
    protected new Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_RequestDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048838, false, false, false, null)]
    protected new Environment _RequestDate;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1048801, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_InProcess")]
    protected new Environment _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Step")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1049032, false, false, true, null)]
    protected new Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_HoldReasonName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048800, false, false, false, null)]
    protected Environment _HoldReasonName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ProductName")]
    protected new Environment _ProductName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049278, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ContainerLevelName")]
    protected new Environment _ContainerLevelName;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, true, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Operation")]
    protected new Environment _Operation;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048787, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_CurrentThruputQty")]
    protected new Environment _CurrentThruputQty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_StatusName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050396, false, false, false, null)]
    protected new Environment _StatusName;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1049279, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ProductDescription")]
    protected new Environment _ProductDescription;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049575, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ResourceName")]
    protected new Environment _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, true, null)]
    protected new Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ReworkReason")]
    [Metadata("An instance of a Process Rework Code is used to provide a list of reasons for Process Rework. The code is associated with a Container when it enters a rework loop. It is then associated with all throughput transactions generated by the container while it is in the rework loop. This provides, for example, a means of differentiating between first pass and rework throughput in reporting.\r\n", "ReworkReason", false, false, true, "NamedObjectRef", 1048740, false, false, true, null)]
    protected new Environment _ReworkReason;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, true, "NamedSubentityRef", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Location")]
    protected new Environment _Location;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, true, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Factory")]
    protected new Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_DocumentEntries")]
    [Metadata("A Document Entry is used to include a Document in a Document and provide a description for it within the Document Set. If there is more than one Document within a Document Set when a request is made to display a Document Set, the list of Document Entries is used to build a selection list. (Note that a one-to-one relationship between a Document Set and a Document is likely the common scenario).", "DocumentEntry", false, false, true, "DocumentEntry", 1050452, false, true, false, null)]
    protected DocumentEntry_Environment _DocumentEntries;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, true, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Owner")]
    protected new Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_WorkflowRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1049581, false, false, false, null)]
    protected new Environment _WorkflowRev;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049634, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_StartReasonName")]
    protected Environment _StartReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_PlannedQty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048827, false, false, false, null)]
    protected new Environment _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ProductRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1049573, false, false, false, null)]
    protected new Environment _ProductRev;
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, true, "NamedObjectRef", 1049086, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_PriorityCode")]
    protected new Environment _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_SalesOrderName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049633, false, false, false, null)]
    protected Environment _SalesOrderName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ContainerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049043, false, false, false, null)]
    protected new Environment _ContainerName;
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, true, "NamedObjectRef", 1049278, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ContainerLevel")]
    protected new Environment _ContainerLevel;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, true, "Boolean", 1049580, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_WorkflowIsRevOfRcd")]
    protected new Environment _WorkflowIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_MfgOrder")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, true, "NamedObjectRef", 1048810, false, false, true, null)]
    protected new Environment _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_StepName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049579, false, false, false, null)]
    protected new Environment _StepName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_MfgOrderName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048810, false, false, false, null)]
    protected Environment _MfgOrderName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Specification")]
    protected new Environment _Specification;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, true, "Boolean", 1049572, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ProductIsRevOfRcd")]
    protected new Environment _ProductIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048836, false, false, false, null)]
    protected new Environment _Qty;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_UOMName")]
    protected Environment _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_PriorityCodeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049086, false, false, false, null)]
    protected Environment _PriorityCodeName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_UOM2Name")]
    protected Environment _UOM2Name;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1049578, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_SpecRevision")]
    protected new Environment _SpecRevision;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_ContainerComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048771, false, false, false, null)]
    protected new Environment _ContainerComments;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_SalesOrder")]
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, true, "NamedObjectRef", 1048843, false, false, true, null)]
    protected new Environment _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_PlannedProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048826, false, false, true, null)]
    protected new Environment _PlannedProduct;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_OwnerName")]
    protected Environment _OwnerName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048812, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_NextOperation")]
    protected new Environment _NextOperation;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_SpecIsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, true, "Boolean", 1049577, false, false, false, "0")]
    protected new Environment _SpecIsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected new Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, true, null)]
    protected new Environment _Workflow;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049632, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_CustomerName")]
    protected Environment _CustomerName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_LocationName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048660, false, false, false, null)]
    protected Environment _LocationName;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainerAsParent_Environment_OperationName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049568, false, false, false, null)]
    protected new Environment _OperationName;

    public new Environment PlannedUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedUOM));
      }
    }

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

    public new Environment PlannedUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedUOM2));
      }
    }

    public new Environment PlannedQty2
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

    public new Environment CurrentThruputQty2
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

    public new Environment Qty2
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

    public new Environment UOM2
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

    public new Environment OriginalStartDate
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

    public new Environment LastMoveDate
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

    public new Environment LastActivityDate
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

    public new Environment ProjectedDate
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

    public new Environment RequestDate
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

    public Environment HoldReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReasonName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReasonName));
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

    public new Environment CurrentThruputQty
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

    public new Environment StatusName
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

    public new Environment ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductDescription));
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

    public DocumentEntry_Environment DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry_Environment) this.PropertyGet(nameof (DocumentEntries));
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

    public Environment StartReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartReasonName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartReasonName));
      }
    }

    public new Environment PlannedQty
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

    public Environment SalesOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SalesOrderName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SalesOrderName));
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

    public new Environment WorkflowIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowIsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowIsRevOfRcd));
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

    public Environment MfgOrderName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrderName));
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

    public new Environment ProductIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductIsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductIsRevOfRcd));
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

    public Environment UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOMName));
      }
    }

    public Environment PriorityCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityCodeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityCodeName));
      }
    }

    public Environment UOM2Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2Name));
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

    public new Environment ContainerComments
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

    public new Environment PlannedProduct
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

    public new Environment NextOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextOperation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextOperation));
      }
    }

    public new Environment SpecIsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecIsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecIsRevOfRcd));
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

    public Environment CustomerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerName));
      }
    }

    public Environment LocationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LocationName));
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
  }
}
