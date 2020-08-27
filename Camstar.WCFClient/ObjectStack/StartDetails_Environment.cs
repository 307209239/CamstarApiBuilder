// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (GroupStartDetails_Environment))]
  [KnownType(typeof (UnitStartDetails_Environment))]
  [KnownType(typeof (MaterialContainerStartDetails_Environment))]
  [KnownType(typeof (SerializedStartDetails_Environment))]
  [KnownType(typeof (BatchStartDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class StartDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048630, false, false, true, null)]
    protected Environment _UOM2;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 16777571, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttachedFileName")]
    protected Environment _AttachedFileName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_BOM")]
    [Metadata("The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.", "Bill", false, false, false, "RevisionedObjectRef", 1049438, false, false, true, null)]
    protected Environment _BOM;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048830, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_PlannedQtyUOM2")]
    protected Environment _PlannedQtyUOM2;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_VendorItem")]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_BillOfProcess")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, true, null)]
    protected Environment _BillOfProcess;
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1048612, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Customer")]
    protected Environment _Customer;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 16777595, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttachedFileExtension")]
    protected Environment _AttachedFileExtension;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected Environment _UOM;
    [Metadata("StartDetails describes the attributes of the container about to be started.", "StartDetails", false, false, false, "StartDetails", 1048769, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ChildContainers")]
    protected StartDetails_Environment _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_StartReason")]
    [Metadata("Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).", "StartReason", false, false, false, "NamedObjectRef", 1048846, false, false, true, null)]
    protected Environment _StartReason;
    [Metadata("File directory path", "", false, false, false, "String", 16777579, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_FilePath")]
    protected Environment _FilePath;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_PlannedQty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048828, false, false, false, null)]
    protected Environment _PlannedQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Status")]
    [Metadata("Current status of the Container. This value is used to distinguish between Containers that are active, closed and those that have been deleted. \r\nValid values and their meanings are:\r\n0 = Deleted\r\n1 = Active\r\n2 = Closed\r\n3 = In Transit (shipped)\r\n4 = Issued (component)\r\nA deleted Container is one where all of the transactions, including the Create (or Split-to) transaction have been reversed.", "ContainerStatusEnum", false, false, false, "Integer", 1048671, false, false, true, "1")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_PlannedQtyUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048829, false, false, true, null)]
    protected Environment _PlannedQtyUOM;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049574, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_DefaultChildQty2")]
    protected Environment _DefaultChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttachDocument")]
    [Metadata("AttachDocument is a subclass of GenericTxn that is used to attach documents to any Container, NDO, or RDO object type.  There are three ways to attach a document:\r\n1.\tAs a reusable document that can be attached to multiple instances of an object\r\n2.\tAs a document that will not be reused and is only attached to a single instance of an object\r\n3.\tAs a reference to an existing Document\r\n", "AttachDocument", false, false, false, "AttachDocument", 16777594, false, false, false, null)]
    protected AttachDocument_Environment _AttachDocument;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_SamplingLot")]
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, false, "NamedObjectRef", 16777719, false, false, true, null)]
    protected Environment _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AutoNumberRule")]
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, true, "NamedObjectRef", 1051465, false, false, false, null)]
    protected Environment _AutoNumberRule;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttributeDetails")]
    [Metadata("Name/Value pairs to be added to the container.", "StartContainerAttributeDetail", false, false, false, "StartContainerAttributeDetail", 1051938, false, true, false, null)]
    protected StartContainerAttributeDetail_Environment _AttributeDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttachmentType")]
    [Metadata("Enumeration used to indicate what type of document attachment will be perfomed:\r\n1 - Attach a new document that will not be reused (no Revision needed)\r\n2 - Attach a new document that will be reused (Revision must be provided)\r\n3 - Attach an existing document", "AttachmentTypeEnum", false, false, false, "Integer", 16777572, false, false, true, null)]
    protected Environment _AttachmentType;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 16777541, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ContainerInstance")]
    protected Environment _ContainerInstance;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050479, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ExpirationDate")]
    protected Environment _ExpirationDate;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053104, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_SamplingRequired")]
    protected Environment _SamplingRequired;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051939, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttributeSources")]
    protected Environment _AttributeSources;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, true, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AutoNumber")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778905, false, false, false, "0")]
    protected Environment _AutoNumber;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779198, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_InQualityControl")]
    protected Environment _InQualityControl;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ChildAutoNumber")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778920, false, false, false, "0")]
    protected Environment _ChildAutoNumber;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_UnitCount")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048852, false, false, false, null)]
    protected Environment _UnitCount;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048770, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ChildCount")]
    protected Environment _ChildCount;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777596, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttachmentIsROR")]
    protected Environment _AttachmentIsROR;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_UsingAttributes")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051933, false, false, false, "1")]
    protected Environment _UsingAttributes;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778929, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_LastSequence")]
    protected Environment _LastSequence;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_IsContainer")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777528, false, false, false, "0")]
    protected Environment _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_RequestDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048838, false, false, false, null)]
    protected Environment _RequestDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_OriginalContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1048816, false, false, true, null)]
    protected Environment _OriginalContainer;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050318, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_PlannedStartDate")]
    protected Environment _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttachAsROR")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777568, false, false, false, "0")]
    protected Environment _AttachAsROR;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_DueDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    protected Environment _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ChildIndex")]
    [Metadata("Generic Integer", "", true, false, true, "Integer", 16778906, false, false, false, null)]
    protected Environment _ChildIndex;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050784, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ObjectTypeId")]
    protected Environment _ObjectTypeId;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_DefaultChildQty")]
    protected Environment _DefaultChildQty;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Owner")]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_DocumentRevision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 16777566, false, false, false, null)]
    protected Environment _DocumentRevision;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_DocumentDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 16777575, false, false, false, null)]
    protected Environment _DocumentDescription;
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_MfgOrder")]
    protected Environment _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Workstation")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1050517, false, false, false, null)]
    protected Environment _Workstation;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16778907, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_NumberingRuleQryResult")]
    protected Environment _NumberingRuleQryResult;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_AttachedDocument")]
    [Metadata("Most Modeling entities include a reference to a document. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.\r\n\r\nDocuments are also used to define recipe files for downloading to machines. In this case, presenting the Document means presenting it (downloading it) to a machine.", "Document", false, false, false, "RevisionedObjectRef", 16777569, false, false, true, null)]
    protected Environment _AttachedDocument;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048817, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_OriginalFactory")]
    protected Environment _OriginalFactory;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ContainerName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049088, false, false, false, null)]
    protected Environment _ContainerName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Identifier")]
    [Metadata("External identifier for a document (Path and file name, URL, etc.)", "", false, false, false, "String", 1051057, false, false, false, null)]
    protected Environment _Identifier;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050228, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_DocumentName")]
    protected Environment _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_Level")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1048809, false, false, true, null)]
    protected Environment _Level;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_DefaultChildLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1049600, false, false, true, null)]
    protected Environment _DefaultChildLevel;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_PlannedProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048826, false, false, true, null)]
    protected Environment _PlannedProduct;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1049089, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_ContainerComment")]
    protected Environment _ContainerComment;
    [Metadata("A Sales Order defines a quantity of product expected by a customer by a date. This equates to a line item on a typical (ERP) Sales Order. Containers are optionally assigned to a Sales Order (by specifying the Sales Order as an attribute). This provides the mechanism for relating WIP (Containers) to Customer Orders.", "SalesOrder", false, false, false, "NamedObjectRef", 1048843, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_SalesOrder")]
    protected Environment _SalesOrder;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_PriorityCode")]
    [Metadata("An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.", "PriorityCode", false, false, false, "NamedObjectRef", 1049086, false, false, true, null)]
    protected Environment _PriorityCode;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails_Environment_PlannedQty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048827, false, false, false, null)]
    protected Environment _PlannedQty;

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

    public Environment AttachedFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedFileName));
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

    public Environment AttachedFileExtension
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedFileExtension), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedFileExtension));
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

    public StartDetails_Environment ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (StartDetails_Environment) this.PropertyGet(nameof (ChildContainers));
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

    public Environment FilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilePath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilePath));
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

    public Environment DefaultChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultChildQty2));
      }
    }

    public AttachDocument_Environment AttachDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocument), (object) value);
      }
      get
      {
        return (AttachDocument_Environment) this.PropertyGet(nameof (AttachDocument));
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

    public Environment AutoNumberRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumberRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoNumberRule));
      }
    }

    public StartContainerAttributeDetail_Environment AttributeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeDetails), (object) value);
      }
      get
      {
        return (StartContainerAttributeDetail_Environment) this.PropertyGet(nameof (AttributeDetails));
      }
    }

    public Environment AttachmentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentType));
      }
    }

    public Environment ContainerInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInstance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerInstance));
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

    public Environment AttributeSources
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeSources), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeSources));
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

    public Environment AutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AutoNumber));
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

    public Environment ChildAutoNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildAutoNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildAutoNumber));
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

    public Environment AttachmentIsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentIsROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentIsROR));
      }
    }

    public Environment UsingAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (UsingAttributes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UsingAttributes));
      }
    }

    public Environment LastSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastSequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastSequence));
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

    public Environment OriginalContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalContainer));
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

    public Environment AttachAsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachAsROR));
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

    public Environment ChildIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildIndex));
      }
    }

    public Environment ObjectTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeId));
      }
    }

    public Environment DefaultChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultChildQty));
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

    public Environment DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentRevision));
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

    public Environment DocumentDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentDescription));
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

    public Environment NumberingRuleQryResult
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleQryResult), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NumberingRuleQryResult));
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

    public Environment AttachedDocument
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachedDocument), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachedDocument));
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

    public Environment ContainerName
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

    public Environment DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentName));
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

    public Environment DefaultChildLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultChildLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultChildLevel));
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

    public Environment ContainerComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerComment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerComment));
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

    public Environment PriorityCode
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
  }
}
