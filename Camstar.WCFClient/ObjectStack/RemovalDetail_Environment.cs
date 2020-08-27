// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalDetailStock_Environment))]
  [KnownType(typeof (RemovalDetailQuantity_Environment))]
  [KnownType(typeof (RemovalDetailBulk_Environment))]
  [KnownType(typeof (RemovalDetailLotStock_Environment))]
  [KnownType(typeof (RemovalDetailSerial_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class RemovalDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("The reason material was removed from a WIP container", "RemovalReason", false, false, false, "NamedObjectRef", 1049499, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_RemovalReason")]
    protected Environment _RemovalReason;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049463, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_IssueControl")]
    protected Environment _IssueControl;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_UOM")]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_RemoveDifferenceReason")]
    [Metadata("The reasons that a difference between the quantity that was issued and the quantity that was removed might exist.", "RemoveDifferenceReason", false, false, false, "NamedObjectRef", 1049626, false, false, true, null)]
    protected Environment _RemoveDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_Qty2Removed")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049497, false, false, false, null)]
    protected Environment _Qty2Removed;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_VendorItem")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, true, null)]
    protected Environment _VendorItem;
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, false, "SubentityRef", 1049872, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_IssueActualHistory")]
    protected Environment _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_RemoveAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049690, false, false, false, "0")]
    protected Environment _RemoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_QtyRemoved")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049496, false, false, false, null)]
    protected Environment _QtyRemoved;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1049450, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_Product")]
    protected Environment _Product;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetail_Environment_Notes")]
    protected Environment _Notes;

    public Environment RemovalReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemovalReason));
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

    public Environment RemoveDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveDifferenceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemoveDifferenceReason));
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

    public Environment Qty2Removed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Removed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Removed));
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

    public Environment RemoveAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoveAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemoveAllQty));
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

    public Environment QtyRemoved
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemoved), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyRemoved));
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

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
