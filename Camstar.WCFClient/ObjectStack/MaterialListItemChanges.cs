// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItemChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RecipeMaterialListItemChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ERPMaterialListItemChanges))]
  [KnownType(typeof (ProductMaterialListItemChanges))]
  [Serializable]
  public class MaterialListItemChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_PhantomBill")]
    protected RevisionedObjectRef _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_SetupQty2")]
    protected Primitive<double> _SetupQty2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_IssueControl")]
    protected Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Qty2Required")]
    protected Primitive<double> _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_AllowOverConsumption")]
    protected Primitive<bool> _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_VendorControl")]
    protected Primitive<bool> _VendorControl;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_AllowSubstitution")]
    protected Primitive<bool> _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_IsPhantom")]
    protected Primitive<bool> _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_IssuePoint")]
    protected BaseObjectRef _IssuePoint;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_AllowUnderConsumption")]
    protected Primitive<bool> _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_ScrapPercent")]
    protected Primitive<double> _ScrapPercent;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_QtyRequired")]
    protected Primitive<double> _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_SetupQty")]
    protected Primitive<double> _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is MaterialListItemChanges && object.Equals((object) this._PhantomBill, (object) ((MaterialListItemChanges) obj)._PhantomBill) && (object.Equals((object) this._SetupQty2, (object) ((MaterialListItemChanges) obj)._SetupQty2) && object.Equals((object) this._ListItemToChange, (object) ((MaterialListItemChanges) obj)._ListItemToChange)) && (object.Equals((object) this._UOM2, (object) ((MaterialListItemChanges) obj)._UOM2) && object.Equals((object) this._UOM, (object) ((MaterialListItemChanges) obj)._UOM) && (object.Equals((object) this._ObjectToChange, (object) ((MaterialListItemChanges) obj)._ObjectToChange) && object.Equals((object) this._IssueControl, (object) ((MaterialListItemChanges) obj)._IssueControl))) && (object.Equals((object) this._Qty2Required, (object) ((MaterialListItemChanges) obj)._Qty2Required) && object.Equals((object) this._EffectiveThruDate, (object) ((MaterialListItemChanges) obj)._EffectiveThruDate) && (object.Equals((object) this._EffectiveThruDateGMT, (object) ((MaterialListItemChanges) obj)._EffectiveThruDateGMT) && object.Equals((object) this._AllowOverConsumption, (object) ((MaterialListItemChanges) obj)._AllowOverConsumption)) && (object.Equals((object) this._EffectiveFromDate, (object) ((MaterialListItemChanges) obj)._EffectiveFromDate) && object.Equals((object) this._EffectiveFromDateGMT, (object) ((MaterialListItemChanges) obj)._EffectiveFromDateGMT) && (object.Equals((object) this._VendorControl, (object) ((MaterialListItemChanges) obj)._VendorControl) && object.Equals((object) this._AllowSubstitution, (object) ((MaterialListItemChanges) obj)._AllowSubstitution)))) && (object.Equals((object) this._ReferenceDesignator, (object) ((MaterialListItemChanges) obj)._ReferenceDesignator) && object.Equals((object) this._IsPhantom, (object) ((MaterialListItemChanges) obj)._IsPhantom) && (object.Equals((object) this._IssuePoint, (object) ((MaterialListItemChanges) obj)._IssuePoint) && object.Equals((object) this._AllowUnderConsumption, (object) ((MaterialListItemChanges) obj)._AllowUnderConsumption)) && (object.Equals((object) this._ScrapPercent, (object) ((MaterialListItemChanges) obj)._ScrapPercent) && object.Equals((object) this._QtyRequired, (object) ((MaterialListItemChanges) obj)._QtyRequired) && (object.Equals((object) this._IsFrozen, (object) ((MaterialListItemChanges) obj)._IsFrozen) && object.Equals((object) this._SetupQty, (object) ((MaterialListItemChanges) obj)._SetupQty))) && (object.Equals((object) this._Name, (object) ((MaterialListItemChanges) obj)._Name) && object.Equals((object) this._Product, (object) ((MaterialListItemChanges) obj)._Product))) && base.Equals(obj);
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

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
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

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
