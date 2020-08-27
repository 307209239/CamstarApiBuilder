// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventHistory_Info
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
  public class UpdateEventHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Info_HistoryDetails")]
    protected EventHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Info_QualityCrossRefHistories")]
    protected QualityCrossRefHistory_Info _QualityCrossRefHistories;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Info_Submit")]
    protected Info _Submit;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public EventHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (EventHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public QualityCrossRefHistory_Info QualityCrossRefHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossRefHistories), (object) value);
      }
      get
      {
        return (QualityCrossRefHistory_Info) this.PropertyGet(nameof (QualityCrossRefHistories));
      }
    }

    public Info Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Submit));
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
