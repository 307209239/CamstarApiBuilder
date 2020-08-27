// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaintDetail_Environment
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
  public class ContainerMaintDetail_Environment : ChgContainerAttrDetail_Environment
  {
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_UOM")]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048630, false, false, true, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_PreHistoryDetail")]
    [Metadata("Provides a service that allows changing the value of all container, container detail and current status attributes allowed to be updated.", "ContainerMaintHistDetail", false, false, false, "SubentityRef", 1050289, false, false, false, null)]
    protected new Environment _PreHistoryDetail;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048830, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_PlannedQtyUOM2")]
    protected Environment _PlannedQtyUOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_VendorItem")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, true, null)]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_RelativePriority")]
    [Metadata("This is a numeric value that is used to sequence Containers for Dispatching (\"What do I work on next?\"). There are multiple algorithms that can be resolved to a single numeric value. This (use of a field) is a simple approach to dividing the algorithm from the Dispatching.", "", false, false, false, "Integer", 1048705, false, false, false, null)]
    protected Environment _RelativePriority;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_PlannedQty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048828, false, false, false, null)]
    protected Environment _PlannedQty2;
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1048612, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Customer")]
    protected Environment _Customer;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048829, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_PlannedQtyUOM")]
    protected Environment _PlannedQtyUOM;
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_BillOfProcess")]
    protected Environment _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_StartReason")]
    [Metadata("Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).", "StartReason", false, false, false, "NamedObjectRef", 1048846, false, false, true, null)]
    protected Environment _StartReason;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_SamplingLot")]
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, false, "NamedObjectRef", 16777719, false, false, true, null)]
    protected Environment _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_ExpirationDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050479, false, false, false, null)]
    protected Environment _ExpirationDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_DueDate")]
    protected Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_SamplingRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053104, false, false, false, "0")]
    protected Environment _SamplingRequired;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048838, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_RequestDate")]
    protected Environment _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_ExpirationDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052251, false, false, false, null)]
    protected Environment _ExpirationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_DueDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048792, false, false, false, null)]
    protected Environment _DueDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048839, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_RequestDateGMT")]
    protected Environment _RequestDateGMT;
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1048809, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Level")]
    protected Environment _Level;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Owner")]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Priority")]
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, false, "NamedObjectRef", 1049086, false, false, true, null)]
    protected Environment _Priority;
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_MfgOrder")]
    protected Environment _MfgOrder;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Resource")]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_ContainerComments")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048771, false, false, false, null)]
    protected Environment _ContainerComments;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Location")]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    protected Environment _Name;
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, false, "NamedObjectRef", 1048843, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_SalesOrder")]
    protected Environment _SalesOrder;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Factory")]
    protected Environment _Factory;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_PlannedQty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048827, false, false, false, null)]
    protected Environment _PlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintDetail_Environment_PlannedProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048826, false, false, true, null)]
    protected Environment _PlannedProduct;

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

    public new Environment PreHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreHistoryDetail));
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
  }
}
