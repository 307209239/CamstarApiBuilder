// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScheduledBusinessRuleChanges_Environment
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
  public class ScheduledBusinessRuleChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ScheduleMonths")]
    [Metadata("Comments", "", false, false, false, "String", 1052722, false, false, false, null)]
    protected Environment _ScheduleMonths;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_DayOfWeek")]
    [Metadata("The day of the week.", "DayOfWeekEnum", false, false, false, "Integer", 1050644, false, false, true, null)]
    protected Environment _DayOfWeek;
    [Metadata("List of months.", "MonthEnum", false, false, false, "Integer", 1050688, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_MonthOfYear")]
    protected Environment _MonthOfYear;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ScheduleHours")]
    [Metadata("Comments", "", false, false, false, "String", 1052721, false, false, false, null)]
    protected Environment _ScheduleHours;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ScheduleDaysOfMonth")]
    [Metadata("Comments", "", false, false, false, "String", 1052719, false, false, false, null)]
    protected Environment _ScheduleDaysOfMonth;
    [Metadata("Comments", "", false, false, false, "String", 1052720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ScheduleDaysOfWeek")]
    protected Environment _ScheduleDaysOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ExecutionContextType")]
    [Metadata("CDOType", "", false, true, false, "Integer", 1049631, false, false, true, null)]
    protected Environment _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_Status")]
    [Metadata("Enumeration for the Scheduled Business Rule Status:\r\n1 = Pending\r\n2 = InProcess\r\n3 = OnHold", "ScheduledBizRuleStatusEnum", false, false, true, "Integer", 1048671, false, false, true, "1")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_OnExecute")]
    [Metadata("Business Rule", "BusinessRule", false, true, false, "NamedObjectRef", 1051287, false, false, true, null)]
    protected Environment _OnExecute;
    [Metadata("Scheduler Recurrence Pattern", "SchedulerRecurrencePatternEnum", false, false, false, "Integer", 1051289, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_RecurrencePattern")]
    protected Environment _RecurrencePattern;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ObjectToChange")]
    [Metadata("Scheduled Business Rule", "ScheduledBusinessRule", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_EndDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051247, false, false, false, null)]
    protected Environment _EndDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_IsLastDayOfMonth")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051245, false, false, false, "0")]
    protected Environment _IsLastDayOfMonth;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049310, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_EndDate")]
    protected Environment _EndDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050944, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_DueTimeGMT")]
    protected Environment _DueTimeGMT;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050685, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_DayOfMonth")]
    protected Environment _DayOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_IsAdvancedMode")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778417, false, false, false, "0")]
    protected Environment _IsAdvancedMode;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051290, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_RecurrenceCount")]
    protected Environment _RecurrenceCount;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ExecutionContext")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1051288, false, false, false, null)]
    protected Environment _ExecutionContext;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_DueTime")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050943, false, false, false, null)]
    protected Environment _DueTime;
    [Metadata("Generic String", "", false, true, false, "String", 1051288, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_ExecutionContextId")]
    protected Environment _ExecutionContextId;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049313, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_StartDate")]
    protected Environment _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_StartDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051246, false, false, false, null)]
    protected Environment _StartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_IsSystemDefined")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051248, false, false, false, "0")]
    protected Environment _IsSystemDefined;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_RecurrenceFrequency")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050687, false, false, false, null)]
    protected Environment _RecurrenceFrequency;
    [DataMember(EmitDefaultValue = false, Name = "ScheduledBusinessRuleChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052256, false, false, false, null)]
    protected new Environment _Name;

    public Environment ScheduleMonths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleMonths), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleMonths));
      }
    }

    public Environment DayOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (DayOfWeek), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DayOfWeek));
      }
    }

    public Environment MonthOfYear
    {
      [param: In] set
      {
        this.PropertySet(nameof (MonthOfYear), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MonthOfYear));
      }
    }

    public Environment ScheduleHours
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleHours), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleHours));
      }
    }

    public Environment ScheduleDaysOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfMonth), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDaysOfMonth));
      }
    }

    public Environment ScheduleDaysOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfWeek), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDaysOfWeek));
      }
    }

    public Environment ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment OnExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnExecute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OnExecute));
      }
    }

    public Environment RecurrencePattern
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrencePattern), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecurrencePattern));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Environment IsLastDayOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLastDayOfMonth), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsLastDayOfMonth));
      }
    }

    public Environment EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDate));
      }
    }

    public Environment DueTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueTimeGMT));
      }
    }

    public Environment DayOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (DayOfMonth), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DayOfMonth));
      }
    }

    public Environment IsAdvancedMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAdvancedMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsAdvancedMode));
      }
    }

    public Environment RecurrenceCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrenceCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecurrenceCount));
      }
    }

    public Environment ExecutionContext
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContext), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionContext));
      }
    }

    public Environment DueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueTime));
      }
    }

    public Environment ExecutionContextId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionContextId));
      }
    }

    public Environment StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartDate));
      }
    }

    public Environment StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Environment IsSystemDefined
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSystemDefined), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsSystemDefined));
      }
    }

    public Environment RecurrenceFrequency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurrenceFrequency), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecurrenceFrequency));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
