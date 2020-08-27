// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItem_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ERPMaterialListItem_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MaterialListItem_Environment : NamedSubentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_DisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    protected new Environment _DisplayName;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_UOM2")]
    protected Environment _UOM2;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, true, "Integer", 1049417, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_IssueControl")]
    protected Environment _IssueControl;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049489, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_SetupQty2")]
    protected Environment _SetupQty2;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049415, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_Qty2Required")]
    protected Environment _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_IsEnabled")]
    [Metadata("Determines, based on Status and Effective From and Thru dates whether a CDO should be considered for processing.\r\nIf a field is not found within the CDO, a positive result is assumed.", "", false, false, true, "Boolean", 1049431, false, false, false, "0")]
    protected Environment _IsEnabled;
    [Metadata("The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.", "Bill", false, false, true, "RevisionedObjectRef", 1049924, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_PhantomBill")]
    protected Environment _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_EffectiveThruDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049027, false, false, false, null)]
    protected Environment _EffectiveThruDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049028, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_EffectiveThruDateGMT")]
    protected Environment _EffectiveThruDateGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050897, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_AllowOverConsumption")]
    protected Environment _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_AllowUnderConsumption")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050898, false, false, false, "0")]
    protected Environment _AllowUnderConsumption;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048744, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_EffectiveFromDate")]
    protected Environment _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_AllowSubstitution")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049488, false, false, false, "0")]
    protected Environment _AllowSubstitution;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049026, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_EffectiveFromDateGMT")]
    protected Environment _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, true, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_IssuePoint")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049914, false, false, false, null)]
    protected Environment _IssuePoint;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049922, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_IsPhantom")]
    protected Environment _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_VendorControl")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049421, false, false, false, "0")]
    protected Environment _VendorControl;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049414, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_QtyRequired")]
    protected Environment _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1049416, false, false, false, null)]
    protected Environment _Product;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049420, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_SetupQty")]
    protected Environment _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050246, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Percentage", "", false, false, true, "Fixed", 1049419, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Environment_ScrapPercent")]
    protected Environment _ScrapPercent;

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
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

    public Environment IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsEnabled));
      }
    }

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
  }
}
