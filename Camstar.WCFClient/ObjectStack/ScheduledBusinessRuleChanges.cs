// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScheduledBusinessRuleChanges
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
  public class ScheduledBusinessRuleChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ScheduleMonths")]
    protected Primitive<string> _ScheduleMonths;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_DayOfWeek")]
    protected Enumeration<DayOfWeekEnum, int> _DayOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_MonthOfYear")]
    protected Enumeration<MonthEnum, int> _MonthOfYear;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ScheduleHours")]
    protected Primitive<string> _ScheduleHours;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ScheduleDaysOfMonth")]
    protected Primitive<string> _ScheduleDaysOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ScheduleDaysOfWeek")]
    protected Primitive<string> _ScheduleDaysOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ExecutionContextType")]
    protected Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Status")]
    protected Enumeration<ScheduledBizRuleStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_OnExecute")]
    protected NamedObjectRef _OnExecute;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_RecurrencePattern")]
    protected Enumeration<SchedulerRecurrencePatternEnum, int> _RecurrencePattern;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_EndDateGMT")]
    protected Primitive<DateTime> _EndDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_IsLastDayOfMonth")]
    protected Primitive<bool> _IsLastDayOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_EndDate")]
    protected Primitive<DateTime> _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_DueTimeGMT")]
    protected Primitive<DateTime> _DueTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_DayOfMonth")]
    protected Primitive<int> _DayOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_IsAdvancedMode")]
    protected Primitive<bool> _IsAdvancedMode;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_RecurrenceCount")]
    protected Primitive<int> _RecurrenceCount;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ExecutionContext")]
    protected BaseObjectRef _ExecutionContext;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_DueTime")]
    protected Primitive<DateTime> _DueTime;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_ExecutionContextId")]
    protected Primitive<string> _ExecutionContextId;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_StartDate")]
    protected Primitive<DateTime> _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_StartDateGMT")]
    protected Primitive<DateTime> _StartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_IsSystemDefined")]
    protected Primitive<bool> _IsSystemDefined;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_RecurrenceFrequency")]
    protected Primitive<int> _RecurrenceFrequency;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ScheduledBusinessRuleChanges && object.Equals((object) this._ScheduleMonths, (object) ((ScheduledBusinessRuleChanges) obj)._ScheduleMonths) && (object.Equals((object) this._DayOfWeek, (object) ((ScheduledBusinessRuleChanges) obj)._DayOfWeek) && object.Equals((object) this._MonthOfYear, (object) ((ScheduledBusinessRuleChanges) obj)._MonthOfYear)) && (object.Equals((object) this._ScheduleHours, (object) ((ScheduledBusinessRuleChanges) obj)._ScheduleHours) && object.Equals((object) this._ScheduleDaysOfMonth, (object) ((ScheduledBusinessRuleChanges) obj)._ScheduleDaysOfMonth) && (object.Equals((object) this._ScheduleDaysOfWeek, (object) ((ScheduledBusinessRuleChanges) obj)._ScheduleDaysOfWeek) && object.Equals((object) this._ExecutionContextType, (object) ((ScheduledBusinessRuleChanges) obj)._ExecutionContextType))) && (object.Equals((object) this._Status, (object) ((ScheduledBusinessRuleChanges) obj)._Status) && object.Equals((object) this._OnExecute, (object) ((ScheduledBusinessRuleChanges) obj)._OnExecute) && (object.Equals((object) this._RecurrencePattern, (object) ((ScheduledBusinessRuleChanges) obj)._RecurrencePattern) && object.Equals((object) this._ObjectToChange, (object) ((ScheduledBusinessRuleChanges) obj)._ObjectToChange)) && (object.Equals((object) this._EndDateGMT, (object) ((ScheduledBusinessRuleChanges) obj)._EndDateGMT) && object.Equals((object) this._IsLastDayOfMonth, (object) ((ScheduledBusinessRuleChanges) obj)._IsLastDayOfMonth) && (object.Equals((object) this._EndDate, (object) ((ScheduledBusinessRuleChanges) obj)._EndDate) && object.Equals((object) this._DueTimeGMT, (object) ((ScheduledBusinessRuleChanges) obj)._DueTimeGMT)))) && (object.Equals((object) this._DayOfMonth, (object) ((ScheduledBusinessRuleChanges) obj)._DayOfMonth) && object.Equals((object) this._IsAdvancedMode, (object) ((ScheduledBusinessRuleChanges) obj)._IsAdvancedMode) && (object.Equals((object) this._RecurrenceCount, (object) ((ScheduledBusinessRuleChanges) obj)._RecurrenceCount) && object.Equals((object) this._ExecutionContext, (object) ((ScheduledBusinessRuleChanges) obj)._ExecutionContext)) && (object.Equals((object) this._DueTime, (object) ((ScheduledBusinessRuleChanges) obj)._DueTime) && object.Equals((object) this._ExecutionContextId, (object) ((ScheduledBusinessRuleChanges) obj)._ExecutionContextId) && (object.Equals((object) this._StartDate, (object) ((ScheduledBusinessRuleChanges) obj)._StartDate) && object.Equals((object) this._StartDateGMT, (object) ((ScheduledBusinessRuleChanges) obj)._StartDateGMT))) && (object.Equals((object) this._IsSystemDefined, (object) ((ScheduledBusinessRuleChanges) obj)._IsSystemDefined) && object.Equals((object) this._RecurrenceFrequency, (object) ((ScheduledBusinessRuleChanges) obj)._RecurrenceFrequency) && object.Equals((object) this._Name, (object) ((ScheduledBusinessRuleChanges) obj)._Name))) && base.Equals(obj);
    }

    public Primitive<string> ScheduleMonths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleMonths), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleMonths));
      }
    }

    public Enumeration<DayOfWeekEnum, int> DayOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (DayOfWeek), (object) value);
      }
      get
      {
        return (Enumeration<DayOfWeekEnum, int>) this.PropertyGet(nameof (DayOfWeek));
      }
    }

    public Enumeration<MonthEnum, int> MonthOfYear
    {
      [param: In] set
      {
        this.PropertySet(nameof (MonthOfYear), (object) value);
      }
      get
      {
        return (Enumeration<MonthEnum, int>) this.PropertyGet(nameof (MonthOfYear));
      }
    }

    public Primitive<string> ScheduleHours
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleHours), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleHours));
      }
    }

    public Primitive<string> ScheduleDaysOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfMonth), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleDaysOfMonth));
      }
    }

    public Primitive<string> ScheduleDaysOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfWeek), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleDaysOfWeek));
      }
    }

    public Primitive<int> ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public Enumeration<ScheduledBizRuleStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ScheduledBizRuleStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public NamedObjectRef OnExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnExecute), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OnExecute));
      }
    }

    public Enumeration<SchedulerRecurrencePatternEnum, int> RecurrencePattern
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrencePattern), (object) value);
      }
      get
      {
        return (Enumeration<SchedulerRecurrencePatternEnum, int>) this.PropertyGet(nameof (RecurrencePattern));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<DateTime> EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Primitive<bool> IsLastDayOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLastDayOfMonth), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsLastDayOfMonth));
      }
    }

    public Primitive<DateTime> EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDate));
      }
    }

    public Primitive<DateTime> DueTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueTimeGMT));
      }
    }

    public Primitive<int> DayOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (DayOfMonth), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DayOfMonth));
      }
    }

    public Primitive<bool> IsAdvancedMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAdvancedMode), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsAdvancedMode));
      }
    }

    public Primitive<int> RecurrenceCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrenceCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RecurrenceCount));
      }
    }

    public BaseObjectRef ExecutionContext
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContext), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ExecutionContext));
      }
    }

    public Primitive<DateTime> DueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueTime), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueTime));
      }
    }

    public Primitive<string> ExecutionContextId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExecutionContextId));
      }
    }

    public Primitive<DateTime> StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartDate));
      }
    }

    public Primitive<DateTime> StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Primitive<bool> IsSystemDefined
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSystemDefined), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsSystemDefined));
      }
    }

    public Primitive<int> RecurrenceFrequency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrenceFrequency), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RecurrenceFrequency));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
