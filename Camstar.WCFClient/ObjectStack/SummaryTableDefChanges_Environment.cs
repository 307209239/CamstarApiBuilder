// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SummaryTableDefChanges_Environment
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
  public class SummaryTableDefChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_ScheduleMonths")]
    [Metadata("Comments", "", true, false, false, "String", 1052722, false, false, false, null)]
    protected Environment _ScheduleMonths;
    [Metadata("Comments", "", true, false, false, "String", 1052721, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_ScheduleHours")]
    protected Environment _ScheduleHours;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_SummarySQL")]
    [Metadata("LongString", "", true, true, false, "String", 1050928, false, false, false, null)]
    protected Environment _SummarySQL;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_ScheduleDaysOfWeek")]
    [Metadata("Comments", "", true, false, false, "String", 1052720, false, false, false, null)]
    protected Environment _ScheduleDaysOfWeek;
    [Metadata("Comments", "", true, false, false, "String", 1052719, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_ScheduleDaysOfMonth")]
    protected Environment _ScheduleDaysOfMonth;
    [Metadata("Definitions for Summary Tables", "SummaryTableDef", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_LastRunElapsedSeconds")]
    [Metadata("Generic Integer", "", true, false, false, "Integer", 1052866, false, false, false, null)]
    protected Environment _LastRunElapsedSeconds;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_IsManuallyExecuted")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 1052864, false, false, false, "0")]
    protected Environment _IsManuallyExecuted;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_IsEnabled")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 1052898, false, false, false, "0")]
    protected Environment _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_StartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052899, false, false, false, null)]
    protected Environment _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_NextRunDate")]
    [Metadata("Generic TimeStamp", "", true, false, false, "TimeStamp", 1052869, false, false, false, null)]
    protected Environment _NextRunDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_LastRunDate")]
    [Metadata("Generic TimeStamp", "", true, false, false, "TimeStamp", 1052865, false, false, false, null)]
    protected Environment _LastRunDate;
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 1052861, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_AppendToTable")]
    protected Environment _AppendToTable;
    [Metadata("Generic String", "", false, false, false, "String", 1052870, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_TargetSchema")]
    protected Environment _TargetSchema;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052773, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_ForceExecute")]
    protected Environment _ForceExecute;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_LastRunSuccess")]
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 1052868, false, false, false, "0")]
    protected Environment _LastRunSuccess;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052713, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_IsView")]
    protected Environment _IsView;
    [Metadata("Generic Boolean", "", true, false, false, "Boolean", 1052710, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_ForceRefresh")]
    protected Environment _ForceRefresh;
    [Metadata("Generic String", "", true, true, false, "String", 1052871, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_TargetTableName")]
    protected Environment _TargetTableName;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_EndDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052862, false, false, false, null)]
    protected Environment _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052896, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "SummaryTableDefChanges_Environment_LastRunMessage")]
    [Metadata("Notes/Comments", "", true, false, false, "String", 1052867, false, false, false, null)]
    protected Environment _LastRunMessage;

    public Environment ScheduleMonths
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleMonths), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleMonths));
      }
    }

    public Environment ScheduleHours
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleHours), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleHours));
      }
    }

    public Environment SummarySQL
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummarySQL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SummarySQL));
      }
    }

    public Environment ScheduleDaysOfWeek
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfWeek), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDaysOfWeek));
      }
    }

    public Environment ScheduleDaysOfMonth
    {
      [param: In] set
      {
        this.PropertySet(nameof (ScheduleDaysOfMonth), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ScheduleDaysOfMonth));
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

    public Environment LastRunElapsedSeconds
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunElapsedSeconds), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRunElapsedSeconds));
      }
    }

    public Environment IsManuallyExecuted
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManuallyExecuted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsManuallyExecuted));
      }
    }

    public Environment IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Environment StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartDate));
      }
    }

    public Environment NextRunDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextRunDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NextRunDate));
      }
    }

    public Environment LastRunDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRunDate));
      }
    }

    public Environment AppendToTable
    {
      [param: In] set
      {
        this.PropertySet(nameof (AppendToTable), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AppendToTable));
      }
    }

    public Environment TargetSchema
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSchema), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSchema));
      }
    }

    public Environment ForceExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceExecute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ForceExecute));
      }
    }

    public Environment LastRunSuccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunSuccess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRunSuccess));
      }
    }

    public Environment IsView
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsView), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsView));
      }
    }

    public Environment ForceRefresh
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceRefresh), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ForceRefresh));
      }
    }

    public Environment TargetTableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetTableName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetTableName));
      }
    }

    public Environment EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDate));
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

    public Environment LastRunMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRunMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastRunMessage));
      }
    }
  }
}
