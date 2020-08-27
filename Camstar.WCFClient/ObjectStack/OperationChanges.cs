// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OperationChanges
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
  public class OperationChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ShipmentDestinations")]
    protected NamedObjectRef _ShipmentDestinations;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_DispatchRule")]
    protected NamedObjectRef _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_SchedulingDetail")]
    protected OperationSchedulingDetailChanges _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_BuyReasons")]
    protected NamedObjectRef _BuyReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ComponentDefectReasons")]
    protected NamedObjectRef _ComponentDefectReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_SellReasons")]
    protected NamedObjectRef _SellReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Image")]
    protected Primitive<string> _Image;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_QtyAdjustReasons")]
    protected NamedObjectRef _QtyAdjustReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_DefaultRollupReason")]
    protected NamedObjectRef _DefaultRollupReason;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ShippingReasons")]
    protected NamedObjectRef _ShippingReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ContainerDefectReasons")]
    protected NamedObjectRef _ContainerDefectReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_LocalReworkReasons")]
    protected NamedObjectRef _LocalReworkReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_DisallowedTxns")]
    protected DisallowedTxnsChanges[] _DisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_DisallowedTxnItem")]
    protected DisallowedTxnsChanges _DisallowedTxnItem;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ReworkReasons")]
    protected NamedObjectRef _ReworkReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_LossReasons")]
    protected NamedObjectRef _LossReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_BonusReasons")]
    protected NamedObjectRef _BonusReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ActionsMenu")]
    protected NamedObjectRef _ActionsMenu;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_OutsideServicePoint")]
    protected Primitive<bool> _OutsideServicePoint;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_UseQueue")]
    protected Primitive<bool> _UseQueue;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_RejectIncomingNCContainer")]
    protected Primitive<bool> _RejectIncomingNCContainer;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_SummaryThruput")]
    protected Primitive<bool> _SummaryThruput;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_InventoryPoint")]
    protected Primitive<bool> _InventoryPoint;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_InTransit")]
    protected Primitive<bool> _InTransit;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ThruputReportingLevel")]
    protected NamedObjectRef _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_WorkCenter")]
    protected NamedObjectRef _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_AutoAdjustReason")]
    protected NamedObjectRef _AutoAdjustReason;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_AutoAdjustLimit")]
    protected Primitive<double> _AutoAdjustLimit;

    public override bool Equals(object obj)
    {
      return obj is OperationChanges && object.Equals((object) this._ShipmentDestinations, (object) ((OperationChanges) obj)._ShipmentDestinations) && (object.Equals((object) this._DispatchRule, (object) ((OperationChanges) obj)._DispatchRule) && object.Equals((object) this._SchedulingDetail, (object) ((OperationChanges) obj)._SchedulingDetail)) && (object.Equals((object) this._BuyReasons, (object) ((OperationChanges) obj)._BuyReasons) && object.Equals((object) this._ComponentDefectReasons, (object) ((OperationChanges) obj)._ComponentDefectReasons) && (object.Equals((object) this._PrintQueue, (object) ((OperationChanges) obj)._PrintQueue) && object.Equals((object) this._SellReasons, (object) ((OperationChanges) obj)._SellReasons))) && (object.Equals((object) this._TrainingReqGroup, (object) ((OperationChanges) obj)._TrainingReqGroup) && object.Equals((object) this._Image, (object) ((OperationChanges) obj)._Image) && (object.Equals((object) this._QtyAdjustReasons, (object) ((OperationChanges) obj)._QtyAdjustReasons) && object.Equals((object) this._DefaultRollupReason, (object) ((OperationChanges) obj)._DefaultRollupReason)) && (object.Equals((object) this._ShippingReasons, (object) ((OperationChanges) obj)._ShippingReasons) && object.Equals((object) this._ContainerDefectReasons, (object) ((OperationChanges) obj)._ContainerDefectReasons) && (object.Equals((object) this._LocalReworkReasons, (object) ((OperationChanges) obj)._LocalReworkReasons) && this.CompareArrays((Array) this._DisallowedTxns, (Array) ((OperationChanges) obj)._DisallowedTxns)))) && (object.Equals((object) this._WIPMsgDefMgr, (object) ((OperationChanges) obj)._WIPMsgDefMgr) && object.Equals((object) this._DisallowedTxnItem, (object) ((OperationChanges) obj)._DisallowedTxnItem) && (object.Equals((object) this._ReworkReasons, (object) ((OperationChanges) obj)._ReworkReasons) && object.Equals((object) this._LossReasons, (object) ((OperationChanges) obj)._LossReasons)) && (object.Equals((object) this._BonusReasons, (object) ((OperationChanges) obj)._BonusReasons) && object.Equals((object) this._ActionsMenu, (object) ((OperationChanges) obj)._ActionsMenu) && (object.Equals((object) this._OutsideServicePoint, (object) ((OperationChanges) obj)._OutsideServicePoint) && object.Equals((object) this._UseQueue, (object) ((OperationChanges) obj)._UseQueue))) && (object.Equals((object) this._RejectIncomingNCContainer, (object) ((OperationChanges) obj)._RejectIncomingNCContainer) && object.Equals((object) this._SummaryThruput, (object) ((OperationChanges) obj)._SummaryThruput) && (object.Equals((object) this._InventoryPoint, (object) ((OperationChanges) obj)._InventoryPoint) && object.Equals((object) this._InTransit, (object) ((OperationChanges) obj)._InTransit)) && (object.Equals((object) this._ThruputReportingLevel, (object) ((OperationChanges) obj)._ThruputReportingLevel) && object.Equals((object) this._ObjectToChange, (object) ((OperationChanges) obj)._ObjectToChange) && (object.Equals((object) this._WorkCenter, (object) ((OperationChanges) obj)._WorkCenter) && object.Equals((object) this._Name, (object) ((OperationChanges) obj)._Name))))) && (object.Equals((object) this._AutoAdjustReason, (object) ((OperationChanges) obj)._AutoAdjustReason) && object.Equals((object) this._AutoAdjustLimit, (object) ((OperationChanges) obj)._AutoAdjustLimit)) && base.Equals(obj);
    }

    public NamedObjectRef ShipmentDestinations
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShipmentDestinations), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ShipmentDestinations));
      }
    }

    public NamedObjectRef DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public OperationSchedulingDetailChanges SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (OperationSchedulingDetailChanges) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public NamedObjectRef BuyReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuyReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BuyReasons));
      }
    }

    public NamedObjectRef ComponentDefectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComponentDefectReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ComponentDefectReasons));
      }
    }

    public NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public NamedObjectRef SellReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (SellReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SellReasons));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Primitive<string> Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Image));
      }
    }

    public NamedObjectRef QtyAdjustReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAdjustReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QtyAdjustReasons));
      }
    }

    public NamedObjectRef DefaultRollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultRollupReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DefaultRollupReason));
      }
    }

    public NamedObjectRef ShippingReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShippingReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ShippingReasons));
      }
    }

    public NamedObjectRef ContainerDefectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerDefectReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerDefectReasons));
      }
    }

    public NamedObjectRef LocalReworkReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalReworkReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LocalReworkReasons));
      }
    }

    public DisallowedTxnsChanges[] DisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxns), (object) value);
      }
      get
      {
        return (DisallowedTxnsChanges[]) this.PropertyGet(nameof (DisallowedTxns));
      }
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public DisallowedTxnsChanges DisallowedTxnItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxnItem), (object) value);
      }
      get
      {
        return (DisallowedTxnsChanges) this.PropertyGet(nameof (DisallowedTxnItem));
      }
    }

    public NamedObjectRef ReworkReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReasons));
      }
    }

    public NamedObjectRef LossReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LossReasons));
      }
    }

    public NamedObjectRef BonusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (BonusReasons), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BonusReasons));
      }
    }

    public NamedObjectRef ActionsMenu
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionsMenu), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionsMenu));
      }
    }

    public Primitive<bool> OutsideServicePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutsideServicePoint), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OutsideServicePoint));
      }
    }

    public Primitive<bool> UseQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseQueue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseQueue));
      }
    }

    public Primitive<bool> RejectIncomingNCContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectIncomingNCContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RejectIncomingNCContainer));
      }
    }

    public Primitive<bool> SummaryThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryThruput), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SummaryThruput));
      }
    }

    public Primitive<bool> InventoryPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (InventoryPoint), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InventoryPoint));
      }
    }

    public Primitive<bool> InTransit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InTransit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InTransit));
      }
    }

    public NamedObjectRef ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCenter));
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

    public NamedObjectRef AutoAdjustReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoAdjustReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AutoAdjustReason));
      }
    }

    public Primitive<double> AutoAdjustLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoAdjustLimit), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (AutoAdjustLimit));
      }
    }
  }
}
