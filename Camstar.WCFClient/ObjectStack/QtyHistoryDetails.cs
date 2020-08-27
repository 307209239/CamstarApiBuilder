// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QtyHistoryDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (QtyBonusHistoryDetails))]
  [KnownType(typeof (QtyBuyHistoryDetails))]
  [KnownType(typeof (QtySellHistoryDetails))]
  [KnownType(typeof (QtyAdjustHistoryDetails))]
  [KnownType(typeof (QtyLossHistoryDetails))]
  [Serializable]
  public class QtyHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_ChildrenLost")]
    protected Primitive<int> _ChildrenLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_ChangeQtyType")]
    protected Primitive<int> _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_UnitsLost")]
    protected Primitive<int> _UnitsLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_ThisContainerDisassociated")]
    protected Primitive<bool> _ThisContainerDisassociated;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_ThisContainerClosed")]
    protected Primitive<bool> _ThisContainerClosed;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_UnitContainer")]
    protected Primitive<bool> _UnitContainer;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_RecordAllQty")]
    protected Primitive<bool> _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_CountsAgainstProduction")]
    protected Primitive<bool> _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_QtyMultiplier")]
    protected Primitive<int> _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_IsRollup")]
    protected Primitive<bool> _IsRollup;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_CloseWhenZero")]
    protected Primitive<bool> _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_AdjustThruput")]
    protected Primitive<bool> _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_ReasonCode")]
    protected NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Comments")]
    protected Primitive<string> _Comments;

    public override bool Equals(object obj)
    {
      return obj is QtyHistoryDetails && object.Equals((object) this._UOM, (object) ((QtyHistoryDetails) obj)._UOM) && (object.Equals((object) this._ExportImportKey, (object) ((QtyHistoryDetails) obj)._ExportImportKey) && object.Equals((object) this._UOM2, (object) ((QtyHistoryDetails) obj)._UOM2)) && (object.Equals((object) this._ChildrenLost, (object) ((QtyHistoryDetails) obj)._ChildrenLost) && object.Equals((object) this._ChangeQtyType, (object) ((QtyHistoryDetails) obj)._ChangeQtyType) && (object.Equals((object) this._UnitsLost, (object) ((QtyHistoryDetails) obj)._UnitsLost) && object.Equals((object) this._ThisContainerDisassociated, (object) ((QtyHistoryDetails) obj)._ThisContainerDisassociated))) && (object.Equals((object) this._ThisContainerClosed, (object) ((QtyHistoryDetails) obj)._ThisContainerClosed) && object.Equals((object) this._UnitContainer, (object) ((QtyHistoryDetails) obj)._UnitContainer) && (object.Equals((object) this._RecordAllQty, (object) ((QtyHistoryDetails) obj)._RecordAllQty) && object.Equals((object) this._CountsAgainstProduction, (object) ((QtyHistoryDetails) obj)._CountsAgainstProduction)) && (object.Equals((object) this._QtyMultiplier, (object) ((QtyHistoryDetails) obj)._QtyMultiplier) && object.Equals((object) this._IsRollup, (object) ((QtyHistoryDetails) obj)._IsRollup) && (object.Equals((object) this._CloseWhenZero, (object) ((QtyHistoryDetails) obj)._CloseWhenZero) && object.Equals((object) this._Container, (object) ((QtyHistoryDetails) obj)._Container)))) && (object.Equals((object) this._HistoryId, (object) ((QtyHistoryDetails) obj)._HistoryId) && object.Equals((object) this._AdjustThruput, (object) ((QtyHistoryDetails) obj)._AdjustThruput) && (object.Equals((object) this._ReasonCode, (object) ((QtyHistoryDetails) obj)._ReasonCode) && object.Equals((object) this._Product, (object) ((QtyHistoryDetails) obj)._Product)) && (object.Equals((object) this._Qty, (object) ((QtyHistoryDetails) obj)._Qty) && object.Equals((object) this._Operation, (object) ((QtyHistoryDetails) obj)._Operation) && (object.Equals((object) this._Qty2, (object) ((QtyHistoryDetails) obj)._Qty2) && object.Equals((object) this._ChargeToStep, (object) ((QtyHistoryDetails) obj)._ChargeToStep))) && object.Equals((object) this._Comments, (object) ((QtyHistoryDetails) obj)._Comments)) && base.Equals(obj);
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

    public Primitive<int> ChildrenLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildrenLost), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildrenLost));
      }
    }

    public Primitive<int> ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChangeQtyType));
      }
    }

    public Primitive<int> UnitsLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsLost), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitsLost));
      }
    }

    public Primitive<bool> ThisContainerDisassociated
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerDisassociated), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ThisContainerDisassociated));
      }
    }

    public Primitive<bool> ThisContainerClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerClosed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ThisContainerClosed));
      }
    }

    public Primitive<bool> UnitContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UnitContainer));
      }
    }

    public Primitive<bool> RecordAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordAllQty));
      }
    }

    public Primitive<bool> CountsAgainstProduction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountsAgainstProduction), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CountsAgainstProduction));
      }
    }

    public Primitive<int> QtyMultiplier
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyMultiplier), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (QtyMultiplier));
      }
    }

    public Primitive<bool> IsRollup
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRollup), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRollup));
      }
    }

    public Primitive<bool> CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<bool> AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public NamedObjectRef ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReasonCode));
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

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public NamedSubentityRef ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }
  }
}
