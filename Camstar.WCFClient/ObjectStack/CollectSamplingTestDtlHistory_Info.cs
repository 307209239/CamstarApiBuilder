// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingTestDtlHistory_Info
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
  public class CollectSamplingTestDtlHistory_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_RejectReason")]
    protected Info _RejectReason;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_SampleDataPoint")]
    protected Info _SampleDataPoint;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_DataValue")]
    protected Info _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_UpperLimit")]
    protected Info _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_LowerLimit")]
    protected Info _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_Passed")]
    protected Info _Passed;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingTestDtlHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public Info RejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RejectReason));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleDataPoint));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
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

    public Info UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Info LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Info Passed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Passed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Passed));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
