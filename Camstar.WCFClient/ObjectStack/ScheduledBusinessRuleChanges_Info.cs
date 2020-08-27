// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScheduledBusinessRuleChanges_Info
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
  public class ScheduledBusinessRuleChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ScheduleMonths")]
    protected Info _ScheduleMonths;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_DayOfWeek")]
    protected Info _DayOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_MonthOfYear")]
    protected Info _MonthOfYear;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ScheduleHours")]
    protected Info _ScheduleHours;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ScheduleDaysOfMonth")]
    protected Info _ScheduleDaysOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ScheduleDaysOfWeek")]
    protected Info _ScheduleDaysOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ExecutionContextType")]
    protected Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_OnExecute")]
    protected Info _OnExecute;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_RecurrencePattern")]
    protected Info _RecurrencePattern;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_EndDateGMT")]
    protected Info _EndDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_IsLastDayOfMonth")]
    protected Info _IsLastDayOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_EndDate")]
    protected Info _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_DueTimeGMT")]
    protected Info _DueTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_DayOfMonth")]
    protected Info _DayOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_IsAdvancedMode")]
    protected Info _IsAdvancedMode;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_RecurrenceCount")]
    protected Info _RecurrenceCount;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ExecutionContext")]
    protected Info _ExecutionContext;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_DueTime")]
    protected Info _DueTime;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_ExecutionContextId")]
    protected Info _ExecutionContextId;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_StartDate")]
    protected Info _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_StartDateGMT")]
    protected Info _StartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_IsSystemDefined")]
    protected Info _IsSystemDefined;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_RecurrenceFrequency")]
    protected Info _RecurrenceFrequency;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Info_Name")]
    protected new Info _Name;

    public Info ScheduleMonths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleMonths), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleMonths));
      }
    }

    public Info DayOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (DayOfWeek), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DayOfWeek));
      }
    }

    public Info MonthOfYear
    {
      [param: In] set
      {
        this.PropertySet(nameof (MonthOfYear), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MonthOfYear));
      }
    }

    public Info ScheduleHours
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleHours), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleHours));
      }
    }

    public Info ScheduleDaysOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfMonth), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDaysOfMonth));
      }
    }

    public Info ScheduleDaysOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfWeek), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDaysOfWeek));
      }
    }

    public Info ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info OnExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnExecute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnExecute));
      }
    }

    public Info RecurrencePattern
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrencePattern), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecurrencePattern));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Info IsLastDayOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLastDayOfMonth), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsLastDayOfMonth));
      }
    }

    public Info EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDate));
      }
    }

    public Info DueTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueTimeGMT));
      }
    }

    public Info DayOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (DayOfMonth), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DayOfMonth));
      }
    }

    public Info IsAdvancedMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAdvancedMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsAdvancedMode));
      }
    }

    public Info RecurrenceCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrenceCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecurrenceCount));
      }
    }

    public Info ExecutionContext
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContext), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionContext));
      }
    }

    public Info DueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueTime));
      }
    }

    public Info ExecutionContextId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionContextId));
      }
    }

    public Info StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartDate));
      }
    }

    public Info StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Info IsSystemDefined
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSystemDefined), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsSystemDefined));
      }
    }

    public Info RecurrenceFrequency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrenceFrequency), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecurrenceFrequency));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
