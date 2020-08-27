// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItem
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ERPMaterialListItem))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MaterialListItem : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_IssueControl")]
    protected Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_SetupQty2")]
    protected Primitive<double> _SetupQty2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Qty2Required")]
    protected Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_IsEnabled")]
    protected Primitive<bool> _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_PhantomBill")]
    protected RevisionedObjectRef _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_AllowOverConsumption")]
    protected Primitive<bool> _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_AllowUnderConsumption")]
    protected Primitive<bool> _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_AllowSubstitution")]
    protected Primitive<bool> _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_IssuePoint")]
    protected BaseObjectRef _IssuePoint;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_IsPhantom")]
    protected Primitive<bool> _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_VendorControl")]
    protected Primitive<bool> _VendorControl;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_QtyRequired")]
    protected Primitive<double> _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_SetupQty")]
    protected Primitive<double> _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItem_ScrapPercent")]
    protected Primitive<double> _ScrapPercent;

    public override bool Equals(object obj)
    {
      return obj is MaterialListItem && object.Equals((object) this._DisplayName, (object) ((MaterialListItem) obj)._DisplayName) && (object.Equals((object) this._UOM2, (object) ((MaterialListItem) obj)._UOM2) && object.Equals((object) this._UOM, (object) ((MaterialListItem) obj)._UOM)) && (object.Equals((object) this._IssueControl, (object) ((MaterialListItem) obj)._IssueControl) && object.Equals((object) this._SetupQty2, (object) ((MaterialListItem) obj)._SetupQty2) && (object.Equals((object) this._Qty2Required, (object) ((MaterialListItem) obj)._Qty2Required) && object.Equals((object) this._ExportImportKey, (object) ((MaterialListItem) obj)._ExportImportKey))) && (object.Equals((object) this._IsEnabled, (object) ((MaterialListItem) obj)._IsEnabled) && object.Equals((object) this._PhantomBill, (object) ((MaterialListItem) obj)._PhantomBill) && (object.Equals((object) this._EffectiveThruDate, (object) ((MaterialListItem) obj)._EffectiveThruDate) && object.Equals((object) this._EffectiveThruDateGMT, (object) ((MaterialListItem) obj)._EffectiveThruDateGMT)) && (object.Equals((object) this._AllowOverConsumption, (object) ((MaterialListItem) obj)._AllowOverConsumption) && object.Equals((object) this._AllowUnderConsumption, (object) ((MaterialListItem) obj)._AllowUnderConsumption) && (object.Equals((object) this._EffectiveFromDate, (object) ((MaterialListItem) obj)._EffectiveFromDate) && object.Equals((object) this._AllowSubstitution, (object) ((MaterialListItem) obj)._AllowSubstitution)))) && (object.Equals((object) this._EffectiveFromDateGMT, (object) ((MaterialListItem) obj)._EffectiveFromDateGMT) && object.Equals((object) this._ReferenceDesignator, (object) ((MaterialListItem) obj)._ReferenceDesignator) && (object.Equals((object) this._IssuePoint, (object) ((MaterialListItem) obj)._IssuePoint) && object.Equals((object) this._IsPhantom, (object) ((MaterialListItem) obj)._IsPhantom)) && (object.Equals((object) this._VendorControl, (object) ((MaterialListItem) obj)._VendorControl) && object.Equals((object) this._QtyRequired, (object) ((MaterialListItem) obj)._QtyRequired) && (object.Equals((object) this._Product, (object) ((MaterialListItem) obj)._Product) && object.Equals((object) this._SetupQty, (object) ((MaterialListItem) obj)._SetupQty))) && (object.Equals((object) this._IsFrozen, (object) ((MaterialListItem) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((MaterialListItem) obj)._Name) && object.Equals((object) this._ScrapPercent, (object) ((MaterialListItem) obj)._ScrapPercent))) && base.Equals(obj);
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

    public NamedObjectRef UOM2
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

    public NamedObjectRef UOM
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

    public Enumeration<IssueControlEnum, int> IssueControl
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

    public Primitive<double> SetupQty2
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

    public Primitive<double> Qty2Required
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

    public Primitive<bool> IsEnabled
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

    public RevisionedObjectRef PhantomBill
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

    public Primitive<DateTime> EffectiveThruDate
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

    public Primitive<DateTime> EffectiveThruDateGMT
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

    public Primitive<bool> AllowOverConsumption
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

    public Primitive<bool> AllowUnderConsumption
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

    public Primitive<DateTime> EffectiveFromDate
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

    public Primitive<bool> AllowSubstitution
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

    public Primitive<DateTime> EffectiveFromDateGMT
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

    public Primitive<string> ReferenceDesignator
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

    public BaseObjectRef IssuePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuePoint), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (IssuePoint));
      }
    }

    public Primitive<bool> IsPhantom
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

    public Primitive<bool> VendorControl
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

    public Primitive<double> QtyRequired
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

    public RevisionedObjectRef Product
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

    public Primitive<double> SetupQty
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

    public Primitive<double> ScrapPercent
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
  }
}
