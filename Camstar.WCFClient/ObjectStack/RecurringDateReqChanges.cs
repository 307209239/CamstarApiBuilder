// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecurringDateReqChanges
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
  public class RecurringDateReqChanges : MaintenanceReqChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_DayOfWeek")]
    protected Enumeration<DayOfWeekEnum, int> _DayOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_MonthOfYear")]
    protected Enumeration<MonthEnum, int> _MonthOfYear;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_RecurringDatePattern")]
    protected Enumeration<RecurringDatePatternEnum, int> _RecurringDatePattern;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_RecurringDateType")]
    protected Enumeration<RecurringDateTypeEnum, int> _RecurringDateType;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_EndDate")]
    protected Primitive<DateTime> _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_DayOfMonth")]
    protected Primitive<int> _DayOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_SeedDate")]
    protected Primitive<DateTime> _SeedDate;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Occurrences")]
    protected Primitive<int> _Occurrences;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Frequency")]
    protected Primitive<int> _Frequency;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_WarningPeriod")]
    protected Primitive<double> _WarningPeriod;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_TolerancePeriod")]
    protected Primitive<double> _TolerancePeriod;

    public override bool Equals(object obj)
    {
      return obj is RecurringDateReqChanges && object.Equals((object) this._DayOfWeek, (object) ((RecurringDateReqChanges) obj)._DayOfWeek) && (object.Equals((object) this._MonthOfYear, (object) ((RecurringDateReqChanges) obj)._MonthOfYear) && object.Equals((object) this._RecurringDatePattern, (object) ((RecurringDateReqChanges) obj)._RecurringDatePattern)) && (object.Equals((object) this._RecurringDateType, (object) ((RecurringDateReqChanges) obj)._RecurringDateType) && object.Equals((object) this._ObjectToChange, (object) ((RecurringDateReqChanges) obj)._ObjectToChange) && (object.Equals((object) this._Base, (object) ((RecurringDateReqChanges) obj)._Base) && object.Equals((object) this._EndDate, (object) ((RecurringDateReqChanges) obj)._EndDate))) && (object.Equals((object) this._DayOfMonth, (object) ((RecurringDateReqChanges) obj)._DayOfMonth) && object.Equals((object) this._SeedDate, (object) ((RecurringDateReqChanges) obj)._SeedDate) && (object.Equals((object) this._Occurrences, (object) ((RecurringDateReqChanges) obj)._Occurrences) && object.Equals((object) this._Frequency, (object) ((RecurringDateReqChanges) obj)._Frequency)) && (object.Equals((object) this._WarningPeriod, (object) ((RecurringDateReqChanges) obj)._WarningPeriod) && object.Equals((object) this._Name, (object) ((RecurringDateReqChanges) obj)._Name) && object.Equals((object) this._TolerancePeriod, (object) ((RecurringDateReqChanges) obj)._TolerancePeriod))) && base.Equals(obj);
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

    public Enumeration<RecurringDatePatternEnum, int> RecurringDatePattern
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurringDatePattern), (object) value);
      }
      get
      {
        return (Enumeration<RecurringDatePatternEnum, int>) this.PropertyGet(nameof (RecurringDatePattern));
      }
    }

    public Enumeration<RecurringDateTypeEnum, int> RecurringDateType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurringDateType), (object) value);
      }
      get
      {
        return (Enumeration<RecurringDateTypeEnum, int>) this.PropertyGet(nameof (RecurringDateType));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
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

    public Primitive<DateTime> SeedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SeedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (SeedDate));
      }
    }

    public Primitive<int> Occurrences
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occurrences), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Occurrences));
      }
    }

    public Primitive<int> Frequency
    {
      [param: In] set
      {
        this.PropertySet(nameof (Frequency), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Frequency));
      }
    }

    public Primitive<double> WarningPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningPeriod), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (WarningPeriod));
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

    public Primitive<double> TolerancePeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (TolerancePeriod), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TolerancePeriod));
      }
    }
  }
}
