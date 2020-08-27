// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteChecklistHistoryDtl_Info
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
  public class ExecuteChecklistHistoryDtl_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Info_UserComments")]
    protected Info _UserComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Info_ChecklistText")]
    protected Info _ChecklistText;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Info_ChecklistEntry")]
    protected Info _ChecklistEntry;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Info_ResponseSet")]
    protected Info _ResponseSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Info_UserResponses")]
    protected ExecuteChklstResponseHistDtl_Info _UserResponses;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteChecklistHistoryDtl_Info_HistoryId")]
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

    public Info UserComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserComments));
      }
    }

    public Info ChecklistText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistText));
      }
    }

    public Info ChecklistEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistEntry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistEntry));
      }
    }

    public Info ResponseSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResponseSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResponseSet));
      }
    }

    public ExecuteChklstResponseHistDtl_Info UserResponses
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserResponses), (object) value);
      }
      get
      {
        return (ExecuteChklstResponseHistDtl_Info) this.PropertyGet(nameof (UserResponses));
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
