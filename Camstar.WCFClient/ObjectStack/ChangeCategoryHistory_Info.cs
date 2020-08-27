// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeCategoryHistory_Info
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
  public class ChangeCategoryHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Info_FromCategory")]
    protected Info _FromCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Info_NewCategory")]
    protected Info _NewCategory;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Info_TriageComplete")]
    protected Info _TriageComplete;

    public Info FromCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromCategory));
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

    public Info NewCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewCategory));
      }
    }

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageComplete));
      }
    }
  }
}
