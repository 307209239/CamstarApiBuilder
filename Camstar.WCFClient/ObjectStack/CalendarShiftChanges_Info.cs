// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CalendarShiftChanges_Info
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
  public class CalendarShiftChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_Shift")]
    protected Info _Shift;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_Team")]
    protected Info _Team;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_ShiftStart")]
    protected Info _ShiftStart;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_ShiftEnd")]
    protected Info _ShiftEnd;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_FiscalQuarter")]
    protected Info _FiscalQuarter;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_FiscalMonth")]
    protected Info _FiscalMonth;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_CalendarDate")]
    protected Info _CalendarDate;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_FiscalYear")]
    protected Info _FiscalYear;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_FiscalWeek")]
    protected Info _FiscalWeek;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info Shift
    {
      [param: In] set
      {
        this.PropertySet(nameof (Shift), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Shift));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info Team
    {
      [param: In] set
      {
        this.PropertySet(nameof (Team), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Team));
      }
    }

    public Info ShiftStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftStart), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShiftStart));
      }
    }

    public Info ShiftEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftEnd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShiftEnd));
      }
    }

    public Info FiscalQuarter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalQuarter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FiscalQuarter));
      }
    }

    public Info FiscalMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalMonth), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FiscalMonth));
      }
    }

    public Info CalendarDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalendarDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CalendarDate));
      }
    }

    public Info FiscalYear
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalYear), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FiscalYear));
      }
    }

    public Info FiscalWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalWeek), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FiscalWeek));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
