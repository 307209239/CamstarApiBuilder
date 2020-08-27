// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotDetail_Info
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
  public class EventLotDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_EventLot")]
    protected Info _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_NCRDefectDetails")]
    protected NCRDefectDetails_Info _NCRDefectDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_FailureModes")]
    protected Info _FailureModes;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_Components")]
    protected EventComponentDetail_Info _Components;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_EventDispositionDetails")]
    protected EventDispositionDetail_Info _EventDispositionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_LotDispositionStatus")]
    protected Info _LotDispositionStatus;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_OriginalStartDate")]
    protected Info _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_ReferenceDesignator")]
    protected Info _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_IsContainer")]
    protected Info _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_PlaceOnHold")]
    protected Info _PlaceOnHold;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_ProductDescription")]
    protected Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_WorkcenterName")]
    protected Info _WorkcenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_OperationName")]
    protected Info _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_UOMName")]
    protected Info _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_FactoryName")]
    protected Info _FactoryName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_ChargeToStep")]
    protected Info _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_ProductRev")]
    protected Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_QtyPendingDisp")]
    protected Info _QtyPendingDisp;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_QtyDefective")]
    protected Info _QtyDefective;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Info_QtySampled")]
    protected Info _QtySampled;

    public Info EventLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventLot));
      }
    }

    public Info Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Task));
      }
    }

    public NCRDefectDetails_Info NCRDefectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectDetails), (object) value);
      }
      get
      {
        return (NCRDefectDetails_Info) this.PropertyGet(nameof (NCRDefectDetails));
      }
    }

    public Info FailureModes
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureModes));
      }
    }

    public EventComponentDetail_Info Components
    {
      [param: In] set
      {
        this.PropertySet(nameof (Components), (object) value);
      }
      get
      {
        return (EventComponentDetail_Info) this.PropertyGet(nameof (Components));
      }
    }

    public EventDispositionDetail_Info EventDispositionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDispositionDetails), (object) value);
      }
      get
      {
        return (EventDispositionDetail_Info) this.PropertyGet(nameof (EventDispositionDetails));
      }
    }

    public Info LotDispositionStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotDispositionStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LotDispositionStatus));
      }
    }

    public Info OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalStartDate));
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

    public Info IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Info PlaceOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlaceOnHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlaceOnHold));
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

    public Info ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Info WorkcenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkcenterName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkcenterName));
      }
    }

    public Info OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationName));
      }
    }

    public Info UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOMName));
      }
    }

    public Info FactoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FactoryName));
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

    public Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public Info Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Lot));
      }
    }

    public Info ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Info QtyPendingDisp
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyPendingDisp), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyPendingDisp));
      }
    }

    public Info QtyDefective
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyDefective), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyDefective));
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

    public Info QtySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtySampled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtySampled));
      }
    }
  }
}
