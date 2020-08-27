// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotDetailInquiry
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
  public class EventLotDetailInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_EventFailures")]
    protected EventFailure[] _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_EventLot")]
    protected SubentityRef _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_DispositionFilter")]
    protected Enumeration<DispositionFilterEnum, int> _DispositionFilter;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_QuantityAffected")]
    protected Primitive<string> _QuantityAffected;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_DispositionSummaries")]
    protected DispositionSummary[] _DispositionSummaries;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_QuantitySampled")]
    protected Primitive<string> _QuantitySampled;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Caller")]
    protected BaseObjectRef _Caller;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_OperationName")]
    protected Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_WorkCenterName")]
    protected Primitive<string> _WorkCenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_FactoryName")]
    protected Primitive<string> _FactoryName;

    public override bool Equals(object obj)
    {
      return obj is EventLotDetailInquiry && this.CompareArrays((Array) this._EventFailures, (Array) ((EventLotDetailInquiry) obj)._EventFailures) && (object.Equals((object) this._QualityObject, (object) ((EventLotDetailInquiry) obj)._QualityObject) && object.Equals((object) this._EventLot, (object) ((EventLotDetailInquiry) obj)._EventLot)) && (object.Equals((object) this._DispositionFilter, (object) ((EventLotDetailInquiry) obj)._DispositionFilter) && object.Equals((object) this._QuantityAffected, (object) ((EventLotDetailInquiry) obj)._QuantityAffected) && (this.CompareArrays((Array) this._DispositionSummaries, (Array) ((EventLotDetailInquiry) obj)._DispositionSummaries) && object.Equals((object) this._QuantitySampled, (object) ((EventLotDetailInquiry) obj)._QuantitySampled))) && (object.Equals((object) this._Caller, (object) ((EventLotDetailInquiry) obj)._Caller) && object.Equals((object) this._OperationName, (object) ((EventLotDetailInquiry) obj)._OperationName) && (object.Equals((object) this._WorkCenterName, (object) ((EventLotDetailInquiry) obj)._WorkCenterName) && object.Equals((object) this._Lot, (object) ((EventLotDetailInquiry) obj)._Lot)) && object.Equals((object) this._FactoryName, (object) ((EventLotDetailInquiry) obj)._FactoryName)) && base.Equals(obj);
    }

    public EventFailure[] EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (EventFailure[]) this.PropertyGet(nameof (EventFailures));
      }
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
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

    public Enumeration<DispositionFilterEnum, int> DispositionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionFilter), (object) value);
      }
      get
      {
        return (Enumeration<DispositionFilterEnum, int>) this.PropertyGet(nameof (DispositionFilter));
      }
    }

    public Primitive<string> QuantityAffected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAffected), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantityAffected));
      }
    }

    public DispositionSummary[] DispositionSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionSummaries), (object) value);
      }
      get
      {
        return (DispositionSummary[]) this.PropertyGet(nameof (DispositionSummaries));
      }
    }

    public Primitive<string> QuantitySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantitySampled), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QuantitySampled));
      }
    }

    public BaseObjectRef Caller
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caller), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Caller));
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

    public Primitive<string> WorkCenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkCenterName));
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
  }
}
