// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgCalendarChanges_Info
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
  public class MfgCalendarChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Info_MfgCalendarShifts")]
    protected CalendarShiftChanges_Info _MfgCalendarShifts;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Info_MaxShiftDuration")]
    protected Info _MaxShiftDuration;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Info_Name")]
    protected new Info _Name;

    public CalendarShiftChanges_Info MfgCalendarShifts
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendarShifts), (object) value);
      }
      get
      {
        return (CalendarShiftChanges_Info) this.PropertyGet(nameof (MfgCalendarShifts));
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

    public Info MaxShiftDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxShiftDuration), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxShiftDuration));
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
