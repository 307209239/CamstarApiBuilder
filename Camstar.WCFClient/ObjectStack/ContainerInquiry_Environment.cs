// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInquiry_Environment
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
  public class ContainerInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_ToStartDateFilter")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053185, false, false, false, null)]
    protected Environment _ToStartDateFilter;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_Container")]
    protected Environment _Container;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053184, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_FromStartDateFilter")]
    protected Environment _FromStartDateFilter;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052976, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_SearchIssuedFromContainers")]
    protected Environment _SearchIssuedFromContainers;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052005, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_ToStartDate")]
    protected Environment _ToStartDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_SearchIssuedToContainers")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052975, false, false, false, "0")]
    protected Environment _SearchIssuedToContainers;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_ChildContainer")]
    protected Environment _ChildContainer;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_SearchEmployeeHistory")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052973, false, false, false, "0")]
    protected Environment _SearchEmployeeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_SearchOperationHistory")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052973, false, false, false, "0")]
    protected Environment _SearchOperationHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_FromStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052004, false, false, false, null)]
    protected Environment _FromStartDate;
    [Metadata("Generic String", "", false, false, false, "String", 1052913, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_FromIssuedLotFilter")]
    protected Environment _FromIssuedLotFilter;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052974, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_SearchContainersOnly")]
    protected Environment _SearchContainersOnly;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052973, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_SearchResourceHistory")]
    protected Environment _SearchResourceHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_OnHoldFilter")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051239, false, false, false, "0")]
    protected Environment _OnHoldFilter;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049637, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_InReworkFilter")]
    protected Environment _InReworkFilter;
    [Metadata("Generic String", "", false, false, false, "String", 1052914, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_FromIssuedStockPointFilter")]
    protected Environment _FromIssuedStockPointFilter;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_ProductFilter")]
    protected Environment _ProductFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_EmployeeFilter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048861, false, false, true, null)]
    protected Environment _EmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_ContainerNameFilter")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049043, false, false, true, null)]
    protected Environment _ContainerNameFilter;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048824, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_OwnerFilter")]
    protected Environment _OwnerFilter;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_OperationFilter")]
    protected Environment _OperationFilter;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_MfgOrderFilter")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    protected Environment _MfgOrderFilter;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInquiry_Environment_ResourceFilter")]
    protected Environment _ResourceFilter;

    public Environment ToStartDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDateFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStartDateFilter));
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

    public Environment FromStartDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDateFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStartDateFilter));
      }
    }

    public Environment SearchIssuedFromContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchIssuedFromContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchIssuedFromContainers));
      }
    }

    public Environment ToStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStartDate));
      }
    }

    public Environment SearchIssuedToContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchIssuedToContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchIssuedToContainers));
      }
    }

    public Environment ChildContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildContainer));
      }
    }

    public Environment SearchEmployeeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchEmployeeHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchEmployeeHistory));
      }
    }

    public Environment SearchOperationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchOperationHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchOperationHistory));
      }
    }

    public Environment FromStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStartDate));
      }
    }

    public Environment FromIssuedLotFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedLotFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromIssuedLotFilter));
      }
    }

    public Environment SearchContainersOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchContainersOnly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchContainersOnly));
      }
    }

    public Environment SearchResourceHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchResourceHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchResourceHistory));
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

    public Environment FromIssuedStockPointFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromIssuedStockPointFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromIssuedStockPointFilter));
      }
    }

    public Environment ProductFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductFilter));
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

    public Environment ContainerNameFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNameFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerNameFilter));
      }
    }

    public Environment OwnerFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerFilter));
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

    public Environment MfgOrderFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrderFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrderFilter));
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
  }
}
