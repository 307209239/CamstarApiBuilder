// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureCauseDetail
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
  public class EventFailureCauseDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_CauseCodeGroup")]
    protected NamedObjectRef _CauseCodeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_CauseCode")]
    protected NamedObjectRef _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_EventFailureCause")]
    protected SubentityRef _EventFailureCause;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_EventFailureActionDetails")]
    protected EventFailureActionDetail[] _EventFailureActionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureCauseDetail_IsRootCause")]
    protected Primitive<bool> _IsRootCause;

    public override bool Equals(object obj)
    {
      return obj is EventFailureCauseDetail && object.Equals((object) this._Comments, (object) ((EventFailureCauseDetail) obj)._Comments) && (object.Equals((object) this._CauseCodeGroup, (object) ((EventFailureCauseDetail) obj)._CauseCodeGroup) && object.Equals((object) this._CauseCode, (object) ((EventFailureCauseDetail) obj)._CauseCode)) && (object.Equals((object) this._EventFailureCause, (object) ((EventFailureCauseDetail) obj)._EventFailureCause) && this.CompareArrays((Array) this._EventFailureActionDetails, (Array) ((EventFailureCauseDetail) obj)._EventFailureActionDetails) && object.Equals((object) this._IsRootCause, (object) ((EventFailureCauseDetail) obj)._IsRootCause)) && base.Equals(obj);
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

    public NamedObjectRef CauseCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CauseCodeGroup));
      }
    }

    public NamedObjectRef CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CauseCode));
      }
    }

    public SubentityRef EventFailureCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCause), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventFailureCause));
      }
    }

    public EventFailureActionDetail[] EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail[]) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }

    public Primitive<bool> IsRootCause
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRootCause), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRootCause));
      }
    }
  }
}
