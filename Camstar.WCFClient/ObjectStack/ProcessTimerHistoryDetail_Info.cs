// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerHistoryDetail_Info
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
  public class ProcessTimerHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_StartTimeGMT")]
    protected Info _StartTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_DefinedMinTime")]
    protected Info _DefinedMinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_EndTimeGMT")]
    protected Info _EndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_DefinedMaxTime")]
    protected Info _DefinedMaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_TimerCompletionStatusName")]
    protected Info _TimerCompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Info_ProcessTimerName")]
    protected Info _ProcessTimerName;

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

    public Info StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Info DefinedMinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefinedMinTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefinedMinTime));
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

    public Info EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Info DefinedMaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefinedMaxTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefinedMaxTime));
      }
    }

    public Info TimerCompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerCompletionStatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerCompletionStatusName));
      }
    }

    public Info ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerName));
      }
    }
  }
}
