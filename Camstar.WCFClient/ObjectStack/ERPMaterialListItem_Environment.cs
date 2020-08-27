// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPMaterialListItem_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerMaterialListItem_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ERPMaterialListItem_Environment : MaterialListItem_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049489, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_SetupQty2")]
    protected new Environment _SetupQty2;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_IssuePoint")]
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, true, "NamedSubentityRef", 1049914, false, false, false, null)]
    protected new Environment _IssuePoint;
    [Metadata("A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.", "ERPBOM", false, false, true, "RevisionedObjectRef", 1049924, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_PhantomBill")]
    protected new Environment _PhantomBill;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_UOM")]
    protected new Environment _UOM;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_UOM2")]
    protected new Environment _UOM2;
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, true, "NamedSubentityRef", 1049917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_RouteStep")]
    protected Environment _RouteStep;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Determines, based on Status and Effective From and Thru dates whether a CDO should be considered for processing.\r\nIf a field is not found within the CDO, a positive result is assumed.", "", false, false, true, "Boolean", 1049431, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_IsEnabled")]
    protected new Environment _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_Qty2Required")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049415, false, false, false, null)]
    protected new Environment _Qty2Required;
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, false, true, "Integer", 1049417, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_IssueControl")]
    protected new Environment _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_AllowOverConsumption")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050897, false, false, false, "1")]
    protected new Environment _AllowOverConsumption;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049026, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_EffectiveFromDateGMT")]
    protected new Environment _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_ERPLineItem")]
    [Metadata("Generic String", "", false, false, true, "String", 1050329, false, false, false, null)]
    protected Environment _ERPLineItem;
    [Metadata("Generic String", "", false, false, true, "String", 1050328, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_DefaultStockPoint")]
    protected Environment _DefaultStockPoint;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050898, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_AllowUnderConsumption")]
    protected new Environment _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_AllowSubstitution")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049488, false, false, false, "0")]
    protected new Environment _AllowSubstitution;
    [Metadata("Generic String", "", false, false, true, "String", 1049418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_ReferenceDesignator")]
    protected new Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_ERPReportingFlag")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050327, false, false, false, "0")]
    protected Environment _ERPReportingFlag;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049028, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_EffectiveThruDateGMT")]
    protected new Environment _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_IsPhantom")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049922, false, false, false, "0")]
    protected new Environment _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_VendorControl")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049421, false, false, false, "0")]
    protected new Environment _VendorControl;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049027, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_EffectiveThruDate")]
    protected new Environment _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_DefaultLot")]
    [Metadata("Generic String", "", false, false, true, "String", 1050325, false, false, false, null)]
    protected Environment _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_EffectiveFromDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048744, false, false, false, null)]
    protected new Environment _EffectiveFromDate;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049420, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_SetupQty")]
    protected new Environment _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_ScrapPercent")]
    [Metadata("Percentage", "", false, false, true, "Fixed", 1049419, false, false, false, null)]
    protected new Environment _ScrapPercent;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050316, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_SubFactory")]
    protected Environment _SubFactory;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1049416, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_Product")]
    protected new Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051649, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049414, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Environment_QtyRequired")]
    protected new Environment _QtyRequired;

    public new Environment SetupQty2
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

    public new Environment IssuePoint
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

    public new Environment PhantomBill
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

    public new Environment UOM
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

    public new Environment UOM2
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

    public Environment RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RouteStep));
      }
    }

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

    public new Environment IsEnabled
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

    public new Environment Qty2Required
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

    public new Environment IssueControl
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

    public new Environment AllowOverConsumption
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

    public new Environment EffectiveFromDateGMT
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

    public Environment ERPLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPLineItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPLineItem));
      }
    }

    public Environment DefaultStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultStockPoint));
      }
    }

    public new Environment AllowUnderConsumption
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

    public new Environment AllowSubstitution
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

    public new Environment ReferenceDesignator
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

    public Environment ERPReportingFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPReportingFlag), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ERPReportingFlag));
      }
    }

    public new Environment EffectiveThruDateGMT
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

    public new Environment IsPhantom
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

    public new Environment VendorControl
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

    public new Environment EffectiveThruDate
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

    public Environment DefaultLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultLot));
      }
    }

    public new Environment EffectiveFromDate
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

    public new Environment SetupQty
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

    public new Environment ScrapPercent
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

    public new Environment Product
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

    public new Environment QtyRequired
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
