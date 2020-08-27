// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureHistoryDetail_Info
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
  public class EventFailureHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_FailureSeverity")]
    protected Info _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_FailureType")]
    protected Info _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_FailureMode")]
    protected Info _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_EventFailureCauseHistoryDetails")]
    protected EventFailureCauseHistoryDetail_Info _EventFailureCauseHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureHistoryDetail_Info_Description")]
    protected Info _Description;

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

    public Info FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public Info FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureType));
      }
    }

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

    public EventFailureCauseHistoryDetail_Info EventFailureCauseHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCauseHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureCauseHistoryDetail_Info) this.PropertyGet(nameof (EventFailureCauseHistoryDetails));
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

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
