// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTasks_Info
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
  public class DelegateTasks_Info : GenericTxns_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_Info_DelegationReasonCode")]
    protected Info _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_Info_Services")]
    protected DelegateTask_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_Info_TargetEmployee")]
    protected Info _TargetEmployee;

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

    public DelegateTask_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (DelegateTask_Info) this.PropertyGet(nameof (Services));
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
