// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductChanges_Environment
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
  public class ProductChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ERPRoute")]
    [Metadata("ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a mirror of the route definitions in the ERP, where the definition stored in the ERP is the \"master\" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.", "ERPRoute", false, false, false, "RevisionedObjectRef", 1049919, false, false, true, null)]
    protected Environment _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_VendorItemsInquiry")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049820, false, true, true, null)]
    protected Environment _VendorItemsInquiry;
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_BillOfProcess")]
    protected Environment _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_VendorItems")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049439, false, true, true, null)]
    protected Environment _VendorItems;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_StdStartUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1049509, false, false, true, null)]
    protected Environment _StdStartUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ERPBOM")]
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOM", false, false, false, "RevisionedObjectRef", 1049920, false, false, true, null)]
    protected Environment _ERPBOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_TrainingReqGroup")]
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    protected Environment _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_VendorInquiry")]
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, false, "NamedObjectRef", 1049821, false, false, true, null)]
    protected Environment _VendorInquiry;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1051827, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_FEFOOverrideESigRequirement")]
    protected Environment _FEFOOverrideESigRequirement;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050598, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_StdStartQty2")]
    protected Environment _StdStartQty2;
    [Metadata("A bill of material defines the materials needed to produce a specific product.", "BOM", false, false, false, "RevisionedObjectRef", 1049438, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_BOM")]
    protected Environment _BOM;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_Customer")]
    [Metadata("A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.", "Customer", false, false, false, "NamedObjectRef", 1048612, false, false, true, null)]
    protected Environment _Customer;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1050599, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_StdStartUOM2")]
    protected Environment _StdStartUOM2;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_SamplingPlan")]
    protected Environment _SamplingPlan;
    [Metadata("A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.", "UserAttributeChanges", false, false, false, "UserAttributeChanges", 1051932, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_Attributes")]
    protected UserAttributeChanges_Environment _Attributes;
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, false, "NamedObjectRef", 1051905, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ContainerNumberingRule")]
    protected Environment _ContainerNumberingRule;
    [Metadata("An enumeration of FEFOEnforceType. 0=Not Enforced, 1=Enforced, 2=Warn, 3=WarnWithESig", "FEFOEnum", false, false, false, "Integer", 1051826, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_FEFOEnforce")]
    protected Environment _FEFOEnforce;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050313, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_SerialControlled")]
    protected Environment _SerialControlled;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_LotControlled")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050311, false, false, false, "0")]
    protected Environment _LotControlled;
    [Metadata("Generic String", "", false, false, false, "String", 1051222, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_DeviceType")]
    protected Environment _DeviceType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049921, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_IsPhantom")]
    protected Environment _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_InventoryControlled")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050314, false, false, false, "0")]
    protected Environment _InventoryControlled;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053121, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_InspectAll")]
    protected Environment _InspectAll;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050315, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_StockPointControlled")]
    protected Environment _StockPointControlled;
    [Metadata("Generic Float", "", false, false, false, "Float", 1053028, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_TargetUnitsPerHour")]
    protected Environment _TargetUnitsPerHour;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ConcomitantProductNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051221, false, false, false, null)]
    protected Environment _ConcomitantProductNumber;
    [Metadata("Generic String", "", false, false, false, "String", 1051223, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ModelNumber")]
    protected Environment _ModelNumber;
    [Metadata("Generic String", "", false, false, false, "String", 1051220, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_CatalogNumber")]
    protected Environment _CatalogNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_BrandName")]
    [Metadata("Generic String", "", false, false, false, "String", 1051219, false, false, false, null)]
    protected Environment _BrandName;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ProductVariation")]
    [Metadata("Generic String", "", false, false, false, "String", 1050312, false, false, false, null)]
    protected Environment _ProductVariation;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050310, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ExternallyControlled")]
    protected Environment _ExternallyControlled;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_Workflow")]
    protected Environment _Workflow;
    [Metadata("A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Each Product can belong to a Product Family. Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.\r\n\r\nProduct Families are a slightly different concept from object groups. Grouping (Product bases, Operations, Resources, etc.) is done for validation and reporting. Groups are more free form and the application has less concrete knowledge of Groups (than Product Families). Another differentiation is that one object can belong to multiple Groups, but a product can only belong to one Product Family. Finally, Groups can contain other (sub-) Groups. Product Families can only contain Products.", "ProductFamily", false, false, false, "NamedObjectRef", 1048604, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ProductFamily")]
    protected Environment _ProductFamily;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049654, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_StdStartQty")]
    protected Environment _StdStartQty;
    [Metadata("Processing yield (as a percentage).", "", false, false, false, "Fixed", 1053023, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_TargetRolledThroughputYield")]
    protected Environment _TargetRolledThroughputYield;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_TargetFinalYield")]
    [Metadata("Processing yield (as a percentage).", "", false, false, false, "Fixed", 1053022, false, false, false, null)]
    protected Environment _TargetFinalYield;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050316, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_SubFactory")]
    protected Environment _SubFactory;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1049442, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_Substitutes")]
    protected Environment _Substitutes;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_TargetDurationPerUnit")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1053025, false, false, false, null)]
    protected Environment _TargetDurationPerUnit;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("Product Type Codes are used to differentiate between types of product such as WIP, Raw Material, Finished Goods, etc.", "ProductType", false, true, false, "NamedObjectRef", 1048605, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_ProductType")]
    protected Environment _ProductType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_PlannedCost")]
    [Metadata("Cost per unit", "", false, false, false, "Fixed", 1048706, false, false, false, null)]
    protected Environment _PlannedCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_TargetCycleTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1053027, false, false, false, null)]
    protected Environment _TargetCycleTime;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_CustomerProductNumber")]
    [Metadata("Text string that represents the Customers Identifier for this product (if any)", "", false, false, false, "String", 1048711, false, false, false, null)]
    protected Environment _CustomerProductNumber;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_CurrentCost")]
    [Metadata("Cost per unit", "", false, false, false, "Fixed", 1048645, false, false, false, null)]
    protected Environment _CurrentCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_Base")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "ProductBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_GLEntity")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1050317, false, false, false, null)]
    protected Environment _GLEntity;
    [Metadata("Cost per unit", "", false, false, false, "Fixed", 1048649, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductChanges_Environment_StdCost")]
    protected Environment _StdCost;

    public Environment ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public Environment VendorItemsInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItemsInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorItemsInquiry));
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

    public Environment VendorItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItems), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorItems));
      }
    }

    public Environment StdStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartUOM));
      }
    }

    public Environment ERPBOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPBOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPBOM));
      }
    }

    public Environment TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Environment VendorInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorInquiry));
      }
    }

    public Environment FEFOOverrideESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOOverrideESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FEFOOverrideESigRequirement));
      }
    }

    public Environment StdStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartQty2));
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

    public Environment StdStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartUOM2));
      }
    }

    public Environment SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public UserAttributeChanges_Environment Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges_Environment) this.PropertyGet(nameof (Attributes));
      }
    }

    public Environment ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Environment FEFOEnforce
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOEnforce), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FEFOEnforce));
      }
    }

    public Environment SerialControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (SerialControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SerialControlled));
      }
    }

    public Environment LotControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotControlled));
      }
    }

    public Environment DeviceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceType));
      }
    }

    public Environment IsPhantom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPhantom), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsPhantom));
      }
    }

    public Environment InventoryControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (InventoryControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InventoryControlled));
      }
    }

    public Environment InspectAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAll), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectAll));
      }
    }

    public Environment StockPointControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (StockPointControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StockPointControlled));
      }
    }

    public Environment TargetUnitsPerHour
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetUnitsPerHour), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetUnitsPerHour));
      }
    }

    public Environment ConcomitantProductNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConcomitantProductNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ConcomitantProductNumber));
      }
    }

    public Environment ModelNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelNumber));
      }
    }

    public Environment CatalogNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatalogNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CatalogNumber));
      }
    }

    public Environment BrandName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BrandName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BrandName));
      }
    }

    public Environment ProductVariation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductVariation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductVariation));
      }
    }

    public Environment ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExternallyControlled));
      }
    }

    public Environment Workflow
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

    public Environment ProductFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductFamily), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductFamily));
      }
    }

    public Environment StdStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartQty));
      }
    }

    public Environment TargetRolledThroughputYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetRolledThroughputYield), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetRolledThroughputYield));
      }
    }

    public Environment TargetFinalYield
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetFinalYield), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetFinalYield));
      }
    }

    public Environment SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubFactory));
      }
    }

    public Environment Substitutes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Substitutes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Substitutes));
      }
    }

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment TargetDurationPerUnit
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDurationPerUnit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetDurationPerUnit));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment ProductType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductType));
      }
    }

    public new Environment Name
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

    public Environment PlannedCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedCost));
      }
    }

    public Environment TargetCycleTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetCycleTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetCycleTime));
      }
    }

    public Environment CustomerProductNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomerProductNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomerProductNumber));
      }
    }

    public Environment CurrentCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentCost));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment GLEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (GLEntity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GLEntity));
      }
    }

    public Environment StdCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdCost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdCost));
      }
    }
  }
}
