// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureActionDetail_Info
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
  public class EventFailureActionDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Info_ActionRole")]
    protected Info _ActionRole;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Info_EventFailureAction")]
    protected Info _EventFailureAction;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Info_ActionTypeGroup")]
    protected Info _ActionTypeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Info_ActionType")]
    protected Info _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Info_CompletionDate")]
    protected Info _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Info_ActionOwner")]
    protected Info _ActionOwner;

    public Info ActionRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionRole));
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

    public Info EventFailureAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventFailureAction));
      }
    }

    public Info ActionTypeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionTypeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionTypeGroup));
      }
    }

    public Info ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionType));
      }
    }

    public Info CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletionDate));
      }
    }

    public Info ActionOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionOwner));
      }
    }
  }
}
