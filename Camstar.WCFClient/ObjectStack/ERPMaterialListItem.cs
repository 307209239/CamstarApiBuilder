// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPMaterialListItem
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerMaterialListItem))]
  [Serializable]
  public class ERPMaterialListItem : MaterialListItem
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_SetupQty2")]
    protected new Primitive<double> _SetupQty2;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_IssuePoint")]
    protected NamedSubentityRef _IssuePoint;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_PhantomBill")]
    protected new RevisionedObjectRef _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_UOM2")]
    protected new NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_RouteStep")]
    protected NamedSubentityRef _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_IsEnabled")]
    protected new Primitive<bool> _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Qty2Required")]
    protected new Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_AllowOverConsumption")]
    protected new Primitive<bool> _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_EffectiveFromDateGMT")]
    protected new Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_ERPLineItem")]
    protected Primitive<string> _ERPLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_DefaultStockPoint")]
    protected Primitive<string> _DefaultStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_AllowUnderConsumption")]
    protected new Primitive<bool> _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_AllowSubstitution")]
    protected new Primitive<bool> _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_ReferenceDesignator")]
    protected new Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_ERPReportingFlag")]
    protected Primitive<bool> _ERPReportingFlag;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_EffectiveThruDateGMT")]
    protected new Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_IsPhantom")]
    protected new Primitive<bool> _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_VendorControl")]
    protected new Primitive<bool> _VendorControl;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_EffectiveThruDate")]
    protected new Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_DefaultLot")]
    protected Primitive<string> _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_EffectiveFromDate")]
    protected new Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_SetupQty")]
    protected new Primitive<double> _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_ScrapPercent")]
    protected new Primitive<double> _ScrapPercent;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_SubFactory")]
    protected Primitive<string> _SubFactory;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Product")]
    protected new RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ERPMaterialListItem_QtyRequired")]
    protected new Primitive<double> _QtyRequired;

    public override bool Equals(object obj)
    {
      return obj is ERPMaterialListItem && object.Equals((object) this._SetupQty2, (object) ((ERPMaterialListItem) obj)._SetupQty2) && (object.Equals((object) this._IssuePoint, (object) ((ERPMaterialListItem) obj)._IssuePoint) && object.Equals((object) this._PhantomBill, (object) ((ERPMaterialListItem) obj)._PhantomBill)) && (object.Equals((object) this._UOM, (object) ((ERPMaterialListItem) obj)._UOM) && object.Equals((object) this._UOM2, (object) ((ERPMaterialListItem) obj)._UOM2) && (object.Equals((object) this._RouteStep, (object) ((ERPMaterialListItem) obj)._RouteStep) && object.Equals((object) this._DisplayName, (object) ((ERPMaterialListItem) obj)._DisplayName))) && (object.Equals((object) this._ExportImportKey, (object) ((ERPMaterialListItem) obj)._ExportImportKey) && object.Equals((object) this._IsEnabled, (object) ((ERPMaterialListItem) obj)._IsEnabled) && (object.Equals((object) this._Qty2Required, (object) ((ERPMaterialListItem) obj)._Qty2Required) && object.Equals((object) this._IssueControl, (object) ((ERPMaterialListItem) obj)._IssueControl)) && (object.Equals((object) this._AllowOverConsumption, (object) ((ERPMaterialListItem) obj)._AllowOverConsumption) && object.Equals((object) this._EffectiveFromDateGMT, (object) ((ERPMaterialListItem) obj)._EffectiveFromDateGMT) && (object.Equals((object) this._ERPLineItem, (object) ((ERPMaterialListItem) obj)._ERPLineItem) && object.Equals((object) this._DefaultStockPoint, (object) ((ERPMaterialListItem) obj)._DefaultStockPoint)))) && (object.Equals((object) this._AllowUnderConsumption, (object) ((ERPMaterialListItem) obj)._AllowUnderConsumption) && object.Equals((object) this._AllowSubstitution, (object) ((ERPMaterialListItem) obj)._AllowSubstitution) && (object.Equals((object) this._ReferenceDesignator, (object) ((ERPMaterialListItem) obj)._ReferenceDesignator) && object.Equals((object) this._ERPReportingFlag, (object) ((ERPMaterialListItem) obj)._ERPReportingFlag)) && (object.Equals((object) this._EffectiveThruDateGMT, (object) ((ERPMaterialListItem) obj)._EffectiveThruDateGMT) && object.Equals((object) this._IsPhantom, (object) ((ERPMaterialListItem) obj)._IsPhantom) && (object.Equals((object) this._VendorControl, (object) ((ERPMaterialListItem) obj)._VendorControl) && object.Equals((object) this._EffectiveThruDate, (object) ((ERPMaterialListItem) obj)._EffectiveThruDate))) && (object.Equals((object) this._DefaultLot, (object) ((ERPMaterialListItem) obj)._DefaultLot) && object.Equals((object) this._EffectiveFromDate, (object) ((ERPMaterialListItem) obj)._EffectiveFromDate) && (object.Equals((object) this._SetupQty, (object) ((ERPMaterialListItem) obj)._SetupQty) && object.Equals((object) this._ScrapPercent, (object) ((ERPMaterialListItem) obj)._ScrapPercent)) && (object.Equals((object) this._SubFactory, (object) ((ERPMaterialListItem) obj)._SubFactory) && object.Equals((object) this._Product, (object) ((ERPMaterialListItem) obj)._Product) && (object.Equals((object) this._IsFrozen, (object) ((ERPMaterialListItem) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((ERPMaterialListItem) obj)._Name))))) && object.Equals((object) this._QtyRequired, (object) ((ERPMaterialListItem) obj)._QtyRequired) && base.Equals(obj);
    }

    public new Primitive<double> SetupQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupQty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (SetupQty2));
      }
    }

    public NamedSubentityRef IssuePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuePoint), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (IssuePoint));
      }
    }

    public new RevisionedObjectRef PhantomBill
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBill), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PhantomBill));
      }
    }

    public new NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public new NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public NamedSubentityRef RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (RouteStep));
      }
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Primitive<bool> IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public new Primitive<double> Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public new Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public new Primitive<bool> AllowOverConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverConsumption), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowOverConsumption));
      }
    }

    public new Primitive<DateTime> EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Primitive<string> ERPLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPLineItem), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ERPLineItem));
      }
    }

    public Primitive<string> DefaultStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultStockPoint));
      }
    }

    public new Primitive<bool> AllowUnderConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowUnderConsumption), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowUnderConsumption));
      }
    }

    public new Primitive<bool> AllowSubstitution
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowSubstitution), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowSubstitution));
      }
    }

    public new Primitive<string> ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Primitive<bool> ERPReportingFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPReportingFlag), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ERPReportingFlag));
      }
    }

    public new Primitive<DateTime> EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public new Primitive<bool> IsPhantom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPhantom), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsPhantom));
      }
    }

    public new Primitive<bool> VendorControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorControl), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (VendorControl));
      }
    }

    public new Primitive<DateTime> EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Primitive<string> DefaultLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultLot));
      }
    }

    public new Primitive<DateTime> EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public new Primitive<double> SetupQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (SetupQty));
      }
    }

    public new Primitive<double> ScrapPercent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapPercent), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ScrapPercent));
      }
    }

    public Primitive<string> SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SubFactory));
      }
    }

    public new RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new Primitive<double> QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyRequired));
      }
    }
  }
}
