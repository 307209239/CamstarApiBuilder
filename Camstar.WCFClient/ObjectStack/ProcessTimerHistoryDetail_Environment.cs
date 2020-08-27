// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerHistoryDetail_Environment
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
  public class ProcessTimerHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16778636, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778641, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_StartTimeGMT")]
    protected Environment _StartTimeGMT;
    [Metadata("Generic String", "", false, false, true, "String", 16778853, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_DefinedMinTime")]
    protected Environment _DefinedMinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778637, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_EndTimeGMT")]
    protected Environment _EndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_DefinedMaxTime")]
    [Metadata("Generic String", "", false, false, true, "String", 16778852, false, false, false, null)]
    protected Environment _DefinedMaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_TimerCompletionStatusName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778692, false, false, false, null)]
    protected Environment _TimerCompletionStatusName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778640, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerHistoryDetail_Environment_ProcessTimerName")]
    protected Environment _ProcessTimerName;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Environment DefinedMinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefinedMinTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefinedMinTime));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Environment DefinedMaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefinedMaxTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefinedMaxTime));
      }
    }

    public Environment TimerCompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerCompletionStatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimerCompletionStatusName));
      }
    }

    public Environment ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerName));
      }
    }
  }
}
