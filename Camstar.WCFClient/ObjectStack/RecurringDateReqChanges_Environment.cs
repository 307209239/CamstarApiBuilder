// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecurringDateReqChanges_Environment
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
  public class RecurringDateReqChanges_Environment : MaintenanceReqChanges_Environment
  {
    [Metadata("The day of the week.", "DayOfWeekEnum", false, false, false, "Integer", 1050698, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_DayOfWeek")]
    protected Environment _DayOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_MonthOfYear")]
    [Metadata("List of months.", "MonthEnum", false, false, false, "Integer", 1050688, false, false, true, null)]
    protected Environment _MonthOfYear;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_RecurringDatePattern")]
    [Metadata("Defines the interval on which a maintenance schedule will be performed.", "RecurringDatePatternEnum", false, true, false, "Integer", 1050647, false, false, true, null)]
    protected Environment _RecurringDatePattern;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_RecurringDateType")]
    [Metadata("Defines the type of schedule that will be used for maintence event.", "RecurringDateTypeEnum", false, false, false, "Integer", 1050690, false, false, true, null)]
    protected Environment _RecurringDateType;
    [Metadata("Defines a maintenance requirement schedule based on calendar dates comprised on one or more dates.  The maintenance event must occur on the scheduled date and each following maintenance event must be followed independently of when the previous maintenance event occured.", "RecurringDateReq", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Defines a maintenance requirement schedule based on calendar dates comprised on one or more dates.  The maintenance event must occur on the scheduled date and each following maintenance event must be followed independently of when the previous maintenance event occured.", "RecurringDateReqBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_EndDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050699, false, false, false, null)]
    protected Environment _EndDate;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050685, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_DayOfMonth")]
    protected Environment _DayOfMonth;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050691, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_SeedDate")]
    protected Environment _SeedDate;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_Occurrences")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050689, false, false, false, null)]
    protected Environment _Occurrences;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1050687, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_Frequency")]
    protected Environment _Frequency;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1050683, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_WarningPeriod")]
    protected Environment _WarningPeriod;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050692, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1050682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Environment_TolerancePeriod")]
    protected Environment _TolerancePeriod;

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

    public Environment RecurringDatePattern
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurringDatePattern), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecurringDatePattern));
      }
    }

    public Environment RecurringDateType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurringDateType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecurringDateType));
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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
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

    public Environment SeedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SeedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SeedDate));
      }
    }

    public Environment Occurrences
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occurrences), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Occurrences));
      }
    }

    public Environment Frequency
    {
      [param: In] set
      {
        this.PropertySet(nameof (Frequency), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Frequency));
      }
    }

    public Environment WarningPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningPeriod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WarningPeriod));
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

    public Environment TolerancePeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (TolerancePeriod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TolerancePeriod));
      }
    }
  }
}
