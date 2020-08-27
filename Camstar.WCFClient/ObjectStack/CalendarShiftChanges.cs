// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CalendarShiftChanges
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
  public class CalendarShiftChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Shift")]
    protected NamedObjectRef _Shift;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Team")]
    protected NamedObjectRef _Team;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_ShiftStart")]
    protected Primitive<DateTime> _ShiftStart;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_ShiftEnd")]
    protected Primitive<DateTime> _ShiftEnd;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_FiscalQuarter")]
    protected Primitive<int> _FiscalQuarter;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_FiscalMonth")]
    protected Primitive<int> _FiscalMonth;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_CalendarDate")]
    protected Primitive<DateTime> _CalendarDate;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_FiscalYear")]
    protected Primitive<int> _FiscalYear;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_FiscalWeek")]
    protected Primitive<int> _FiscalWeek;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is CalendarShiftChanges && object.Equals((object) this._Shift, (object) ((CalendarShiftChanges) obj)._Shift) && (object.Equals((object) this._ListItemToChange, (object) ((CalendarShiftChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((CalendarShiftChanges) obj)._ObjectToChange)) && (object.Equals((object) this._Team, (object) ((CalendarShiftChanges) obj)._Team) && object.Equals((object) this._ShiftStart, (object) ((CalendarShiftChanges) obj)._ShiftStart) && (object.Equals((object) this._ShiftEnd, (object) ((CalendarShiftChanges) obj)._ShiftEnd) && object.Equals((object) this._FiscalQuarter, (object) ((CalendarShiftChanges) obj)._FiscalQuarter))) && (object.Equals((object) this._FiscalMonth, (object) ((CalendarShiftChanges) obj)._FiscalMonth) && object.Equals((object) this._CalendarDate, (object) ((CalendarShiftChanges) obj)._CalendarDate) && (object.Equals((object) this._FiscalYear, (object) ((CalendarShiftChanges) obj)._FiscalYear) && object.Equals((object) this._FiscalWeek, (object) ((CalendarShiftChanges) obj)._FiscalWeek)) && object.Equals((object) this._IsFrozen, (object) ((CalendarShiftChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public NamedObjectRef Shift
    {
      [param: In] set
      {
        this.PropertySet(nameof (Shift), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Shift));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef Team
    {
      [param: In] set
      {
        this.PropertySet(nameof (Team), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Team));
      }
    }

    public Primitive<DateTime> ShiftStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftStart), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ShiftStart));
      }
    }

    public Primitive<DateTime> ShiftEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftEnd), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ShiftEnd));
      }
    }

    public Primitive<int> FiscalQuarter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalQuarter), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FiscalQuarter));
      }
    }

    public Primitive<int> FiscalMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalMonth), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FiscalMonth));
      }
    }

    public Primitive<DateTime> CalendarDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalendarDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CalendarDate));
      }
    }

    public Primitive<int> FiscalYear
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalYear), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FiscalYear));
      }
    }

    public Primitive<int> FiscalWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalWeek), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FiscalWeek));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
