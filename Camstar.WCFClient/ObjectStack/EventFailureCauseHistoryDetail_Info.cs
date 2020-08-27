// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCauseHistoryDetail_Info
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
  public class EventFailureCauseHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Info_CauseCode")]
    protected Info _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Info_FailureMode")]
    protected Info _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Info_EventFailureActionHistoryDetails")]
    protected Info _EventFailureActionHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Info_IsRootCause")]
    protected Info _IsRootCause;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;

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

    public Info EventFailureActionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventFailureActionHistoryDetails));
      }
    }

    public Info IsRootCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRootCause), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRootCause));
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
