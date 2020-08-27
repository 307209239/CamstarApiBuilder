// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OperationChanges_Info
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
  public class OperationChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ShipmentDestinations")]
    protected Info _ShipmentDestinations;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_DispatchRule")]
    protected Info _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_SchedulingDetail")]
    protected OperationSchedulingDetailChanges_Info _SchedulingDetail;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_BuyReasons")]
    protected Info _BuyReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ComponentDefectReasons")]
    protected Info _ComponentDefectReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_PrintQueue")]
    protected Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_SellReasons")]
    protected Info _SellReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_Image")]
    protected Info _Image;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_QtyAdjustReasons")]
    protected Info _QtyAdjustReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_DefaultRollupReason")]
    protected Info _DefaultRollupReason;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ShippingReasons")]
    protected Info _ShippingReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ContainerDefectReasons")]
    protected Info _ContainerDefectReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_LocalReworkReasons")]
    protected Info _LocalReworkReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_DisallowedTxns")]
    protected DisallowedTxnsChanges_Info _DisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_DisallowedTxnItem")]
    protected DisallowedTxnsChanges_Info _DisallowedTxnItem;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ReworkReasons")]
    protected Info _ReworkReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_LossReasons")]
    protected Info _LossReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_BonusReasons")]
    protected Info _BonusReasons;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ActionsMenu")]
    protected Info _ActionsMenu;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_OutsideServicePoint")]
    protected Info _OutsideServicePoint;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_UseQueue")]
    protected Info _UseQueue;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_RejectIncomingNCContainer")]
    protected Info _RejectIncomingNCContainer;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_SummaryThruput")]
    protected Info _SummaryThruput;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_InventoryPoint")]
    protected Info _InventoryPoint;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_InTransit")]
    protected Info _InTransit;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ThruputReportingLevel")]
    protected Info _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_WorkCenter")]
    protected Info _WorkCenter;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_AutoAdjustReason")]
    protected Info _AutoAdjustReason;
    [DataMember(EmitDefaultValue = false, Name = "OperationChanges_Info_AutoAdjustLimit")]
    protected Info _AutoAdjustLimit;

    public Info ShipmentDestinations
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShipmentDestinations), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShipmentDestinations));
      }
    }

    public Info DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public OperationSchedulingDetailChanges_Info SchedulingDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SchedulingDetail), (object) value);
      }
      get
      {
        return (OperationSchedulingDetailChanges_Info) this.PropertyGet(nameof (SchedulingDetail));
      }
    }

    public Info BuyReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (BuyReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BuyReasons));
      }
    }

    public Info ComponentDefectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComponentDefectReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ComponentDefectReasons));
      }
    }

    public Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Info SellReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (SellReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SellReasons));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Image));
      }
    }

    public Info QtyAdjustReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAdjustReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyAdjustReasons));
      }
    }

    public Info DefaultRollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultRollupReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultRollupReason));
      }
    }

    public Info ShippingReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShippingReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShippingReasons));
      }
    }

    public Info ContainerDefectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerDefectReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerDefectReasons));
      }
    }

    public Info LocalReworkReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalReworkReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LocalReworkReasons));
      }
    }

    public DisallowedTxnsChanges_Info DisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxns), (object) value);
      }
      get
      {
        return (DisallowedTxnsChanges_Info) this.PropertyGet(nameof (DisallowedTxns));
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

    public DisallowedTxnsChanges_Info DisallowedTxnItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxnItem), (object) value);
      }
      get
      {
        return (DisallowedTxnsChanges_Info) this.PropertyGet(nameof (DisallowedTxnItem));
      }
    }

    public Info ReworkReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkReasons));
      }
    }

    public Info LossReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LossReasons));
      }
    }

    public Info BonusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (BonusReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BonusReasons));
      }
    }

    public Info ActionsMenu
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionsMenu), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionsMenu));
      }
    }

    public Info OutsideServicePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (OutsideServicePoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OutsideServicePoint));
      }
    }

    public Info UseQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseQueue));
      }
    }

    public Info RejectIncomingNCContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectIncomingNCContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RejectIncomingNCContainer));
      }
    }

    public Info SummaryThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryThruput), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SummaryThruput));
      }
    }

    public Info InventoryPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (InventoryPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InventoryPoint));
      }
    }

    public Info InTransit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InTransit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InTransit));
      }
    }

    public Info ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputReportingLevel));
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

    public Info WorkCenter
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenter));
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

    public Info AutoAdjustReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoAdjustReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoAdjustReason));
      }
    }

    public Info AutoAdjustLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoAdjustLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoAdjustLimit));
      }
    }
  }
}
