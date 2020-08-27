// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureDetail
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
  public class EventFailureDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_FailureType")]
    protected NamedObjectRef _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_EventFailure")]
    protected SubentityRef _EventFailure;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_FailureSeverity")]
    protected NamedObjectRef _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_FailureModeGroup")]
    protected NamedObjectRef _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_EventFailureCauseDetails")]
    protected EventFailureCauseDetail[] _EventFailureCauseDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureDetail_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is EventFailureDetail && object.Equals((object) this._FailureType, (object) ((EventFailureDetail) obj)._FailureType) && (object.Equals((object) this._FailureMode, (object) ((EventFailureDetail) obj)._FailureMode) && object.Equals((object) this._Comments, (object) ((EventFailureDetail) obj)._Comments)) && (object.Equals((object) this._EventFailure, (object) ((EventFailureDetail) obj)._EventFailure) && object.Equals((object) this._FailureSeverity, (object) ((EventFailureDetail) obj)._FailureSeverity) && (object.Equals((object) this._FailureModeGroup, (object) ((EventFailureDetail) obj)._FailureModeGroup) && this.CompareArrays((Array) this._EventFailureCauseDetails, (Array) ((EventFailureDetail) obj)._EventFailureCauseDetails))) && object.Equals((object) this._Description, (object) ((EventFailureDetail) obj)._Description) && base.Equals(obj);
    }

    public NamedObjectRef FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureType));
      }
    }

    public NamedObjectRef FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureMode));
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

    public SubentityRef EventFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailure), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventFailure));
      }
    }

    public NamedObjectRef FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public NamedObjectRef FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public EventFailureCauseDetail[] EventFailureCauseDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureCauseDetails), (object) value);
      }
      get
      {
        return (EventFailureCauseDetail[]) this.PropertyGet(nameof (EventFailureCauseDetails));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
