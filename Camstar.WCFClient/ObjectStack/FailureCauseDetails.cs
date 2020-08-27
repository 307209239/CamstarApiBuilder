// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseDetails
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
  public class FailureCauseDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Cause")]
    protected NamedObjectRef _Cause;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_FailurePlans")]
    protected FailurePlanDetails[] _FailurePlans;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_FailureCauseData")]
    protected SubentityRef _FailureCauseData;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDetails_RootCauseConfirmed")]
    protected Primitive<bool> _RootCauseConfirmed;

    public override bool Equals(object obj)
    {
      return obj is FailureCauseDetails && object.Equals((object) this._Cause, (object) ((FailureCauseDetails) obj)._Cause) && (object.Equals((object) this._Comments, (object) ((FailureCauseDetails) obj)._Comments) && this.CompareArrays((Array) this._FailurePlans, (Array) ((FailureCauseDetails) obj)._FailurePlans)) && (object.Equals((object) this._FailureCauseData, (object) ((FailureCauseDetails) obj)._FailureCauseData) && object.Equals((object) this._RootCauseConfirmed, (object) ((FailureCauseDetails) obj)._RootCauseConfirmed)) && base.Equals(obj);
    }

    public NamedObjectRef Cause
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cause), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Cause));
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

    public FailurePlanDetails[] FailurePlans
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlans), (object) value);
      }
      get
      {
        return (FailurePlanDetails[]) this.PropertyGet(nameof (FailurePlans));
      }
    }

    public SubentityRef FailureCauseData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureCauseData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (FailureCauseData));
      }
    }

    public Primitive<bool> RootCauseConfirmed
    {
      [param: In] set
      {
        this.PropertySet(nameof (RootCauseConfirmed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RootCauseConfirmed));
      }
    }
  }
}
