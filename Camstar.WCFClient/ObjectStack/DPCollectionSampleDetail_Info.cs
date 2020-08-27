// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionSampleDetail_Info
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
  public class DPCollectionSampleDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_DecimalValue")]
    protected Info _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_Sample")]
    protected Info _Sample;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_DataPointCollectionRangeColor")]
    protected Info _DataPointCollectionRangeColor;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_TimestampValue")]
    protected Info _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_DataValue")]
    protected Info _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_BooleanValue")]
    protected Info _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_IntegerValue")]
    protected Info _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Info_CellName")]
    protected Info _CellName;

    public Info DecimalValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecimalValue));
      }
    }

    public Info Sample
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sample), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sample));
      }
    }

    public Info DataPointCollectionRangeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollectionRangeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPointCollectionRangeColor));
      }
    }

    public Info TimestampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimestampValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimestampValue));
      }
    }

    public Info DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataValue));
      }
    }

    public Info BooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BooleanValue));
      }
    }

    public Info IntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IntegerValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IntegerValue));
      }
    }

    public Info CellName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CellName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CellName));
      }
    }
  }
}
