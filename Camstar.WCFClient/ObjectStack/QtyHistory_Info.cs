// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QtyHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EmptyCarrierHistory_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class QtyHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_RollupReason")]
    protected Info _RollupReason;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_HistoryDetails")]
    protected QtyHistoryDetails_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_ThruputSummary")]
    protected Info _ThruputSummary;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_UnitsLost")]
    protected Info _UnitsLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_CloseWhenZero")]
    protected Info _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_ThruputReportingLevel")]
    protected Info _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Info_Resource")]
    protected Info _Resource;

    public Info RollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RollupReason));
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

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public QtyHistoryDetails_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (QtyHistoryDetails_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info ThruputSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputSummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputSummary));
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

    public Info UnitsLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsLost), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitsLost));
      }
    }

    public Info CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public Info ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
