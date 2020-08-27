// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityInvestigation
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
  public class CompleteActivityInvestigation : CompleteActivity
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Activity")]
    protected new NamedSubentityRef _Activity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_Failures")]
    protected FailureDetails[] _Failures;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityInvestigation_ProcessObjectDetails")]
    protected ActivityInvestigation _ProcessObjectDetails;

    public override bool Equals(object obj)
    {
      return obj is CompleteActivityInvestigation && object.Equals((object) this._ProcessObject, (object) ((CompleteActivityInvestigation) obj)._ProcessObject) && (object.Equals((object) this._Activity, (object) ((CompleteActivityInvestigation) obj)._Activity) && this.CompareArrays((Array) this._Failures, (Array) ((CompleteActivityInvestigation) obj)._Failures)) && object.Equals((object) this._ProcessObjectDetails, (object) ((CompleteActivityInvestigation) obj)._ProcessObjectDetails) && base.Equals(obj);
    }

    public new NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new NamedSubentityRef Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Activity));
      }
    }

    public FailureDetails[] Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (FailureDetails[]) this.PropertyGet(nameof (Failures));
      }
    }

    public ActivityInvestigation ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ActivityInvestigation) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}
