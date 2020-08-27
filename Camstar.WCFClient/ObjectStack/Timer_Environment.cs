// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Timer_Environment
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
  public class Timer_Environment : Subentity_Environment
  {
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, true, "RevisionedObjectRef", 16778806, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_EndTimerSpecID")]
    protected Environment _EndTimerSpecID;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16777762, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("StartTimerTaskDtl", "StartTimerTaskDtl", false, false, true, "SubentityRef", 16778632, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_TaskStartTimerID")]
    protected Environment _TaskStartTimerID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_ProcessTimerRevOfRcd")]
    [Metadata("Process Timer", "ProcessTimer", false, false, true, "RevisionedObjectRef", 16778629, false, false, false, null)]
    protected Environment _ProcessTimerRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_ProcessTimerID")]
    [Metadata("Process Timer", "ProcessTimer", false, false, true, "RevisionedObjectRef", 16778627, false, false, false, null)]
    protected Environment _ProcessTimerID;
    [Metadata("StartTimerTxnMap", "StartTimerTxnMap", false, false, true, "SubentityRef", 16778630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_SpecStartTimerID")]
    protected Environment _SpecStartTimerID;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16778622, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_IsStoped")]
    protected Environment _IsStoped;
    [Metadata("Generic String", "", false, false, true, "String", 16778363, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MinWarningTimeColor")]
    protected Environment _MinWarningTimeColor;
    [Metadata("Generic String", "", false, false, true, "String", 16778364, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MinTimeColor")]
    protected Environment _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MaxWarningTimeColor")]
    [Metadata("Generic String", "", false, false, true, "String", 16778365, false, false, false, null)]
    protected Environment _MaxWarningTimeColor;
    [Metadata("Generic String", "", false, false, true, "String", 16778366, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MaxTimeColor")]
    protected Environment _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MaxEndWarningTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778624, false, false, false, null)]
    protected Environment _MaxEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MinEndWarningTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778626, false, false, false, null)]
    protected Environment _MinEndWarningTimeGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MinEndTimeGMT")]
    protected Environment _MinEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_MaxEndTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778623, false, false, false, null)]
    protected Environment _MaxEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_EndTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778621, false, false, false, null)]
    protected Environment _EndTimeGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778631, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_StartTimeGMT")]
    protected Environment _StartTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_ProcessTimerRevision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 16778628, false, false, false, null)]
    protected Environment _ProcessTimerRevision;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_TimerCompletionStatusName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778693, false, false, false, null)]
    protected Environment _TimerCompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Environment_ProcessTimerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 16778357, false, false, false, null)]
    protected Environment _ProcessTimerName;

    public Environment EndTimerSpecID
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerSpecID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimerSpecID));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment TaskStartTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskStartTimerID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskStartTimerID));
      }
    }

    public Environment ProcessTimerRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerRevOfRcd));
      }
    }

    public Environment ProcessTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerID));
      }
    }

    public Environment SpecStartTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStartTimerID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecStartTimerID));
      }
    }

    public Environment IsStoped
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsStoped), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsStoped));
      }
    }

    public Environment MinWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinWarningTimeColor));
      }
    }

    public Environment MinTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinTimeColor));
      }
    }

    public Environment MaxWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxWarningTimeColor));
      }
    }

    public Environment MaxTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeColor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxTimeColor));
      }
    }

    public Environment MaxEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxEndWarningTimeGMT));
      }
    }

    public Environment MinEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinEndWarningTimeGMT));
      }
    }

    public Environment MinEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinEndTimeGMT));
      }
    }

    public Environment MaxEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxEndTimeGMT));
      }
    }

    public Environment EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Environment StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Environment ProcessTimerRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerRevision));
      }
    }

    public Environment TimerCompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerCompletionStatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimerCompletionStatusName));
      }
    }

    public Environment ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerName));
      }
    }
  }
}
