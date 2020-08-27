// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SummaryTableDefChanges_Info
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
  public class SummaryTableDefChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_ScheduleMonths")]
    protected Info _ScheduleMonths;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_ScheduleHours")]
    protected Info _ScheduleHours;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_SummarySQL")]
    protected Info _SummarySQL;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_ScheduleDaysOfWeek")]
    protected Info _ScheduleDaysOfWeek;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_ScheduleDaysOfMonth")]
    protected Info _ScheduleDaysOfMonth;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_LastRunElapsedSeconds")]
    protected Info _LastRunElapsedSeconds;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_IsManuallyExecuted")]
    protected Info _IsManuallyExecuted;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_IsEnabled")]
    protected Info _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_StartDate")]
    protected Info _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_NextRunDate")]
    protected Info _NextRunDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_LastRunDate")]
    protected Info _LastRunDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_AppendToTable")]
    protected Info _AppendToTable;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_TargetSchema")]
    protected Info _TargetSchema;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_ForceExecute")]
    protected Info _ForceExecute;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_LastRunSuccess")]
    protected Info _LastRunSuccess;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_IsView")]
    protected Info _IsView;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_ForceRefresh")]
    protected Info _ForceRefresh;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_TargetTableName")]
    protected Info _TargetTableName;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_EndDate")]
    protected Info _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Info_LastRunMessage")]
    protected Info _LastRunMessage;

    public Info ScheduleMonths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleMonths), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleMonths));
      }
    }

    public Info ScheduleHours
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleHours), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleHours));
      }
    }

    public Info SummarySQL
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummarySQL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SummarySQL));
      }
    }

    public Info ScheduleDaysOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfWeek), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDaysOfWeek));
      }
    }

    public Info ScheduleDaysOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfMonth), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ScheduleDaysOfMonth));
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

    public Info LastRunElapsedSeconds
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunElapsedSeconds), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRunElapsedSeconds));
      }
    }

    public Info IsManuallyExecuted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManuallyExecuted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsManuallyExecuted));
      }
    }

    public Info IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Info StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartDate));
      }
    }

    public Info NextRunDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextRunDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextRunDate));
      }
    }

    public Info LastRunDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRunDate));
      }
    }

    public Info AppendToTable
    {
      [param: In] set
      {
        this.PropertySet(nameof (AppendToTable), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AppendToTable));
      }
    }

    public Info TargetSchema
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSchema), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSchema));
      }
    }

    public Info ForceExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceExecute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ForceExecute));
      }
    }

    public Info LastRunSuccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunSuccess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRunSuccess));
      }
    }

    public Info IsView
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsView), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsView));
      }
    }

    public Info ForceRefresh
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceRefresh), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ForceRefresh));
      }
    }

    public Info TargetTableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetTableName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetTableName));
      }
    }

    public Info EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDate));
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

    public Info LastRunMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastRunMessage));
      }
    }
  }
}
