// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaterialListItem
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
  public class ContainerMaterialListItem : ERPMaterialListItem
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_RouteStep")]
    protected new NamedSubentityRef _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_PhantomBill")]
    protected new RevisionedObjectRef _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_UOM")]
    protected new NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_SetupQty2")]
    protected new Primitive<double> _SetupQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_IsEnabled")]
    protected new Primitive<bool> _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_UOM2")]
    protected new NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Qty2Required")]
    protected new Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_AllowOverConsumption")]
    protected new Primitive<bool> _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_ERPLineItem")]
    protected new Primitive<string> _ERPLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_ReferenceDesignator")]
    protected new Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_DefaultStockPoint")]
    protected new Primitive<string> _DefaultStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_VendorControl")]
    protected new Primitive<bool> _VendorControl;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_EffectiveFromDateGMT")]
    protected new Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_EffectiveThruDateGMT")]
    protected new Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_AllowUnderConsumption")]
    protected new Primitive<bool> _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_EffectiveFromDate")]
    protected new Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_EffectiveThruDate")]
    protected new Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_DefaultLot")]
    protected new Primitive<string> _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_IsPhantom")]
    protected new Primitive<bool> _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_ERPReportingFlag")]
    protected new Primitive<bool> _ERPReportingFlag;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_AllowSubstitution")]
    protected new Primitive<bool> _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_QtyRequired")]
    protected new Primitive<double> _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_SubFactory")]
    protected new Primitive<string> _SubFactory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_ScrapPercent")]
    protected new Primitive<double> _ScrapPercent;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_SetupQty")]
    protected new Primitive<double> _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Product")]
    protected new RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is ContainerMaterialListItem && object.Equals((object) this._RouteStep, (object) ((ContainerMaterialListItem) obj)._RouteStep) && (object.Equals((object) this._PhantomBill, (object) ((ContainerMaterialListItem) obj)._PhantomBill) && object.Equals((object) this._IssueControl, (object) ((ContainerMaterialListItem) obj)._IssueControl)) && (object.Equals((object) this._UOM, (object) ((ContainerMaterialListItem) obj)._UOM) && object.Equals((object) this._SetupQty2, (object) ((ContainerMaterialListItem) obj)._SetupQty2) && (object.Equals((object) this._IsEnabled, (object) ((ContainerMaterialListItem) obj)._IsEnabled) && object.Equals((object) this._UOM2, (object) ((ContainerMaterialListItem) obj)._UOM2))) && (object.Equals((object) this._ExportImportKey, (object) ((ContainerMaterialListItem) obj)._ExportImportKey) && object.Equals((object) this._Qty2Required, (object) ((ContainerMaterialListItem) obj)._Qty2Required) && (object.Equals((object) this._AllowOverConsumption, (object) ((ContainerMaterialListItem) obj)._AllowOverConsumption) && object.Equals((object) this._ERPLineItem, (object) ((ContainerMaterialListItem) obj)._ERPLineItem)) && (object.Equals((object) this._ReferenceDesignator, (object) ((ContainerMaterialListItem) obj)._ReferenceDesignator) && object.Equals((object) this._DefaultStockPoint, (object) ((ContainerMaterialListItem) obj)._DefaultStockPoint) && (object.Equals((object) this._VendorControl, (object) ((ContainerMaterialListItem) obj)._VendorControl) && object.Equals((object) this._EffectiveFromDateGMT, (object) ((ContainerMaterialListItem) obj)._EffectiveFromDateGMT)))) && (object.Equals((object) this._EffectiveThruDateGMT, (object) ((ContainerMaterialListItem) obj)._EffectiveThruDateGMT) && object.Equals((object) this._AllowUnderConsumption, (object) ((ContainerMaterialListItem) obj)._AllowUnderConsumption) && (object.Equals((object) this._EffectiveFromDate, (object) ((ContainerMaterialListItem) obj)._EffectiveFromDate) && object.Equals((object) this._EffectiveThruDate, (object) ((ContainerMaterialListItem) obj)._EffectiveThruDate)) && (object.Equals((object) this._DefaultLot, (object) ((ContainerMaterialListItem) obj)._DefaultLot) && object.Equals((object) this._IsPhantom, (object) ((ContainerMaterialListItem) obj)._IsPhantom) && (object.Equals((object) this._ERPReportingFlag, (object) ((ContainerMaterialListItem) obj)._ERPReportingFlag) && object.Equals((object) this._AllowSubstitution, (object) ((ContainerMaterialListItem) obj)._AllowSubstitution))) && (object.Equals((object) this._QtyRequired, (object) ((ContainerMaterialListItem) obj)._QtyRequired) && object.Equals((object) this._SubFactory, (object) ((ContainerMaterialListItem) obj)._SubFactory) && (object.Equals((object) this._IsFrozen, (object) ((ContainerMaterialListItem) obj)._IsFrozen) && object.Equals((object) this._ScrapPercent, (object) ((ContainerMaterialListItem) obj)._ScrapPercent)) && (object.Equals((object) this._SetupQty, (object) ((ContainerMaterialListItem) obj)._SetupQty) && object.Equals((object) this._Name, (object) ((ContainerMaterialListItem) obj)._Name) && object.Equals((object) this._Product, (object) ((ContainerMaterialListItem) obj)._Product)))) && base.Equals(obj);
    }

    public new NamedSubentityRef RouteStep
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

    public new Primitive<string> ERPLineItem
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

    public new Primitive<string> DefaultStockPoint
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

    public new Primitive<string> DefaultLot
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

    public new Primitive<bool> ERPReportingFlag
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

    public new Primitive<string> SubFactory
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
  }
}
