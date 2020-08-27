// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActuals_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActualsLotStock_Environment))]
  [KnownType(typeof (ActualsSerial_Environment))]
  [KnownType(typeof (ActualsQuantity_Environment))]
  [KnownType(typeof (ActualsDisplayOnly_Environment))]
  [KnownType(typeof (ActualsBulk_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ActualsStock_Environment))]
  [Serializable]
  public class IssueActuals_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_SubstitutionReason")]
    [Metadata("Records the reason that the product actually used differed from the product specified for use.\r\n", "SubstitutionReason", false, false, false, "NamedObjectRef", 1049453, false, false, true, null)]
    protected Environment _SubstitutionReason;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049452, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_Qty2Issued")]
    protected Environment _Qty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_IssueDifferenceReason")]
    [Metadata("Describes the reason for the difference between the required quantity and the actual quantity issued.", "IssueDifferenceReason", false, false, false, "NamedObjectRef", 1049467, false, false, true, null)]
    protected Environment _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_IssueReason")]
    [Metadata("A list of reason codes that describe the purpose of a component issue.", "IssueReason", false, false, false, "NamedObjectRef", 1049455, false, false, true, null)]
    protected Environment _IssueReason;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_Vendor")]
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, false, "NamedObjectRef", 1049565, false, false, true, null)]
    protected Environment _Vendor;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_VendorItem")]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_IssueActualsHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, true, "SubentityRef", 1049765, false, false, false, null)]
    protected Environment _IssueActualsHistory;
    [Metadata("Scales are resources that provide information about calibration and setup, scale capabilities such as precision, and working range and connection information for device connectivity.", "Scale", false, false, false, "NamedObjectRef", 1051931, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_Scale")]
    protected Environment _Scale;
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_ReferenceDesignator")]
    protected Environment _ReferenceDesignator;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051944, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_ManualOverride")]
    protected Environment _ManualOverride;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_IsAutoWeightEntry")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051862, false, false, false, "0")]
    protected Environment _IsAutoWeightEntry;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_ToContainer")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049400, false, false, true, null)]
    protected Environment _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    protected Environment _Product;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_ToLocation")]
    protected Environment _ToLocation;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049451, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_QtyIssued")]
    protected Environment _QtyIssued;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1049279, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActuals_Environment_ProductDescription")]
    protected Environment _ProductDescription;

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

    public Environment IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public Environment IssueReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueReason));
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

    public Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Environment Scale
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scale), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Scale));
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

    public Environment ManualOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (ManualOverride), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ManualOverride));
      }
    }

    public Environment IsAutoWeightEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAutoWeightEntry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsAutoWeightEntry));
      }
    }

    public Environment ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToContainer));
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

    public Environment ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToLocation));
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
  }
}
