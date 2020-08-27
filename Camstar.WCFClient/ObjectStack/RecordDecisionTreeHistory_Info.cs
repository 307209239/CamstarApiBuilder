// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordDecisionTreeHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CreateRegulatoryReportHistory_Info))]
  [Serializable]
  public class RecordDecisionTreeHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Info_Result")]
    protected Info _Result;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Info_DecisionTree")]
    protected Info _DecisionTree;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Info_HistoryDetails")]
    protected DecisionTreeHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "RecordDecisionTreeHistory_Info_HistoryId")]
    protected new Info _HistoryId;

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

    public Info Result
    {
      [param: In] set
      {
        this.PropertySet(nameof (Result), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Result));
      }
    }

    public Info DecisionTree
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTree), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DecisionTree));
      }
    }

    public DecisionTreeHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DecisionTreeHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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
