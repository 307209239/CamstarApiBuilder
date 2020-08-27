// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteDateHistoryDetails_Environment
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
  public class CompleteDateHistoryDetails_Environment : CompleteMaintHistoryDetails_Environment
  {
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052547, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Environment_ScheduleDateLimitGMT")]
    protected Environment _ScheduleDateLimitGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052548, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Environment_ScheduleDateWarningGMT")]
    protected Environment _ScheduleDateWarningGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050753, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Environment_ScheduleDateWarning")]
    protected Environment _ScheduleDateWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Environment_ScheduleDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052539, false, false, false, null)]
    protected Environment _ScheduleDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Environment_ScheduleDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050681, false, false, false, null)]
    protected Environment _ScheduleDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050752, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Environment_ScheduleDateLimit")]
    protected Environment _ScheduleDateLimit;

    public Environment ScheduleDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateLimitGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDateLimitGMT));
      }
    }

    public Environment ScheduleDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateWarningGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDateWarningGMT));
      }
    }

    public Environment ScheduleDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateWarning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDateWarning));
      }
    }

    public Environment ScheduleDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDateGMT));
      }
    }

    public Environment ScheduleDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDate));
      }
    }

    public Environment ScheduleDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDateLimit));
      }
    }
  }
}
