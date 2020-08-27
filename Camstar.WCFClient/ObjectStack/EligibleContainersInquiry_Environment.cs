// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EligibleContainersInquiry_Environment
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
  public class EligibleContainersInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_FilterForCombine")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052570, false, false, false, "0")]
    protected Environment _FilterForCombine;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_FilterForAssociate")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052564, false, false, false, "0")]
    protected Environment _FilterForAssociate;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052565, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_IncludeIneligibleContainers")]
    protected Environment _IncludeIneligibleContainers;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_SingleContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1052568, false, false, false, null)]
    protected Environment _SingleContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_SingleContainerMismatchAllowed")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052569, false, false, false, "0")]
    protected Environment _SingleContainerMismatchAllowed;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_ContainersToExclude")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1052665, false, true, false, null)]
    protected Environment _ContainersToExclude;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_GroupContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1052972, false, false, false, null)]
    protected Environment _GroupContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_ParentContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049070, false, false, false, null)]
    protected Environment _ParentContainer;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052963, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_CombineType")]
    protected Environment _CombineType;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_EligibleContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1052563, false, false, true, null)]
    protected Environment _EligibleContainer;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_ProductFilter")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _ProductFilter;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052567, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_QtyLessThanFilter")]
    protected Environment _QtyLessThanFilter;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049088, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_ContainerNameFilter")]
    protected Environment _ContainerNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_QtyGreaterThanFilter")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052566, false, false, false, null)]
    protected Environment _QtyGreaterThanFilter;
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_MfgOrderFilter")]
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    protected Environment _MfgOrderFilter;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EligibleContainersInquiry_Environment_OperationFilter")]
    protected Environment _OperationFilter;

    public Environment FilterForCombine
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForCombine), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterForCombine));
      }
    }

    public Environment FilterForAssociate
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterForAssociate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterForAssociate));
      }
    }

    public Environment IncludeIneligibleContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeIneligibleContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeIneligibleContainers));
      }
    }

    public Environment SingleContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (SingleContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SingleContainer));
      }
    }

    public Environment SingleContainerMismatchAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SingleContainerMismatchAllowed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SingleContainerMismatchAllowed));
      }
    }

    public Environment ContainersToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainersToExclude), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainersToExclude));
      }
    }

    public Environment GroupContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GroupContainer));
      }
    }

    public Environment ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public Environment CombineType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CombineType));
      }
    }

    public Environment EligibleContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EligibleContainer));
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

    public Environment QtyLessThanFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLessThanFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyLessThanFilter));
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

    public Environment QtyGreaterThanFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyGreaterThanFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyGreaterThanFilter));
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
  }
}
