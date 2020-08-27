// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerChanges_Info
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
  public class ProcessTimerChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_StartProcessTimerMapDtl")]
    protected ProcessTimerMapDtlChanges_Info _StartProcessTimerMapDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_ProcessTimerMaxTimeDtl")]
    protected ProcessTimerDtlChanges_Info _ProcessTimerMaxTimeDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_EndProcessTimerMapDtl")]
    protected ProcessTimerMapDtlChanges_Info _EndProcessTimerMapDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_TimerType")]
    protected Info _TimerType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_ProcessTimerType")]
    protected Info _ProcessTimerType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_ProcessTimerMinTimeDtl")]
    protected ProcessTimerDtlChanges_Info _ProcessTimerMinTimeDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MaxTimeColor")]
    protected Info _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MaxWarningTimeColor")]
    protected Info _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MinTimeColor")]
    protected Info _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MinWarningTimeColor")]
    protected Info _MinWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MaxTime")]
    protected Info _MaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MaxWarningTime")]
    protected Info _MaxWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MinTime")]
    protected Info _MinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Info_MinWarningTime")]
    protected Info _MinWarningTime;

    public ProcessTimerMapDtlChanges_Info StartProcessTimerMapDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartProcessTimerMapDtl), (object) value);
      }
      get
      {
        return (ProcessTimerMapDtlChanges_Info) this.PropertyGet(nameof (StartProcessTimerMapDtl));
      }
    }

    public ProcessTimerDtlChanges_Info ProcessTimerMaxTimeDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerMaxTimeDtl), (object) value);
      }
      get
      {
        return (ProcessTimerDtlChanges_Info) this.PropertyGet(nameof (ProcessTimerMaxTimeDtl));
      }
    }

    public ProcessTimerMapDtlChanges_Info EndProcessTimerMapDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndProcessTimerMapDtl), (object) value);
      }
      get
      {
        return (ProcessTimerMapDtlChanges_Info) this.PropertyGet(nameof (EndProcessTimerMapDtl));
      }
    }

    public Info TimerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerType));
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

    public Info ProcessTimerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerType));
      }
    }

    public ProcessTimerDtlChanges_Info ProcessTimerMinTimeDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerMinTimeDtl), (object) value);
      }
      get
      {
        return (ProcessTimerDtlChanges_Info) this.PropertyGet(nameof (ProcessTimerMinTimeDtl));
      }
    }

    public Info MaxTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxTimeColor));
      }
    }

    public Info MaxWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxWarningTimeColor));
      }
    }

    public Info MinTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinTimeColor));
      }
    }

    public Info MinWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTimeColor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinWarningTimeColor));
      }
    }

    public Info MaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxTime));
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

    public Info MaxWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxWarningTime));
      }
    }

    public Info MinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinTime));
      }
    }

    public Info MinWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinWarningTime));
      }
    }
  }
}
