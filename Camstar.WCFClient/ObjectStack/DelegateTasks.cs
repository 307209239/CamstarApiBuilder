// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTasks
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
  public class DelegateTasks : GenericTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_DelegationReasonCode")]
    protected NamedObjectRef _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_Services")]
    protected DelegateTask[] _Services;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_TargetEmployee")]
    protected NamedObjectRef _TargetEmployee;

    public override bool Equals(object obj)
    {
      return obj is DelegateTasks && object.Equals((object) this._DelegationReasonCode, (object) ((DelegateTasks) obj)._DelegationReasonCode) && (this.CompareArrays((Array) this._Services, (Array) ((DelegateTasks) obj)._Services) && object.Equals((object) this._TargetEmployee, (object) ((DelegateTasks) obj)._TargetEmployee)) && base.Equals(obj);
    }

    public NamedObjectRef DelegationReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegationReasonCode));
      }
    }

    public DelegateTask[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (DelegateTask[]) this.PropertyGet(nameof (Services));
      }
    }

    public NamedObjectRef TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
