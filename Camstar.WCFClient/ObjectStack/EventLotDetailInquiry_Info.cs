// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotDetailInquiry_Info
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
  public class EventLotDetailInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_EventFailures")]
    protected EventFailure_Info _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_EventLot")]
    protected Info _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_DispositionFilter")]
    protected Info _DispositionFilter;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_QuantityAffected")]
    protected Info _QuantityAffected;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_DispositionSummaries")]
    protected DispositionSummary_Info _DispositionSummaries;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_QuantitySampled")]
    protected Info _QuantitySampled;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_Caller")]
    protected Info _Caller;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_OperationName")]
    protected Info _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_WorkCenterName")]
    protected Info _WorkCenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_Lot")]
    protected Info _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Info_FactoryName")]
    protected Info _FactoryName;

    public EventFailure_Info EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (EventFailure_Info) this.PropertyGet(nameof (EventFailures));
      }
    }

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

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

    public Info DispositionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispositionFilter));
      }
    }

    public Info QuantityAffected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAffected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantityAffected));
      }
    }

    public DispositionSummary_Info DispositionSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionSummaries), (object) value);
      }
      get
      {
        return (DispositionSummary_Info) this.PropertyGet(nameof (DispositionSummaries));
      }
    }

    public Info QuantitySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantitySampled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QuantitySampled));
      }
    }

    public Info Caller
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caller), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Caller));
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

    public Info WorkCenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenterName));
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
  }
}
