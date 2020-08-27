// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DateReqChanges_Info
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
  public class DateReqChanges_Info : MaintenanceReqChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Info_ScheduleDate")]
    protected Info _ScheduleDate;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Info_WarningPeriod")]
    protected Info _WarningPeriod;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Info_TolerancePeriod")]
    protected Info _TolerancePeriod;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Info_Name")]
    protected new Info _Name;

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

    public Info ScheduleDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDate));
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
