// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotHistoryDetail
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
  public class EventLotHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_EventComponentHistoryDetails")]
    protected SubentityRef[] _EventComponentHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_NCRDefectHistoryDetails")]
    protected Camstar.WCF.ObjectStack.NCRDefectHistoryDetails[] _NCRDefectHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_FailureModes")]
    protected NamedObjectRef[] _FailureModes;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_EventDispositionHistoryDetails")]
    protected SubentityRef[] _EventDispositionHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_OriginalStartDate")]
    protected Primitive<DateTime> _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_ReferenceDesignator")]
    protected Primitive<string> _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_IsContainer")]
    protected Primitive<bool> _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_PlaceOnHold")]
    protected Primitive<bool> _PlaceOnHold;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_OperationName")]
    protected Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_FactoryName")]
    protected Primitive<string> _FactoryName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_ChargeToStep")]
    protected NamedSubentityRef _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_WorkcenterName")]
    protected Primitive<string> _WorkcenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_QtySampled")]
    protected Primitive<double> _QtySampled;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_QtyDefective")]
    protected Primitive<double> _QtyDefective;

    public override bool Equals(object obj)
    {
      return obj is EventLotHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((EventLotHistoryDetail) obj)._ExportImportKey) && (this.CompareArrays((Array) this._EventComponentHistoryDetails, (Array) ((EventLotHistoryDetail) obj)._EventComponentHistoryDetails) && this.CompareArrays((Array) this._NCRDefectHistoryDetails, (Array) ((EventLotHistoryDetail) obj)._NCRDefectHistoryDetails)) && (object.Equals((object) this._Task, (object) ((EventLotHistoryDetail) obj)._Task) && this.CompareArrays((Array) this._FailureModes, (Array) ((EventLotHistoryDetail) obj)._FailureModes) && (this.CompareArrays((Array) this._EventDispositionHistoryDetails, (Array) ((EventLotHistoryDetail) obj)._EventDispositionHistoryDetails) && object.Equals((object) this._HistoryId, (object) ((EventLotHistoryDetail) obj)._HistoryId))) && (object.Equals((object) this._Container, (object) ((EventLotHistoryDetail) obj)._Container) && object.Equals((object) this._OriginalStartDate, (object) ((EventLotHistoryDetail) obj)._OriginalStartDate) && (object.Equals((object) this._ReferenceDesignator, (object) ((EventLotHistoryDetail) obj)._ReferenceDesignator) && object.Equals((object) this._IsContainer, (object) ((EventLotHistoryDetail) obj)._IsContainer)) && (object.Equals((object) this._PlaceOnHold, (object) ((EventLotHistoryDetail) obj)._PlaceOnHold) && object.Equals((object) this._ProductName, (object) ((EventLotHistoryDetail) obj)._ProductName) && (object.Equals((object) this._OperationName, (object) ((EventLotHistoryDetail) obj)._OperationName) && object.Equals((object) this._FactoryName, (object) ((EventLotHistoryDetail) obj)._FactoryName)))) && (object.Equals((object) this._UOMName, (object) ((EventLotHistoryDetail) obj)._UOMName) && object.Equals((object) this._ChargeToStep, (object) ((EventLotHistoryDetail) obj)._ChargeToStep) && (object.Equals((object) this._Qty, (object) ((EventLotHistoryDetail) obj)._Qty) && object.Equals((object) this._WorkcenterName, (object) ((EventLotHistoryDetail) obj)._WorkcenterName)) && (object.Equals((object) this._Lot, (object) ((EventLotHistoryDetail) obj)._Lot) && object.Equals((object) this._QtySampled, (object) ((EventLotHistoryDetail) obj)._QtySampled) && (object.Equals((object) this._ProductDescription, (object) ((EventLotHistoryDetail) obj)._ProductDescription) && object.Equals((object) this._ProductRev, (object) ((EventLotHistoryDetail) obj)._ProductRev))) && object.Equals((object) this._QtyDefective, (object) ((EventLotHistoryDetail) obj)._QtyDefective)) && base.Equals(obj);
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

    public SubentityRef[] EventComponentHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventComponentHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (EventComponentHistoryDetails));
      }
    }

    public Camstar.WCF.ObjectStack.NCRDefectHistoryDetails[] NCRDefectHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectHistoryDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.NCRDefectHistoryDetails[]) this.PropertyGet(nameof (NCRDefectHistoryDetails));
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

    public SubentityRef[] EventDispositionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDispositionHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (EventDispositionHistoryDetails));
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
  }
}
