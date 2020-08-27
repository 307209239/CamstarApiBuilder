// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteDateHistoryDetails_Info
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
  public class CompleteDateHistoryDetails_Info : CompleteMaintHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Info_ScheduleDateLimitGMT")]
    protected Info _ScheduleDateLimitGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Info_ScheduleDateWarningGMT")]
    protected Info _ScheduleDateWarningGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Info_ScheduleDateWarning")]
    protected Info _ScheduleDateWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Info_ScheduleDateGMT")]
    protected Info _ScheduleDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Info_ScheduleDate")]
    protected Info _ScheduleDate;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_Info_ScheduleDateLimit")]
    protected Info _ScheduleDateLimit;

    public Info ScheduleDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateLimitGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDateLimitGMT));
      }
    }

    public Info ScheduleDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateWarningGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDateWarningGMT));
      }
    }

    public Info ScheduleDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateWarning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDateWarning));
      }
    }

    public Info ScheduleDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDateGMT));
      }
    }

    public Info ScheduleDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDate));
      }
    }

    public Info ScheduleDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDateLimit));
      }
    }
  }
}
