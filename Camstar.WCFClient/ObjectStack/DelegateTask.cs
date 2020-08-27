// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTask
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
  public class DelegateTask : GenericTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_ChangePackage")]
    protected NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_DelegationReasonCode")]
    protected NamedObjectRef _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_DelegationTarget")]
    protected BaseObjectRef _DelegationTarget;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_SourceEmployee")]
    protected NamedObjectRef _SourceEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_TargetEmployee")]
    protected NamedObjectRef _TargetEmployee;

    public override bool Equals(object obj)
    {
      return obj is DelegateTask && object.Equals((object) this._ChangePackage, (object) ((DelegateTask) obj)._ChangePackage) && (object.Equals((object) this._DelegationReasonCode, (object) ((DelegateTask) obj)._DelegationReasonCode) && object.Equals((object) this._DelegationTarget, (object) ((DelegateTask) obj)._DelegationTarget)) && (object.Equals((object) this._TrackableObject, (object) ((DelegateTask) obj)._TrackableObject) && object.Equals((object) this._SourceEmployee, (object) ((DelegateTask) obj)._SourceEmployee) && object.Equals((object) this._TargetEmployee, (object) ((DelegateTask) obj)._TargetEmployee)) && base.Equals(obj);
    }

    public NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
      }
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

    public BaseObjectRef DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (DelegationTarget));
      }
    }

    public new BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public NamedObjectRef SourceEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SourceEmployee));
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
