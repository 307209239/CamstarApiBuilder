// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionSampleDetail_Environment
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
  public class DPCollectionSampleDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("DecimalValue allowing both precision and scale.", "", false, false, true, "String", 1050541, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_DecimalValue")]
    protected Environment _DecimalValue;
    [Metadata("A sample collected for the Data Point.", "DPCollectionPointSample", false, false, false, "NamedSubentityRef", 1052478, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_Sample")]
    protected Environment _Sample;
    [Metadata("Enumeration for the Data Point Collection Range Color:\r\n-2 = BelowOuter\r\n-1 = BelowInner\r\n0  = WithinInner\r\n1  = AboveInner\r\n2  = AboveOuter", "DPCollectionRangeColorEnum", false, false, false, "Integer", 1052458, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_DataPointCollectionRangeColor")]
    protected Environment _DataPointCollectionRangeColor;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050543, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_TimestampValue")]
    protected Environment _TimestampValue;
    [Metadata("Generic String", "", false, false, false, "String", 1052459, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_DataValue")]
    protected Environment _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_BooleanValue")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049126, false, false, false, "0")]
    protected Environment _BooleanValue;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049135, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_IntegerValue")]
    protected Environment _IntegerValue;
    [Metadata("Generic String", "", false, false, false, "String", 1052457, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleDetail_Environment_CellName")]
    protected Environment _CellName;

    public Environment DecimalValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecimalValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DecimalValue));
      }
    }

    public Environment Sample
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sample), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sample));
      }
    }

    public Environment DataPointCollectionRangeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollectionRangeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointCollectionRangeColor));
      }
    }

    public Environment TimestampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimestampValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimestampValue));
      }
    }

    public Environment DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataValue));
      }
    }

    public Environment BooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (BooleanValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BooleanValue));
      }
    }

    public Environment IntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IntegerValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IntegerValue));
      }
    }

    public Environment CellName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CellName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CellName));
      }
    }
  }
}
