// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgCalendarChanges
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
  public class MfgCalendarChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_MfgCalendarShifts")]
    protected CalendarShiftChanges[] _MfgCalendarShifts;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_MaxShiftDuration")]
    protected Primitive<double> _MaxShiftDuration;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is MfgCalendarChanges && this.CompareArrays((Array) this._MfgCalendarShifts, (Array) ((MfgCalendarChanges) obj)._MfgCalendarShifts) && (object.Equals((object) this._ObjectToChange, (object) ((MfgCalendarChanges) obj)._ObjectToChange) && object.Equals((object) this._MaxShiftDuration, (object) ((MfgCalendarChanges) obj)._MaxShiftDuration)) && object.Equals((object) this._Name, (object) ((MfgCalendarChanges) obj)._Name) && base.Equals(obj);
    }

    public CalendarShiftChanges[] MfgCalendarShifts
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendarShifts), (object) value);
      }
      get
      {
        return (CalendarShiftChanges[]) this.PropertyGet(nameof (MfgCalendarShifts));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<double> MaxShiftDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxShiftDuration), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MaxShiftDuration));
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
  }
}
