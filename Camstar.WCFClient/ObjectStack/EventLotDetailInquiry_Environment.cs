// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotDetailInquiry_Environment
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
  public class EventLotDetailInquiry_Environment : Inquiry_Environment
  {
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, false, "EventFailure", 1052044, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_EventFailures")]
    protected EventFailure_Environment _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051298, false, false, false, null)]
    protected Environment _QualityObject;
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, false, "SubentityRef", 1051083, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_EventLot")]
    protected Environment _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_DispositionFilter")]
    [Metadata("DispositionFilter", "DispositionFilterEnum", false, false, false, "Integer", 1052043, false, false, false, "1")]
    protected Environment _DispositionFilter;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_QuantityAffected")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1051085, false, false, false, null)]
    protected Environment _QuantityAffected;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_DispositionSummaries")]
    [Metadata("Disposition Summary", "DispositionSummary", false, false, false, "DispositionSummary", 1052041, false, true, false, null)]
    protected DispositionSummary_Environment _DispositionSummaries;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1051086, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_QuantitySampled")]
    protected Environment _QuantitySampled;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1052035, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_Caller")]
    protected Environment _Caller;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_OperationName")]
    [Metadata("Generic String", "", false, false, false, "String", 1048815, false, false, false, null)]
    protected Environment _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_WorkCenterName")]
    [Metadata("Generic String", "", false, false, false, "String", 1048644, false, false, false, null)]
    protected Environment _WorkCenterName;
    [Metadata("Generic String", "", false, false, false, "String", 1052042, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_Lot")]
    protected Environment _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetailInquiry_Environment_FactoryName")]
    [Metadata("Generic String", "", false, false, false, "String", 1048659, false, false, false, null)]
    protected Environment _FactoryName;

    public EventFailure_Environment EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (EventFailure_Environment) this.PropertyGet(nameof (EventFailures));
      }
    }

    public Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Environment EventLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventLot));
      }
    }

    public Environment DispositionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispositionFilter));
      }
    }

    public Environment QuantityAffected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAffected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityAffected));
      }
    }

    public DispositionSummary_Environment DispositionSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionSummaries), (object) value);
      }
      get
      {
        return (DispositionSummary_Environment) this.PropertyGet(nameof (DispositionSummaries));
      }
    }

    public Environment QuantitySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantitySampled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantitySampled));
      }
    }

    public Environment Caller
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caller), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Caller));
      }
    }

    public Environment OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationName));
      }
    }

    public Environment WorkCenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenterName));
      }
    }

    public Environment Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Lot));
      }
    }

    public Environment FactoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryName));
      }
    }
  }
}
