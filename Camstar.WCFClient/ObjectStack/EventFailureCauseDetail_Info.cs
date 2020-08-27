// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCauseDetail_Info
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
  public class EventFailureCauseDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Info_CauseCodeGroup")]
    protected Info _CauseCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Info_CauseCode")]
    protected Info _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Info_EventFailureCause")]
    protected Info _EventFailureCause;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Info_EventFailureActionDetails")]
    protected EventFailureActionDetail_Info _EventFailureActionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Info_IsRootCause")]
    protected Info _IsRootCause;

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

    public Info CauseCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CauseCodeGroup));
      }
    }

    public Info CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CauseCode));
      }
    }

    public Info EventFailureCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCause), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventFailureCause));
      }
    }

    public EventFailureActionDetail_Info EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail_Info) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }

    public Info IsRootCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRootCause), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRootCause));
      }
    }
  }
}
