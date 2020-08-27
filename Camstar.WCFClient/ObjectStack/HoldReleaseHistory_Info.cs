// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldReleaseHistory_Info
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
  public class HoldReleaseHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Info_ReleaseReason")]
    protected Info _ReleaseReason;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Info_HistoryDetails")]
    protected HoldReleaseHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Info_HoldReason")]
    protected Info _HoldReason;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public Info ReleaseReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReleaseReason));
      }
    }

    public HoldReleaseHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (HoldReleaseHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
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

    public Info HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HoldReason));
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
