// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteDateHistoryDetails
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
  public class CompleteDateHistoryDetails : CompleteMaintHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_ScheduleDateLimitGMT")]
    protected Primitive<DateTime> _ScheduleDateLimitGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_ScheduleDateWarningGMT")]
    protected Primitive<DateTime> _ScheduleDateWarningGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_ScheduleDateWarning")]
    protected Primitive<DateTime> _ScheduleDateWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_ScheduleDateGMT")]
    protected Primitive<DateTime> _ScheduleDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_ScheduleDate")]
    protected Primitive<DateTime> _ScheduleDate;
    [DataMember(EmitDefaultValue = false, Name = "CompleteDateHistoryDetails_ScheduleDateLimit")]
    protected Primitive<DateTime> _ScheduleDateLimit;

    public override bool Equals(object obj)
    {
      return obj is CompleteDateHistoryDetails && object.Equals((object) this._ScheduleDateLimitGMT, (object) ((CompleteDateHistoryDetails) obj)._ScheduleDateLimitGMT) && (object.Equals((object) this._ScheduleDateWarningGMT, (object) ((CompleteDateHistoryDetails) obj)._ScheduleDateWarningGMT) && object.Equals((object) this._ScheduleDateWarning, (object) ((CompleteDateHistoryDetails) obj)._ScheduleDateWarning)) && (object.Equals((object) this._ScheduleDateGMT, (object) ((CompleteDateHistoryDetails) obj)._ScheduleDateGMT) && object.Equals((object) this._ScheduleDate, (object) ((CompleteDateHistoryDetails) obj)._ScheduleDate) && object.Equals((object) this._ScheduleDateLimit, (object) ((CompleteDateHistoryDetails) obj)._ScheduleDateLimit)) && base.Equals(obj);
    }

    public Primitive<DateTime> ScheduleDateLimitGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateLimitGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ScheduleDateLimitGMT));
      }
    }

    public Primitive<DateTime> ScheduleDateWarningGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateWarningGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ScheduleDateWarningGMT));
      }
    }

    public Primitive<DateTime> ScheduleDateWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateWarning), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ScheduleDateWarning));
      }
    }

    public Primitive<DateTime> ScheduleDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ScheduleDateGMT));
      }
    }

    public Primitive<DateTime> ScheduleDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ScheduleDate));
      }
    }

    public Primitive<DateTime> ScheduleDateLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDateLimit), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ScheduleDateLimit));
      }
    }
  }
}
