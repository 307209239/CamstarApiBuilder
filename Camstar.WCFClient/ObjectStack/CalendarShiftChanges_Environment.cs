// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CalendarShiftChanges_Environment
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
  public class CalendarShiftChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Typically applies to manufacturing companies that have areas staffed for a long enough during a day that workers do not all start and end their day at the same time.  Shift is a mechanism for grouping production information based on management responsibilities for workers that start and leave at a particular time.  For example, the \"Day\" shift might work from 6am to 6pm, and the \"Night\" shift would work from 6pm to 6am. ", "Shift", false, false, false, "NamedObjectRef", 1049106, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_Shift")]
    protected Environment _Shift;
    [Metadata("The primary feature of the Manufacturing Calendar.  The Manufacturing Calendar contains a collection (list) of \"calendar shifts\".  Each calendar shift starts and ends at a particular calendar date/time, and includes information on which shift, mfg date, etc. to use for this time period.", "CalendarShiftChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_ObjectToChange")]
    [Metadata("The primary feature of the Manufacturing Calendar.  The Manufacturing Calendar contains a collection (list) of \"calendar shifts\".  Each calendar shift starts and ends at a particular calendar date/time, and includes information on which shift, mfg date, etc. to use for this time period.", "CalendarShift", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("An alternate means of grouping production information to \"shift\".  For example, \"day\" and \"night\" shifts that are schedule to work on Monday-Thursday might be assigned to team \"Red\", while day and night shifts that work Friday-Sunday would be assigned to team \"Blues\".", "Team", false, false, false, "NamedObjectRef", 1049944, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_Team")]
    protected Environment _Team;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049943, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_ShiftStart")]
    protected Environment _ShiftStart;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049942, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_ShiftEnd")]
    protected Environment _ShiftEnd;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_FiscalQuarter")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049939, false, false, false, null)]
    protected Environment _FiscalQuarter;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049938, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_FiscalMonth")]
    protected Environment _FiscalMonth;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049937, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_CalendarDate")]
    protected Environment _CalendarDate;
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_FiscalYear")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049941, false, false, false, null)]
    protected Environment _FiscalYear;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049940, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_FiscalWeek")]
    protected Environment _FiscalWeek;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CalendarShiftChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment Shift
    {
      [param: In] set
      {
        this.PropertySet(nameof (Shift), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Shift));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment Team
    {
      [param: In] set
      {
        this.PropertySet(nameof (Team), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Team));
      }
    }

    public Environment ShiftStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftStart), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShiftStart));
      }
    }

    public Environment ShiftEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShiftEnd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShiftEnd));
      }
    }

    public Environment FiscalQuarter
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalQuarter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FiscalQuarter));
      }
    }

    public Environment FiscalMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalMonth), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FiscalMonth));
      }
    }

    public Environment CalendarDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalendarDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CalendarDate));
      }
    }

    public Environment FiscalYear
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalYear), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FiscalYear));
      }
    }

    public Environment FiscalWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (FiscalWeek), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FiscalWeek));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
