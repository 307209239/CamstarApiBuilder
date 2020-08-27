// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DateReqChanges_Environment
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
  public class DateReqChanges_Environment : MaintenanceReqChanges_Environment
  {
    [Metadata("Defines a maintenance requirement schedule based on a date when maintenance is to be performed.", "DateReq", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Defines a maintenance requirement schedule based on a date when maintenance is to be performed.", "DateReqBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Environment_Base")]
    protected new Environment _Base;
    [Metadata("Generic TimeStamp", "", false, true, false, "TimeStamp", 1050681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Environment_ScheduleDate")]
    protected Environment _ScheduleDate;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Environment_WarningPeriod")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1050683, false, false, false, null)]
    protected Environment _WarningPeriod;
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Environment_TolerancePeriod")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1050682, false, false, false, null)]
    protected Environment _TolerancePeriod;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050684, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DateReqChanges_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment ScheduleDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDate));
      }
    }

    public Environment WarningPeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningPeriod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WarningPeriod));
      }
    }

    public Environment TolerancePeriod
    {
      [param: In] set
      {
        this.PropertySet(nameof (TolerancePeriod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TolerancePeriod));
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
