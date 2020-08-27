// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Timer_Info
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
  public class Timer_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_EndTimerSpecID")]
    protected Info _EndTimerSpecID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_TaskStartTimerID")]
    protected Info _TaskStartTimerID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_ProcessTimerRevOfRcd")]
    protected Info _ProcessTimerRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_ProcessTimerID")]
    protected Info _ProcessTimerID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_SpecStartTimerID")]
    protected Info _SpecStartTimerID;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_IsStoped")]
    protected Info _IsStoped;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MinWarningTimeColor")]
    protected Info _MinWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MinTimeColor")]
    protected Info _MinTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MaxWarningTimeColor")]
    protected Info _MaxWarningTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MaxTimeColor")]
    protected Info _MaxTimeColor;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MaxEndWarningTimeGMT")]
    protected Info _MaxEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MinEndWarningTimeGMT")]
    protected Info _MinEndWarningTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MinEndTimeGMT")]
    protected Info _MinEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_MaxEndTimeGMT")]
    protected Info _MaxEndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_EndTimeGMT")]
    protected Info _EndTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_StartTimeGMT")]
    protected Info _StartTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_ProcessTimerRevision")]
    protected Info _ProcessTimerRevision;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_TimerCompletionStatusName")]
    protected Info _TimerCompletionStatusName;
    [DataMember(EmitDefaultValue = false, Name = "Timer_Info_ProcessTimerName")]
    protected Info _ProcessTimerName;

    public Info EndTimerSpecID
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerSpecID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndTimerSpecID));
      }
    }

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info TaskStartTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskStartTimerID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskStartTimerID));
      }
    }

    public Info ProcessTimerRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerRevOfRcd));
      }
    }

    public Info ProcessTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerID));
      }
    }

    public Info SpecStartTimerID
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecStartTimerID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecStartTimerID));
      }
    }

    public Info IsStoped
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsStoped), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsStoped));
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

    public Info MaxEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxEndWarningTimeGMT));
      }
    }

    public Info MinEndWarningTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndWarningTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinEndWarningTimeGMT));
      }
    }

    public Info MinEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinEndTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinEndTimeGMT));
      }
    }

    public Info MaxEndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxEndTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxEndTimeGMT));
      }
    }

    public Info EndTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndTimeGMT));
      }
    }

    public Info StartTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartTimeGMT));
      }
    }

    public Info ProcessTimerRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerRevision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerRevision));
      }
    }

    public Info TimerCompletionStatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerCompletionStatusName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerCompletionStatusName));
      }
    }

    public Info ProcessTimerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessTimerName));
      }
    }
  }
}
