// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionSampleHistory_Info
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
  public class DPCollectionSampleHistory_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_DecimalValue")]
    protected Info _DecimalValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_DataPointCollectionRangeColor")]
    protected Info _DataPointCollectionRangeColor;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_DataValue")]
    protected Info _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_CellName")]
    protected Info _CellName;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_BooleanValue")]
    protected Info _BooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_IntegerValue")]
    protected Info _IntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_TimestampValue")]
    protected Info _TimestampValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionSampleHistory_Info_HistoryId")]
    protected new Info _HistoryId;

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
