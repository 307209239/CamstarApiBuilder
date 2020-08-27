// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QtyHistoryDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (QtyBonusHistoryDetails_Info))]
  [KnownType(typeof (QtyLossHistoryDetails_Info))]
  [KnownType(typeof (QtyBuyHistoryDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (QtyAdjustHistoryDetails_Info))]
  [KnownType(typeof (QtySellHistoryDetails_Info))]
  [Serializable]
  public class QtyHistoryDetails_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_ChildrenLost")]
    protected Info _ChildrenLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_ChangeQtyType")]
    protected Info _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_UnitsLost")]
    protected Info _UnitsLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_ThisContainerDisassociated")]
    protected Info _ThisContainerDisassociated;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_ThisContainerClosed")]
    protected Info _ThisContainerClosed;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_UnitContainer")]
    protected Info _UnitContainer;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_RecordAllQty")]
    protected Info _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_CountsAgainstProduction")]
    protected Info _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_QtyMultiplier")]
    protected Info _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_IsRollup")]
    protected Info _IsRollup;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_CloseWhenZero")]
    protected Info _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_AdjustThruput")]
    protected Info _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_ReasonCode")]
    protected Info _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Info_Comments")]
    protected Info _Comments;

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

    public Info ChildrenLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildrenLost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildrenLost));
      }
    }

    public Info ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangeQtyType));
      }
    }

    public Info UnitsLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsLost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitsLost));
      }
    }

    public Info ThisContainerDisassociated
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerDisassociated), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThisContainerDisassociated));
      }
    }

    public Info ThisContainerClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerClosed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThisContainerClosed));
      }
    }

    public Info UnitContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitContainer));
      }
    }

    public Info RecordAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordAllQty));
      }
    }

    public Info CountsAgainstProduction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountsAgainstProduction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CountsAgainstProduction));
      }
    }

    public Info QtyMultiplier
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyMultiplier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyMultiplier));
      }
    }

    public Info IsRollup
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRollup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRollup));
      }
    }

    public Info CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public Info ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReasonCode));
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

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
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

    public Info ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
