// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureDetail_Info
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
  public class EventFailureDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_FailureType")]
    protected Info _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_FailureMode")]
    protected Info _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_EventFailure")]
    protected Info _EventFailure;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_FailureSeverity")]
    protected Info _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_FailureModeGroup")]
    protected Info _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_EventFailureCauseDetails")]
    protected EventFailureCauseDetail_Info _EventFailureCauseDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Info_Description")]
    protected Info _Description;

    public Info FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureType));
      }
    }

    public Info FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureMode));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info EventFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventFailure));
      }
    }

    public Info FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public Info FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public EventFailureCauseDetail_Info EventFailureCauseDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCauseDetails), (object) value);
      }
      get
      {
        return (EventFailureCauseDetail_Info) this.PropertyGet(nameof (EventFailureCauseDetails));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
