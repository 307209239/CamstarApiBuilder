// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTaskHistory_Info
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
  public class DelegateTaskHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_DelegationReasonCode")]
    protected Info _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_DelegationTarget")]
    protected Info _DelegationTarget;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_SourceEmployee")]
    protected Info _SourceEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskHistory_Info_TargetEmployee")]
    protected Info _TargetEmployee;

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

    public Info DelegationReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationReasonCode));
      }
    }

    public Info DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationTarget));
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

    public Info SourceEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceEmployee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SourceEmployee));
      }
    }

    public Info TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
