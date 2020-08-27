// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgCalendarChanges_Environment
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
  public class MfgCalendarChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("The primary feature of the Manufacturing Calendar.  The Manufacturing Calendar contains a collection (list) of \"calendar shifts\".  Each calendar shift starts and ends at a particular calendar date/time, and includes information on which shift, mfg date, etc. to use for this time period.", "CalendarShiftChanges", false, false, false, "CalendarShiftChanges", 1049936, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Environment_MfgCalendarShifts")]
    protected CalendarShiftChanges_Environment _MfgCalendarShifts;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Environment_ObjectToChange")]
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendar", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Environment_MaxShiftDuration")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1050032, false, false, false, "2.0")]
    protected Environment _MaxShiftDuration;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050067, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Environment_Name")]
    protected new Environment _Name;

    public CalendarShiftChanges_Environment MfgCalendarShifts
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendarShifts), (object) value);
      }
      get
      {
        return (CalendarShiftChanges_Environment) this.PropertyGet(nameof (MfgCalendarShifts));
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

    public Environment MaxShiftDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxShiftDuration), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxShiftDuration));
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
