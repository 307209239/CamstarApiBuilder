// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTask_Info
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
  public class DelegateTask_Info : GenericTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Info_ChangePackage")]
    protected Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Info_DelegationReasonCode")]
    protected Info _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Info_DelegationTarget")]
    protected Info _DelegationTarget;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Info_SourceEmployee")]
    protected Info _SourceEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Info_TargetEmployee")]
    protected Info _TargetEmployee;

    public Info ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Info DelegationReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationReasonCode));
      }
    }

    public Info DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationTarget));
      }
    }

    public new Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Info SourceEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceEmployee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SourceEmployee));
      }
    }

    public Info TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
