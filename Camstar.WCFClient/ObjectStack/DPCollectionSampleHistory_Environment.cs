// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionSampleHistory_Environment
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
  public class DPCollectionSampleHistory_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_DecimalValue")]
    [Metadata("DecimalValue allowing both precision and scale.", "", false, false, true, "String", 1050541, false, false, false, null)]
    protected Environment _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_DataPointCollectionRangeColor")]
    [Metadata("Enumeration for the Data Point Collection Range Color:\r\n-2 = BelowOuter\r\n-1 = BelowInner\r\n0  = WithinInner\r\n1  = AboveInner\r\n2  = AboveOuter", "DPCollectionRangeColorEnum", false, false, true, "Integer", 1052458, false, false, false, null)]
    protected Environment _DataPointCollectionRangeColor;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_DataValue")]
    [Metadata("Generic String", "", false, false, true, "String", 1052459, false, false, false, null)]
    protected Environment _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_CellName")]
    [Metadata("Generic String", "", false, false, true, "String", 1052457, false, false, false, null)]
    protected Environment _CellName;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049126, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_BooleanValue")]
    protected Environment _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_IntegerValue")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049135, false, false, false, null)]
    protected Environment _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_TimestampValue")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050543, false, false, false, null)]
    protected Environment _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
