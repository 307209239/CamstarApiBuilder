// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerChanges
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
  public class ProcessTimerChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_StartProcessTimerMapDtl")]
    protected ProcessTimerMapDtlChanges[] _StartProcessTimerMapDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_ProcessTimerMaxTimeDtl")]
    protected ProcessTimerDtlChanges _ProcessTimerMaxTimeDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_EndProcessTimerMapDtl")]
    protected ProcessTimerMapDtlChanges[] _EndProcessTimerMapDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_TimerType")]
    protected Enumeration<TimerTypeEnum, int> _TimerType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_ProcessTimerType")]
    protected NamedObjectRef _ProcessTimerType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_ProcessTimerMinTimeDtl")]
    protected ProcessTimerDtlChanges _ProcessTimerMinTimeDtl;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MaxTimeColor")]
    protected Primitive<string> _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MaxWarningTimeColor")]
    protected Primitive<string> _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MinTimeColor")]
    protected Primitive<string> _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MinWarningTimeColor")]
    protected Primitive<string> _MinWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MaxTime")]
    protected Primitive<double> _MaxTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MaxWarningTime")]
    protected Primitive<double> _MaxWarningTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MinTime")]
    protected Primitive<double> _MinTime;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerChanges_MinWarningTime")]
    protected Primitive<double> _MinWarningTime;

    public override bool Equals(object obj)
    {
      return obj is ProcessTimerChanges && this.CompareArrays((Array) this._StartProcessTimerMapDtl, (Array) ((ProcessTimerChanges) obj)._StartProcessTimerMapDtl) && (object.Equals((object) this._ProcessTimerMaxTimeDtl, (object) ((ProcessTimerChanges) obj)._ProcessTimerMaxTimeDtl) && this.CompareArrays((Array) this._EndProcessTimerMapDtl, (Array) ((ProcessTimerChanges) obj)._EndProcessTimerMapDtl)) && (object.Equals((object) this._TimerType, (object) ((ProcessTimerChanges) obj)._TimerType) && object.Equals((object) this._Base, (object) ((ProcessTimerChanges) obj)._Base) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessTimerChanges) obj)._ObjectToChange) && object.Equals((object) this._ProcessTimerType, (object) ((ProcessTimerChanges) obj)._ProcessTimerType))) && (object.Equals((object) this._ProcessTimerMinTimeDtl, (object) ((ProcessTimerChanges) obj)._ProcessTimerMinTimeDtl) && object.Equals((object) this._MaxTimeColor, (object) ((ProcessTimerChanges) obj)._MaxTimeColor) && (object.Equals((object) this._MaxWarningTimeColor, (object) ((ProcessTimerChanges) obj)._MaxWarningTimeColor) && object.Equals((object) this._MinTimeColor, (object) ((ProcessTimerChanges) obj)._MinTimeColor)) && (object.Equals((object) this._MinWarningTimeColor, (object) ((ProcessTimerChanges) obj)._MinWarningTimeColor) && object.Equals((object) this._MaxTime, (object) ((ProcessTimerChanges) obj)._MaxTime) && (object.Equals((object) this._Name, (object) ((ProcessTimerChanges) obj)._Name) && object.Equals((object) this._MaxWarningTime, (object) ((ProcessTimerChanges) obj)._MaxWarningTime)))) && (object.Equals((object) this._MinTime, (object) ((ProcessTimerChanges) obj)._MinTime) && object.Equals((object) this._MinWarningTime, (object) ((ProcessTimerChanges) obj)._MinWarningTime)) && base.Equals(obj);
    }

    public ProcessTimerMapDtlChanges[] StartProcessTimerMapDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartProcessTimerMapDtl), (object) value);
      }
      get
      {
        return (ProcessTimerMapDtlChanges[]) this.PropertyGet(nameof (StartProcessTimerMapDtl));
      }
    }

    public ProcessTimerDtlChanges ProcessTimerMaxTimeDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerMaxTimeDtl), (object) value);
      }
      get
      {
        return (ProcessTimerDtlChanges) this.PropertyGet(nameof (ProcessTimerMaxTimeDtl));
      }
    }

    public ProcessTimerMapDtlChanges[] EndProcessTimerMapDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndProcessTimerMapDtl), (object) value);
      }
      get
      {
        return (ProcessTimerMapDtlChanges[]) this.PropertyGet(nameof (EndProcessTimerMapDtl));
      }
    }

    public Enumeration<TimerTypeEnum, int> TimerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerType), (object) value);
      }
      get
      {
        return (Enumeration<TimerTypeEnum, int>) this.PropertyGet(nameof (TimerType));
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

    public NamedObjectRef ProcessTimerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ProcessTimerType));
      }
    }

    public ProcessTimerDtlChanges ProcessTimerMinTimeDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerMinTimeDtl), (object) value);
      }
      get
      {
        return (ProcessTimerDtlChanges) this.PropertyGet(nameof (ProcessTimerMinTimeDtl));
      }
    }

    public Primitive<string> MaxTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaxTimeColor));
      }
    }

    public Primitive<string> MaxWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaxWarningTimeColor));
      }
    }

    public Primitive<string> MinTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MinTimeColor));
      }
    }

    public Primitive<string> MinWarningTimeColor
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTimeColor), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MinWarningTimeColor));
      }
    }

    public Primitive<double> MaxTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MaxTime));
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

    public Primitive<double> MaxWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxWarningTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MaxWarningTime));
      }
    }

    public Primitive<double> MinTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MinTime));
      }
    }

    public Primitive<double> MinWarningTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinWarningTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MinWarningTime));
      }
    }
  }
}
