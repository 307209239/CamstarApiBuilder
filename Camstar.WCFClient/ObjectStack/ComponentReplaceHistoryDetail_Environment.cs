// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceHistoryDetail_Environment
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
  public class ComponentReplaceHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1052596, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_UOM2")]
    protected Environment _UOM2;
    [Metadata("Records the details of the removal of components from a WIP container", "RemovalHistoryDetail", false, false, true, "SubentityRef", 16779377, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_RemovalDetails")]
    protected Environment _RemovalDetails;
    [Metadata("Records the actual values issued to meet the BOM line item requirements", "IssueActualsHistory", false, false, true, "IssueActualsHistory", 1049459, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_Actuals")]
    protected IssueActualsHistory_Environment _Actuals;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049415, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_Qty2Required")]
    protected Environment _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_BOMLineItem")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "ProductMaterialListItem", false, false, true, "NamedSubentityRef", 1049462, false, false, false, null)]
    protected Environment _BOMLineItem;
    [Metadata("Records the reason that the product actually used differed from the product specified for use.\r\n", "SubstitutionReason", false, false, true, "NamedObjectRef", 1049453, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_SubstitutionReason")]
    protected Environment _SubstitutionReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16779376, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_IssueDetails")]
    [Metadata("Records the requirement details for a particular Component issue requirement, along with a summary of the actuals.", "IssueHistoryDetail", false, false, true, "SubentityRef", 8389014, false, false, false, null)]
    protected Environment _IssueDetails;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, true, "NamedSubentityRef", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_VendorItem")]
    protected Environment _VendorItem;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049497, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_Qty2Removed")]
    protected Environment _Qty2Removed;
    [Metadata("Reason codes for replacing container", "ReplaceReason", false, false, true, "NamedObjectRef", 16779380, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_ReplaceReason")]
    protected Environment _ReplaceReason;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_IsScrapReplaced")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16779384, false, false, false, "0")]
    protected Environment _IsScrapReplaced;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, true, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_ActualQty2Issued")]
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1050041, false, false, false, null)]
    protected Environment _ActualQty2Issued;
    [Metadata("Generic Fixed.  The fixed data type is used to store a fixed point number as a floating point number in the database.  A floating point value is an approximation of a fixed point value.  Note that a \"Decimal\" type is available and should be used to store an exact numeric value with defined precision and scale.", "", false, false, true, "Fixed", 1049464, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_ActualQtyIssued")]
    protected Environment _ActualQtyIssued;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049463, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_IssueControl")]
    protected Environment _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049496, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_QtyRemoved")]
    protected Environment _QtyRemoved;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_Notes")]
    protected Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1049450, false, false, false, null)]
    protected Environment _Product;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049414, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceHistoryDetail_Environment_QtyRequired")]
    protected Environment _QtyRequired;

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

    public Environment RemovalDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemovalDetails));
      }
    }

    public IssueActualsHistory_Environment Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Environment) this.PropertyGet(nameof (Actuals));
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

    public Environment IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueDetails));
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

    public Environment ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public Environment ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQtyIssued));
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
  }
}
