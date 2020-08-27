// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureActionDetail
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
  public class EventFailureActionDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_ActionRole")]
    protected NamedObjectRef _ActionRole;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_EventFailureAction")]
    protected SubentityRef _EventFailureAction;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_ActionTypeGroup")]
    protected NamedObjectRef _ActionTypeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_ActionType")]
    protected NamedObjectRef _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_CompletionDate")]
    protected Primitive<DateTime> _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_ActionOwner")]
    protected NamedObjectRef _ActionOwner;

    public override bool Equals(object obj)
    {
      return obj is EventFailureActionDetail && object.Equals((object) this._ActionRole, (object) ((EventFailureActionDetail) obj)._ActionRole) && (object.Equals((object) this._Comments, (object) ((EventFailureActionDetail) obj)._Comments) && object.Equals((object) this._EventFailureAction, (object) ((EventFailureActionDetail) obj)._EventFailureAction)) && (object.Equals((object) this._ActionTypeGroup, (object) ((EventFailureActionDetail) obj)._ActionTypeGroup) && object.Equals((object) this._ActionType, (object) ((EventFailureActionDetail) obj)._ActionType) && (object.Equals((object) this._CompletionDate, (object) ((EventFailureActionDetail) obj)._CompletionDate) && object.Equals((object) this._ActionOwner, (object) ((EventFailureActionDetail) obj)._ActionOwner))) && base.Equals(obj);
    }

    public NamedObjectRef ActionRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionRole));
      }
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public SubentityRef EventFailureAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureAction), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventFailureAction));
      }
    }

    public NamedObjectRef ActionTypeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionTypeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionTypeGroup));
      }
    }

    public NamedObjectRef ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionType));
      }
    }

    public Primitive<DateTime> CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionDate));
      }
    }

    public NamedObjectRef ActionOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionOwner));
      }
    }
  }
}
