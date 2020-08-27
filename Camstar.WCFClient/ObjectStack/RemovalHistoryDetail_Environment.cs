// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalHistoryDetailSerial_Environment))]
  [KnownType(typeof (RemovalHistoryDetailBulk_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RemovalHistoryDetailLotStock_Environment))]
  [KnownType(typeof (RemovalHistoryDetailQuantity_Environment))]
  [KnownType(typeof (RemovalHistoryDetailStock_Environment))]
  [Serializable]
  public class RemovalHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("The reasons that a difference between the quantity that was issued and the quantity that was removed might exist.", "RemoveDifferenceReason", false, false, true, "NamedObjectRef", 1049626, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_RemoveDifferenceReason")]
    protected Environment _RemoveDifferenceReason;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_VendorItem")]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1052593, false, false, false, null)]
    protected Environment _UOM;
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, true, "SubentityRef", 1049765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_IssueActualsHistory")]
    protected Environment _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_Qty2Removed")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049497, false, false, false, null)]
    protected Environment _Qty2Removed;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049463, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_IssueControl")]
    protected Environment _IssueControl;
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_ReferenceDesignator")]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_RemoveAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049690, false, false, false, "0")]
    protected Environment _RemoveAllQty;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    protected Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_RemovalReason")]
    [Metadata("User codes are most often used to define loss reasons through selection lists for data entry fields. InSite provides several user codes such as Bonus Reason and Loss Reason. User Defined Codes are used to allow each customer to specify a list of allowable values for a specific field. In many cases a User Defined Code will merely consist of a Name and Description with no additional attributes. They may also include additional attributes, typically used for additional validations.\r\n\r\nThe name for each Code must be unique within its type. This value is used as an alternate key for lookup-up, data entry and validation.\r\n", "UserCode", false, false, false, "NamedObjectRef", 1049499, false, false, false, null)]
    protected Environment _RemovalReason;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_QtyRemoved")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049496, false, false, false, null)]
    protected Environment _QtyRemoved;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetail_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;

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
  }
}
