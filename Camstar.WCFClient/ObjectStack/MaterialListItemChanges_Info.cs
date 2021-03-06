﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialListItemChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RecipeMaterialListItemChanges_Info))]
  [KnownType(typeof (ERPMaterialListItemChanges_Info))]
  [KnownType(typeof (ProductMaterialListItemChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MaterialListItemChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_PhantomBill")]
    protected Info _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_SetupQty2")]
    protected Info _SetupQty2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_Qty2Required")]
    protected Info _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_EffectiveThruDate")]
    protected Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_EffectiveThruDateGMT")]
    protected Info _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_AllowOverConsumption")]
    protected Info _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_EffectiveFromDate")]
    protected Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_EffectiveFromDateGMT")]
    protected Info _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_VendorControl")]
    protected Info _VendorControl;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_AllowSubstitution")]
    protected Info _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_IsPhantom")]
    protected Info _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_IssuePoint")]
    protected Info _IssuePoint;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_AllowUnderConsumption")]
    protected Info _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_ScrapPercent")]
    protected Info _ScrapPercent;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_QtyRequired")]
    protected Info _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_SetupQty")]
    protected Info _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "MaterialListItemChanges_Info_Product")]
    protected Info _Product;

    public Info PhantomBill
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBill), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PhantomBill));
      }
    }

    public Info SetupQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SetupQty2));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
      }
    }

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Info Qty2Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Required), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Required));
      }
    }

    public Info EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDate));
      }
    }

    public Info EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveThruDateGMT));
      }
    }

    public Info AllowOverConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowOverConsumption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowOverConsumption));
      }
    }

    public Info EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Info EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EffectiveFromDateGMT));
      }
    }

    public Info VendorControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorControl));
      }
    }

    public Info AllowSubstitution
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowSubstitution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowSubstitution));
      }
    }

    public Info ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Info IsPhantom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPhantom), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsPhantom));
      }
    }

    public Info IssuePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuePoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuePoint));
      }
    }

    public Info AllowUnderConsumption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowUnderConsumption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowUnderConsumption));
      }
    }

    public Info ScrapPercent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScrapPercent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScrapPercent));
      }
    }

    public Info QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRequired));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info SetupQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SetupQty));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }
  }
}
