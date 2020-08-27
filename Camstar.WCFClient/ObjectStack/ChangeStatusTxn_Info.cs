// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeStatusTxn_Info
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
  public class ChangeStatusTxn_Info : ChangeMgtTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_Info_ChangePackage")]
    protected new Info _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_Info_LockInstances")]
    protected Info _LockInstances;
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusTxn_Info_Status")]
    protected Info _Status;

    public new Info ChangePackage
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

    public Info LockInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (LockInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LockInstances));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }
  }
}
