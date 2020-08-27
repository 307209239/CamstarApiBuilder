// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureActionHistoryDtl_Info
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
  public class EventFailureActionHistoryDtl_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_FailureMode")]
    protected Info _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_CauseCode")]
    protected Info _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_ActionType")]
    protected Info _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_CompletionDate")]
    protected Info _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionHistoryDtl_Info_ActionOwner")]
    protected Info _ActionOwner;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureMode));
      }
    }

    public Info CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CauseCode));
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

    public Info ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionType));
      }
    }

    public Info CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionDate));
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

    public Info ActionOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionOwner));
      }
    }
  }
}
