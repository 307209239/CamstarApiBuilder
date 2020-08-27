// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Timer
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
  public class Timer : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "Timer_EndTimerSpecID")]
    protected RevisionedObjectRef _EndTimerSpecID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "Timer_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Timer_TaskStartTimerID")]
    protected SubentityRef _TaskStartTimerID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_ProcessTimerRevOfRcd")]
    protected RevisionedObjectRef _ProcessTimerRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "Timer_ProcessTimerID")]
    protected RevisionedObjectRef _ProcessTimerID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_SpecStartTimerID")]
    protected SubentityRef _SpecStartTimerID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_IsStoped")]
    protected Primitive<bool> _IsStoped;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MinWarningTimeColor")]
    protected Primitive<string> _MinWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MinTimeColor")]
    protected Primitive<string> _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MaxWarningTimeColor")]
    protected Primitive<string> _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MaxTimeColor")]
    protected Primitive<string> _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MaxEndWarningTimeGMT")]
    protected Primitive<DateTime> _MaxEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MinEndWarningTimeGMT")]
    protected Primitive<DateTime> _MinEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MinEndTimeGMT")]
    protected Primitive<DateTime> _MinEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_MaxEndTimeGMT")]
    protected Primitive<DateTime> _MaxEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_EndTimeGMT")]
    protected Primitive<DateTime> _EndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_StartTimeGMT")]
    protected Primitive<DateTime> _StartTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_ProcessTimerRevision")]
    protected Primitive<string> _ProcessTimerRevision;
    [DataMember(EmitDefaultValue = false, Name = "Timer_TimerCompletionStatusName")]
    protected Primitive<string> _TimerCompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "Timer_ProcessTimerName")]
    protected Primitive<string> _ProcessTimerName;

    public override bool Equals(object obj)
    {
      return obj is Timer && object.Equals((object) this._EndTimerSpecID, (object) ((Timer) obj)._EndTimerSpecID) && (object.Equals((object) this._DisplayName, (object) ((Timer) obj)._DisplayName) && object.Equals((object) this._ExportImportKey, (object) ((Timer) obj)._ExportImportKey)) && (object.Equals((object) this._TaskStartTimerID, (object) ((Timer) obj)._TaskStartTimerID) && object.Equals((object) this._ProcessTimerRevOfRcd, (object) ((Timer) obj)._ProcessTimerRevOfRcd) && (object.Equals((object) this._ProcessTimerID, (object) ((Timer) obj)._ProcessTimerID) && object.Equals((object) this._SpecStartTimerID, (object) ((Timer) obj)._SpecStartTimerID))) && (object.Equals((object) this._IsStoped, (object) ((Timer) obj)._IsStoped) && object.Equals((object) this._MinWarningTimeColor, (object) ((Timer) obj)._MinWarningTimeColor) && (object.Equals((object) this._MinTimeColor, (object) ((Timer) obj)._MinTimeColor) && object.Equals((object) this._MaxWarningTimeColor, (object) ((Timer) obj)._MaxWarningTimeColor)) && (object.Equals((object) this._MaxTimeColor, (object) ((Timer) obj)._MaxTimeColor) && object.Equals((object) this._MaxEndWarningTimeGMT, (object) ((Timer) obj)._MaxEndWarningTimeGMT) && (object.Equals((object) this._MinEndWarningTimeGMT, (object) ((Timer) obj)._MinEndWarningTimeGMT) && object.Equals((object) this._MinEndTimeGMT, (object) ((Timer) obj)._MinEndTimeGMT)))) && (object.Equals((object) this._MaxEndTimeGMT, (object) ((Timer) obj)._MaxEndTimeGMT) && object.Equals((object) this._EndTimeGMT, (object) ((Timer) obj)._EndTimeGMT) && (object.Equals((object) this._StartTimeGMT, (object) ((Timer) obj)._StartTimeGMT) && object.Equals((object) this._ProcessTimerRevision, (object) ((Timer) obj)._ProcessTimerRevision)) && (object.Equals((object) this._TimerCompletionStatusName, (object) ((Timer) obj)._TimerCompletionStatusName) && object.Equals((object) this._ProcessTimerName, (object) ((Timer) obj)._ProcessTimerName))) && base.Equals(obj);
    }

    public RevisionedObjectRef EndTimerSpecID
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerSpecID), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (EndTimerSpecID));
      }
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public SubentityRef TaskStartTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskStartTimerID), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (TaskStartTimerID));
      }
    }

    public RevisionedObjectRef ProcessTimerRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRevOfRcd), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessTimerRevOfRcd));
      }
    }

    public RevisionedObjectRef ProcessTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerID), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessTimerID));
      }
    }

    public SubentityRef SpecStartTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStartTimerID), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (SpecStartTimerID));
      }
    }

    public Primitive<bool> IsStoped
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsStoped), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsStoped));
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

    public Primitive<DateTime> MaxEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MaxEndWarningTimeGMT));
      }
    }

    public Primitive<DateTime> MinEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MinEndWarningTimeGMT));
      }
    }

    public Primitive<DateTime> MinEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MinEndTimeGMT));
      }
    }

    public Primitive<DateTime> MaxEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (MaxEndTimeGMT));
      }
    }

    public Primitive<DateTime> EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Primitive<DateTime> StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Primitive<string> ProcessTimerRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessTimerRevision));
      }
    }

    public Primitive<string> TimerCompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerCompletionStatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TimerCompletionStatusName));
      }
    }

    public Primitive<string> ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessTimerName));
      }
    }
  }
}
