// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerChanges_Environment
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
  public class ProcessTimerChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_StartProcessTimerMapDtl")]
    [Metadata("ProcessTimerMapDtlChanges", "ProcessTimerMapDtlChanges", false, false, false, "ProcessTimerMapDtlChanges", 16778415, false, true, false, null)]
    protected ProcessTimerMapDtlChanges_Environment _StartProcessTimerMapDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_ProcessTimerMaxTimeDtl")]
    [Metadata("ProcessTimerDtlChanges", "ProcessTimerDtlChanges", false, false, false, "ProcessTimerDtlChanges", 16778374, true, false, false, null)]
    protected ProcessTimerDtlChanges_Environment _ProcessTimerMaxTimeDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_EndProcessTimerMapDtl")]
    [Metadata("ProcessTimerMapDtlChanges", "ProcessTimerMapDtlChanges", false, false, false, "ProcessTimerMapDtlChanges", 16778416, false, true, false, null)]
    protected ProcessTimerMapDtlChanges_Environment _EndProcessTimerMapDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_TimerType")]
    [Metadata("Enumeration for TimerType\r\n1 = Min only\r\n2 = Max only\r\n3 = Min and Max", "TimerTypeEnum", false, true, false, "Integer", 16778381, false, false, true, "1")]
    protected Environment _TimerType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_Base")]
    [Metadata("Process Timer", "ProcessTimerBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Process Timer", "ProcessTimer", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_ProcessTimerType")]
    [Metadata("Process Timer Type", "ProcessTimerType", false, false, false, "NamedObjectRef", 16778358, false, false, true, null)]
    protected Environment _ProcessTimerType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_ProcessTimerMinTimeDtl")]
    [Metadata("ProcessTimerDtlChanges", "ProcessTimerDtlChanges", false, false, false, "ProcessTimerDtlChanges", 16778375, true, false, false, null)]
    protected ProcessTimerDtlChanges_Environment _ProcessTimerMinTimeDtl;
    [Metadata("Generic String", "", false, false, false, "String", 16778366, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MaxTimeColor")]
    protected Environment _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MaxWarningTimeColor")]
    [Metadata("Generic String", "", false, false, false, "String", 16778365, false, false, false, null)]
    protected Environment _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MinTimeColor")]
    [Metadata("Generic String", "", false, false, false, "String", 16778364, false, false, false, null)]
    protected Environment _MinTimeColor;
    [Metadata("Generic String", "", false, false, false, "String", 16778363, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MinWarningTimeColor")]
    protected Environment _MinWarningTimeColor;
    [Metadata("Time as a duration", "", false, false, false, "Float", 16778362, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MaxTime")]
    protected Environment _MaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16778357, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Time as a duration", "", false, false, false, "Float", 16778361, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MaxWarningTime")]
    protected Environment _MaxWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MinTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 16778360, false, false, false, null)]
    protected Environment _MinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Environment_MinWarningTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 16778359, false, false, false, null)]
    protected Environment _MinWarningTime;

    public ProcessTimerMapDtlChanges_Environment StartProcessTimerMapDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartProcessTimerMapDtl), (object) value);
      }
      get
      {
        return (ProcessTimerMapDtlChanges_Environment) this.PropertyGet(nameof (StartProcessTimerMapDtl));
      }
    }

    public ProcessTimerDtlChanges_Environment ProcessTimerMaxTimeDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerMaxTimeDtl), (object) value);
      }
      get
      {
        return (ProcessTimerDtlChanges_Environment) this.PropertyGet(nameof (ProcessTimerMaxTimeDtl));
      }
    }

    public ProcessTimerMapDtlChanges_Environment EndProcessTimerMapDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndProcessTimerMapDtl), (object) value);
      }
      get
      {
        return (ProcessTimerMapDtlChanges_Environment) this.PropertyGet(nameof (EndProcessTimerMapDtl));
      }
    }

    public Environment TimerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimerType));
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

    public Environment ProcessTimerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimerType));
      }
    }

    public ProcessTimerDtlChanges_Environment ProcessTimerMinTimeDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerMinTimeDtl), (object) value);
      }
      get
      {
        return (ProcessTimerDtlChanges_Environment) this.PropertyGet(nameof (ProcessTimerMinTimeDtl));
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

    public Environment MaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxTime));
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

    public Environment MaxWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxWarningTime));
      }
    }

    public Environment MinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinTime));
      }
    }

    public Environment MinWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinWarningTime));
      }
    }
  }
}
