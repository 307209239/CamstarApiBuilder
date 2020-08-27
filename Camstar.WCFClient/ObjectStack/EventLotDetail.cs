// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotDetail
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
  public class EventLotDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_EventLot")]
    protected SubentityRef _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_NCRDefectDetails")]
    protected Camstar.WCF.ObjectStack.NCRDefectDetails[] _NCRDefectDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_FailureModes")]
    protected NamedObjectRef[] _FailureModes;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Components")]
    protected EventComponentDetail[] _Components;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_EventDispositionDetails")]
    protected EventDispositionDetail[] _EventDispositionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_LotDispositionStatus")]
    protected Enumeration<LotDispositionStatusEnum, int> _LotDispositionStatus;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_OriginalStartDate")]
    protected Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_PlaceOnHold")]
    protected Primitive<bool> _PlaceOnHold;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_WorkcenterName")]
    protected Primitive<string> _WorkcenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_OperationName")]
    protected Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_FactoryName")]
    protected Primitive<string> _FactoryName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_QtyPendingDisp")]
    protected Primitive<double> _QtyPendingDisp;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_QtyDefective")]
    protected Primitive<double> _QtyDefective;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_QtySampled")]
    protected Primitive<double> _QtySampled;

    public override bool Equals(object obj)
    {
      return obj is EventLotDetail && object.Equals((object) this._EventLot, (object) ((EventLotDetail) obj)._EventLot) && (object.Equals((object) this._Task, (object) ((EventLotDetail) obj)._Task) && this.CompareArrays((Array) this._NCRDefectDetails, (Array) ((EventLotDetail) obj)._NCRDefectDetails)) && (this.CompareArrays((Array) this._FailureModes, (Array) ((EventLotDetail) obj)._FailureModes) && this.CompareArrays((Array) this._Components, (Array) ((EventLotDetail) obj)._Components) && (this.CompareArrays((Array) this._EventDispositionDetails, (Array) ((EventLotDetail) obj)._EventDispositionDetails) && object.Equals((object) this._LotDispositionStatus, (object) ((EventLotDetail) obj)._LotDispositionStatus))) && (object.Equals((object) this._OriginalStartDate, (object) ((EventLotDetail) obj)._OriginalStartDate) && object.Equals((object) this._ReferenceDesignator, (object) ((EventLotDetail) obj)._ReferenceDesignator) && (object.Equals((object) this._IsContainer, (object) ((EventLotDetail) obj)._IsContainer) && object.Equals((object) this._PlaceOnHold, (object) ((EventLotDetail) obj)._PlaceOnHold)) && (object.Equals((object) this._Container, (object) ((EventLotDetail) obj)._Container) && object.Equals((object) this._ProductDescription, (object) ((EventLotDetail) obj)._ProductDescription) && (object.Equals((object) this._WorkcenterName, (object) ((EventLotDetail) obj)._WorkcenterName) && object.Equals((object) this._OperationName, (object) ((EventLotDetail) obj)._OperationName)))) && (object.Equals((object) this._UOMName, (object) ((EventLotDetail) obj)._UOMName) && object.Equals((object) this._FactoryName, (object) ((EventLotDetail) obj)._FactoryName) && (object.Equals((object) this._ChargeToStep, (object) ((EventLotDetail) obj)._ChargeToStep) && object.Equals((object) this._ProductName, (object) ((EventLotDetail) obj)._ProductName)) && (object.Equals((object) this._Lot, (object) ((EventLotDetail) obj)._Lot) && object.Equals((object) this._ProductRev, (object) ((EventLotDetail) obj)._ProductRev) && (object.Equals((object) this._QtyPendingDisp, (object) ((EventLotDetail) obj)._QtyPendingDisp) && object.Equals((object) this._QtyDefective, (object) ((EventLotDetail) obj)._QtyDefective))) && (object.Equals((object) this._Qty, (object) ((EventLotDetail) obj)._Qty) && object.Equals((object) this._QtySampled, (object) ((EventLotDetail) obj)._QtySampled))) && base.Equals(obj);
    }

    public SubentityRef EventLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLot), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventLot));
      }
    }

    public NamedSubentityRef Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Task));
      }
    }

    public Camstar.WCF.ObjectStack.NCRDefectDetails[] NCRDefectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.NCRDefectDetails[]) this.PropertyGet(nameof (NCRDefectDetails));
      }
    }

    public NamedObjectRef[] FailureModes
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModes), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (FailureModes));
      }
    }

    public EventComponentDetail[] Components
    {
      [param: In] set
      {
        this.PropertySet(nameof (Components), (object) value);
      }
      get
      {
        return (EventComponentDetail[]) this.PropertyGet(nameof (Components));
      }
    }

    public EventDispositionDetail[] EventDispositionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDispositionDetails), (object) value);
      }
      get
      {
        return (EventDispositionDetail[]) this.PropertyGet(nameof (EventDispositionDetails));
      }
    }

    public Enumeration<LotDispositionStatusEnum, int> LotDispositionStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotDispositionStatus), (object) value);
      }
      get
      {
        return (Enumeration<LotDispositionStatusEnum, int>) this.PropertyGet(nameof (LotDispositionStatus));
      }
    }

    public Primitive<DateTime> OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OriginalStartDate));
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

    public Primitive<bool> IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Primitive<bool> PlaceOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlaceOnHold), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PlaceOnHold));
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

    public Primitive<string> ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Primitive<string> WorkcenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkcenterName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkcenterName));
      }
    }

    public Primitive<string> OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OperationName));
      }
    }

    public Primitive<string> UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOMName));
      }
    }

    public Primitive<string> FactoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FactoryName));
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

    public Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public Primitive<string> Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Lot));
      }
    }

    public Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Primitive<double> QtyPendingDisp
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyPendingDisp), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyPendingDisp));
      }
    }

    public Primitive<double> QtyDefective
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyDefective), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyDefective));
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

    public Primitive<double> QtySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtySampled), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtySampled));
      }
    }
  }
}
