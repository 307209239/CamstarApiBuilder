// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DateReqChanges
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
  public class DateReqChanges : MaintenanceReqChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_ScheduleDate")]
    protected Primitive<DateTime> _ScheduleDate;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_WarningPeriod")]
    protected Primitive<double> _WarningPeriod;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_TolerancePeriod")]
    protected Primitive<double> _TolerancePeriod;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DateReqChanges && object.Equals((object) this._ObjectToChange, (object) ((DateReqChanges) obj)._ObjectToChange) && (object.Equals((object) this._Base, (object) ((DateReqChanges) obj)._Base) && object.Equals((object) this._ScheduleDate, (object) ((DateReqChanges) obj)._ScheduleDate)) && (object.Equals((object) this._WarningPeriod, (object) ((DateReqChanges) obj)._WarningPeriod) && object.Equals((object) this._TolerancePeriod, (object) ((DateReqChanges) obj)._TolerancePeriod) && object.Equals((object) this._Name, (object) ((DateReqChanges) obj)._Name)) && base.Equals(obj);
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

    public Primitive<DateTime> ScheduleDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ScheduleDate));
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
