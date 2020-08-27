// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistHistory_Info
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
  public class ExecuteChecklistHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Info_ChecklistInstructions")]
    protected Info _ChecklistInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Info_HistoryDetails")]
    protected ExecuteChecklistHistoryDtl_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Info_Checklist")]
    protected Info _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistory_Info_Submit")]
    protected Info _Submit;

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

    public Info ChecklistInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistInstructions));
      }
    }

    public ExecuteChecklistHistoryDtl_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ExecuteChecklistHistoryDtl_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Checklist));
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
  }
}
