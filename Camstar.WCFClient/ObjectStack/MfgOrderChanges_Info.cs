// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgOrderChanges_Info
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
  public class MfgOrderChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_OrderStatus")]
    protected Info _OrderStatus;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_OrderType")]
    protected Info _OrderType;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ERPBOM")]
    protected Info _ERPBOM;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ERPRoute")]
    protected Info _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_MaterialList")]
    protected MfgOrderMaterialListItmChanges_Info _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_BillOfProcess")]
    protected Info _BillOfProcess;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_Attributes")]
    protected UserAttributeChanges_Info _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ContainerNumberingRule")]
    protected Info _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_PlannedStartDate")]
    protected Info _PlannedStartDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ExternallyControlled")]
    protected Info _ExternallyControlled;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_PlannedStartDateGMT")]
    protected Info _PlannedStartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_PlannedCompletionDateGMT")]
    protected Info _PlannedCompletionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ReleaseDateGMT")]
    protected Info _ReleaseDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_PlannedCompletionDate")]
    protected Info _PlannedCompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ReleaseDate")]
    protected Info _ReleaseDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_DefaultLot")]
    protected Info _DefaultLot;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_Priority")]
    protected Info _Priority;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_Containers")]
    protected Info _Containers;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_DefaultPutawayStockPoint")]
    protected Info _DefaultPutawayStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_ReportingFactory")]
    protected Info _ReportingFactory;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_BeginProduct")]
    protected Info _BeginProduct;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderChanges_Info_Product")]
    protected Info _Product;

    public Info OrderStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrderStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OrderStatus));
      }
    }

    public Info OrderType
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrderType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OrderType));
      }
    }

    public Info ERPBOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPBOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPBOM));
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

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Info ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public MfgOrderMaterialListItmChanges_Info MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (MfgOrderMaterialListItmChanges_Info) this.PropertyGet(nameof (MaterialList));
      }
    }

    public Info BillOfProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillOfProcess));
      }
    }

    public UserAttributeChanges_Info Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges_Info) this.PropertyGet(nameof (Attributes));
      }
    }

    public Info ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Info PlannedStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedStartDate));
      }
    }

    public Info ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExternallyControlled));
      }
    }

    public Info PlannedStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedStartDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedStartDateGMT));
      }
    }

    public Info PlannedCompletionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCompletionDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedCompletionDateGMT));
      }
    }

    public Info ReleaseDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReleaseDateGMT));
      }
    }

    public Info PlannedCompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCompletionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlannedCompletionDate));
      }
    }

    public Info ReleaseDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReleaseDate));
      }
    }

    public Info DefaultLot
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

    public Info Priority
    {
      [param: In] set
      {
        this.PropertySet(nameof (Priority), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Priority));
      }
    }

    public Info Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Containers));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public Info DefaultPutawayStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultPutawayStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultPutawayStockPoint));
      }
    }

    public Info ReportingFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportingFactory));
      }
    }

    public Info BeginProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BeginProduct));
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
