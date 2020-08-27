// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingTestDtlHistory_Environment
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
  public class CollectSamplingTestDtlHistory_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("The user code for loss reason.", "LossReason", false, false, false, "NamedObjectRef", 1053152, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_RejectReason")]
    protected Environment _RejectReason;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_SampleDataPoint")]
    [Metadata("Object used for defining a reusable data points.", "SampleDataPoint", false, true, false, "RevisionedObjectRef", 1053159, false, false, false, null)]
    protected Environment _SampleDataPoint;
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_DataType")]
    protected Environment _DataType;
    [Metadata("Generic String", "", false, false, false, "String", 1052459, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_DataValue")]
    protected Environment _DataValue;
    [Metadata("Generic String", "", false, false, true, "String", 1050532, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_UpperLimit")]
    protected Environment _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_LowerLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1050533, false, false, false, null)]
    protected Environment _LowerLimit;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053116, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_Passed")]
    protected Environment _Passed;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;

    public Environment RejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RejectReason));
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

    public Environment SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleDataPoint));
      }
    }

    public Environment DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType));
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

    public Environment UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Environment LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Environment Passed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Passed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Passed));
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
