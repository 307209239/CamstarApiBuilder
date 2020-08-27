// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureCauseDataHistoryDetails
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
  public class FailureCauseDataHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_Cause")]
    protected NamedObjectRef _Cause;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_FailurePlanHistoryDetails")]
    protected FailurePlanDataHistoryDetails[] _FailurePlanHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "FailureCauseDataHistoryDetails_RootCauseConfirmed")]
    protected Primitive<bool> _RootCauseConfirmed;

    public override bool Equals(object obj)
    {
      return obj is FailureCauseDataHistoryDetails && object.Equals((object) this._Comments, (object) ((FailureCauseDataHistoryDetails) obj)._Comments) && (object.Equals((object) this._Cause, (object) ((FailureCauseDataHistoryDetails) obj)._Cause) && this.CompareArrays((Array) this._FailurePlanHistoryDetails, (Array) ((FailureCauseDataHistoryDetails) obj)._FailurePlanHistoryDetails)) && object.Equals((object) this._RootCauseConfirmed, (object) ((FailureCauseDataHistoryDetails) obj)._RootCauseConfirmed) && base.Equals(obj);
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

    public FailurePlanDataHistoryDetails[] FailurePlanHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailurePlanHistoryDetails), (object) value);
      }
      get
      {
        return (FailurePlanDataHistoryDetails[]) this.PropertyGet(nameof (FailurePlanHistoryDetails));
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
