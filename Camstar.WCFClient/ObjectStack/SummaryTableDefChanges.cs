// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SummaryTableDefChanges
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
  public class SummaryTableDefChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_ScheduleMonths")]
    protected Primitive<string> _ScheduleMonths;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_ScheduleHours")]
    protected Primitive<string> _ScheduleHours;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_SummarySQL")]
    protected Primitive<string> _SummarySQL;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_ScheduleDaysOfWeek")]
    protected Primitive<string> _ScheduleDaysOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_ScheduleDaysOfMonth")]
    protected Primitive<string> _ScheduleDaysOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_LastRunElapsedSeconds")]
    protected Primitive<int> _LastRunElapsedSeconds;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_IsManuallyExecuted")]
    protected Primitive<bool> _IsManuallyExecuted;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_IsEnabled")]
    protected Primitive<bool> _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_StartDate")]
    protected Primitive<DateTime> _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_NextRunDate")]
    protected Primitive<DateTime> _NextRunDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_LastRunDate")]
    protected Primitive<DateTime> _LastRunDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_AppendToTable")]
    protected Primitive<bool> _AppendToTable;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_TargetSchema")]
    protected Primitive<string> _TargetSchema;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_ForceExecute")]
    protected Primitive<bool> _ForceExecute;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_LastRunSuccess")]
    protected Primitive<bool> _LastRunSuccess;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_IsView")]
    protected Primitive<bool> _IsView;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_ForceRefresh")]
    protected Primitive<bool> _ForceRefresh;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_TargetTableName")]
    protected Primitive<string> _TargetTableName;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_EndDate")]
    protected Primitive<DateTime> _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_LastRunMessage")]
    protected Primitive<string> _LastRunMessage;

    public override bool Equals(object obj)
    {
      return obj is SummaryTableDefChanges && object.Equals((object) this._ScheduleMonths, (object) ((SummaryTableDefChanges) obj)._ScheduleMonths) && (object.Equals((object) this._ScheduleHours, (object) ((SummaryTableDefChanges) obj)._ScheduleHours) && object.Equals((object) this._SummarySQL, (object) ((SummaryTableDefChanges) obj)._SummarySQL)) && (object.Equals((object) this._ScheduleDaysOfWeek, (object) ((SummaryTableDefChanges) obj)._ScheduleDaysOfWeek) && object.Equals((object) this._ScheduleDaysOfMonth, (object) ((SummaryTableDefChanges) obj)._ScheduleDaysOfMonth) && (object.Equals((object) this._ObjectToChange, (object) ((SummaryTableDefChanges) obj)._ObjectToChange) && object.Equals((object) this._LastRunElapsedSeconds, (object) ((SummaryTableDefChanges) obj)._LastRunElapsedSeconds))) && (object.Equals((object) this._IsManuallyExecuted, (object) ((SummaryTableDefChanges) obj)._IsManuallyExecuted) && object.Equals((object) this._IsEnabled, (object) ((SummaryTableDefChanges) obj)._IsEnabled) && (object.Equals((object) this._StartDate, (object) ((SummaryTableDefChanges) obj)._StartDate) && object.Equals((object) this._NextRunDate, (object) ((SummaryTableDefChanges) obj)._NextRunDate)) && (object.Equals((object) this._LastRunDate, (object) ((SummaryTableDefChanges) obj)._LastRunDate) && object.Equals((object) this._AppendToTable, (object) ((SummaryTableDefChanges) obj)._AppendToTable) && (object.Equals((object) this._TargetSchema, (object) ((SummaryTableDefChanges) obj)._TargetSchema) && object.Equals((object) this._ForceExecute, (object) ((SummaryTableDefChanges) obj)._ForceExecute)))) && (object.Equals((object) this._LastRunSuccess, (object) ((SummaryTableDefChanges) obj)._LastRunSuccess) && object.Equals((object) this._IsView, (object) ((SummaryTableDefChanges) obj)._IsView) && (object.Equals((object) this._ForceRefresh, (object) ((SummaryTableDefChanges) obj)._ForceRefresh) && object.Equals((object) this._TargetTableName, (object) ((SummaryTableDefChanges) obj)._TargetTableName)) && (object.Equals((object) this._EndDate, (object) ((SummaryTableDefChanges) obj)._EndDate) && object.Equals((object) this._Name, (object) ((SummaryTableDefChanges) obj)._Name) && object.Equals((object) this._LastRunMessage, (object) ((SummaryTableDefChanges) obj)._LastRunMessage))) && base.Equals(obj);
    }

    public Primitive<string> ScheduleMonths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleMonths), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleMonths));
      }
    }

    public Primitive<string> ScheduleHours
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleHours), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleHours));
      }
    }

    public Primitive<string> SummarySQL
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummarySQL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SummarySQL));
      }
    }

    public Primitive<string> ScheduleDaysOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfWeek), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleDaysOfWeek));
      }
    }

    public Primitive<string> ScheduleDaysOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfMonth), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ScheduleDaysOfMonth));
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

    public Primitive<int> LastRunElapsedSeconds
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunElapsedSeconds), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LastRunElapsedSeconds));
      }
    }

    public Primitive<bool> IsManuallyExecuted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManuallyExecuted), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsManuallyExecuted));
      }
    }

    public Primitive<bool> IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Primitive<DateTime> StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartDate));
      }
    }

    public Primitive<DateTime> NextRunDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextRunDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (NextRunDate));
      }
    }

    public Primitive<DateTime> LastRunDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastRunDate));
      }
    }

    public Primitive<bool> AppendToTable
    {
      [param: In] set
      {
        this.PropertySet(nameof (AppendToTable), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AppendToTable));
      }
    }

    public Primitive<string> TargetSchema
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSchema), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetSchema));
      }
    }

    public Primitive<bool> ForceExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceExecute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ForceExecute));
      }
    }

    public Primitive<bool> LastRunSuccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunSuccess), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LastRunSuccess));
      }
    }

    public Primitive<bool> IsView
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsView), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsView));
      }
    }

    public Primitive<bool> ForceRefresh
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceRefresh), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ForceRefresh));
      }
    }

    public Primitive<string> TargetTableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetTableName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetTableName));
      }
    }

    public Primitive<DateTime> EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDate));
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

    public Primitive<string> LastRunMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LastRunMessage));
      }
    }
  }
}
