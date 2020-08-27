// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecurringDateReqChanges_Info
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
  public class RecurringDateReqChanges_Info : MaintenanceReqChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_DayOfWeek")]
    protected Info _DayOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_MonthOfYear")]
    protected Info _MonthOfYear;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_RecurringDatePattern")]
    protected Info _RecurringDatePattern;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_RecurringDateType")]
    protected Info _RecurringDateType;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_EndDate")]
    protected Info _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_DayOfMonth")]
    protected Info _DayOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_SeedDate")]
    protected Info _SeedDate;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_Occurrences")]
    protected Info _Occurrences;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_Frequency")]
    protected Info _Frequency;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_WarningPeriod")]
    protected Info _WarningPeriod;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqChanges_Info_TolerancePeriod")]
    protected Info _TolerancePeriod;

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

    public Info RecurringDatePattern
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurringDatePattern), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecurringDatePattern));
      }
    }

    public Info RecurringDateType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecurringDateType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecurringDateType));
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

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
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

    public Info SeedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SeedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SeedDate));
      }
    }

    public Info Occurrences
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occurrences), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Occurrences));
      }
    }

    public Info Frequency
    {
      [param: In] set
      {
        this.PropertySet(nameof (Frequency), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Frequency));
      }
    }

    public Info WarningPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningPeriod), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WarningPeriod));
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

    public Info TolerancePeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (TolerancePeriod), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TolerancePeriod));
      }
    }
  }
}
