// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaterialListItem_Info
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
  public class ContainerMaterialListItem_Info : ERPMaterialListItem_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_RouteStep")]
    protected new Info _RouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_PhantomBill")]
    protected new Info _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_IssueControl")]
    protected new Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_UOM")]
    protected new Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_SetupQty2")]
    protected new Info _SetupQty2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_IsEnabled")]
    protected new Info _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_UOM2")]
    protected new Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_Qty2Required")]
    protected new Info _Qty2Required;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_AllowOverConsumption")]
    protected new Info _AllowOverConsumption;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_ERPLineItem")]
    protected new Info _ERPLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_ReferenceDesignator")]
    protected new Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_DefaultStockPoint")]
    protected new Info _DefaultStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_VendorControl")]
    protected new Info _VendorControl;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_EffectiveFromDateGMT")]
    protected new Info _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_EffectiveThruDateGMT")]
    protected new Info _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_AllowUnderConsumption")]
    protected new Info _AllowUnderConsumption;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_EffectiveFromDate")]
    protected new Info _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_EffectiveThruDate")]
    protected new Info _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_DefaultLot")]
    protected new Info _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_IsPhantom")]
    protected new Info _IsPhantom;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_ERPReportingFlag")]
    protected new Info _ERPReportingFlag;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_AllowSubstitution")]
    protected new Info _AllowSubstitution;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_QtyRequired")]
    protected new Info _QtyRequired;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_SubFactory")]
    protected new Info _SubFactory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_ScrapPercent")]
    protected new Info _ScrapPercent;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_SetupQty")]
    protected new Info _SetupQty;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaterialListItem_Info_Product")]
    protected new Info _Product;

    public new Info RouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (RouteStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RouteStep));
      }
    }

    public new Info PhantomBill
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

    public new Info IssueControl
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

    public new Info UOM
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

    public new Info SetupQty2
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

    public new Info IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public new Info UOM2
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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Info Qty2Required
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

    public new Info AllowOverConsumption
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

    public new Info ERPLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPLineItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPLineItem));
      }
    }

    public new Info ReferenceDesignator
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

    public new Info DefaultStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultStockPoint));
      }
    }

    public new Info VendorControl
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

    public new Info EffectiveFromDateGMT
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

    public new Info EffectiveThruDateGMT
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

    public new Info AllowUnderConsumption
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

    public new Info EffectiveFromDate
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

    public new Info EffectiveThruDate
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

    public new Info DefaultLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultLot));
      }
    }

    public new Info IsPhantom
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

    public new Info ERPReportingFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPReportingFlag), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPReportingFlag));
      }
    }

    public new Info AllowSubstitution
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

    public new Info QtyRequired
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

    public new Info SubFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubFactory));
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

    public new Info ScrapPercent
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

    public new Info SetupQty
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

    public new Info Product
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
