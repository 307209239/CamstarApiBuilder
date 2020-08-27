// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerHistoryDetail
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
  public class ProcessTimerHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_StartTimeGMT")]
    protected Primitive<DateTime> _StartTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_DefinedMinTime")]
    protected Primitive<string> _DefinedMinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_EndTimeGMT")]
    protected Primitive<DateTime> _EndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_DefinedMaxTime")]
    protected Primitive<string> _DefinedMaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_TimerCompletionStatusName")]
    protected Primitive<string> _TimerCompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_ProcessTimerName")]
    protected Primitive<string> _ProcessTimerName;

    public override bool Equals(object obj)
    {
      return obj is ProcessTimerHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((ProcessTimerHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._StartTimeGMT, (object) ((ProcessTimerHistoryDetail) obj)._StartTimeGMT) && object.Equals((object) this._DefinedMinTime, (object) ((ProcessTimerHistoryDetail) obj)._DefinedMinTime)) && (object.Equals((object) this._HistoryId, (object) ((ProcessTimerHistoryDetail) obj)._HistoryId) && object.Equals((object) this._EndTimeGMT, (object) ((ProcessTimerHistoryDetail) obj)._EndTimeGMT) && (object.Equals((object) this._DefinedMaxTime, (object) ((ProcessTimerHistoryDetail) obj)._DefinedMaxTime) && object.Equals((object) this._TimerCompletionStatusName, (object) ((ProcessTimerHistoryDetail) obj)._TimerCompletionStatusName))) && object.Equals((object) this._ProcessTimerName, (object) ((ProcessTimerHistoryDetail) obj)._ProcessTimerName) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<DateTime> StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Primitive<string> DefinedMinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefinedMinTime), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefinedMinTime));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<DateTime> EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Primitive<string> DefinedMaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefinedMaxTime), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefinedMaxTime));
      }
    }

    public Primitive<string> TimerCompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerCompletionStatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimerCompletionStatusName));
      }
    }

    public Primitive<string> ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessTimerName));
      }
    }
  }
}
