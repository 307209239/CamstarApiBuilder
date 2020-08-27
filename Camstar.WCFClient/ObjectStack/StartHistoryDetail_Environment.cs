// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartHistoryDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (GroupHistoryDetail_Environment))]
  [KnownType(typeof (MaterialContainerHistoryDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (BatchStartHistoryDetail_Environment))]
  [KnownType(typeof (UnitHistoryDetail_Environment))]
  [Serializable]
  public class StartHistoryDetail_Environment : HistoryDetails_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048828, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_PlannedQty2")]
    protected Environment _PlannedQty2;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Qty2")]
    protected Environment _Qty2;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048829, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_PlannedQtyUOM")]
    protected Environment _PlannedQtyUOM;
    [Metadata("Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).", "StartReason", false, false, false, "NamedObjectRef", 1049119, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_StartReason")]
    protected Environment _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048853, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_UOM")]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_PlannedQtyUOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048830, false, false, false, null)]
    protected Environment _PlannedQtyUOM2;
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, true, "RevisionedObjectRef", 1050936, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_BillOfProcess")]
    protected Environment _BillOfProcess;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048854, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_UOM2")]
    protected Environment _UOM2;
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1048612, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Customer")]
    protected Environment _Customer;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_VendorItem")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, true, "NamedSubentityRef", 1049454, false, false, false, null)]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_SamplingLot")]
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, true, "NamedObjectRef", 16777719, false, false, false, null)]
    protected Environment _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Carrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, true, "NamedObjectRef", 1051807, false, false, false, null)]
    protected Environment _Carrier;
    [Metadata("Name/Value pairs to be added as user attributes to the started containers", "StartContAttrHistoryDetail", false, false, true, "SubentityRef", 1051932, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Attributes")]
    protected Environment _Attributes;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048852, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_UnitCount")]
    protected Environment _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051257, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_ExpirationDateGMT")]
    protected Environment _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_PlannedStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050318, false, false, false, null)]
    protected Environment _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_PlannedStartDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051453, false, false, false, null)]
    protected Environment _PlannedStartDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050479, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_ExpirationDate")]
    protected Environment _ExpirationDate;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16779198, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_InQualityControl")]
    protected Environment _InQualityControl;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048838, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_RequestDate")]
    protected Environment _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_DueDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    protected Environment _DueDate;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053104, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_SamplingRequired")]
    protected Environment _SamplingRequired;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048792, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_DueDateGMT")]
    protected Environment _DueDateGMT;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048770, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_ChildCount")]
    protected Environment _ChildCount;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1049067, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_WorkflowStack")]
    protected Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, false, null)]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Location")]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, false, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Workstation")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1050517, false, false, false, null)]
    protected Environment _Workstation;
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, false, "NamedObjectRef", 1048843, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_SalesOrder")]
    protected Environment _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_PlannedProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048826, false, false, false, null)]
    protected Environment _PlannedProduct;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_WorkflowStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048855, false, false, false, null)]
    protected Environment _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_PlannedQty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048827, false, false, false, null)]
    protected Environment _PlannedQty;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Owner")]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_MfgOrder")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, false, null)]
    protected Environment _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_Priority")]
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, false, "NamedObjectRef", 1049086, false, false, false, null)]
    protected Environment _Priority;
    [DataMember(EmitDefaultValue = false, Name = "StartHistoryDetail_Environment_ContainerComments")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048771, false, false, false, null)]
    protected Environment _ContainerComments;

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

    public Environment Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Attributes));
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

    public new Environment HistoryId
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

    public Environment WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStack));
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

    public Environment Location
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
  }
}
