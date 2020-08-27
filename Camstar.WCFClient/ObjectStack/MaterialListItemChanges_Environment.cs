// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItemChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ProductMaterialListItemChanges_Environment))]
  [KnownType(typeof (ERPMaterialListItemChanges_Environment))]
  [KnownType(typeof (RecipeMaterialListItemChanges_Environment))]
  [Serializable]
  public class MaterialListItemChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.", "Bill", false, false, false, "RevisionedObjectRef", 1049924, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_PhantomBill")]
    protected Environment _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_SetupQty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050600, false, false, false, null)]
    protected Environment _SetupQty2;
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1049648, false, false, true, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_ObjectToChange")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, false, "Integer", 1049491, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_IssueControl")]
    protected Environment _IssueControl;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049650, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_Qty2Required")]
    protected Environment _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_EffectiveThruDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048745, false, false, false, null)]
    protected Environment _EffectiveThruDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049028, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_EffectiveThruDateGMT")]
    protected Environment _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_AllowOverConsumption")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050897, false, false, false, "1")]
    protected Environment _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_EffectiveFromDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048744, false, false, false, null)]
    protected Environment _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_EffectiveFromDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049026, false, false, false, null)]
    protected Environment _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_VendorControl")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049421, false, false, false, "0")]
    protected Environment _VendorControl;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_AllowSubstitution")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049012, false, false, false, "0")]
    protected Environment _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_IsPhantom")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049922, false, false, false, "0")]
    protected Environment _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_IssuePoint")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049914, false, false, false, null)]
    protected Environment _IssuePoint;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050898, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_AllowUnderConsumption")]
    protected Environment _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_ScrapPercent")]
    [Metadata("Percentage", "", false, false, false, "Fixed", 1049419, false, false, false, null)]
    protected Environment _ScrapPercent;
    [Metadata("Material quantity (individual)", "", false, true, false, "Fixed", 1049649, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_QtyRequired")]
    protected Environment _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049651, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_SetupQty")]
    protected Environment _SetupQty;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051654, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, true, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Environment_Product")]
    protected Environment _Product;

    public Environment PhantomBill
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBill), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PhantomBill));
      }
    }

    public Environment SetupQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SetupQty2));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Environment EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Environment AllowOverConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverConsumption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowOverConsumption));
      }
    }

    public Environment EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Environment EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Environment VendorControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorControl));
      }
    }

    public Environment AllowSubstitution
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowSubstitution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowSubstitution));
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

    public Environment IssuePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuePoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuePoint));
      }
    }

    public Environment AllowUnderConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowUnderConsumption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowUnderConsumption));
      }
    }

    public Environment ScrapPercent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapPercent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScrapPercent));
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

    public Environment SetupQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SetupQty));
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
