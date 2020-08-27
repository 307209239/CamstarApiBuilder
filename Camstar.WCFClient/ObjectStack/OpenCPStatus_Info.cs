// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OpenCPStatus_Info
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
  public class OpenCPStatus_Info : ChangeStatusTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "OpenCPStatus_Info_Status")]
    protected new Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "OpenCPStatus_Info_LockInstances")]
    protected new Info _LockInstances;

    public new Info Status
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

    public new Info LockInstances
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
  }
}
