// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceDetail_Environment
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
  public class ComponentReplaceDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItem", false, false, false, "NamedSubentityRef", 1049462, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_BOMLineItem")]
    protected Environment _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_VendorItem")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, true, null)]
    protected Environment _VendorItem;
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, false, "NamedObjectRef", 1049565, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Vendor")]
    protected Environment _Vendor;
    [Metadata("Contains the defined BOM requirements for a particular level of the BOM. These requirements are loaded by the method <GetRequirements>\r\n", "IssueDetails", false, false, true, "IssueDetails", 1049844, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueDetails")]
    protected IssueDetails_Environment _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Qty2Required")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049415, false, false, false, null)]
    protected Environment _Qty2Required;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049452, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Qty2Issued")]
    protected Environment _Qty2Issued;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049685, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_NetQty2Issued")]
    protected Environment _NetQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_NetQty2Required")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049687, false, false, false, null)]
    protected Environment _NetQty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_RemovalCandidate")]
    [Metadata("Service detail with net quantity issued", "RemovalCandidate", false, false, true, "RemovalCandidate", 8389168, false, false, false, null)]
    protected RemovalCandidate_Environment _RemovalCandidate;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_SubstitutionReason")]
    [Metadata("Records the reason that the product actually used differed from the product specified for use.\r\n", "SubstitutionReason", false, false, false, "NamedObjectRef", 1049453, false, false, true, null)]
    protected Environment _SubstitutionReason;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 16779389, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Qty2Replaced")]
    protected Environment _Qty2Replaced;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueControl")]
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049491, false, false, false, null)]
    protected Environment _IssueControl;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow. This allows, for example, the re-use of Workflows for Rework processing.\r\n\r\n", "SubWorkflowStep", false, false, false, "NamedSubentityRef", 1049818, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_ToWorkflowStack")]
    protected Environment _ToWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueActualHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "SubentityRef", 1049765, false, false, false, null)]
    protected Environment _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueCarrier")]
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051865, false, false, false, null)]
    protected Environment _IssueCarrier;
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, true, "ContainerRef", 1051864, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueBatch")]
    protected Environment _IssueBatch;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_ReplaceReason")]
    [Metadata("Reason codes for replacing container", "ReplaceReason", false, false, false, "NamedObjectRef", 16779380, false, false, true, null)]
    protected Environment _ReplaceReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_DestinationStockPoint")]
    [Metadata("Generic String", "", false, false, false, "String", 16779408, false, false, false, null)]
    protected Environment _DestinationStockPoint;
    [Metadata("Generic String", "", false, false, false, "String", 1049876, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_DestinationLot")]
    protected Environment _DestinationLot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueStockPoint")]
    [Metadata("Generic String", "", false, false, false, "String", 1049877, false, false, false, null)]
    protected Environment _IssueStockPoint;
    [Metadata("Generic String", "", false, false, false, "String", 1049876, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueLot")]
    protected Environment _IssueLot;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueControlName")]
    [Metadata("Generic String", "", false, false, false, "String", 1049491, false, false, false, null)]
    protected Environment _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_RemoveContainer")]
    [Metadata("Generic String", "", false, false, true, "String", 1050419, false, false, false, null)]
    protected Environment _RemoveContainer;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049874, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_OpenClosedContainer")]
    protected Environment _OpenClosedContainer;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049456, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueContainer")]
    protected Environment _IssueContainer;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779384, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IsScrapReplaced")]
    protected Environment _IsScrapReplaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_UniqueID")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052978, false, false, false, null)]
    protected Environment _UniqueID;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_DestinationContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049492, false, false, false, null)]
    protected Environment _DestinationContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_ProductDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1049279, false, false, false, null)]
    protected Environment _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_IssueLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049689, false, false, false, null)]
    protected Environment _IssueLocation;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_ToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1048929, false, false, true, null)]
    protected Environment _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1049450, false, false, true, null)]
    protected Environment _Product;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049414, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_QtyRequired")]
    protected Environment _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_DestinationLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049875, false, false, false, null)]
    protected Environment _DestinationLocation;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_NetQtyIssued")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1052595, false, false, false, null)]
    protected Environment _NetQtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_NetQtyRequired")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049686, false, false, false, null)]
    protected Environment _NetQtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_QtyIssued")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049451, false, false, false, null)]
    protected Environment _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_Location")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, false, null)]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_ToWorkflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1049622, false, false, true, null)]
    protected Environment _ToWorkflow;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 16779388, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceDetail_Environment_QtyReplaced")]
    protected Environment _QtyReplaced;

    public Environment BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BOMLineItem));
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

    public Environment Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Vendor));
      }
    }

    public IssueDetails_Environment IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (IssueDetails_Environment) this.PropertyGet(nameof (IssueDetails));
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

    public Environment Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public Environment Qty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Issued));
      }
    }

    public Environment NetQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQty2Issued));
      }
    }

    public Environment NetQty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Required), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQty2Required));
      }
    }

    public RemovalCandidate_Environment RemovalCandidate
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalCandidate), (object) value);
      }
      get
      {
        return (RemovalCandidate_Environment) this.PropertyGet(nameof (RemovalCandidate));
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

    public Environment SubstitutionReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubstitutionReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubstitutionReason));
      }
    }

    public Environment Qty2Replaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Replaced), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Replaced));
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

    public Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Environment ToWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToWorkflowStack));
      }
    }

    public Environment IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public Environment IssueCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueCarrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueCarrier));
      }
    }

    public Environment IssueBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueBatch));
      }
    }

    public Environment ReplaceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReplaceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReplaceReason));
      }
    }

    public Environment DestinationStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DestinationStockPoint));
      }
    }

    public Environment DestinationLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DestinationLot));
      }
    }

    public Environment ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Environment IssueStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueStockPoint));
      }
    }

    public Environment IssueLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueLot));
      }
    }

    public Environment IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Environment RemoveContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemoveContainer));
      }
    }

    public Environment OpenClosedContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (OpenClosedContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OpenClosedContainer));
      }
    }

    public Environment IssueContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueContainer));
      }
    }

    public Environment IsScrapReplaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsScrapReplaced), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsScrapReplaced));
      }
    }

    public Environment UniqueID
    {
      [param: In] set
      {
        this.PropertySet(nameof (UniqueID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UniqueID));
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

    public Environment DestinationContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DestinationContainer));
      }
    }

    public Environment ProductDescription
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

    public Environment IssueLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueLocation));
      }
    }

    public Environment ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStep));
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

    public Environment QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public Environment DestinationLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DestinationLocation));
      }
    }

    public Environment NetQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQtyIssued));
      }
    }

    public Environment NetQtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NetQtyRequired));
      }
    }

    public Environment QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyIssued));
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

    public Environment ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToWorkflow));
      }
    }

    public Environment QtyReplaced
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyReplaced), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyReplaced));
      }
    }
  }
}
